using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Xamarin_AB.View;

namespace App_Xamarin_AB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new EmpleadosYPromedioView ());
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
