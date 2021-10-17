using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.Fletcher_Reeves
{
    public class FletcherReeves
    {
        public FletcherReeves(float value1, float value2, double a, double b, double c, double d, double e, double f)
        {
            soln = new Algorithm(value1, value2, a, b, c, d, e, f);

        }
        public Algorithm soln;
        public void GetEntryValues()
        {
            soln.StartAlgorithm();
            arrayG1 = soln.arrayG1;
            arrayG2 = soln.arrayG2;
            arrayS1 = soln.arrayS1;
            arrayS2 = soln.arrayS2;
            arrayLambda = soln.arrayLambda;
            arrayX1 = soln.arrayX1;
            arrayX2 = soln.arrayX2;
            a = 2;
            // making the number of iterations a constant since flrtcher-reeves will always have two iterations 
            GetGradePerEntry();
        }

        private double GetGradePerEntry()
        {
            mark = Math.Round(100 / (7 * a), 3);//i used a to be able to get the exact no of iterations since arrays start counting from
                                                //zero trying to kill two birds with one stone.
            return mark;
        }

        public const double gradingTolerance = 0.05;
        public double a; public double sCore = 0;
        public double[] arrayG1;
        public double[] arrayG2;
        public double[] arrayS1;
        public double[] arrayS2;
        public double[] arrayLambda;
        public double[] arrayX1;
        public double[] arrayX2;
        double mark;

        public double CompareScores(int n, double gOne, double gTwo, double sOne, double sTwo, double lambda, double x1Value, double x2Value)
        {
            if (Math.Abs(arrayG1[n] - gOne) <= Math.Abs(gradingTolerance))
            {
                sCore = mark;
            }
            else
            {
                sCore = 0;
            }
            if (Math.Abs(arrayG2[n] - gTwo) <= Math.Abs(gradingTolerance))
            {
                sCore = sCore + mark;
            }
            else
            {
                sCore = sCore + 0;
            }
            if (Math.Abs(arrayS1[n] - sOne) <= Math.Abs(gradingTolerance))
            {
                sCore = sCore + mark;
            }
            else
            {
                sCore = sCore + 0;
            }
            if (Math.Abs(arrayS2[n] - sTwo) <= Math.Abs(gradingTolerance))
            {
                sCore = sCore + mark;
            }
            else
            {
                sCore = sCore + 0;
            }
            if (Math.Abs(arrayLambda[n] - lambda) <= Math.Abs(gradingTolerance))
            {
                sCore = sCore + mark;
            }
            else
            {
                sCore = sCore + 0;
            }
            if (Math.Abs(arrayX1[n] - x1Value) <= Math.Abs(gradingTolerance))
            {
                sCore = sCore + mark;
            }
            else
            {
                sCore = sCore + 0;
            }
            if (Math.Abs(arrayX2[n] - x2Value) <= Math.Abs(gradingTolerance))
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
