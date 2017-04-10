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
    public partial class QuestionnairePg5 : ContentPage
    {
        public QuestionnairePg5()
        {
            InitializeComponent();

            //Set switch method and phase out grid view
            switch1.Toggled += switcher_Toggled;
            grid1.Opacity = 0;

            //Initalise Pickers
            family.SelectedIndex = 0;
            friendNeighbour.SelectedIndex = 0;
            healthcareProf.SelectedIndex = 0;
        }

        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch1.IsToggled == false)
            {
                response.Text = "No";
                grid1.Opacity = 0;
                family.SelectedIndex = 0;
                friendNeighbour.SelectedIndex = 0;
                healthcareProf.SelectedIndex = 0;
            }
            else
            {
                response.Text = "Yes";
                grid1.Opacity = 1;

            }
        }

        void progressToPage6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuestionnairePg6());
        }
    }
}
