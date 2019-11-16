using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;

namespace Punchcard
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Pages.LoginPage());
            authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyCdweWwcxQ3y0Sh0YRFHFMX7JPtd9pdbo4"));

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

        public static FirebaseAuthProvider authProvider;
        public static FirebaseClient firebase;
        public static string authID;
        public static string userID;
    }
}
