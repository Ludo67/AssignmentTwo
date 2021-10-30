using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            if (usernameText.Text == null || usernameText.Text == "")
            {
                errorMessagePrompt += "- Enter a valid username -\n";
            }
            if (passwordText.Text == null || passwordText.Text == "")
            {
                errorMessagePrompt += "- Enter a valid password -\n";
            }
            if (passwordText.Text != null && passwordText.Text != "")
            {
                if (passwordText.Text.Length <= 10)
                {
                    errorMessagePrompt += "- Enter a valid password: Need more than 10 characters -\n";
                }
            }
            if (firstNameText.Text == null || firstNameText.Text == "")
            {
                errorMessagePrompt += "- Enter a valid first name -\n";
            }
            if (lastnameText.Text == null || lastnameText.Text == "")
            {
                errorMessagePrompt += "- Enter a valid last name -\n";
            }
            if (phoneText.Text == null || phoneText.Text == "")
            {
                errorMessagePrompt += "- Enter a valid phone number -\n";
            }
            if (emailText.Text == null || emailText.Text == "")
            {
                errorMessagePrompt += "- Enter a valid email -";
            }

            if (errorMessagePrompt != "ERROR! Please fill in the following inputs:\n\n")
            {
                await DisplayAlert("Alert", errorMessagePrompt, "OK");
            }

            if (errorMessagePrompt == "ERROR! Please fill in the following inputs:\n\n"){
                await DisplayAlert("Patient Added Successfully To The Database! ", "Success!", "OK");
                await Navigation.PushAsync(new LoginPage());
            }
        }
    }
}