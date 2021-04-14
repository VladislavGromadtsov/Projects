using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NachaloLab
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "cars.db";
        public static CarRepository database;
        public static CarRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new CarRepository(DATABASE_NAME);
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new LoadingPage();
            //MainPage = new NachaloLab.TabbedPage1();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
