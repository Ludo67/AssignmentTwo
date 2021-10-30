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
    public partial class PetRegistrationPage : ContentPage
    {
        public PetRegistrationPage()
        {
            InitializeComponent();
        }

        async void AddPetClicked(object sender, EventArgs e)
        {

            string errorMessagePrompt = "ERROR! Please fill in the following inputs:\n\n";

            if (petId.Text == null || petId.Text == "")
            {
                errorMessagePrompt += "- Enter a valid petId\n";
            }

            if (petName.Text == null || petName.Text == "")
            {
                errorMessagePrompt += "- Enter a valid pet name\n";
            }

            if (type.Text == null || type.Text == "")
            {
                errorMessagePrompt += "- Enter a valid pet type\n";
            }

            if (errorMessagePrompt != "ERROR! Please fill in the following inputs:\n\n")
            {
                await DisplayAlert("Alert", errorMessagePrompt, "OK");
            }

            if (errorMessagePrompt == "ERROR! Please fill in the following inputs:\n\n")
            {
                await DisplayAlert("Pet Added Successfully To The Database! ", "Success!", "OK");
                await Navigation.PushAsync(new HomePage());
                await App.Database.RegisterPetAsync(new Pet 
                {
                    PetID = petId.Text,
                    PetName = petName.Text,
                    PetType = type.Text
                });
            }
            
        }
    }
}