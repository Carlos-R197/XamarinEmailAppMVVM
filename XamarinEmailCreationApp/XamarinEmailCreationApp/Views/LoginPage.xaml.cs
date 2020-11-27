using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinEmailCreationApp.ViewModels;

namespace XamarinEmailCreationApp
{
    public partial class LoginPage : ContentPage
    {
        private static List<User> existingUsers = new List<User>();

        public static void AddUser(User user) =>
            existingUsers.Add(user);

        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel(existingUsers);
        }
    }
}
