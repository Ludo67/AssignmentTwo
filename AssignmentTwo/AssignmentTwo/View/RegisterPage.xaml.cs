using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AssignmentTwo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async void RegisterClicked(object sender, EventArgs e)
        {
            string errorMessagePrompt = "ERROR! Please fill in the following inputs:\n\n";

            if (username.Text == null || username.Text == "")
            {
                errorMessagePrompt += "- Enter a valid username -\n";
            }
            if (password.Text == null || password.Text == "")
            {
                errorMessagePrompt += "- Enter a valid password -\n";
            }
            if (password.Text != null && password.Text != "")
            {
                if (password.Text.Length <= 10)
                {
                    errorMessagePrompt += "- Enter a valid password: Need more than 10 characters -\n";
                }
            }
            if (firstName.Text == null || firstName.Text == "")
            {
                errorMessagePrompt += "- Enter a valid first name -\n";
            }
            if (lastname.Text == null || lastname.Text == "")
            {
                errorMessagePrompt += "- Enter a valid last name -\n";
            }
            if (phone.Text == null || phone.Text == "")
            {
                errorMessagePrompt += "- Enter a valid phone number -\n";
            }
            if (email.Text == null || email.Text == "")
            {
                errorMessagePrompt += "- Enter a valid email -";
            }

            if (email.Text != null && !Regex.IsMatch(email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorMessagePrompt += "- Enter a valid email -";
            }

            if (errorMessagePrompt != "ERROR! Please fill in the following inputs:\n\n")
            {
                await DisplayAlert("Alert", errorMessagePrompt, "OK");
            }

            if (errorMessagePrompt == "ERROR! Please fill in the following inputs:\n\n"){
                await DisplayAlert("Patient Added Successfully To The Database! ", "Success!", "OK");
                await App.Database.RegisterUserAsync(new User
                {
                    Username = username.Text,
                    Password = password.Text,
                    FirstName = firstName.Text,
                    LastName = lastname.Text,
                    PhoneNumber = phone.Text,
                    Email = email.Text
                });
                await Navigation.PushAsync(new LoginPage());
            }

        }
    }
}