using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.Fletcher_Reeves
{
    static public class MathOperations
    {
        static public double DifferentiateWrtX1(double a, double b, double c, double d, double e, double f, double x1, double x2)
        {
            var diff = 2 * a * Math.Pow(x1, 2 - 1) + b * Math.Pow(x1, 1 - 1) + c * x2 * Math.Pow(x1, 1 - 1)
                + 0 * d * x2 * Math.Pow(x1, 0 - 1) + 0 * e * Math.Pow(x2, 2) * Math.Pow(x1, 0 - 1) + 0 * f * Math.Pow(x1, 0 - 1);
            return diff;
        }

        static public double DifferentiateWrtX2(double a, double b, double c, double d, double e, double f, double x1, double x2)
        {
            return 0 * a * Math.Pow(x1, 2) * Math.Pow(x2, 0 - 1) + 0 * b * x1 * Math.Pow(x2, 0 - 1) + c * x1 * Math.Pow(x2, 1 - 1)
                + d * Math.Pow(x2, 1 - 1) + 2 * e * Math.Pow(x2, 2 - 1) + 0 * f * Math.Pow(x2, 0 - 1);
        }
        //these differentiation methods are strictly for quadratic equations in the form AX1^2+BX1+CX1X2+DX2+EX2^2+F

        static public double[,] MatriXNegativeOne(double[,] value)
        {
            double[,] m = new double[2, 1];
            m[0, 0] = value[0, 0] * -1;
            m[1, 0] = value[1, 0] * -1;
            return m;
        }
        //strictly for 2 X 1 matrices

        static public double[,] AddMatrices(double[,] one, double[,] two)
        {
            var result = new double[2, 1];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = one[i, j] + two[i, j];
                }
            }
            return result;
        }

        static public double[,] TransposeMatrix(double[,] m)
        {
            var _new = new double[1, 2];
            _new[0, 0] = m[0, 0];
            _new[0, 1] = m[1, 0];
            return _new;
        }
        //the transpose method is only for 2 X 2 matrices i recommend making it for a larger audience

        static public double[,] MultiplyMatrixByScalar(double[,] m, double scalar)
        {
            var buffer = new double[2, 1];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    buffer[i, j] = m[i, j] * scalar;  //here the major error was that m[i,j] was being multiplied by the 
                                                      //scalar and still assigned back to itself which was causing the value of s to change. 
                }
            }
            return buffer;
        }

        static public double MultiplyMatrixByMatrix(double[,] one, double[,] two)
        {
            var value = 0.0;
            if (one.GetLength(1) == two.GetLength(0))
            {
                for (int i = 0; i < one.GetLength(0); i++)
                {
                    for (int j = 0; j < one.GetLength(1); j++)
                    {
                        value += one[i, j] * two[j, i];
                    }
                }
            }
            return value;
        }
    }
}
