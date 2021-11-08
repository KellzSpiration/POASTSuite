using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.DFPModule
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DfpPage : ContentPage
    {
        public DfpPage()
        {
            //This code enables to remove navigation bar property 
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
        }

        async private void NextButtonSelectionQuestionPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DfpQuestionSelection());
        }

        async private void BackButtonSelectQuestionPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WelcomePage());
        }
    }
}