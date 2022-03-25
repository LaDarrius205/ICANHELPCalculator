using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICANHELPCalculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileRegister : ContentPage
    {
        public ProfileRegister()
        {
            InitializeComponent();
        }
        async void RegSubmitClicked(object sender, EventArgs e) 
        { 
            await Navigation.PushAsync(new LoginPage()); 
        }
    }
}