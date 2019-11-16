using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Auth;

using Xamarin.Forms;

namespace Punchcard.Pages
{
    public partial class LoginPage : ContentPage
    {
        public String user;
        public LoginPage()
        {
            InitializeComponent();
        }

        public async void loginMethod(object o, EventArgs e)
        {
            //dummy data
            try
            {
                var email = userEmail.Text;
                var password = userPassword.Text;

                // specify your app’s client key (API Key) when creating the auth provider

                //var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
                var auth = await App.authProvider.SignInWithEmailAndPasswordAsync(email, password);
               

                //your Firebase URL
                App.firebase = new FirebaseClient("https://handshake-a96bf.firebaseio.com/",
                    new FirebaseOptions
                    {
                        //this is important, and this is where the blog post is wrong
                        AuthTokenAsyncFactory = () => Task.FromResult(auth.FirebaseToken)
                    }
                );

                await Navigation.PushModalAsync(new MainPage());
                App.authID = auth.User.LocalId;
                App.userID = email;


            }
            catch(Exception ex)
            {
                Console.Write(ex);
            }
        }

        async void registerMethod(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
