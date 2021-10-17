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
    public partial class QuestionPage6 : ContentPage
    {
        string username;
        FletcherReeves question6;
        public QuestionPage6(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            question6 = new FletcherReeves(-2, 4, 3.5, -0.5, -1, 2, 0.3, 1);
            functionDisplay.Text = question6.soln.writeFunction();
            xValue.Text = question6.soln.x[0, 0].ToString();
            yValue.Text = question6.soln.x[1, 0].ToString();
            this.username = username;
        }

        async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationPage(question6, username));
        }
    }
}