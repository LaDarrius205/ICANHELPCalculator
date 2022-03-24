using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICANHELPCalculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
