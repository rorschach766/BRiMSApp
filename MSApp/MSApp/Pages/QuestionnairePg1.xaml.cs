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
    public partial class QuestionnairePg1 : ContentPage
    {
        public QuestionnairePg1()
        {
            InitializeComponent();
            switch1.Toggled += switcher_Toggled;
        }

        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch1.IsToggled == false) {
                anyFallsDisplay.Text = "No";
            }else{
                anyFallsDisplay.Text = "Yes";
            }
        }

        void progressToPage2(object sender, EventArgs e)
        {
            if (switch1.IsToggled) {
                
                Navigation.PushAsync(new QuestionnairePg2());
            }
            else
            {
                
                Navigation.PushAsync(new QuestionnairePg6());
            }
        }
    }
}
