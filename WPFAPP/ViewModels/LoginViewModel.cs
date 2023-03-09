using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using WPFAPP.Models;

namespace WPFAPP.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private UserModel userModel;
        private string username;
        private string password;
        private string errorMessage;

        public LoginViewModel()
        {
            userModel = new UserModel();
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value;
                OnPropertyChanged("ErrorMessage");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool AuthenticateUser()
        {
            return userModel.AuthenticateUser(Username, Password);
        }
    }
}