using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using POASTSuite.HookeAndJeevesModule.ProgramClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.HookeAndJeevesModule.QuestionEight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IterationOneQ8 : ContentPage
    {
        public IterationOneQ8()
        {
            InitializeComponent();
        }

      async  private void BtnNext_Clicked(object sender, EventArgs e)
        {
            var parameter8 = new Parameter8(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

            parameter8.f = 6 * Math.Pow(parameter8.x, 2) - (9 * (parameter8.x * parameter8.y)) + 4 * Math.Pow(parameter8.y, 2) + (2 * parameter8.x) + (2 * parameter8.y);
            Console.WriteLine("f(0,0) = {0}", parameter8.f);
            int Max = 0;

            while (parameter8.h1 >= parameter8.h1F && parameter8.h2 >= parameter8.h2F && Max < 5)
            {

                if (parameter8.bestPoint > parameter8.THf)
                {
                    Program8.SolveFx(parameter8);
                }
                else
                {
                    if (parameter8.upperFx == parameter8.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter8.upperx, parameter8.y);
                        parameter8.h1 = parameter8.h1 / 2;
                        parameter8.h2 = parameter8.h2 / 2;
                        parameter8.THxx = parameter8.upperx;
                        parameter8.THyy = parameter8.y;

                        Program8.SolveFx(parameter8);
                    }

                    else if (parameter8.lowerFx == parameter8.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter8.lowerx, parameter8.y);
                        parameter8.h1 = parameter8.h1 / 2;
                        parameter8.h2 = parameter8.h2 / 2;
                        parameter8.THxx = parameter8.lowerx;
                        parameter8.THyy = parameter8.y;
                        Program8.SolveFx(parameter8);

                    }

                    else if (parameter8.upperFy == parameter8.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter8.xF, parameter8.uppery);
                        parameter8.h1 = parameter8.h1 / 2;
                        parameter8.h2 = parameter8.h2 / 2;
                        parameter8.THxx = parameter8.xF;
                        parameter8.THyy = parameter8.uppery;

                        Program8.SolveFx(parameter8);
                    }

                    else if (parameter8.lowerFy == parameter8.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter8.xF, parameter8.lowery);
                        parameter8.h1 = parameter8.h1 / 2;
                        parameter8.h2 = parameter8.h2 / 2;
                        parameter8.THxx = parameter8.xF;
                        parameter8.THyy = parameter8.lowery;

                        Program8.SolveFx(parameter8);
                    }
                }
                parameter8.i++;
                Max++;
            }


            int a;
            bool isEntryEmpty001 = string.IsNullOrEmpty(UpFX1.Text);
            if (isEntryEmpty001)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX1.Text) - parameter8.UpFX[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFX1.Text) - parameter8.LowFX[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(UpFY1.Text) - parameter8.UpFY[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFY1.Text) - parameter8.LowFY[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Th1.Text) - parameter8.TFunct[0]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Bp1.Text) - parameter8.Function[0]) <= 0.05)
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
