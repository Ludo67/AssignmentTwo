using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AssignmentTwo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void loginButton_OnClicked(object sender, EventArgs e)
        {
            //VetRegisterPage = new NavigationPage(new VetRegistration());
            //PetRegisterPage = new NavigationPage(new PetRegistration());
            //Home = new NavigationPage(new HomePage());
            //Registerpage = new NavigationPage(new Register());
            await Navigation.PushAsync(new NavigationPage(new HomePage()));
        }

        private async void registerButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Register()));
        }

    }
}
