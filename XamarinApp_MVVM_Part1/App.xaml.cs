using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp_MVVM_Part1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.LoginPage();
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
