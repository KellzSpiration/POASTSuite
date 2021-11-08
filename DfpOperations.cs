using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.DFPModule
{
    class DfpOperations
    {
        //Partial Diff wrt x1              //check
        static public double DifferentiateWrtoX1(double a, double b, double c, double d, double ee, double f, double x1, double x2)
        {
            var diff = 2 * a * Math.Pow(x1, 2 - 1) + (0 * b * Math.Pow(x2, 2 - 1)) + c * x2 * Math.Pow(x1, 1 - 1)
                + d * Math.Pow(x1, 1 - 1);
            return diff;

            // var difff = (2 * a * X1[0, 0]) + (c * X1[1, 0]) + d;
            // return diff;
        }

        //Partial Diff wrt x2               //check
        static public double DifferentiateWrtoX2(double a, double b, double c, double d, double ee, double f, double x1, double x2)
        {
            var diff = 2 * b * Math.Pow(x2, 2 - 1) + (c * x1 * Math.Pow(x2, 1 - 1)) + (2 * ee * Math.Pow(x2, 1 - 1));
            return diff;

            // var diff = (2 * b * X1[1, 0]) + (c * X1[0, 0]) + (2 * ee * X1[1, 0]);
            //return diff;
        }

        // Method to multiply two Matrix A and Matric B - SAMPLE 2
        public static double[,] MatrixMultiplication(double[,] A, double[,] B)
        {
            int n1 = A.GetLength(1);
            int n2 = B.GetLength(0);
            if (n1 != n2)
            {
                Console.WriteLine("The column count of the first array must equal the row count of the second array");
                return null;
            }

            double[,] C = new double[A.GetLength(0), B.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    for (int z = 0; z < n1; z++)
                    {
                        C[i, j] += A[i, z] * B[z, j];
                    }
                }
            }
            return C;
        }

        // Method to Multiply a Scalar with a Matrix
        public static double[,] ScalarMatrixMultiplication(double[,] matrix, double m)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i, j] * m;
                }
            }

            return matrix;
        }

        // Method to Transpose a Matrix
        public static double[,] TransposeMatrix(double[,] matrix)
        {
            double[,] sT = new double[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sT[j, i] = matrix[i, j];
                }
            }
            return sT;
        }

        static public double[,] AddMatrices(double[,] one, double[,] two)
        {
            var result = new double[2, 2];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = one[i, j] + two[i, j];
                }
            }
            return result;
        }

        static public double[,] MatriXNegativeOne(double[,] value)
        {
            double[,] m = new double[2, 1];
            m[0, 0] = value[0, 0] * -1;
            m[1, 0] = value[1, 0] * -1;
            return m;
        }


    }
}

