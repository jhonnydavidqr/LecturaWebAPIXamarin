using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public int cont = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnCallWS_Click(object sender, EventArgs e)
        {
            WSClient client = new WSClient();
            cont++;
            var url = "https://jsonplaceholder.typicode.com/posts/" + cont;
            var result = await client.Get<WSResult>(url);
            if (result != null)
            {
                lblId.Text = $"{result.id}";
                lblTitle.Text = result.title;
                lblBody.Text = result.body;
            }
        }
    }
}
