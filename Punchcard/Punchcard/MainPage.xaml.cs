using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punchcard.Pages;
using Xamarin.Forms;

namespace Punchcard
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Children.Add(new ContactsPage());
            this.Children.Add(new ActiveChatsPage());
            this.Children.Add(new SettingsPage());
        }
    }
}
