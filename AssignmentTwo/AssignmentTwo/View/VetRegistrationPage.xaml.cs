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
    public partial class VetRegistrationPage : ContentPage
    {
        public VetRegistrationPage()
        {
            InitializeComponent();
        }

        private async void AddVetClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VetListPage());
        }
    }
}