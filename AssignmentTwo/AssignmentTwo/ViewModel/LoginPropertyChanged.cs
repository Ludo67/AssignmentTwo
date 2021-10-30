using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AssignmentTwo.ViewModel
{
    public class LoginPropertyChanged : INotifyPropertyChanged
    {

        string username = null;
        public string UserName
        {
            get => username;
                set
                {
                if (value == username)
                    return;
                OnPropertyChanged(nameof(username));
                OnPropertyChanged(nameof(Welcome));

                }
        }
        public string Welcome
        {
            get => $"Welcome {username}!";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string username)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(username));
        }
    }
}