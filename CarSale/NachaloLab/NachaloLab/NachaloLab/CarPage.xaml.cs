using NachaloLab.AppRes;
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
    public partial class CarPage : ContentPage
    {
        public CarPage()
        {
            InitializeComponent();
        }

        private async void SaveCar(object sender, EventArgs e)
        {
            var car = (Car)BindingContext;
            if (!String.IsNullOrEmpty(car.Mark))
            {
                await App.Database.SaveItemAsync(car);
            }
            await this.Navigation.PopAsync();
        }
        private async void DeleteCar(object sender, EventArgs e)
        {
            var car = (Car)BindingContext;
            await App.Database.DeleteItemAsync(car);
            await this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = Lbl1 + " " + Lbl2;
            Lbl1.Text = AppResources.Mark + ": " + Lbl1.Text;
            Lbl2.Text = AppResources.Model + ": " + Lbl2.Text;
            Lbl3.Text = AppResources.Year + ": " + Lbl3.Text;
            Lbl4.Text = AppResources.Milage + ": " + Lbl4.Text;
            Lbl5.Text = AppResources.Price + ": " + Lbl5.Text;
            Lbl6.Text = AppResources.Transmission + ": " + Lbl6.Text;
            Lbl7.Text = AppResources.BodyType + ": " + Lbl7.Text;
            Lbl8.Text = AppResources.Engine + ": " + Lbl8.Text;
            Lbl9.Text = AppResources.VIN + ": " + Lbl9.Text;
            Lbl10.Text = AppResources.Drive + ": " + Lbl10.Text;
            
        }
    }
}