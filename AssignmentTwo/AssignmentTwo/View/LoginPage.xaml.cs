using AssignmentTwo.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AssignmentTwo
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            LoginPageViewModel loginPageViewModel = new LoginPageViewModel();
            loginPageViewModel.User = new User();
            InitializeComponent();
            BindingContext = loginPageViewModel;
        }

        private async void LoginClicked(object sender, EventArgs e)
        {
            List<User> users = await App.Database.GetUsers();
            if(users.Count == 0)
            {
                await DisplayAlert("Error!", "Incorrect Username or Password", "OK");
            }
            foreach (User user in users)
                if(username.Text == user.Username && password.Text == user.Password)
                {
                    await Navigation.PushAsync(new HomePage());
                }
                else
                {
                    await DisplayAlert("Error!", "Incorrect Username or Password", "OK");
                }
            
        }

        private async void RegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }

    }
}
