using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinEmailCreationApp.ViewModels
{
    public class MasterViewModel
    {
        public ICommand ReturnCommand => new Command(Return);

        async private void Return()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
