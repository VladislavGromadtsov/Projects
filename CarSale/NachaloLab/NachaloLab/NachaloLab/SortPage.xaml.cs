using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NachaloLab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SortPage : ContentPage
    {
        public SortPage()
        {
            InitializeComponent();
        }

        private async void SortOk_Clicked(object sender, EventArgs e)
        {
            if (Ch1.IsChecked) Person.Sort = 1;
            else if (Ch2.IsChecked) Person.Sort = 2;
            else if (Ch3.IsChecked) Person.Sort = 3;
            await Navigation.PopAsync();
        }

        private void Ch1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (Ch1.IsChecked) { Ch2.IsChecked = false; Ch3.IsChecked = false; }
            else if (Ch2.IsChecked) { Ch1.IsChecked = false; Ch3.IsChecked = false; }
            else if (Ch3.IsChecked) { Ch2.IsChecked = false; Ch1.IsChecked = false; }
        }

        private void Ch2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (Ch2.IsChecked) { Ch1.IsChecked = false; Ch3.IsChecked = false; }
            else if (Ch1.IsChecked) { Ch2.IsChecked = false; Ch3.IsChecked = false; }
            else if(Ch3.IsChecked) { Ch2.IsChecked = false; Ch1.IsChecked = false; }
        }

        private void Ch3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (Ch3.IsChecked) { Ch2.IsChecked = false; Ch1.IsChecked = false; }
            else if (Ch2.IsChecked) { Ch1.IsChecked = false; Ch3.IsChecked = false; }
            else if (Ch1.IsChecked) { Ch2.IsChecked = false; Ch3.IsChecked = false; }
        }
    }
}