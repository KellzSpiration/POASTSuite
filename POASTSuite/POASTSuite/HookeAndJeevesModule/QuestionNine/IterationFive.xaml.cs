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
            bool isEntryEmpty001 = string.IsNullOrEmpty(UpFX5.Text);
            if (isEntryEmpty001)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX5.Text) - parameter9.UpFX[4]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFX5.Text) - parameter9.LowFX[4]) <= 0.05)
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
            else if (Math.Abs(double.Parse(UpFY5.Text) - parameter9.UpFY[4]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFY5.Text) - parameter9.LowFY[4]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Th5.Text) - parameter9.TFunct[4]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Bp5.Text) - parameter9.Function[4]) <= 0.05)
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

