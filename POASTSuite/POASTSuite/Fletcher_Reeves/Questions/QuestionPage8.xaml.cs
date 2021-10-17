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
    public partial class QuestionPage8 : ContentPage
    {
        string username;
        FletcherReeves question8;
        public QuestionPage8(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            question8 = new FletcherReeves(-2, 4, 1.6, -1.5, 1, 1, 0.5, 0);
            functionDisplay.Text = question8.soln.writeFunction();
            xValue.Text = question8.soln.x[0, 0].ToString();
            yValue.Text = question8.soln.x[1, 0].ToString();
            this.username = username;
        }

        async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationPage(question8, username));
        }
    }
}