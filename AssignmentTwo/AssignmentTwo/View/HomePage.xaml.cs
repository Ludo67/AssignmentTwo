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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void VetRegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VetRegistrationPage());
        }

        private async void VetListClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VetListPage());
        }

        private async void PetRegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PetRegistrationPage());
        }

        private async void PetDisplayClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PetDisplayPage());
        }

        private async void LogoutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}