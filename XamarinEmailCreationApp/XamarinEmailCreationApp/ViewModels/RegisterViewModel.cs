using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using System.Linq;

namespace XamarinEmailCreationApp.ViewModels
{
    public class RegisterViewModel
    {
        public ICommand RegisterCommand => new Command(Register);

        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        private IEnumerable<User> existingUsers;

        public RegisterViewModel(IEnumerable<User> users)
        {
            existingUsers = users;
        }


        async public void Register()
        {
            if (AreEntriesFilled())
                await App.Current.MainPage.DisplayAlert("Error", "Name, Email, and/or password can't be empty", "OK");
            else if (Password != ConfirmPassword)
                await App.Current.MainPage.DisplayAlert("Error", "Your passwords aren't the same", "OK");
            else
            {
                if (existingUsers.Any(t => t.Email == Email))
                    await App.Current.MainPage.DisplayAlert("Error", "That email is alredy in use", "OK");
                else
                {
                    LoginPage.AddUser(new User(Name, Email, Password));
                    await App.Current.MainPage.DisplayAlert("Important", "Your account has been created", "OK");
                }
            }
        }

        private bool AreEntriesFilled()
        {
            return string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Email)
                || string.IsNullOrWhiteSpace(Password);
        }
    }
}
