using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AssignmentTwo.ViewModel
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        public LoginPageViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private User _user;

        public User User
        {
            get => _user;
            set
            {
                _user = value;
            }
        }

        string username = "";
        public string Username
        {
            get { return username; }
            set { 
                    username = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(DisplayText));
            }
        }

        void OnPropertyChanged([CallerMemberName] string username = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(username));
        }

        public string DisplayText => $"Hello {Username} and welcome to Champlain PetClinic!";
    }
}
