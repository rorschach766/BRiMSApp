using MSApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MSApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        public void ShowDiaryButton_Clicked(object sender, EventArgs e) {
            Navigation.PushAsync(new DiaryPage());
        }

        public void ShowReminderButton_Clicked(object sender, EventArgs e) {
            Navigation.PushAsync(new ReminderPage());
        }

        public void ShowQuestionnaireButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuestionnairePg1());
        }

    }
}
