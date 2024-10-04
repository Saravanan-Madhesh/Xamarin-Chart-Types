using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopTenChartTypes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            new Database();
            MainPage = new NavigationPage(new SamplePage()) { StyleId = "NavigationPageID" };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
