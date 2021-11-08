using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.DFPModule
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DfpIterationPage1 : ContentPage
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
        
        DfpGradingCentre Question;

        public DfpIterationPage1(DfpGradingCentre question)
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
        }



        async private void nextIteration_Clicked(object sender, EventArgs e)
        {
            try
            {
                sCore = Question.Compare_Scores(h, double.Parse(Userg1x1.Text), double.Parse(Userg1x2.Text), double.Parse(Users1x1.Text), double.Parse(Users1x2.Text), double.Parse(UserL1.Text), double.Parse(UserX2x1.Text), double.Parse(UserX2x2.Text));



                await Navigation.PushModalAsync(new DfpIterationPage2a(sCore, i, h, Question, arrayg1, arrayg2, arrays1, arrays2, arraylambda, arrayx1, arrayx2));

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }

        }
    }
}
