using System;
using System.Collections.Generic;
using Firebase.Auth;

using Xamarin.Forms;

namespace Punchcard
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        public async void registerMethod(object o, EventArgs e)
        {
            var usr = userEmail.Text;
            var pswd = userPassword.Text;
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyCdweWwcxQ3y0Sh0YRFHFMX7JPtd9pdbo4"));
            await authProvider.CreateUserWithEmailAndPasswordAsync(usr, pswd);
        }
    }
}
