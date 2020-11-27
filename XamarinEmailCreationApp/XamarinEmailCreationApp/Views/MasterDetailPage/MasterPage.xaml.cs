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
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
            this.BindingContext = new MasterViewModel();
        }
        /*
        async private void LoginPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        */
    }
}