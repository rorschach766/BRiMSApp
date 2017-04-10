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
    public partial class QuestionnairePg4 : ContentPage
    {
        public QuestionnairePg4()
        {
            InitializeComponent();

            //Set switch method and phase out grid view
            switch1.Toggled += switcher_Toggled;
            grid1.Opacity = 0;

            //Initalise Pickers
            tenThirty.SelectedIndex = 0;
            thirtySixty.SelectedIndex = 0;
            sixtyPlus.SelectedIndex = 0;
        }

        //Method for switch toogle, which set the text, and phases grid view in and out and resets the selected indexes
        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch1.IsToggled == false)
            {
                response.Text = "No";
                grid1.Opacity = 0;
                tenThirty.SelectedIndex = 0;
                thirtySixty.SelectedIndex = 0;
                sixtyPlus.SelectedIndex = 0;
            }
            else
            {
                response.Text = "Yes";
                grid1.Opacity = 1;

            }
        }

        void progressToPage5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuestionnairePg5());
        }
    }
}
