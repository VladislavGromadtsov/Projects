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
    public partial class PersonPage : ContentPage
    {
        public PersonPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Person.Name = EntryMyName.Text;
            Person.Email = EntryMyEmail.Text;
            Person.Password = EntryMyPass.Text;
            Application.Current.MainPage =new TabbedPage1();
        }

       
        private void Reg_Clicked(object sender, EventArgs e)
        {
            Person.Name = EntryMyName.Text;
            Person.Email = EntryMyEmail.Text;
            Person.Password = EntryMyPass.Text;
            Application.Current.MainPage = new TabbedPage1();
        }
    }
}