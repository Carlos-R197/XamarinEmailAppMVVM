using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;

namespace XamarinEmailCreationApp.ViewModels
{
    public class LoginViewModel
    {
        public ICommand LoginCommand => new Command(Login);
        public ICommand RegisterCommand => new Command(MoveToRegisterPage);

        public User CurrentUser { get; set; }

        private List<User> existingUsers;

        public LoginViewModel(List<User> users)
        {
            CurrentUser = new User();
            existingUsers = users;
        }

        async public void Login()
        {
            User user = existingUsers.FirstOrDefault(t => t.Email == CurrentUser.Email && t.Password == CurrentUser.Password);
            if (user != null)
            {
                await App.Current.MainPage.DisplayAlert("Welcome", $"Hello {user.Name} ", "OK");
                CurrentUser.Email = "";
                CurrentUser.Password = "";
                await App.Current.MainPage.Navigation.PushAsync(new LoggedPage());
            }
            else
            {
                if (string.IsNullOrWhiteSpace(CurrentUser.Email) || string.IsNullOrWhiteSpace(CurrentUser.Password))
                    await App.Current.MainPage.DisplayAlert("Error", "The entries must be filled", "OK");
                else
                    await App.Current.MainPage.DisplayAlert("Error", "The user does not exist", "OK");
            }
        }

        async public void MoveToRegisterPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage(existingUsers));
        }
    }
}
