using System;

using Xamarin.Forms;

namespace MSApp.Pages
{
    public partial class DiaryPage : ContentPage
    {
        public DiaryPage()
        {
            InitializeComponent();
        }

        void NumFallsChanged(object sender, ValueChangedEventArgs e)
        {
            fallsDisplay.Text = "1";
            fallsDisplay.Text = String.Format("{0}", e.NewValue);
        }

        void NumInjuryChanged(object sender, ValueChangedEventArgs e)
        {
            displayInjury.Text = String.Format("{0}", e.NewValue);
        }

        void NumDaysChanged(object sender, ValueChangedEventArgs e)
        {
            daysDisplay.Text = String.Format("{0}", e.NewValue);
        }
    }
}
