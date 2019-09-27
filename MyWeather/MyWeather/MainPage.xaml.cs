using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MyWeather.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MyWeather
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            SearchWeather("Medellín");
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxCity.Text))
            {
                SearchWeather(tbxCity.Text);
            }
        }

        private void SearchWeather(string city)
        {
            try
            {
                var client = new WebClient();
                var encodedParameter = HttpUtility.UrlEncode(city);
                var formattedUrl = string.Format(App.Endpoint, encodedParameter);
                var url = new Uri(formattedUrl);
                var resultString = client.DownloadString(url);
                var resultObject = JsonConvert.DeserializeObject<WeatherResponse>(resultString);
                client.Dispose();

                BindingContext = resultObject;
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "ok");
            }
        }
    }
}
