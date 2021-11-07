using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using POASTSuite.HookeAndJeevesModule.ProgramClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.HookeAndJeevesModule.QueestionFive
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IterationFive : ContentPage
    {
        private double s;
        public IterationFive(double score4)
        {
            InitializeComponent();
            s = score4;
        }

       async private void BtnNext_Clicked(object sender, EventArgs e)
        {
            {
                var parameter5 = new Parameter5(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

                parameter5.f = 6 * Math.Pow(parameter5.x, 2) - (5 * (parameter5.x * parameter5.y)) + 2 * Math.Pow(parameter5.y, 2) + (4 * parameter5.x) + (2 * parameter5.y);
                Console.WriteLine("f(0,0) = {0}", parameter5.f);
                int Max = 0;

                while (parameter5.h1 >= parameter5.h1F && parameter5.h2 >= parameter5.h2F && Max < 5)
                {

                    if (parameter5.bestPoint > parameter5.THf)
                    {
                        Program5.SolveFx(parameter5);
                    }
                    else
                    {
                        if (parameter5.upperFx == parameter5.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter5.upperx, parameter5.y);
                            parameter5.h1 = parameter5.h1 / 2;
                            parameter5.h2 = parameter5.h2 / 2;
                            parameter5.THxx = parameter5.upperx;
                            parameter5.THyy = parameter5.y;

                            Program5.SolveFx(parameter5);
                        }

                        else if (parameter5.lowerFx == parameter5.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter5.lowerx, parameter5.y);
                            parameter5.h1 = parameter5.h1 / 2;
                            parameter5.h2 = parameter5.h2 / 2;
                            parameter5.THxx = parameter5.lowerx;
                            parameter5.THyy = parameter5.y;
                            Program5.SolveFx(parameter5);

                        }

                        else if (parameter5.upperFy == parameter5.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter5.xF, parameter5.uppery);
                            parameter5.h1 = parameter5.h1 / 2;
                            parameter5.h2 = parameter5.h2 / 2;
                            parameter5.THxx = parameter5.xF;
                            parameter5.THyy = parameter5.uppery;

                            Program5.SolveFx(parameter5);
                        }

                        else if (parameter5.lowerFy == parameter5.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter5.xF, parameter5.lowery);
                            parameter5.h1 = parameter5.h1 / 2;
                            parameter5.h2 = parameter5.h2 / 2;
                            parameter5.THxx = parameter5.xF;
                            parameter5.THyy = parameter5.lowery;

                            Program5.SolveFx(parameter5);
                        }
                    }
                    parameter5.i++;
                    Max++;
                }

                int a;
                bool isEntryEmpty001 = string.IsNullOrEmpty(UpFX5.Text);
                if (isEntryEmpty001)
                {
                    a = 0;
                }
                else if (Math.Abs(double.Parse(UpFX5.Text) - parameter5.UpFX[4]) <= 0.05)
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }


                int a1;
                bool isEntryEmpty002 = string.IsNullOrEmpty(LowFX5.Text);
                if (isEntryEmpty002)
                {
                    a1 = 0;
                }
                else if (Math.Abs(double.Parse(LowFX5.Text) - parameter5.LowFX[4]) <= 0.05)
                {
                    a1 = 1;
                }
                else
                {
                    a1 = 0;
                }


                int a2;
                bool isEntryEmpty003 = string.IsNullOrEmpty(UpFY5.Text);
                if (isEntryEmpty003)
                {
                    a2 = 0;
                }
                else if (Math.Abs(double.Parse(UpFY5.Text) - parameter5.UpFY[4]) <= 0.05)
                {
                    a2 = 1;
                }
                else
                {
                    a2 = 0;
                }

                int a3;
                bool isEntryEmpty004 = string.IsNullOrEmpty(LowFY5.Text);
                if (isEntryEmpty004)
                {
                    a3 = 0;
                }
                else if (Math.Abs(double.Parse(LowFY5.Text) - parameter5.LowFY[4]) <= 0.05)
                {
                    a3 = 1;
                }
                else
                {
                    a3 = 0;
                }

                int b;
                bool isEntryEmpty005 = string.IsNullOrEmpty(Th5.Text);
                if (isEntryEmpty005)
                {
                    b = 0;
                }
                else if (Math.Abs(double.Parse(Th5.Text) - parameter5.TFunct[4]) <= 0.05)
                {
                    b = 1;
                }
                else
                {
                    b = 0;
                }

                int c;
                bool isEntryEmpty006 = string.IsNullOrEmpty(Bp5.Text);
                if (isEntryEmpty006)
                {
                    c = 0;
                }
                else if (Math.Abs(double.Parse(Bp5.Text) - parameter5.Function[4]) <= 0.05)
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }

                double T = a + a1 + a2 + a3 + b + c + s;
                //double score5 = ((Math.Round((T / 6 * 100) * 2) / 2)+s)/2;
                double score5 = Math.Round((T / 30 * 100) * 2) / 2;


                // Bp5.Text = score5.ToString();
                await Navigation.PushModalAsync(new GradePage(score5));

            }
        }
    }
}