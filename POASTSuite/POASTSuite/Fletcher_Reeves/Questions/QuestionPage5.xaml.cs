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
    public partial class QuestionPage5 : ContentPage
    {
        string username;
        FletcherReeves question5;
        public QuestionPage5(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            question5 = new FletcherReeves(-2, 4, 0.6, -2, -2, 0, 0.5, 2);
            functionDisplay.Text = question5.soln.writeFunction();
            xValue.Text = question5.soln.x[0, 0].ToString();
            yValue.Text = question5.soln.x[1, 0].ToString();
            this.username = username;
        }

        async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationPage(question5, username));
        }
    }
}