using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using POASTSuite.HookeAndJeevesModule.ProgramClasses;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.HookeAndJeevesModule.QuestionTwo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IterationOne : ContentPage
    {
        public IterationOne()
        {
            InitializeComponent();
        }

       async private void BtnNext_Clicked(object sender, EventArgs e)
        {
            var parameter2 = new Parameter2 (0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

            parameter2.f = 5 * Math.Pow(parameter2.x, 2) - (3 * (parameter2.x * parameter2.y)) + 6 * Math.Pow(parameter2.y, 2) + (parameter2.x) + (2 * parameter2.y);
            Console.WriteLine("f(0,0) = {0}", parameter2.f);
            int Max = 0;

            while (parameter2.h1 >= parameter2.h1F && parameter2.h2 >= parameter2.h2F && Max < 5)
            {

                if (parameter2.bestPoint > parameter2.THf)
                {
                    Program2.SolveFx(parameter2);
                }
                else
                {
                    if (parameter2.upperFx == parameter2.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter2.upperx, parameter2.y);
                        parameter2.h1 = parameter2.h1 / 2;
                        parameter2.h2 = parameter2.h2 / 2;
                        parameter2.THx = parameter2.upperx;
                        parameter2.THy = parameter2.y;

                        Program2.SolveFx(parameter2);
                    }

                    else if (parameter2.lowerFx == parameter2.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter2.lowerx, parameter2.y);
                        parameter2.h1 = parameter2.h1 / 2;
                        parameter2.h2 = parameter2.h2 / 2;
                        parameter2.THx = parameter2.lowerx;
                        parameter2.THy = parameter2.y;
                        Program2.SolveFx(parameter2);

                    }

                    else if (parameter2.upperFy == parameter2.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter2.xF, parameter2.uppery);
                        parameter2.h1 = parameter2.h1 / 2;
                        parameter2.h2 = parameter2.h2 / 2;
                        parameter2.THx = parameter2.xF;
                        parameter2.THy = parameter2.uppery;

                        Program2.SolveFx(parameter2);
                    }

                    else if (parameter2.lowerFy == parameter2.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter2.xF, parameter2.lowery);
                        parameter2.h1 = parameter2.h1 / 2;
                        parameter2.h2 = parameter2.h2 / 2;
                        parameter2.THx = parameter2.xF;
                        parameter2.THy = parameter2.lowery;

                        Program2.SolveFx(parameter2);
                    }
                }
                parameter2.i++;
                Max++;
            }

            int a;
            bool isEntryEmpty001 = string.IsNullOrEmpty(UpFX1.Text);
            if (isEntryEmpty001)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX1.Text) - parameter2.UpFX[0]) <= 0.05)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }


            int a1;
            bool isEntryEmpty002 = string.IsNullOrEmpty(LowFX1.Text);
            if (isEntryEmpty002)
            {
                a1 = 0;
            }
            else if (Math.Abs(double.Parse(LowFX1.Text) - parameter2.LowFX[0]) <= 0.05)
            {
                a1 = 1;
            }
            else
            {
                a1 = 0;
            }


            int a2;
            bool isEntryEmpty003 = string.IsNullOrEmpty(UpFY1.Text);
            if (isEntryEmpty003)
            {
                a2 = 0;
            }
            else if (Math.Abs(double.Parse(UpFY1.Text) - parameter2.UpFY[0]) <= 0.05)
            {
                a2 = 1;
            }
            else
            {
                a2 = 0;
            }

            int a3;
            bool isEntryEmpty004 = string.IsNullOrEmpty(LowFY1.Text);
            if (isEntryEmpty004)
            {
                a3 = 0;
            }
            else if (Math.Abs(double.Parse(LowFY1.Text) - parameter2.LowFY[0]) <= 0.05)
            {
                a3 = 1;
            }
            else
            {
                a3 = 0;
            }

            int b;
            bool isEntryEmpty005 = string.IsNullOrEmpty(Th1.Text);
            if (isEntryEmpty005)
            {
                b = 0;
            }
            else if (Math.Abs(double.Parse(Th1.Text) - parameter2.TFunct[0]) <= 0.05)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }

            int c;
            bool isEntryEmpty006 = string.IsNullOrEmpty(Bp1.Text);
            if (isEntryEmpty006)
            {
                c = 0;
            }
            else if (Math.Abs(double.Parse(Bp1.Text) - parameter2.Function[0]) <= 0.05)
            {
                c = 1;
            }
            else
            {
                c = 0;
            }

            double T = a + a1 + a2 + a3 + b + c;
            // double score = Math.Round((T / 6 * 100) * 2) / 2;
            double score = T;

            // Bp1.Text = score.ToString();
            await Navigation.PushModalAsync(new IterationTwo(score));

        }

    }
}
