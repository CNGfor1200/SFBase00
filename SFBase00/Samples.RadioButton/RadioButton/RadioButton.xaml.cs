#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using SampleBrowser.Core;

namespace SFBase00
{
  public partial class RadioButton : ContentPage
  {
    public RadioButton()
    {
      InitializeComponent();
      #region intro stuff
      this.Title = "Radio Buttons";
      this.BackgroundColor = Color.WhiteSmoke;
      this.Opacity = 0.9;
      #endregion


      if (Device.RuntimePlatform == Device.Android)
        frame.BackgroundColor = Color.Transparent;
      if (Device.RuntimePlatform == Device.UWP || Device.RuntimePlatform == Device.UWP && Device.Idiom == TargetIdiom.Phone)
      {
        frame.BackgroundColor = Color.White;
        lineFrame.BackgroundColor = Color.White;
        frame.HasShadow = true;
        lineFrame.HasShadow = false;
#pragma warning disable 618
        frame.OutlineColor = Color.FromHex("29000000");
        lineFrame.OutlineColor = Color.FromHex("29000000");
#pragma warning restore 618

      }
      if (Device.Idiom == TargetIdiom.Tablet)
      {
        frame.Margin = new Thickness(45, 89, 45, 0);
        headerText.Margin = new Thickness(0, 50, 0, 0);
        headerText.FontSize = 30;
        amountlabl.FontSize = 22;
        amt.FontSize = 22;
        paymentmodelbl.FontSize = 22;
        debit.FontSize = 20;
        credit.FontSize = 20;
        netbanking.FontSize = 20;
        buttn.FontSize = 25;
        lineFrame.HeightRequest = 2;
        lineFrame.Margin = new Thickness(25, 25, 25, 0);
        amtStack.Margin = new Thickness(25, 25, 25, 0);
        amountlabl.Margin = new Thickness(0, 20, 0, 0);
        amt.Margin = new Thickness(0, 20, 0, 0);
        radioGroup.Margin = new Thickness(0, 35, 0, 0);
        paymentmodelbl.Margin = new Thickness(25, 0, 0, 0);
        debit.Margin = new Thickness(25, 30, 0, 0);
        credit.Margin = new Thickness(25, 30, 0, 45);
        netbanking.Margin = new Thickness(25, 30, 0, 0);
      }
    }
    private void Buttn_Clicked(object sender, EventArgs e)
    {
      Xamarin.Forms.Application.Current.MainPage.DisplayAlert("", " Insurance Payment Successfull ! ", "Ok");
      debit.IsChecked = false;
      credit.IsChecked = false;
      netbanking.IsChecked = false;
      buttn.IsEnabled = false;
    }

    private void paymentMode_StateChanged(object sender, Syncfusion.XForms.Buttons.StateChangedEventArgs eventArgs)
    {
      buttn.IsEnabled = true;
    }


    private void OnbtPrimaryButtons999ClickedAsync(object sender, EventArgs e)
    {
      var url = "http://www.CNGInternet.com/";
      Device.OpenUri(new Uri(url));
    }

  }
}