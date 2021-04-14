using NachaloLab.AppRes;
using Plugin.Multilingual;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NachaloLab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        ICommand Exit;
        public Page4()
        {
            Exit = new Command(OnTapped);
            InitializeComponent();
            LName.Text = Person.Name;
            LEmail.Text = Person.Email;
            
        }

        private async void Enter_Clicked(object sender, EventArgs e)
        {
            await btncl.ScaleTo(5, 1000);
            await btncl.ScaleTo(0.1, 500, Easing.BounceIn);
            await btncl.ScaleTo(1, 100, Easing.BounceOut);
            await Navigation.PushAsync(new PersonPage());
        }

        public ICommand ExitCommand 
        {
        get { return Exit; }
        }

        void OnTapped(object s) 
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        CultureInfo culture;
        string ChooseLang, Cancel;
        private async void LangSwitch_Clicked(object sender, EventArgs e)
        {
            ChooseLang = AppResources.ChooseLang;
            Cancel = AppResources.Cancel;
            var action = await DisplayActionSheet(ChooseLang, Cancel,"", "English", "Русский");
            if (action == "English")
            {
                culture = new CultureInfo("en");
            }
            if (action == "Русский")
            {
                culture = new CultureInfo("ru");
            }
            if (action == null || action == Cancel) 
            {
                return;
            }

            AppResources.Culture = culture;
            CrossMultilingual.Current.CurrentCultureInfo = culture;
            LangSwitch.Text = AppResources.Language;
            Application.Current.MainPage = new TabbedPage1();
        }
    }
}