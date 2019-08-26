using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SFBase00
{
  public partial class App : Application
  {
    public App()
    {
      //Register Syncfusion license
      Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTMzNDk3QDMxMzcyZTMyMmUzMGhyNkxWTGFWT1pRZFhTN1hqSGgyL3owQjlFZXdEMnZ2OVVlNXJJYUlsZjQ9");

      InitializeComponent();

      //
      // ................................................................
      // navigating to root page
      // lots of labels that will get us to all other (demo) pages
      //
      // ...............................................................
      var content = new RootPage();


      NavigationPage navPage = new NavigationPage(content)
      {
        Title = "Root - Demo Syncfusion",

        BarBackgroundColor = Color.FromHex("91CA47"),
        BarTextColor = Color.White,

        //BackgroundColor = Color.Black,
        IsEnabled = true,
        IsVisible = true
      };
      MainPage = navPage;
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
