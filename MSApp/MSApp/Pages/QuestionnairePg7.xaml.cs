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
    public partial class QuestionnairePg7 : ContentPage
    {
        public QuestionnairePg7()
        {
            InitializeComponent();

            //Set switch method and phase out grid view
            switch1.Toggled += switcher_Toggled;
            switch2.Toggled += switcher2_Toggled;
            grid1.Opacity = 0;

            days.SelectedIndex = 0;
        }

        private void switcher2_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch2.IsToggled == false)
            {
                response1.Text = "No";
            }
            else
            {
                response1.Text = "Yes";

            }
        }

        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch1.IsToggled == false)
            {
                response.Text = "No";
                grid1.Opacity = 0;
                days.SelectedIndex = 0;
                entry2.Text = "";
                entry3.Text = "";
                entry4.Text = "";
                switch2.IsToggled = false;
                datePicker1.Date = DateTime.Today;
            }
            else
            {
                response.Text = "Yes";
                grid1.Opacity = 1;

            }
        }
        void completeQuestionnaire(object sender, EventArgs e)
        {
            DisplayAlert("Questionnaire Complete", "Thank you for completeing the BRiMS questionnaire", "OK");
            Navigation.PushAsync(new MainPage());
        }

    }
}