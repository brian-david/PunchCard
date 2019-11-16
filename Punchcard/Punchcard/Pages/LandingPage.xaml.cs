using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Punchcard
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        void loginMethod(object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
