#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using AutoComplete = Syncfusion.SfAutoComplete.XForms.SfAutoComplete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

using Syncfusion.XForms.PopupLayout;

namespace SFBase00
{
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(true)]
  public partial class TextInputPage : ContentPage
  {
    public TextInputPage()
    {
      InitializeComponent();
      #region intro stuff
      this.Title = "Text Input";
      this.BackgroundColor = Color.WhiteSmoke;
      this.Opacity = 0.9;
      #endregion


      #region State Names
      SubmitCommand = new Command<string>(SubmitButtonClicked);
      ResetCommand = new Command<AutoComplete>(ResetButtonClicked);

      State = new List<string>();
      State.Add("Alabama");
      State.Add("Alaska");
      State.Add("Arizona");
      State.Add("California");
      State.Add("Colorado");
      State.Add("Delaware");
      State.Add("Florida");
      State.Add("Georgia");
      State.Add("Hawaii");
      State.Add("Lowa");
      State.Add("Maine");
      State.Add("MaryLand");
      State.Add("Montana");
      State.Add("Nevada");
      State.Add("New Jersey");
      State.Add("New Mexico");
      State.Add("New York");
      State.Add("Washington");


      #endregion
    }
    public event PropertyChangedEventHandler PropertyChanged;

    private bool enableHintAlwaysFloated;

    public bool EnableHintAlwaysFloated
    {
      get { return enableHintAlwaysFloated; }

      set
      {
        enableHintAlwaysFloated = value;
        NotifyPropertyChanged();
      }
    }

    private string notescont;

    public string Notes
    {
      get { return notescont; }
      set
      {
        notescont = value;
        NotifyPropertyChanged();
      }
    }

    private string dateOfBirthcont;

    public string DateOfBirth
    {
      get { return dateOfBirthcont; }
      set
      {
        dateOfBirthcont = value;
        NotifyPropertyChanged();
      }
    }

    private string mailcont;

    public string Mail
    {
      get { return mailcont; }
      set
      {
        mailcont = value;
        HasError = false;
        NotifyPropertyChanged();
      }
    }

    private string passwordcont;

    public string Password
    {
      get { return passwordcont; }
      set
      {
        passwordcont = value;
        IsEnabled = passwordcont.Length >= 5;
        IsPasswordEmpty = false;
        NotifyPropertyChanged();
      }
    }

    private string phoneNumbercont;

    public string PhoneNumber
    {
      get { return phoneNumbercont; }
      set
      {
        phoneNumbercont = value;
        IsMobileNumberEmpty = false;
        NotifyPropertyChanged();
      }
    }

    private string namecont;

    public string Name
    {
      get { return namecont; }
      set
      {
        namecont = value;
        IsNameEmpty = false;
        NotifyPropertyChanged();
      }
    }

    private string addresscont;

    public string Address
    {
      get { return addresscont; }
      set
      {
        addresscont = value;
        IsAddressEmpty = false;
        NotifyPropertyChanged();
      }
    }

    private List<string> statecont;

    public List<string> State
    {
      get { return statecont; }
      set
      {
        statecont = value;
        NotifyPropertyChanged();
      }
    }

    private string selectedStatecont;
    public string SelectedState
    {
      get { return selectedStatecont; }
      set
      {
        selectedStatecont = value;
        IsStateEmpty = false;
        NotifyPropertyChanged();
      }
    }

    private DateTime dateTime = DateTime.Now.Date;

    public DateTime DateTime
    {
      get { return dateTime; }
      set
      {
        if (value != dateTime)
        {
          dateTime = value;
          DateOfBirth = dateTime.Month + "/" + dateTime.Day + "/" + dateTime.Year;
          NotifyPropertyChanged();
        }
      }
    }

    private bool hasError;

    public bool HasError
    {
      get { return hasError; }
      set
      {
        hasError = value;
        NotifyPropertyChanged();
      }
    }

    private string confirmPasswordcont;

    public string ConfirmPassword
    {
      get { return confirmPasswordcont; }
      set
      {
        confirmPasswordcont = value;
        IsConfirmPasswordEmpty = false;
        NotifyPropertyChanged();
      }
    }

    private bool isNameEmptycont;

    public bool IsNameEmpty
    {
      get { return isNameEmptycont; }
      set
      {
        isNameEmptycont = value;
        NotifyPropertyChanged();
      }
    }

    private bool isAddressEmptycont;

    public bool IsAddressEmpty
    {
      get { return isAddressEmptycont; }
      set
      {
        isAddressEmptycont = value;
        NotifyPropertyChanged();
      }
    }

    private bool isStateEmptycont;

    public bool IsStateEmpty
    {
      get { return isStateEmptycont; }
      set
      {
        isStateEmptycont = value;
        NotifyPropertyChanged();
      }
    }

    private bool isMobileNumberEmpty;

    public bool IsMobileNumberEmpty
    {
      get { return isMobileNumberEmpty; }
      set
      {
        isMobileNumberEmpty = value;
        NotifyPropertyChanged();
      }
    }

    private bool isPasswordEmpty;

    public bool IsPasswordEmpty
    {
      get { return isPasswordEmpty; }
      set
      {
        isPasswordEmpty = value;
        NotifyPropertyChanged();
      }
    }

    private bool isConfirmPasswordEmpty;

    public bool IsConfirmPasswordEmpty
    {
      get { return isConfirmPasswordEmpty; }
      set
      {
        isConfirmPasswordEmpty = value;
        NotifyPropertyChanged();
      }
    }

    private bool isEnabled;

    public bool IsEnabled
    {
      get { return isEnabled; }
      set
      {
        isEnabled = value;
        NotifyPropertyChanged(nameof(IsEnabled));
      }
    }

    private List<int> fontSizeCollection = new List<int>
        {
            12,
            14,
            16
        };


    public List<int> FontSizeCollection => fontSizeCollection;

    private int containerLabelFontSize;

    public int ContainerLabelFontSize
    {
      get
      {
        return containerLabelFontSize;
      }
      set
      {
        containerLabelFontSize = value;
        NotifyPropertyChanged();
      }
    }

    private int selectedFontSize = 2;
    public int SelectedFontSize
    {
      get
      {
        return selectedFontSize;
      }
      set
      {
        selectedFontSize = value;
        NotifyPropertyChanged();
        ContainerLabelFontSize = FontSizeCollection[selectedFontSize];
      }
    }

    List<FontAttributes> fontAttributeCollection = new List<FontAttributes>
        {
            FontAttributes.None,
            FontAttributes.Bold,
            FontAttributes.Italic
        };
    public List<FontAttributes> FontAttributeCollection => fontAttributeCollection;

    private FontAttributes containerLabelFontAttribute;
    public FontAttributes ContainerLabelFontAttribute
    {
      get
      {
        return containerLabelFontAttribute;
      }
      set
      {
        containerLabelFontAttribute = value;
        NotifyPropertyChanged();
      }
    }

    private int selectedFontAttribute;
    public int SelectedFontAttribute
    {
      get
      {
        return selectedFontAttribute;
      }
      set
      {
        selectedFontAttribute = value;
        NotifyPropertyChanged();
        ContainerLabelFontAttribute = FontAttributeCollection[selectedFontAttribute];
      }
    }
    List<string> fontFamilyCollection = new List<string>
        {
            "Default",
            "Lobster-Regular"
        };
    public List<string> FontFamilyCollection => fontFamilyCollection;

    private string containerLabelFontFamily;
    public string ContainerLabelFontFamily
    {
      get
      {
        return containerLabelFontFamily;
      }
      set
      {
        containerLabelFontFamily = value;
        NotifyPropertyChanged();
      }
    }
    private int selectedFontFamily;

    public int SelectedFontFamily
    {
      get
      {
        return selectedFontFamily;
      }
      set
      {
        selectedFontFamily = value;
        NotifyPropertyChanged();
        ContainerLabelFontFamily = FontFamilyCollection[selectedFontFamily];
      }
    }

    public ICommand ResetCommand { get; private set; }

    public ICommand SubmitCommand { get; private set; }


    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <summary>
    /// This method will be called whenever reset button is clicked
    /// </summary>
    /// <param name="obj">The object</param>
    private void ResetButtonClicked(object obj)
    {
      Notes = string.Empty;
      Mail = string.Empty;
      DateOfBirth = string.Empty;
      Name = string.Empty;
      PhoneNumber = string.Empty;
      Address = string.Empty;
      ConfirmPassword = string.Empty;
      Password = string.Empty;
      SelectedState = string.Empty;
    }

    /// <summary>
    /// This method will be called whenever submit button is clicked
    /// </summary>
    /// <param name="obj">The object</param>
    private void SubmitButtonClicked(object obj)
    {
      IsNameEmpty = string.IsNullOrEmpty(Name);
      IsMobileNumberEmpty = string.IsNullOrEmpty(PhoneNumber);
      IsAddressEmpty = string.IsNullOrEmpty(Address);
      IsPasswordEmpty = string.IsNullOrEmpty(Password);
      IsStateEmpty = string.IsNullOrEmpty(SelectedState);

      if (!string.IsNullOrEmpty(Password))
      {
        IsPasswordEmpty = Password.Length < 5;
        IsConfirmPasswordEmpty = !Password.Equals(ConfirmPassword);
      }
      if (string.IsNullOrEmpty(Mail) || !mailcont.Contains("@") || !mailcont.Contains("."))
      {
        HasError = true;
      }
      else if (!IsNameEmpty && !IsMobileNumberEmpty && !IsAddressEmpty && !IsStateEmpty && !isPasswordEmpty && !IsConfirmPasswordEmpty)
      {
        Application.Current.MainPage.DisplayAlert("Success", "Your account has been created successfully", "Ok");
      }
    }
  }
}