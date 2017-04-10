using System;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Net.Http;


namespace MSApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        String email;
        String password;
        String passwordConfirm;

        public SignUpPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        void emailEntered (Object sender, PropertyChangedEventArgs e)
        {
            email = emailEntry.Text;
        }

        void passwordEntered(Object sender, PropertyChangedEventArgs e)
        {
            password = passwordEntry.Text;
        }

        void passwordConfirmEntered(Object sender, PropertyChangedEventArgs e)
        {
            passwordConfirm = passwordConfirmEntry.Text;
        }

        void ShowLogIn(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailEntry.Text) || String.IsNullOrEmpty(passwordEntry.Text) || String.IsNullOrEmpty(passwordConfirmEntry.Text))
            {
                DisplayAlert("Warning", "Some fields are empty", "OK");

            } else if (passwordEntry.Text != passwordConfirmEntry.Text)
            {
                DisplayAlert("Warning", "Password do not match", "OK");

            } else if (passwordEntry.Text.Length < 8 && passwordConfirmEntry.Text.Length < 8)
            {
                DisplayAlert("Warning", "Password must be 8 or more characters", "OK");
            }
            else
            {
                Navigation.PushAsync(new LogInPage());
                DisplayAlert("Success", "Account created, You can now log in", "OK");
            }
        }

    }
}
