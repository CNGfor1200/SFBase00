using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SFBase00.Droid
{
  [Activity(Label = "SFBase00", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
  public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
  {
    double statusBarHeight, navbarheight;

    protected override void OnCreate(Bundle savedInstanceState)
    {
      int navigationResID = Resources.GetIdentifier("navigation_bar_height", "dimen", "android");
      if (navigationResID > 0)
      {
        navbarheight = (Resources.GetDimensionPixelSize(navigationResID) / Resources.DisplayMetrics.Density);
      }

      int statusResID = Resources.GetIdentifier("status_bar_height", "dimen", "android");
      if (statusResID > 0)
      {
        statusBarHeight = (Resources.GetDimensionPixelSize(statusResID) / Resources.DisplayMetrics.Density);
      }

      TabLayoutResource = Resource.Layout.Tabbar;
      ToolbarResource = Resource.Layout.Toolbar;

      base.OnCreate(savedInstanceState);

      Xamarin.Essentials.Platform.Init(this, savedInstanceState);
      global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
      //
      // Initializations for all Syncfusion modules included in this app
      //
      //
      // Popup Layout
      //
      Syncfusion.XForms.Android.PopupLayout.SfPopupLayoutRenderer.Init();
      //
      // back to 'normal' flow
      //
      LoadApplication(new App());

    }
    public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
    {
      Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

      base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    }
  }
}