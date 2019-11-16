using System;
using System.Collections.Generic;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Auth;

using Xamarin.Forms;
using System.Threading;
using System.Collections.ObjectModel;

namespace Punchcard.Pages
{
    public partial class ActiveChatsPage : ContentPage
    {

        private static string keyCurrent = null;
        private static string key = null;
        System.Timers.Timer Timer1 = new System.Timers.Timer();
        //public ObservableCollection<Message> Messages { get; set; } = new ObservableCollection<Message>();

        public ActiveChatsPage()
        {
            InitializeComponent();
            //Messages.Insert(0, new Message() { text = "hello there", user = "Jeff" });

        }

        public async void update()
        {
            var messages = await App.firebase
                .Child("messages")
                .OnceAsync<Message>();

            messagesStack.Children.Clear();

            foreach (var message in messages)
            {
                Console.WriteLine($"{message.Key} is {message.Object.text}");
                chatz.Text += message.Object.text;
                messagesStack.Children.Add(new Label { Text = message.Object.user });
                messagesStack.Children.Add(new Label { Text = message.Object.text });
            }
        }

        public async void SendMessage(string _message)
        {
            App.firebase = new FirebaseClient("https://handshake-a96bf.firebaseio.com/");

            await App.firebase
              .Child("messages")
              .PostAsync(new Message(_message, App.userID));

            var observable = App.firebase
              .Child("messages")
              .AsObservable<Message>()
              .Subscribe(d => { Console.WriteLine(d.Key); keyCurrent = d.Key; });

            Device.StartTimer(TimeSpan.FromSeconds(0.5), () =>
            {
                //Console.WriteLine("ALERT");
                if(keyCurrent != key)
                {
                    Console.WriteLine("New message");
                    key = keyCurrent;
                    update();
                }

                return true; // True = Repeat again, False = Stop the timer
            });
        }

        public

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            SendMessage(message.Text);
            message.Text = "";
        }
    }
}