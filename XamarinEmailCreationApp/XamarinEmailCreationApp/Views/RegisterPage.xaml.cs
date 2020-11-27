using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinEmailCreationApp.ViewModels;

namespace XamarinEmailCreationApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage(IEnumerable<User> existingUsers)
        {
            InitializeComponent();
            this.BindingContext = new RegisterViewModel(existingUsers);
        }
    }
}