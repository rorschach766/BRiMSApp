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
    public partial class QuestionnairePg3 : ContentPage
    {
        public QuestionnairePg3()
        {
            InitializeComponent();

            //Set switch method and phase out grid view
            switch1.Toggled += switcher_Toggled;
            grid1.Opacity = 0;

            //Initalise Pickers
            gpVisit.SelectedIndex = 0;
            nurseVisit.SelectedIndex = 0;
            specialistVisit.SelectedIndex = 0;
            emergencyVisit.SelectedIndex = 0;
            hospitalVisit.SelectedIndex = 0;
            other.SelectedIndex = 0;
        }

        //Method for switch toogle, which set the text, and phases grid view in and out and resets the selected indexes
        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch1.IsToggled == false)
            {
                response.Text = "No";
                grid1.Opacity = 0;
                specialistVisit.SelectedIndex = 0;
                other.SelectedIndex = 0;
                hospitalVisit.SelectedIndex = 0;
            }
            else
            {
                response.Text = "Yes";
                grid1.Opacity = 1;
                
            }
        }

        //Method for button press. If either of the three indexes are selected additonal information page
        //will be shown.
        void progressToPage4(object sender, EventArgs e)
        {
            if(specialistVisit.SelectedIndex > 0 || hospitalVisit.SelectedIndex > 0 || other.SelectedIndex > 0)
            {
                Navigation.PushAsync(new QuestionnairePg3a());
            }
            else
            {
                Navigation.PushAsync(new QuestionnairePg4());
            }
            
        }

       
    }
}
