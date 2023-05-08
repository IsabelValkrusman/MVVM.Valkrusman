using MVVM.Valkrusman.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Valkrusman
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new FriendsListPage());
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
