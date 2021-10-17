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
    public partial class QuestionPage4 : ContentPage
    {
        string username;
        FletcherReeves question4;
        public QuestionPage4(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            question4 = new FletcherReeves(-2, 4, 2.6, -2, 1, 0, 0.2, 1);
            functionDisplay.Text = question4.soln.writeFunction();
            xValue.Text = question4.soln.x[0, 0].ToString();
            yValue.Text = question4.soln.x[1, 0].ToString();
            this.username = username;
        }

        async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationPage(question4, username));
        }
    }
}