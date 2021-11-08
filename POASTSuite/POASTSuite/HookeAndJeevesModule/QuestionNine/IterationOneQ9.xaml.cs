using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using POASTSuite.HookeAndJeevesModule.ProgramClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.HookeAndJeevesModule.QuestionNine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IterationOneQ9 : ContentPage
    {
        public IterationOneQ9()
        {
            InitializeComponent();
        }

       async private void BtnNext_Clicked(object sender, EventArgs e)
        {
            var parameter9 = new Parameter9(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

            parameter9.f = 7 * Math.Pow(parameter9.x, 2) - (3 * (parameter9.x * parameter9.y)) + 6 * Math.Pow(parameter9.y, 2) + (7 * parameter9.x) + (2 * parameter9.y);
            Console.WriteLine("f(0,0) = {0}", parameter9.f);
            int Max = 0;

            while (parameter9.h1 >= parameter9.h1F && parameter9.h2 >= parameter9.h2F && Max < 5)
            {

                if (parameter9.bestPoint > parameter9.THf)
                {
                    Program9.SolveFx(parameter9);
                }
                else
                {
                    if (parameter9.upperFx == parameter9.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter9.upperx, parameter9.y);
                        parameter9.h1 = parameter9.h1 / 2;
                        parameter9.h2 = parameter9.h2 / 2;
                        parameter9.THxx = parameter9.upperx;
                        parameter9.THyy = parameter9.y;

                        Program9.SolveFx(parameter9);
                    }

                    else if (parameter9.lowerFx == parameter9.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter9.lowerx, parameter9.y);
                        parameter9.h1 = parameter9.h1 / 2;
                        parameter9.h2 = parameter9.h2 / 2;
                        parameter9.THxx = parameter9.lowerx;
                        parameter9.THyy = parameter9.y;
                        Program9.SolveFx(parameter9);

                    }

                    else if (parameter9.upperFy == parameter9.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter9.xF, parameter9.uppery);
                        parameter9.h1 = parameter9.h1 / 2;
                        parameter9.h2 = parameter9.h2 / 2;
                        parameter9.THxx = parameter9.xF;
                        parameter9.THyy = parameter9.uppery;

                        Program9.SolveFx(parameter9);
                    }

                    else if (parameter9.lowerFy == parameter9.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter9.xF, parameter9.lowery);
                        parameter9.h1 = parameter9.h1 / 2;
                        parameter9.h2 = parameter9.h2 / 2;
                        parameter9.THxx = parameter9.xF;
                        parameter9.THyy = parameter9.lowery;

                        Program9.SolveFx(parameter9);
                    }
                }
                parameter9.i++;
                Max++;
            }

            int a;
            bool isEntryEmpty001 = string.IsNullOrEmpty(UpFX1.Text);
            if (isEntryEmpty001)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX1.Text) - parameter9.UpFX[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFX1.Text) - parameter9.LowFX[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(UpFY1.Text) - parameter9.UpFY[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFY1.Text) - parameter9.LowFY[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Th1.Text) - parameter9.TFunct[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Bp1.Text) - parameter9.Function[0]) <= 0.05)
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
