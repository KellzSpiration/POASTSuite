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
    public partial class ItereationThree : ContentPage
    {
        private double q;
        public ItereationThree(double score2)
        {
            InitializeComponent();
            q = score2;
        }

        

       async private void BtnNext_Clicked_1(object sender, EventArgs e)
        {
            var parameter2 = new Parameter2(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

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
            bool isEntryEmpty007 = string.IsNullOrEmpty(UpFX3.Text);
            if (isEntryEmpty007)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX3.Text) - parameter2.UpFX[2]) <= 0.05)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }


            int a1;
            bool isEntryEmpty008 = string.IsNullOrEmpty(LowFX3.Text);
            if (isEntryEmpty008)
            {
                a1 = 0;
            }
            else if (Math.Abs(double.Parse(LowFX3.Text) - parameter2.LowFX[2]) <= 0.05)
            {
                a1 = 1;
            }
            else
            {
                a1 = 0;
            }


            int a2;
            bool isEntryEmpty009 = string.IsNullOrEmpty(UpFY3.Text);
            if (isEntryEmpty009)
            {
                a2 = 0;
            }
            else if (Math.Abs(double.Parse(UpFY3.Text) - parameter2.UpFY[2]) <= 0.05)
            {
                a2 = 1;
            }
            else
            {
                a2 = 0;
            }

            int a3;
            bool isEntryEmpty010 = string.IsNullOrEmpty(LowFY3.Text);
            if (isEntryEmpty010)
            {
                a3 = 0;
            }
            else if (Math.Abs(double.Parse(LowFY3.Text) - parameter2.LowFY[2]) <= 0.05)
            {
                a3 = 1;
            }
            else
            {
                a3 = 0;
            }

            int b;
            bool isEntryEmpty011 = string.IsNullOrEmpty(Th3.Text);
            if (isEntryEmpty011)
            {
                b = 0;
            }
            else if (Math.Abs(double.Parse(Th3.Text) - parameter2.TFunct[2]) <= 0.05)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }

            int c;
            bool isEntryEmpty012 = string.IsNullOrEmpty(Bp3.Text);
            if (isEntryEmpty012)
            {
                c = 0;
            }
            else if (Math.Abs(double.Parse(Bp3.Text) - parameter2.Function[2]) <= 0.05)
            {
                c = 1;
            }
            else
            {
                c = 0;
            }

            double T = a + a1 + a2 + a3 + b + c + q;
            // double score3 = ((Math.Round((T / 6 * 100) * 2) / 2) + q) / 2;
            // double score3 = Math.Round((((Math.Round((T / 6 * 100) * 2) / 2) + q) / 2) * 2) / 2;

            double score3 = T;
            // Bp3.Text = score3.ToString();
            await Navigation.PushModalAsync(new IterationFour(score3));

        }
    }
    }
