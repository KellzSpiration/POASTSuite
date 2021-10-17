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
    public partial class QuestionPage11 : ContentPage
    {
        string username;
        FletcherReeves question11;
        public QuestionPage11(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            question11 = new FletcherReeves(-1, 1, 1.5, -2, -1, 0, 0.5, 0);
            functionDisplay.Text = question11.soln.writeFunction();
            xValue.Text = question11.soln.x[0, 0].ToString();
            yValue.Text = question11.soln.x[1, 0].ToString();
            this.username = username;
        }

        async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationPage(question11, username));
        }
    }
}