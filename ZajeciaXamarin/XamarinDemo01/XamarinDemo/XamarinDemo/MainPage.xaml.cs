using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_OnClicked(object sender, EventArgs e)
        {
            //var name = LoginEntry.Text;
            //var password = PasswordEntry.Text;
            Navigation.PushModalAsync(new MenuPage());
        }
    }
}
