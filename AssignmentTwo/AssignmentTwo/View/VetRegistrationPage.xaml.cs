﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AssignmentTwo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VetRegistrationPage : ContentPage
    {
        public VetRegistrationPage()
        {
            InitializeComponent();
        }

        private async void AddVetClicked(object sender, EventArgs e)
        {
            string errorMessagePrompt = "ERROR! Please fill in the following inputs:\n\n";

            if (vetId.Text == null || vetId.Text == "")
            {
                errorMessagePrompt += "- Enter a valid vetId\n";
            }

            if (firstName.Text == null || firstName.Text == "")
            {
                errorMessagePrompt += "- Enter a name\n";
            }

            if (lastName.Text == null || lastName.Text == "")
            {
                errorMessagePrompt += "- Enter a valid name\n";
            }

            if (phoneNumber.Text == null || phoneNumber.Text == "")
            {
                errorMessagePrompt += "- Enter a valid phone number\n";
            }

            if (email.Text == null || email.Text == "")
            {
                errorMessagePrompt += "- Enter a valid email\n";
            }

            if (specialization.Text == null || specialization.Text == "")
            {
                errorMessagePrompt += "- Enter a valid specialization\n";
            }

            if (errorMessagePrompt != "ERROR! Please fill in the following inputs:\n\n")
            {
                await DisplayAlert("Alert", errorMessagePrompt, "OK");
            }

            if (errorMessagePrompt == "ERROR! Please fill in the following inputs:\n\n")
            {
                await DisplayAlert("Patient Added Successfully To The Database! ", "Success!", "OK");
                await Navigation.PushAsync(new VetListPage());
                await App.Database.SaveVetAsync(new Vet
                {
                    VetID = vetId.Text,
                    FirstName = firstName.Text,
                    LastName = lastName.Text,
                    PhoneNumber = phoneNumber.Text,
                    Email = email.Text,
                    Specialization = specialization.Text
                });
            }
        }
    }
}