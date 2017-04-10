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
    public partial class QuestionnairePg3a : ContentPage
    {
        public QuestionnairePg3a()
        {
            InitializeComponent();

            //Initalise Pickers
            daysHospital.SelectedIndex = 0;
        }

        void progressToPage4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuestionnairePg4());
        }
    }
}
