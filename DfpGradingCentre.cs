using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.DFPModule
{
    class DfpGradingCentre
    {
        public DfpGradingCentre(double value1, double value2, double a, double b, double c, double d, double ee, double f)
        {
            solution = new DfpAlgorithm(value1, value2, a, b, c, d, ee, f);
        }
        public DfpAlgorithm solution;

        public void GetEntryValues()
        {
            solution.BeginDfpAlgorithm();
            arrayG1 = solution.arrayG1;
            arrayG2 = solution.arrayG2;
            arrayS1 = solution.arrayS1;
            arrayS2 = solution.arrayS2;
            arrayLambda = solution.arrayLambda;
            arrayX1 = solution.arrayX1;
            arrayX2 = solution.arrayX2;
            a = 2;
            // making the number of iterations a constant since flrtcher-reeves will always have two iterations 
            GetGradePerEntry();
        }

        private double GetGradePerEntry()  //remodify
        {
            mark = Math.Round(100 / (7 * a), 4);//i used a to be able to get the exact no of iterations since arrays start counting from
                                                //zero trying to kill two birds with one stone.
            return mark;

        }

        public const double gradingTolerance = 0.1;
        public double a; public double sCore = 0;
        public double[] arrayG1;
        public double[] arrayG2;
        public double[] arrayS1;
        public double[] arrayS2;
        public double[] arrayLambda;
        public double[] arrayX1;
        public double[] arrayX2;
        double mark;

        public double Compare_Scores(int n, double Userg1x1, double Userg1x2, double Users1x1, double Users1x2, double UserL1, double UserX2x1, double UserX2x2)
        {
            if (Math.Abs(arrayG1[n] - Userg1x1) <= Math.Abs(gradingTolerance))
            {
                sCore = mark;
            }
            else
            {
                sCore = 0;
            }
            if (Math.Abs(arrayG2[n] - Userg1x2) <= Math.Abs(gradingTolerance))
            {
                sCore = sCore + mark;
            }
            else
            {
                sCore = sCore + 0;
            }
            if (Math.Abs(arrayS1[n] - Users1x1) <= Math.Abs(gradingTolerance))
            {
                sCore = sCore + mark;
            }
            else
            {
                sCore = sCore + 0;
            }
            if (Math.Abs(arrayS2[n] - Users1x2) <= Math.Abs(gradingTolerance))
            {
                sCore = sCore + mark;
            }
            else
            {
                sCore = sCore + 0;
            }
            if (Math.Abs(arrayLambda[n] - UserL1) <= Math.Abs(gradingTolerance))
            {
                sCore = sCore + mark;
            }
            else
            {
                sCore = sCore + 0;
            }
            if (Math.Abs(arrayX1[n] - UserX2x1) <= Math.Abs(gradingTolerance))
            {
                sCore = sCore + mark;
            }
            else
            {
                sCore = sCore + 0;
            }
            if (Math.Abs(arrayX2[n] - UserX2x2) <= Math.Abs(gradingTolerance))
            {
                sCore = sCore + mark;
            }
            else
            {
                sCore = sCore + 0;
            }

            return sCore;

        }

    }
}

