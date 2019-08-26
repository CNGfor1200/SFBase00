using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Internals;

using Syncfusion.XForms.PopupLayout;

namespace SFBase00
{
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(true)]
  public partial class ButtonPage : ContentPage
  {
    public ButtonPage()
    {
      InitializeComponent();
      #region intro stuff
      this.Title = "Buttons";
      this.BackgroundColor = Color.WhiteSmoke;
      this.Opacity = 0.9;
      #endregion

    }
    // ..................................................
    //
    //
    public System.Windows.Input.ICommand ClickCommand => new Command<string>((url) =>
    {
      Device.OpenUri(new System.Uri(url));
    });
    private void OnbtPrimaryButtons000ClickedAsync(object sender, EventArgs e)
    {
      popupLayout000.Show();
      //this.Navigation.PushAsync(new ButtonPage());
    }

    private async void OnbtNormalButtons100ClickedAsync(object sender, EventArgs e)
    {
      bool aa=await DisplayAlert("Normal Button", " Message for the normal button", "SUCCESS", "OK");
      if (aa)
      {
        // do it
      }
      else
      {
        // can it
      }
      //popupLayout.Show();
      //this.Navigation.PushAsync(new ButtonPage());
    }


    //

    private void OnbtPrimaryButtons200ClickedAsync(object sender, EventArgs e)
    {
      var url = "http://www.CNGInternet.com/";
      Device.OpenUri(new Uri(url));
      //popupLayout200.Show();
      //this.Navigation.PushAsync(new ButtonPage());
    }


    //

    private void OnbtPrimaryButtons300ClickedAsync(object sender, EventArgs e)
    {
      popupLayout300.Show();
      //this.Navigation.PushAsync(new ButtonPage());
    }


    //

    private void OnbtPrimaryButtons400ClickedAsync(object sender, EventArgs e)
    {
      popupLayout400.Show();
      //this.Navigation.PushAsync(new ButtonPage());
    }


    //

    private void OnbtPrimaryButtons500ClickedAsync(object sender, EventArgs e)
    {
      popupLayout500.Show();
      //this.Navigation.PushAsync(new ButtonPage());
    }


    //

    private void OnbtPrimaryButtons600ClickedAsync(object sender, EventArgs e)
    {
      popupLayout600.Show();
      //this.Navigation.PushAsync(new ButtonPage());
    }


    //

    private void OnbtPrimaryButtons700ClickedAsync(object sender, EventArgs e)
    {
      popupLayout700.Show();
      //this.Navigation.PushAsync(new ButtonPage());
    }


    //

    private void OnbtPrimaryButtons800ClickedAsync(object sender, EventArgs e)
    {
      popupLayout800.Show();
      //this.Navigation.PushAsync(new ButtonPage());
    }

    //

    private void OnbtPrimaryButtons900ClickedAsync(object sender, EventArgs e)
    {
      popupLayout900.Show();
      //this.Navigation.PushAsync(new ButtonPage());
    }



    private void OnbtPrimaryButtons999ClickedAsync(object sender, EventArgs e)
    {
      var url = "http://www.CNGInternet.com/";
      Device.OpenUri(new Uri(url));
    }

  }
}
