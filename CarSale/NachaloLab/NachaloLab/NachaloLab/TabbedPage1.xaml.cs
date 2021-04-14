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
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
            Page Page_1 = new NavigationPage(new Page1());
            Page_1.IconImageSource = "baseline_list_black_18dp.png";
            Page_1.Title = AppResources.Advert;

            Page page_4 = new NavigationPage(new Page4());
            page_4.IconImageSource = "baseline_person_black_18dp.png";
            page_4.Title = AppResources.Profile;

            Children.Add(Page_1);
            Children.Add(new AddNewCar());
            Children.Add(page_4);
        }
    }
}