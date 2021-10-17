using POASTSuite.Fletcher_Reeves.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.Fletcher_Reeves
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FletcherReevesMainPage : ContentPage
    {
        string username;
        public FletcherReevesMainPage(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            this.username = username;
        }

        async private void question1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage1(username));
        }

        async private void question2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage2(username));
        }

        async private void question3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage3(username));
        }

        async private void question4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage4(username));
        }

        async private void question5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage5(username));        }

        async private void question6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage6(username));
        }

        async private void question7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage7(username));
        }

        async private void question8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage8(username));
        }

        async private void question9_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage9(username));
        }

        async private void question10_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage10(username));
        }

        async private void question11_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage11(username));
        }

        async private void question12_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new QuestionPage12(username));
        }
    }
}