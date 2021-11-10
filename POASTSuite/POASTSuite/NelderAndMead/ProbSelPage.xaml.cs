using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POASTSuite.NelderAndMead.NeldQ1;
using POASTSuite.NelderAndMead.NeldQ2;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.NelderAndMead
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProbSelPage : ContentPage
    {
        public ProbSelPage()
        {
            InitializeComponent();
        }

        private async void btn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Q1It1());
        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Q2It1());
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {

        }

        private void btn4_Clicked(object sender, EventArgs e)
        {

        }

        private void btn5_Clicked(object sender, EventArgs e)
        {

        }

        private void btn6_Clicked(object sender, EventArgs e)
        {

        }

        private void btn7_Clicked(object sender, EventArgs e)
        {

        }

        private void btn8_Clicked(object sender, EventArgs e)
        {

        }

        private void btn9_Clicked(object sender, EventArgs e)
        {

        }

        private void btn10_Clicked(object sender, EventArgs e)
        {

        }

        private void btn11_Clicked(object sender, EventArgs e)
        {

        }

        private void btn12_Clicked(object sender, EventArgs e)
        {

        }

        private void btn13_Clicked(object sender, EventArgs e)
        {

        }

        private void btn14_Clicked(object sender, EventArgs e)
        {

        }

        private void btn15_Clicked(object sender, EventArgs e)
        {

        }
    }
}