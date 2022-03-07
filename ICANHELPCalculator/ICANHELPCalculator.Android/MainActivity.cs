using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace ICANHELPCalculator.Droid
{                                                                                       //code added so the phone is available on landscape
    [Activity(Label = "ICANHELPCalculator", Icon = "@mipmap/icon", ScreenOrientation = Android.Content.PM.ScreenOrientation.FullSensor, Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {    // Next: adjust the buttons on the phone and configurate the screen to add more buttons and operators
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}