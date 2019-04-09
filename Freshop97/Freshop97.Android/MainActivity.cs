using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Lottie.Forms.Droid;
using System.IO;
using System.Threading.Tasks;
using Android.Content;
using Plugin.CurrentActivity;

namespace Freshop97.Droid
{
    [Activity(Label = "Freshop97", Icon = "@drawable/Freshop", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            AnimationViewRenderer.Init();
            CrossCurrentActivity.Current.Init(this,savedInstanceState);
            //this.Window.ClearFlags(WindowManagerFlags.Fullscreen);
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(enableFastRenderer: true);
            LoadApplication(new App());
        }


    }
}