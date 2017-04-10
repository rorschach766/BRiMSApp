using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogInPage : ContentPage
	{
		public LogInPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasBackButton(this, false);
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        void ShowSignUp(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        void ShowMainPage(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailEntry.Text) || String.IsNullOrEmpty(passwordEntry.Text))
            {
                DisplayAlert("Warning", "Some fields are empty", "OK");
            }
            else
            {
                Navigation.PushAsync(new MainPage());
            }
        }

    }
}

