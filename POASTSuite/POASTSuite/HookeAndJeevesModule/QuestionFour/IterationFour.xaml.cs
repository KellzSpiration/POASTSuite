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
    public partial class IterationFour : ContentPage
    {
        private double r;
        public IterationFour(double score3)
        {
            InitializeComponent();
            r = score3;
        }

       async private void BtnNext_Clicked(object sender, EventArgs e)
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
            bool isEntryEmpty007 = string.IsNullOrEmpty(UpFX4.Text);
            if (isEntryEmpty007)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX4.Text) - parameter4.UpFX[3]) <= 0.05)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }


            int a1;
            bool isEntryEmpty008 = string.IsNullOrEmpty(LowFX4.Text);
            if (isEntryEmpty008)
            {
                a1 = 0;
            }
            else if (Math.Abs(double.Parse(LowFX4.Text) - parameter4.LowFX[3]) <= 0.05)
            {
                a1 = 1;
            }
            else
            {
                a1 = 0;
            }


            int a2;
            bool isEntryEmpty009 = string.IsNullOrEmpty(UpFY4.Text);
            if (isEntryEmpty009)
            {
                a2 = 0;
            }
            else if (Math.Abs(double.Parse(UpFY4.Text) - parameter4.UpFY[3]) <= 0.05)
            {
                a2 = 1;
            }
            else
            {
                a2 = 0;
            }

            int a3;
            bool isEntryEmpty010 = string.IsNullOrEmpty(LowFY4.Text);
            if (isEntryEmpty010)
            {
                a3 = 0;
            }
            else if (Math.Abs(double.Parse(LowFY4.Text) - parameter4.LowFY[3]) <= 0.05)
            {
                a3 = 1;
            }
            else
            {
                a3 = 0;
            }

            int b;
            bool isEntryEmpty011 = string.IsNullOrEmpty(Th4.Text);
            if (isEntryEmpty011)
            {
                b = 0;
            }
            else if (Math.Abs(double.Parse(Th4.Text) - parameter4.TFunct[3]) <= 0.05)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }

            int c;
            bool isEntryEmpty012 = string.IsNullOrEmpty(Bp4.Text);
            if (isEntryEmpty012)
            {
                c = 0;
            }
            else if (Math.Abs(double.Parse(Bp4.Text) - parameter4.Function[3]) <= 0.05)
            {
                c = 1;
            }
            else
            {
                c = 0;
            }

            double T = a + a1 + a2 + a3 + b + c + r;
            //  double score4 =(( Math.Round((T / 6 * 100) * 2) / 2)+r)/2;
            // double score4 = Math.Round((((Math.Round((T / 6 * 100) * 2) / 2) + r) / 2) * 2) / 2;
            double score4 = T;

            // Bp4.Text = score4.ToString();
            await Navigation.PushModalAsync(new IterationFive(score4));


        }
        }
    }
