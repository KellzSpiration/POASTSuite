using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using POASTSuite.HookeAndJeevesModule.ProgramClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.HookeAndJeevesModule.QuestionFour
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IterationOne : ContentPage
    {
        public IterationOne()
        {
            InitializeComponent();
        }

      async  private void BtnNext_Clicked(object sender, EventArgs e)
        {
            var parameter4 = new Parameter4(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

            parameter4.f = 2 * Math.Pow(parameter4.x, 2) - (7 * (parameter4.x * parameter4.y)) + 6 * Math.Pow(parameter4.y, 2) + (5 * parameter4.x) + (5 * parameter4.y);
            Console.WriteLine("f(0,0) = {0}", parameter4.f);
            int Max = 0;

            while (parameter4.h1 >= parameter4.h1F && parameter4.h2 >= parameter4.h2F && Max < 5)
            {

                if (parameter4.bestPoint > parameter4.THf)
                {
                    Program4.SolveFx(parameter4);
                }
                else
                {
                    if (parameter4.upperFx == parameter4.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter4.upperx, parameter4.y);
                        parameter4.h1 = parameter4.h1 / 2;
                        parameter4.h2 = parameter4.h2 / 2;
                        parameter4.THxx = parameter4.upperx;
                        parameter4.THyy = parameter4.y;

                        Program4.SolveFx(parameter4);
                    }

                    else if (parameter4.lowerFx == parameter4.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter4.lowerx, parameter4.y);
                        parameter4.h1 = parameter4.h1 / 2;
                        parameter4.h2 = parameter4.h2 / 2;
                        parameter4.THxx = parameter4.lowerx;
                        parameter4.THyy = parameter4.y;
                        Program4.SolveFx(parameter4);

                    }

                    else if (parameter4.upperFy == parameter4.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter4.xF, parameter4.uppery);
                        parameter4.h1 = parameter4.h1 / 2;
                        parameter4.h2 = parameter4.h2 / 2;
                        parameter4.THxx = parameter4.xF;
                        parameter4.THyy = parameter4.uppery;

                        Program4.SolveFx(parameter4);
                    }

                    else if (parameter4.lowerFy == parameter4.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter4.xF, parameter4.lowery);
                        parameter4.h1 = parameter4.h1 / 2;
                        parameter4.h2 = parameter4.h2 / 2;
                        parameter4.THxx = parameter4.xF;
                        parameter4.THyy = parameter4.lowery;

                        Program4.SolveFx(parameter4);
                    }
                }
                parameter4.i++;
                Max++;
            }

            int a;
            bool isEntryEmpty001 = string.IsNullOrEmpty(UpFX1.Text);
            if (isEntryEmpty001)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX1.Text) - parameter4.UpFX[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFX1.Text) - parameter4.LowFX[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(UpFY1.Text) - parameter4.UpFY[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFY1.Text) - parameter4.LowFY[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Th1.Text) - parameter4.TFunct[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Bp1.Text) - parameter4.Function[0]) <= 0.05)
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

