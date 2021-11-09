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
    public partial class DfpIterationPage2a : ContentPage
    {
        public DfpIterationPage2a()
        {
            InitializeComponent();
        }

        //this page has to be modified 
        public double[] arrayg1;
        public double[] arrayg2;
        public double[] arrays1;
        public double[] arrays2;
        public double[] arraylambda;
        public double[] arrayx1;
        public double[] arrayx2;
        DfpGradingCentre Question;
        int i;
        double sCore;
        int h;
        

        public DfpIterationPage2a(double score, int g, int h, DfpGradingCentre question, double[] arrayg1, double[] arrayg2, double[] arrays1, double[] arrays2, double[] arraylambda, double[] arrayx1, double[] arrayx2)
        {

            InitializeComponent();

            Question = question;
            i = g + 1;
            this.h = h + 1;
            sCore = score;
            iterationNumber.Text = i.ToString();
            this.arrayg1 = arrayg1;
            this.arrayg2 = arrayg2;
            this.arrays1 = arrays1;
            this.arrays2 = arrays2;
            this.arraylambda = arraylambda;
            this.arrayx1 = arrayx1;
            this.arrayx2 = arrayx2;

        }

        async private void scorePage_Clicked(object sender, EventArgs e)
        {
            try
            {
                sCore = sCore + Question.Compare_Scores(h, double.Parse(Userg1x1.Text), double.Parse(Userg1x2.Text), double.Parse(Users1x1.Text), double.Parse(Users1x2.Text), double.Parse(UserL1.Text), double.Parse(UserX2x1.Text), double.Parse(UserX2x2.Text));

                await Navigation.PushModalAsync(new DfpScorePage(sCore));
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }
    }
}
