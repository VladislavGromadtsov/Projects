using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Specialized; 
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace NachaloLab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewCar : ContentPage
    {
        //ObservableCollection<Car> carcoll = new ObservableCollection<Car>();

        Car car = new Car();
        public string Path1 { get; set; }
        public string Path2 { get; set; }
        public string Path3 { get; set; }

        public AddNewCar()
        {
            this.BindingContext = car;
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var car = (Car)BindingContext;
            if (!string.IsNullOrEmpty(Path1)) car.PhotoPath1 = Path1;
            if (!string.IsNullOrEmpty(Path2)) car.PhotoPath2 = Path2;
            if (!string.IsNullOrEmpty(Path3)) car.PhotoPath3 = Path3;
            if (!String.IsNullOrEmpty(car.Mark))
                if (!String.IsNullOrEmpty(car.Model))
                    await App.Database.SaveItemAsync(car);

            Image1.Source = null;
            Image2.Source = null;
            Image3.Source = null;
            E1.Text = string.Empty;
            E2.Text = string.Empty;
            E3.Text = string.Empty;
            E4.Text = string.Empty;
            E5.Text = string.Empty;
            E6.Text = string.Empty;
            E7.Text = string.Empty;
            E8.Text = string.Empty;
            E9.Text = string.Empty;
            E10.Text = string.Empty;
            //await btn.ScaleTo(5, 10000);
            //await btn.ScaleTo(0.1, 5000, Easing.BounceIn);
            //await btn.ScaleTo(1, 10000, Easing.BounceOut);

            //   await btn.TranslateTo(100, 0, 500, Easing.BounceOut);
            //    await btn.TranslateTo(0, 0);
            //await btn.FadeTo(1, 100, Easing.SinInOut);
            var page = this.Parent as TabbedPage1;
            page.CurrentPage = page.Children[0];
           //// await btn.TranslateTo(0, 0);

            //await btn.FadeTo(100, 10);
        }

        private async void TakePhoto_Clicked(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsCameraAvailable && CrossMedia.Current.IsTakePhotoSupported)
            {
                MediaFile file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    SaveToAlbum = true,
                    Directory = "Sample",
                    Name = $"{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.jpg"
                });

                if (file == null)
                    return;

                if (Im1 == false)
                {
                    Image1.Source = ImageSource.FromFile(file.Path);
                    Path1 = file.Path;
                    Im1 = true;
                }
                else if (Im2 == false)
                {
                    Image2.Source = ImageSource.FromFile(file.Path);
                    Path2 = file.Path;
                    Im2 = true;
                }
                else if (Im3 == false)
                {
                    Image3.Source = ImageSource.FromFile(file.Path);
                    Path3 = file.Path;
                    Im3 = true;
                }
            }
        }

        Image img = new Image();
        bool Im1=false, Im2=false, Im3 = false;
        private async void ChoosePhoto_Clicked(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsPickPhotoSupported)
            {
                MediaFile photo = await CrossMedia.Current.PickPhotoAsync();
                if (Im1 == false)
                {
                    Image1.Source = ImageSource.FromFile(photo.Path);
                    Path1 = photo.Path;
                    Im1 = true;
                }
                else if (Im2 == false) 
                {
                    Image2.Source = ImageSource.FromFile(photo.Path); 
                    Path2 = photo.Path;
                    Im2 = true;
                }
                else if (Im3 == false)
                {
                    Image3.Source = ImageSource.FromFile(photo.Path);
                    Path3 = photo.Path;
                    Im3 = true;
                }
            }
        }

        //private async void CreateCar(object sender, EventArgs e)
        //{
        //    await UpdateCarsListAsync();
        //    Car friend = new Car();
        //    CarPage friendPage = new CarPage();
        //    friendPage.BindingContext = friend;
        //    await Navigation.PushAsync(friendPage);
        //}
        //private async Task UpdateCarsListAsync()
        //{
        //    carcoll = await App.Database.GetCarsCollection();
        //}
    }
}