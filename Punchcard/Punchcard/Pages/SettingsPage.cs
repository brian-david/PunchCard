using System;

using Xamarin.Forms;

namespace Punchcard.Pages
{
    public class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

