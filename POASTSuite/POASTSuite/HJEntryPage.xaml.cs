using POASTSuite.HookeAndJeevesModule.QuestionOne;
using POASTSuite.HookeAndJeevesModule.QuestionTwo;
using POASTSuite.HookeAndJeevesModule.QuestionThree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using POASTSuite.HookeAndJeevesModule.QuestionFour;
using POASTSuite.HookeAndJeevesModule.QueestionFive;
using POASTSuite.HookeAndJeevesModule.QuestionSix;
using POASTSuite.HookeAndJeevesModule.QuestionSeven;
using POASTSuite.HookeAndJeevesModule.QuestionEight;
using POASTSuite.HookeAndJeevesModule.QuestionNine;
using POASTSuite.HookeAndJeevesModule.QuestionTen;

namespace POASTSuite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HJEntryPage : ContentPage
    {
        public HJEntryPage()
        {
            InitializeComponent();
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FirstIteration1());
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new IterationOne());
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new IterationOneQ3());
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new IterationOneQ4());
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new IterationOneQ5());
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new IterationOneQ6());
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new IterationOneQ7());
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new IterationOneQ8());
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new IterationOneQ9());
        }

        private void Btn10_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new IterationOneQ10());
        }
    }
}