using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace NachaloLab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        ObservableCollection<Car> carcollection = new ObservableCollection<Car>();
        public Page1()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            // создание таблицы, если ее нет
            await App.Database.CreateTable();
            // привязка данных
            CarsList.ItemsSource = await App.Database.GetItemsAsync();
            await UpdateCarsListAsync();
            base.OnAppearing();
        }

        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Car selectedCar = (Car)e.SelectedItem;
            CarPage carPage = new CarPage();
            carPage.BindingContext = selectedCar;
            await Navigation.PushAsync(carPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateCar(object sender, EventArgs e)
        {
            Car friend = new Car();
            CarPage friendPage = new CarPage();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(friendPage);
        }

        private async void Btnclicked(object sender, EventArgs e) 
        {
            await Navigation.PushAsync(new AddNewCar());
        }

        private async void Sort_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SortPage());
        }
        private async void Filter_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FilterPage());
        }

        public async Task UpdateCarsListAsync()
        {
            carcollection = await App.Database.GetCarsCollection();
            switch (Person.Sort) 
            {
                case 2: carcollection = new ObservableCollection<Car>(carcollection.OrderBy(x => x.Price));
                    break;
                case 3: carcollection = new ObservableCollection<Car>(carcollection.OrderBy(x => x.Year));
                    break;
                default: carcollection = new ObservableCollection<Car>(carcollection.OrderBy(x => x.Mark));
                    break;
            }
            CarsList.ItemsSource = carcollection;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            CarsList.ItemsSource = carcollection.Where(f => f.Model.Contains(entr.Text));
        }

        
    }
}