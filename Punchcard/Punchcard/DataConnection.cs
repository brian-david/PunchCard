// Resources:

// Visual Studio BUG discovered: don't name your project with anything but letters and numbers! Using - or _ gives an error in the code.

// Firebase Database Rules: 
// > https://youtu.be/qLrDWBKTUZo,
// > https://firebase.google.com/docs/reference/security/database
// > https://medium.com/step-up-labs/firebase-authentication-c-library-8e5e1c30acc2
// > https://evgenyzborovsky.com/2018/03/26/firebase-authentication-in-xamarin-forms/ (Like most tutorials this one shows how to do iOS and Android separately, but there is another way)

// NuGet package to add:
// FirebaseAuthentication.net (same developer as "FirebaseDatabase.net" which we use)
// > Documentation: 
// >> Blog post: https://medium.com/step-up-labs/firebase-authentication-c-library-8e5e1c30acc2 (Watch out! There's a code error in the Facebook login example–it's fixed on their GitHub)
// >> GitHub: https://github.com/step-up-labs/firebase-authentication-dotnet
// FirebaseDatabase.net (you'll need both for the authentication's code to work)
// > Documentation:
// >> Blog post: https://medium.com/step-up-labs/firebase-c-library-5c342989ad18
// >> GitHub: https://github.com/step-up-labs/firebase-database-dotnet

// Other notes:
// > You have to create a web app for your project on Firebase, to get an API Key, which can be found while adding the app, or in your project's settings in Firebase (in the code snippet)
// > You're supposed to be able to do error handling to see why login details weren't accepted, if you can find code that works,
//   but you should at least use a TRY-CATCH so that you can tell the user there's an error instead of your app crashing.
// > Firebase and Xamarin are not friends. Yet. Xamarin is aparently working on something, but for now I advise against it for future projects with Xamarin. It's a pity, because Firebase is amazing in almost every other situation. But I've again been digging for workarounds until it's now 4:13am before class, and I'm sure you've had an even harder time with this. My sincere apologies for suggesting this workflow. It was totally unexpected.

using System;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Auth;

namespace testFirebaseAuth03
{
    public class DataConnection
    {
        /*
        public static async void SendMessage(string text, string author = "me")
        {
            //dummy data
            var email = "henry@hotmail.com";
            var password = "henry123";

            // specify your app’s client key (API Key) when creating the auth provider
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyCdweWwcxQ3y0Sh0YRFHFMX7JPtd9pdbo4"));

            //var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
            var auth = await authProvider.SignInWithEmailAndPasswordAsync(email, password);

            //your Firebase URL
            var firebase = new FirebaseClient("https://handshake-a96bf.firebaseio.com/",
                new FirebaseOptions
                {
                    //this is important, and this is where the blog post is wrong
                    AuthTokenAsyncFactory = () => Task.FromResult(auth.FirebaseToken)
                }
            );
            
            var newMessage = await firebase
                .Child("Messages")
                .PostAsync(new Message(text, author));
        }
        */
    }
}