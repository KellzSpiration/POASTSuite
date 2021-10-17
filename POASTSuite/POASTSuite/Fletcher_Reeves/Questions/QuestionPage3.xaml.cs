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
    public partial class QuestionPage3 : ContentPage
    {
        string username;
        FletcherReeves question3;
        public QuestionPage3(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            question3 = new FletcherReeves(-2, 4, 1.6, -3, -1, 0, 0.3, 0);
            functionDisplay.Text = question3.soln.writeFunction();
            xValue.Text = question3.soln.x[0, 0].ToString();
            yValue.Text = question3.soln.x[1, 0].ToString();
            this.username = username;
        }

        async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationPage(question3, username));
        }
    }
}