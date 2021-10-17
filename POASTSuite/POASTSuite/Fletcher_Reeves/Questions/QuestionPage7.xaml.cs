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
    public partial class QuestionPage7 : ContentPage
    {
        string username;
        FletcherReeves question7;
        public QuestionPage7(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            question7 = new FletcherReeves(-2, 4, 1.7, -3, -1, 0, 0.2, 1);
            functionDisplay.Text = question7.soln.writeFunction();
            xValue.Text = question7.soln.x[0, 0].ToString();
            yValue.Text = question7.soln.x[1, 0].ToString();
            this.username = username;
        }

        async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationPage(question7, username));
        }
    }
}