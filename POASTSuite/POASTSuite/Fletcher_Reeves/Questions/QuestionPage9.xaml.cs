using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.Fletcher_Reeves.Questions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage9 : ContentPage
    {
        string username;
        FletcherReeves question9;
        public QuestionPage9(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            question9 = new FletcherReeves(-2, 4, 1.5, 2, -1, 2, 2.5, 0);
            functionDisplay.Text = question9.soln.writeFunction();
            xValue.Text = question9.soln.x[0, 0].ToString();
            yValue.Text = question9.soln.x[1, 0].ToString();
            this.username = username;
        }

        async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationPage(question9, username));
        }
    }
}