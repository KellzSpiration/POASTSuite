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
    public partial class DfpScorePage : ContentPage
    {
        double sCore;
        public DfpScorePage()
        {
            InitializeComponent();
        }

        public DfpScorePage(double score)
        {
            InitializeComponent();
            sCore = Math.Round(score);
            ShowMessage(sCore);
            GetScore();
        }

        private void ShowMessage(double sCore)
        {
            if (sCore == 100)
            {
                message.Text = "EXCELLENT!";
            }
            else if (sCore > 70 && sCore <= 99)
            {
                message.Text = "VERY GOOD";
            }
            else if (sCore < 70 && sCore >= 50)
            {
                message.Text = "GOOD";
            }
            else
            {
                message.Text = "YOU CAN DO BETTER!";
            }
        }

        void GetScore()
        {
            score.Text = sCore.ToString() + " % ";
        }

        async private void done_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DfpQuestionSelection());
        }

        private void back_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushModalAsync(new WelcomePage());
        }
    }
}
