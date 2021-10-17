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
    public partial class FirstIterationPage : ContentPage
    {
        //have arrays that i can pass my iteration values to
        public double[] arrayg1;
        public double[] arrayg2;
        public double[] arrays1;
        public double[] arrays2;
        public double[] arraylambda;
        public double[] arrayx1;
        public double[] arrayx2;
        //double n;
        int i;
        double sCore;
        int h;
        FletcherReeves Question;
        string username;
        public FirstIterationPage(FletcherReeves question,string username)
        {
            InitializeComponent();
            Question = question;
            i = 1;
            h = 0;
            iterationNumber.Text = i.ToString();
            Question.GetEntryValues();

            arrayg1 = Question.arrayG1;
            arrayg2 = Question.arrayG2;
            arrays1 = Question.arrayS1;
            arrays2 = Question.arrayS2;
            arraylambda = Question.arrayLambda;
            arrayx1 = Question.arrayX1;
            arrayx2 = Question.arrayX2;
            this.username = username;
        }

        async private void nextIteration_Clicked(object sender, EventArgs e)
        {
            try
            {
                sCore = Question.CompareScores(h, double.Parse(gOne.Text), double.Parse(gTwo.Text), double.Parse(sOne.Text), double.Parse(sTwo.Text), double.Parse(lambda.Text), double.Parse(x1Value.Text), double.Parse(x2Value.Text));

                await Navigation.PushModalAsync(new SecondIterationPage(sCore, i, h, Question, arrayg1, arrayg2, arrays1, arrays2, arraylambda, arrayx1, arrayx2, username));
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }
    }
}