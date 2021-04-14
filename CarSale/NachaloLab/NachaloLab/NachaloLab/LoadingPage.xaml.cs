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
    public partial class LoadingPage : ContentPage
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void LoadingAnimation_OnFinish(object sender, EventArgs e)
        {
            TabbedPage1 page1 = new TabbedPage1();
            App.Current.MainPage = page1;
        }
    }
}