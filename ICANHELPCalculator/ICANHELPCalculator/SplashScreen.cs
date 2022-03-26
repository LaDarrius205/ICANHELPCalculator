using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ICANHELPCalculator
{
    public class SplashScreen : ContentPage
    {
        readonly Image image;
        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            image = new Image
            {
                Source = "ICanHelp",
                WidthRequest = 500,
                HeightRequest = 500
            };
            AbsoluteLayout.SetLayoutFlags(image, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(image, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(image);
            this.BackgroundColor = Color.FromHex("#000e4a");
            this.Content = sub;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await image.ScaleTo(1, 1000);
            await image.ScaleTo(0.5, 1000, Easing.CubicOut);
            await image.ScaleTo(50, 800, Easing.CubicIn);
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}
