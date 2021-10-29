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

        private async void vetRegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VetRegistration());
        }

        private async void vetListClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VetListPage());
        }

        private async void petRegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PetRegistration());
        }

        private async void petDisplayClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PetDisplayPage());
        }

        private async void LogoutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}