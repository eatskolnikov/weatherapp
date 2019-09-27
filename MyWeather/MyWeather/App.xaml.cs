using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyWeather
{
    public partial class App : Application
    {
        public static string Endpoint = "https://api.apixu.com/v1/current.json?key=f4a33bfe56d84a7b895210819181510&q={0}";

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
