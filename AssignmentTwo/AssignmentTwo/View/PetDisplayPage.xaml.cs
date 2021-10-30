using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AssignmentTwo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PetDisplayPage : ContentPage
    {
        public PetDisplayPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPets();

            var pets = await App.Database.GetPets();
            if (pets.Count == 0)
            {
                await DisplayAlert("Alert", "The list is empty!", "OK");
            }
        }

    }
}