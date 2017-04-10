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
    public partial class QuestionnairePg2 : ContentPage
    {
        public QuestionnairePg2()
        {
            InitializeComponent();

            //Initalise Pickers
            headBrusies.SelectedIndex = 0;
            headBreak.SelectedIndex = 0;
            headCuts.SelectedIndex = 0;
            headDislocation.SelectedIndex = 0;
            headSprain.SelectedIndex = 0;
            bodyBreak.SelectedIndex = 0;
            bodyBrusies.SelectedIndex = 0;
            bodyCuts.SelectedIndex = 0;
            bodyDislocation.SelectedIndex = 0;
            bodySprain.SelectedIndex = 0;
            armBreak.SelectedIndex = 0;
            armBrusies.SelectedIndex = 0;
            armCuts.SelectedIndex = 0;
            armDislocation.SelectedIndex = 0;
            armSprain.SelectedIndex = 0;
            legBreak.SelectedIndex = 0;
            legCuts.SelectedIndex = 0;
            legDislocation.SelectedIndex = 0;
            legsBrusies.SelectedIndex = 0;
            legSprain.SelectedIndex = 0;

            switch1.Toggled += switcher_Toggled;
            grid1.Opacity = 0;
        }

        private void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            if (switch1.IsToggled == false)
            {
                response.Text = "No";
                grid1.Opacity = 0;
                headBrusies.SelectedIndex = 0;
                headBreak.SelectedIndex = 0;
                headCuts.SelectedIndex = 0;
                headDislocation.SelectedIndex = 0;
                headSprain.SelectedIndex = 0;
                bodyBreak.SelectedIndex = 0;
                bodyBrusies.SelectedIndex = 0;
                bodyCuts.SelectedIndex = 0;
                bodyDislocation.SelectedIndex = 0;
                bodySprain.SelectedIndex = 0;
                armBreak.SelectedIndex = 0;
                armBrusies.SelectedIndex = 0;
                armCuts.SelectedIndex = 0;
                armDislocation.SelectedIndex = 0;
                armSprain.SelectedIndex = 0;
                legBreak.SelectedIndex = 0;
                legCuts.SelectedIndex = 0;
                legDislocation.SelectedIndex = 0;
                legsBrusies.SelectedIndex = 0;
                legSprain.SelectedIndex = 0;
            }
            else
            {
                response.Text = "Yes";
                grid1.Opacity = 1;

            }
        }

        void progressToPage3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuestionnairePg3());
        }

    }
}
