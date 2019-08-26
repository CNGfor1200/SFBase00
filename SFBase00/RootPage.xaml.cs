using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SFBase00
{
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer

  [DesignTimeVisible(true)]
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class RootPage : ContentPage
  {
    public RootPage()
    {
      InitializeComponent();

      #region intro stuff
      this.Title = "Function List";
      this.BackgroundColor = Color.WhiteSmoke;
      this.Opacity = 0.9;
      #endregion
    }

    // ..................................................
    //
    //

    private void OnbtBasicButtonsClickedAsync(object sender, EventArgs e)
    {
      this.Navigation.PushAsync(new ButtonPage());
    }

    private void OnbtSwitchesClickedAsync(object sender, EventArgs e)
    {
      this.Navigation.PushAsync(new SwitchPage());
    }


    private void OnbtRadioButtonsClickedAsync(object sender, EventArgs e)
    {
      this.Navigation.PushAsync(new RadioButton());
    }

    private void OnbtBorderButtonsClickedAsync(object sender, EventArgs e)
    {
      this.Navigation.PushAsync(new BorderPage());
    }

    private void OnbtBussyIndicatorButtonsClickedAsync(object sender, EventArgs e)
    {
      this.Navigation.PushAsync(new BusyPage());
    }

    private void OnbtTextInputPageButtonsClickedAsync(object sender, EventArgs e)
    {
      this.Navigation.PushAsync(new TextInputPage());
    }
  }
}
