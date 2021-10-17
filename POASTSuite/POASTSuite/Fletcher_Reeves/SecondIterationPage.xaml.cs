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
    public partial class SecondIterationPage : ContentPage
    {
        public double[] arrayG1;
        public double[] arrayG2;
        public double[] arrayS1;
        public double[] arrayS2;
        public double[] arrayLambda;
        public double[] arrayX1;
        public double[] arrayX2;
        FletcherReeves Question;
        string username;
        int i;
        double sCore;
        int h;
        public SecondIterationPage(double score, int g, int h, FletcherReeves question, double[] arrayg1, double[] arrayg2, double[] arrays1, double[] arrays2, double[] arraylambda, double[] arrayx1, double[] arrayx2, string username)
        {
            InitializeComponent();
            Question = question;
            i = g + 1;
            this.h = h + 1;
            sCore = score;
            iterationNumber.Text = i.ToString();
            arrayG1 = arrayg1;
            arrayG2 = arrayg2;
            arrayS1 = arrays1;
            arrayS2 = arrays2;
            arrayLambda = arraylambda;
            arrayX1 = arrayx1;
            arrayX2 = arrayx2;
            this.username = username;
        }

        async private void scorePage_Clicked(object sender, EventArgs e)
        {
            try
            {
                sCore = sCore + Question.CompareScores(h, double.Parse(gOne.Text), double.Parse(gTwo.Text), double.Parse(sOne.Text), double.Parse(sTwo.Text), double.Parse(lambda.Text), double.Parse(x1Value.Text), double.Parse(x2Value.Text));

                await Navigation.PushModalAsync(new ScorePage(sCore, username));
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }
    }
}