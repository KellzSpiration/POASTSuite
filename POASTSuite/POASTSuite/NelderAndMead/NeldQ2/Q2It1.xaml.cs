using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POASTSuite.NelderAndMead.NeldQ2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Q2It1 : ContentPage
    {
        public Q2It1()
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
        private async void BtnNxt2_Clicked(object sender, EventArgs e)
        {

        }
    }
}