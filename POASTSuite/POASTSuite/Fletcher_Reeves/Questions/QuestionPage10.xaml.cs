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
    public partial class QuestionPage10 : ContentPage
    {
        string username;
        FletcherReeves question10;
        public QuestionPage10(string username)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            question10 = new FletcherReeves(-2, 4, 0.7, -1, -1, 0, 0.5, 0);
            functionDisplay.Text = question10.soln.writeFunction();
            xValue.Text = question10.soln.x[0, 0].ToString();
            yValue.Text = question10.soln.x[1, 0].ToString();
            this.username = username;
        }

        async private void solveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationPage(question10, username));
        }
    }
}