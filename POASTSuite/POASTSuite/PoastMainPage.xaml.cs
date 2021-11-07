using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PoastMainPage : ContentPage
    {
        public PoastMainPage()
        {
            InitializeComponent();
            SetValue(NavigationPage.HasNavigationBarProperty, false);
        }

        private void ExitButton_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

      async  private void ContinueButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}