using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BotaoCima_Clicked(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://gerador-nomes.wolan.net/nome/aleatorio";
                HttpResponseMessage response = await client.GetAsync(url);

                string responseBody = await response.Content.ReadAsStringAsync();
                JArray jsonArray = JArray.Parse(responseBody);

                string firstNome = jsonArray[0].ToString();
                Label1.Text = firstNome;
            }
        }
        private async void BotaoMeio_Clicked(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://gerador-nomes.wolan.net/nome/aleatorio";
                HttpResponseMessage response = await client.GetAsync(url);

                string responseBody = await response.Content.ReadAsStringAsync();
                JArray jsonArray = JArray.Parse(responseBody);

                string SecondNome = jsonArray[1].ToString();
                Label2.Text = SecondNome;
            }
        }
        private async void BotaoGrande_Clicked(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://gerador-nomes.wolan.net/nome/aleatorio";
                HttpResponseMessage response = await client.GetAsync(url);

                string responseBody = await response.Content.ReadAsStringAsync();
                JArray jsonArray = JArray.Parse(responseBody);

                string SecondNome = jsonArray[1].ToString();
                Label2.Text = SecondNome;

                string firstNome = jsonArray[0].ToString();
                Label1.Text = firstNome;
            }
        }

    }
}
