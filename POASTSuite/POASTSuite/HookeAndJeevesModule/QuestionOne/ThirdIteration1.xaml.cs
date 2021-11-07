using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using POASTSuite.HookeAndJeevesModule.ProgramClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.HookeAndJeevesModule.QuestionOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdIteration1 : ContentPage
    {
        private double q;
        public ThirdIteration1(double score2)
        {
            InitializeComponent();
            q = score2;
        }

       async private void BtnNext_Clicked(object sender, EventArgs e)
        {
            var parameter1 = new Parameter1 (0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

            parameter1.f = 3 * Math.Pow(parameter1.x, 2) - (2 * (parameter1.x * parameter1.y)) + Math.Pow(parameter1.y, 2) + (4 * parameter1.x) + (3 * parameter1.y);
            // Console.WriteLine("f(0,0) = {0}", parameter.f);
            while (parameter1.h1 >= parameter1.h1F && parameter1.h2 >= parameter1.h2F)
            {

                if (parameter1.bestPoint > parameter1.THf)
                {
                    Program1.SolveFx(parameter1);
                }

                else
                {
                    if (parameter1.upperFx == parameter1.bestPoint)
                    {
                        // Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter1.upperx, parameter1.y);
                        parameter1.h1 = parameter1.h1 / 2;
                        parameter1.h2 = parameter1.h2 / 2;
                        parameter1.THx = parameter1.upperx;
                        parameter1.THy = parameter1.y;

                        Program1.SolveFx(parameter1);
                    }

                    else if (parameter1.lowerFx == parameter1.bestPoint)
                    {
                        //  Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter1.lowerx, parameter1.y);
                        parameter1.h1 = parameter1.h1 / 2;
                        parameter1.h2 = parameter1.h2 / 2;
                        parameter1.THx = parameter1.lowerx;
                        parameter1.THy = parameter1.y;
                        Program1.SolveFx(parameter1);

                    }

                    else if (parameter1.upperFy == parameter1.bestPoint)
                    {
                        // Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter1.xF, parameter1.uppery);
                        parameter1.h1 = parameter1.h1 / 2;
                        parameter1.h2 = parameter1.h2 / 2;
                        parameter1.THx = parameter1.xF;
                        parameter1.THy = parameter1.uppery;

                        Program1.SolveFx(parameter1);
                    }

                    else if (parameter1.lowerFy == parameter1.bestPoint)
                    {
                        // Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter1.xF, parameter1.lowery);
                        parameter1.h1 = parameter1.h1 / 2;
                        parameter1.h2 = parameter1.h2 / 2;
                        parameter1.THx = parameter1.xF;
                        parameter1.THy = parameter1.lowery;

                        Program1.SolveFx(parameter1);
                    }
                }
                parameter1.i++;
            }

            int a;
            bool isEntryEmpty007 = string.IsNullOrEmpty(UpFX3.Text);
            if (isEntryEmpty007)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX3.Text) - parameter1.UpFX[2]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFX3.Text) - parameter1.LowFX[2]) <= 0.05)
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
            else if (Math.Abs(double.Parse(UpFY3.Text) - parameter1.UpFY[2]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFY3.Text) - parameter1.LowFY[2]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Th3.Text) - parameter1.TFunct[2]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Bp3.Text) - parameter1.Function[2]) <= 0.05)
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
            await Navigation.PushModalAsync(new FourthIteration1(score3));



        }
    }
    }
