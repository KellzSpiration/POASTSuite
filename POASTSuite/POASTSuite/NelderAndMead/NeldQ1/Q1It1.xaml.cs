using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.NelderAndMead.NeldQ1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Q1It1 : ContentPage
    {
        public Q1It1()
        {
            InitializeComponent();
        }
        public static double Centroid(double Xoa, double Xob, double A, double B, double C, double D, double E, double F)
        {
            double fo = Math.Round((((A * (Math.Pow(Xoa, 2))) + (B * Xoa * Xob)) + (C * Math.Pow(Xob, 2)) + (D * (Xoa)) + (E * (Xob)) + F), 4);
            return fo;
        }
        public static double Reflection(double Xra, double Xrb, double A, double B, double C, double D, double E, double F)
        {
            double fr = Math.Round((((A * (Math.Pow(Xra, 2))) + (B * Xra * Xrb)) + (C * Math.Pow(Xrb, 2)) + (D * (Xra)) + (E * (Xrb)) + F), 4);
            return fr;
        }
        public static double Expansion(double Xea, double Xeb, double A, double B, double C, double D, double E, double F)
        {
            double fe = Math.Round((((A * (Math.Pow(Xea, 2))) + (B * Xea * Xeb)) + (C * Math.Pow(Xeb, 2)) + (D * (Xea)) + (E * (Xeb)) + F), 4);
            return fe;
        }
        public static double Contraction1(double Xc1a, double Xc1b, double A, double B, double C, double D, double E, double F)
        {
            double fc = Math.Round((((A * (Math.Pow(Xc1a, 2))) + (B * Xc1a * Xc1b)) + (C * Math.Pow(Xc1b, 2)) + (D * (Xc1a)) + (E * (Xc1b)) + F), 4);
            return fc;
        }
        public static double Contraction2(double Xc2a, double Xc2b, double A, double B, double C, double D, double E, double F)
        {
            double fc = Math.Round((((A * (Math.Pow(Xc2a, 2))) + (B * Xc2a * Xc2b)) + (C * Math.Pow(Xc2b, 2)) + (D * (Xc2a)) + (E * (Xc2b)) + F), 4);
            return fc;
        }
        private async void BtnNxt1_Clicked(object sender, EventArgs e)
        {
            double t = 1, n = 2, p, q, f1, f2, f3, A = 3, B = -2, C = 1, D = 4, E = 3, F = 0, Bpa, Bpb, Wpa, Wpb, Otpa, Otpb;
            double Xoa, Xob, Xra, Xrb, Xea, Xeb, Xc2a, Xc2b, Xc1a, Xc1b, ter;
            double fo = 0;

            // void Main(string[] args)
            {

                // Console.WriteLine("The initial Vertices are");

                p = Math.Round((t / (n * (Math.Sqrt(2)))) * ((Math.Sqrt(n + 1)) + (n - 1)), 4);
                q = Math.Round((t / (n * (Math.Sqrt(2)))) * ((Math.Sqrt(n + 1)) - 1), 4);


                //  Console.WriteLine("The value for p = {0}", p);
                //Console.WriteLine("The value for q = {0}", q);

                double[] X1 = new double[] { -1, -2 };


                double[] Xa = new double[] { p, q }; double[] Xb = new double[] { q, p };

                // Console.WriteLine("F1");
                f1 = Math.Round(((A * (Math.Pow(X1[0], 2)) + (B * (X1[0] * X1[1])) + (C * (Math.Pow(X1[1], 2))) + (D * (X1[0])) + (E * (X1[1])) + F)), 4);
                //Console.WriteLine(f1);

                double[] X2 = new double[] { (X1[0] + Xa[0]), (X1[1] + Xa[1]) };

                Console.WriteLine("F2");
                f2 = Math.Round((((A * (Math.Pow(X2[0], 2))) + (B * X2[0] * X2[1])) + (C * Math.Pow(X2[1], 2)) + (D * (X2[0])) + (E * (X2[1])) + F), 4);
                //  Console.WriteLine(f2);

                double[] X3 = new double[] { (X1[0] + Xb[0]), (X1[1] + Xb[1]) };


                //Console.WriteLine("F3");
                f3 = Math.Round((((A * (Math.Pow(X3[0], 2))) + (B * X3[0] * X3[1])) + (C * Math.Pow(X3[1], 2)) + (D * (X3[0])) + (E * (X3[1])) + F), 4);
                //Console.WriteLine(f3);

                double[] Wp = new double[6]; double[] Bp = new double[6]; double[] Otp = new double[6]; double[] ContExpSht = new double[6]; double[] Ref = new double[6];


                for (int counter = 1; counter < 6; counter++)
                {


                    Console.WriteLine("iteration{0}", counter);
                    //Array will start from here
                    double[] Array1 = { f1, f2, f3 };
                    Wp[counter] = Array1.Max(); Bp[counter] = Array1.Min();



                    if (f1 == Bp[counter] && f2 == Wp[counter])
                    {
                        Otp[counter] = f3;
                        Bpa = X1[0]; Bpb = X1[1];
                        Wpa = X2[0]; Wpb = X2[1];
                        Otpa = X3[0]; Otpb = X3[1];
                    }
                    else if (f1 == Bp[counter] && f3 == Wp[counter])
                    {
                        Otp[counter] = f2;
                        Bpa = X1[0]; Bpb = X1[1];
                        Wpa = X3[0]; Wpb = X3[1];
                        Otpa = X2[0]; Otpb = X2[1];
                    }
                    else if (f2 == Bp[counter] && f1 == Wp[counter])
                    {
                        Otp[counter] = f3;
                        Bpa = X2[0]; Bpb = X2[1];
                        Wpa = X1[0]; Wpb = X1[1];
                        Otpa = X3[0]; Otpb = X3[1];
                    }
                    else if (f2 == Bp[counter] && f3 == Wp[counter])
                    {
                        Otp[counter] = f1;
                        Bpa = X2[0]; Bpb = X2[1];
                        Wpa = X3[0]; Wpb = X3[1];
                        Otpa = X1[0]; Otpb = X1[1];
                    }
                    else if (f3 == Bp[counter] && f1 == Wp[counter])
                    {
                        Otp[counter] = f2;
                        Bpa = X3[0]; Bpb = X3[1];
                        Wpa = X1[0]; Wpb = X1[1];
                        Otpa = X2[0]; Otpb = X2[1];
                    }
                    else
                    {
                        Otp[counter] = f1;
                        Bpa = X3[0]; Bpb = X3[1];
                        Wpa = X2[0]; Wpb = X2[1];
                        Otpa = X1[0]; Otpb = X1[1];
                    }


                    double[] Xo = new double[] { (0.5 * (Bpa + Otpa)), (0.5 * (Bpb + Otpb)) }; Xoa = Xo[0]; Xob = Xo[1];

                    double[] Xr = new double[] { ((2 * (Xo[0])) - Wpa), ((2 * (Xo[1])) - Wpb) }; Xra = Xr[0]; Xrb = Xr[1];

                    double[] Xe = new double[] { ((2 * (Xra)) - Xoa), ((2 * (Xrb)) - Xob) }; Xea = Xe[0]; Xeb = Xe[1];

                    double[] Xc1 = new double[] { (0.5 * (Xoa + Xra)), (0.5 * (Xob + Xrb)) }; Xc1a = Xc1[0]; Xc1b = Xc1[1];

                    double[] Xc2 = new double[] { (0.5 * (Xoa + Wpa)), (0.5 * (Xob + Wpb)) }; Xc2a = Xc2[0]; Xc2b = Xc2[1];

                    // double ter = (Wp - Bp) / (Wp + Bp + e);
                    // Console.WriteLine(ter);
                    fo = Math.Round((((A * (Math.Pow(Xoa, 2))) + (B * Xoa * Xob)) + (C * Math.Pow(Xob, 2)) + (D * (Xoa)) + (E * (Xob)) + F), 4);
                    Ref[counter] = Math.Round((((A * (Math.Pow(Xra, 2))) + (B * Xra * Xrb)) + (C * Math.Pow(Xrb, 2)) + (D * (Xra)) + (E * (Xrb)) + F), 4);
                    //  Console.WriteLine("fr {0}", fr);
                    //Console.WriteLine("fo {0}", fo);

                    //Reduction
                    double[] Xs1 = new double[] { (0.5 * (Wpa + Bpa)), (0.5 * (Wpb + Bpb)) };
                    double[] Xs2 = new double[] { (0.5 * (Otpa + Bpa)), (0.5 * (Otpb + Bpb)) };



                    if (Ref[counter] < Bp[counter])
                    {
                        ContExpSht[counter] = Expansion(Xea, Xeb, A, B, C, D, E, F);
                        // Console.WriteLine("Expansion is {0}", ContExpSht[counter]);

                        if (ContExpSht[counter] < Bp[counter])
                        {
                            X1[0] = Xea; X1[1] = Xeb;
                            f1 = Math.Round(((A * (Math.Pow(X1[0], 2)) + (B * (X1[0] * X1[1])) + (C * (Math.Pow(X1[1], 2))) + (D * (X1[0])) + (E * (X1[1])) + F)), 4);
                            // Console.WriteLine("F1= {0}", f1);

                            f2 = Bp[counter]; X2[0] = Bpa; X2[1] = Bpb;
                            f2 = Math.Round((((A * (Math.Pow(X2[0], 2))) + (B * X2[0] * X2[1])) + (C * Math.Pow(X2[1], 2)) + (D * (X2[0])) + (E * (X2[1])) + F), 4);
                            // Console.WriteLine("F2= {0}", f2);

                            f3 = Otp[counter]; X3[0] = Otpa; X3[1] = Otpb;
                            f3 = Math.Round((((A * (Math.Pow(X3[0], 2))) + (B * X3[0] * X3[1])) + (C * Math.Pow(X3[1], 2)) + (D * (X3[0])) + (E * (X3[1])) + F), 4);
                            // Console.WriteLine("F3= {0}", f3);
                        }
                        else
                        {
                            X1[0] = Xra; X1[1] = Xrb;
                            f1 = Math.Round(((A * (Math.Pow(X1[0], 2)) + (B * (X1[0] * X1[1])) + (C * (Math.Pow(X1[1], 2))) + (D * (X1[0])) + (E * (X1[1])) + F)), 4);
                            // Console.WriteLine("F1= {0}", f1);

                            f2 = Otp[counter]; X2[0] = Otpa; X2[1] = Otpb;
                            f2 = Math.Round((((A * (Math.Pow(X2[0], 2))) + (B * X2[0] * X2[1])) + (C * Math.Pow(X2[1], 2)) + (D * (X2[0])) + (E * (X2[1])) + F), 4);
                            // Console.WriteLine("F2= {0}", f2);

                            f3 = Bp[counter]; X3[0] = Bpa; X3[1] = Bpb;
                            f3 = Math.Round((((A * (Math.Pow(X3[0], 2))) + (B * X3[0] * X3[1])) + (C * Math.Pow(X3[1], 2)) + (D * (X3[0])) + (E * (X3[1])) + F), 4);
                            // Console.WriteLine("F3= {0}", f3);
                        }
                    }
                    else if (Ref[counter] > Bp[counter] && Ref[counter] > Otp[counter] && Ref[counter] < Wp[counter])
                    {
                        ContExpSht[counter] = Contraction1(Xc1a, Xc1b, A, B, C, D, E, F);
                        // Console.WriteLine("Contraction is {0}", ContExpSht[counter]);


                        if (ContExpSht[counter] < Wp[counter])
                        {
                            f1 = ContExpSht[counter]; X1[0] = Xc1a; X1[1] = Xc1b;
                            //f1 = Math.Round(((A * (Math.Pow(X1[0], 2)) + (B * (X1[0] * X1[1])) + (C * (Math.Pow(X1[1], 2))) + (D * (X1[0])) + (E * (X1[1])) + F)), 4);
                            //  Console.WriteLine("F1= {0}", f1);

                            f2 = Bp[counter]; X2[0] = Bpa; X2[1] = Bpb;
                            f2 = Math.Round((((A * (Math.Pow(X2[0], 2))) + (B * X2[0] * X2[1])) + (C * Math.Pow(X2[1], 2)) + (D * (X2[0])) + (E * (X2[1])) + F), 4);
                            //  Console.WriteLine("F2= {0}", f2);

                            f3 = Otp[counter]; X3[0] = Otpa; X3[1] = Otpb;
                            f3 = Math.Round((((A * (Math.Pow(X3[0], 2))) + (B * X3[0] * X3[1])) + (C * Math.Pow(X3[1], 2)) + (D * (X3[0])) + (E * (X3[1])) + F), 4);
                            //  Console.WriteLine("F3= {0}", f3);
                        }
                    }
                    else if (Ref[counter] >= Wp[counter])
                    {
                        ContExpSht[counter] = Contraction2(Xc2a, Xc2b, A, B, C, D, E, F);
                        //  Console.WriteLine("Contraction is {0}", ContExpSht[counter]);


                        if (ContExpSht[counter] < Wp[counter])
                        {
                            X1[0] = Xc2a; X1[1] = Xc2b; f1 = ContExpSht[counter];
                            //f1 = Math.Round(((A * (Math.Pow(X1[0], 2)) + (B * (X1[0] * X1[1])) + (C * (Math.Pow(X1[1], 2))) + (D * (X1[0])) + (E * (X1[1])) + F)), 4);
                            //  Console.WriteLine("F1= {0}", f1);

                            f2 = Bp[counter]; X2[0] = Bpa; X2[1] = Bpb;
                            f2 = Math.Round((((A * (Math.Pow(X2[0], 2))) + (B * X2[0] * X2[1])) + (C * Math.Pow(X2[1], 2)) + (D * (X2[0])) + (E * (X2[1])) + F), 4);
                            // Console.WriteLine("F2= {0}", f2);

                            f3 = Otp[counter]; X3[0] = Otpa; X3[1] = Otpb;
                            f3 = Math.Round((((A * (Math.Pow(X3[0], 2))) + (B * X3[0] * X3[1])) + (C * Math.Pow(X3[1], 2)) + (D * (X3[0])) + (E * (X3[1])) + F), 4);
                            // Console.WriteLine("F3= {0}", f3);
                        }
                    }
                    else
                    {
                        X1[0] = Bpa; X1[1] = Bpb;
                        f1 = Math.Round(((A * (Math.Pow(X1[0], 2)) + (B * (X1[0] * X1[1])) + (C * (Math.Pow(X1[1], 2))) + (D * (X1[0])) + (E * (X1[1])) + F)), 4);
                        //   Console.WriteLine("F1= {0}", f1);

                        X2[0] = Xs1[0]; X2[1] = Xs1[1]; X3[0] = Xs2[0]; X3[1] = Xs2[1];

                        f2 = Math.Round((((A * (Math.Pow(X2[0], 2))) + (B * X2[0] * X2[1])) + (C * Math.Pow(X2[1], 2)) + (D * (X2[0])) + (E * (X2[1])) + F), 4);
                        //  Console.WriteLine("F2= {0}", f2);

                        f3 = Math.Round((((A * (Math.Pow(X3[0], 2))) + (B * X3[0] * X3[1])) + (C * Math.Pow(X3[1], 2)) + (D * (X3[0])) + (E * (X3[1])) + F), 4);
                        // Console.WriteLine("F3= {0}", f3);

                    }
                    //Console.WriteLine(ContExpSht[3]);

                    continue;
                }

                ter = Math.Round((Math.Pow(((Math.Pow((f1 - fo), 2)) / (n + 1)) + ((Math.Pow((f2 - fo), 2)) / (n + 1)) + ((Math.Pow((f3 - fo), 2)) / (n + 1)), 0.5)), 4);
                //  Console.WriteLine("Termination ={0}", ter);


                int d;
                bool isEntryEmpty4 = string.IsNullOrEmpty(worst.Text);

                if (isEntryEmpty4)
                {
                    d = 0;
                }
                else if (Math.Abs(double.Parse(worst.Text) - Wp[1]) <= 0.06)
                {
                    d = 1;
                }
                else
                {
                    d = 0;
                }

                int a;
                bool isEntryEmpty1 = string.IsNullOrEmpty(best.Text);

                if (isEntryEmpty1)
                {
                    a = 0;
                }
                else if (Math.Abs(double.Parse(best.Text) - Bp[1]) <= 0.06)
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }

                int b;
                bool isEntryEmpty2 = string.IsNullOrEmpty(other.Text);

                if (isEntryEmpty2)
                {
                    b = 0;
                }
                else if (Math.Abs(double.Parse(other.Text) - Otp[1]) <= 0.06)
                {
                    b = 1;
                }
                else
                {
                    b = 0;
                }

                int c;
                bool isEntryEmpty3 = string.IsNullOrEmpty(cont.Text);

                if (isEntryEmpty3)
                {
                    c = 0;
                }
                else if (Math.Abs(double.Parse(cont.Text) - ContExpSht[1]) <= 0.06)
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }


                int f;
                bool isEntryEmpty5 = string.IsNullOrEmpty(Reflect.Text);

                if (isEntryEmpty5)
                {
                    f = 0;
                }
                else if (Math.Abs(double.Parse(Reflect.Text) - Ref[1]) <= 0.06)
                {
                    f = 1;
                }
                else
                {
                    f = 0;
                }



                double T = (a + b + c + d + f) / 1;
                //worst.Text = ((a + b + c) / 1).ToString();
                await Navigation.PushModalAsync(new Q1It2(T));
            }
        }
    }
}