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
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            LabelHelloFriend.Text = username;
        }

        private void WelcomeStartTechniqueButton_Clicked(object sender, EventArgs e)
        {
            if (hookesandjeevesCheckbox.IsChecked)
            {
                neldermeadcheckbox.IsEnabled = false;
                DfpCheckbox.IsEnabled = false;
                flectherandreevescheckbox.IsEnabled = false;
             //   Navigation.PushAsync(new MainPage());
                //Kaycee please change MainPage to your very first page for HJ
            }
            else if (neldermeadcheckbox.IsChecked)
            {

                DfpCheckbox.IsEnabled = false;
                flectherandreevescheckbox.IsEnabled = false;
                hookesandjeevesCheckbox.IsEnabled = false;
                //Navigation.PushAsync(new NelderAndMead());
                //Belem please change DfpPage6 to your very first page for NM
            }
            else if (DfpCheckbox.IsChecked)
            {
                neldermeadcheckbox.IsEnabled = false;
                flectherandreevescheckbox.IsEnabled = false;
                hookesandjeevesCheckbox.IsEnabled = false;

                //Navigation.PushAsync(new DFP());
            }

            else if (flectherandreevescheckbox.IsChecked)
            {
                neldermeadcheckbox.IsChecked = false;
                DfpCheckbox.IsChecked = false;
                hookesandjeevesCheckbox.IsChecked = false;
              //  Navigation.PushAsync(new FletcherAndReeves());
                //Iruoma please change MainPage to your very first page for FR
            }
            else
            {
                DisplayAlert("Error selecting a Module", "Please check (tick) a box", "Ok", "Cancel");
            }

        }
    }
}