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
    public partial class PetRegistration : ContentPage
    {
        public PetRegistration()
        {
            InitializeComponent();
        }

        private async void addPetClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PetDisplayPage());
        }
    }
}