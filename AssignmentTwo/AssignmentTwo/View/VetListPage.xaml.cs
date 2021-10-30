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
    public partial class VetListPage : ContentPage
    {
        public VetListPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var vets = await App.Database.GetVetsAsync();
            if(vets.Count() == 0)
            {
                await DisplayAlert("Database is empty!", "There are no vets recorded in the database yet.", "OK");
            }
            collectionView.ItemsSource = vets;
        }
    }
}