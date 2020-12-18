using Android.App;
using Android.Content.PM;
using Android.OS;
using Sharpnado.HorizontalListView.Droid;
using Xamarin.Forms;

namespace BirdAtlas.Droid
{
    [Activity(Label = "BirdAtlas", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Forms.SetFlags("CollectionView_Experimental");
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            SharpnadoInitializer.Initialize(enableInternalLogger: true, enableInternalDebugLogger: true);

            LoadApplication(new App());
        }
    }
}