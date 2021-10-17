using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.Fletcher_Reeves
{
    public class Algorithm
    {
        public Algorithm(double x1, double x2, double a, double b, double c, double d, double e, double f)
        {

            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            g = new double[2, 1];
            s = new double[2, 1];
            gNext = new double[2, 1];
            x = new double[2, 1];
            x[0, 0] = x1;
            x[1, 0] = x2;
            isMinimum = false;
            buffer = 0;
            arrayG1 = new double[5];
            arrayG2 = new double[5];
            arrayS1 = new double[5];
            arrayS2 = new double[5];
            arrayLambda = new double[5];
            arrayX1 = new double[5];
            arrayX2 = new double[5];
            arrayFunction = new double[5];
        }

        const double tolerance = 0.005;

        double a;
        double b;
        double c;
        double d;
        double e;
        double f;
        public double[,] gNext;
        public double[,] sNext;
        public double _lambda;
        public double _lambda2;
        public double[] arrayG1;
        public double[] arrayG2;
        public double[] arrayS1;
        public double[] arrayS2;
        public double[] arrayLambda;
        public double[] arrayX1;
        public double[] arrayX2;
        public double[] arrayFunction;
        public double[,] x;

        public double[,] g;
        //i removed the property so that it doesn't keep calling gets anew and changing the value of S
        //since X keeps changing

        public double[,] s;
        //i removed the property so that it doesn't keep calling gets anew and changing the value of S
        //since X keeps changing

        public double buffer;

        double _function;

        public double Function
        {
            get { return _function; }
            set
            {
                _function = a * Math.Pow(x[0, 0], 2) + b * x[0, 0] + c * x[0, 0] * x[1, 0] + d * x[1, 0]
                                                                            + e * Math.Pow(x[1, 0], 2) + f;
            }
        }

        public bool isMinimum;
        //removed the IsMinimum property that was here

        public int i;
        public void StartAlgorithm()//a lot of changes here
        {
            i = 0;//changes here
            GetG();
            arrayG1[i] = g[0, 0];
            arrayG2[i] = g[1, 0];
            GetS();
            arrayS1[i] = s[0, 0];
            arrayS2[i] = s[1, 0];
            GetLambda();
            arrayLambda[i] = _lambda;
            GetNextPoint1();
            arrayX1[i] = x[0, 0];
            arrayX2[i] = x[1, 0];
            GetGNext();

            arrayFunction[i] = Function;

            GradientCheck();
            if (isMinimum != true)
            {

                while (isMinimum != true)
                {
                    i++;
                    arrayG1[i] = gNext[0, 0];
                    arrayG2[i] = gNext[1, 0];
                    GetSNext();
                    arrayS1[i] = sNext[0, 0];
                    arrayS2[i] = sNext[1, 0];
                    GetLambda2();
                    arrayLambda[i] = _lambda2;
                    GetNextPoint2();
                    arrayX1[i] = x[0, 0];
                    arrayX2[i] = x[1, 0];
                    g[0, 0] = gNext[0, 0];
                    g[1, 0] = gNext[1, 0];
                    s[0, 0] = sNext[0, 0];
                    s[1, 0] = sNext[1, 0];
                    arrayFunction[i] = Function;
                    GetGNext();
                    GradientCheck();
                }
            }

        }

        public string writeFunction()
        {
            return string.Concat($"{a}(x1)^2 + {b}x1 + {c}(x1)(x2) + {d}x2 + {e}(x2)^2 + {f}");
        }

        public double GetLambda()
        {
            _lambda = -(2 * a * s[0, 0] * x[0, 0] + b * s[0, 0] + c * (x[0, 0] * s[1, 0] + x[1, 0] * s[0, 0]) + d * s[1, 0] + 2 * e * s[1, 0] * x[1, 0])
                / (2 * a * Math.Pow(s[0, 0], 2) + 2 * c * s[0, 0] * s[1, 0] + 2 * e * Math.Pow(s[1, 0], 2));
            return _lambda;
            //for only quadratic equations of the form specified above
        }

        public double GetLambda2()
        {
            _lambda2 = -(2 * a * sNext[0, 0] * x[0, 0] + b * sNext[0, 0] + c * (x[0, 0] * sNext[1, 0] + x[1, 0] * sNext[0, 0]) + d * sNext[1, 0] + 2 * e * sNext[1, 0] * x[1, 0])
                / (2 * a * Math.Pow(sNext[0, 0], 2) + 2 * c * sNext[0, 0] * sNext[1, 0] + 2 * e * Math.Pow(sNext[1, 0], 2));
            return _lambda2;
            //for only quadratic equations of the form specified above
        }

        public double[,] GetG()
        {
            //the line of code that was instantiating a new object which was only available within this method,
            //causing my g field to return empty
            g[0, 0] = MathOperations.DifferentiateWrtX1(a, b, c, d, e, f, x[0, 0], x[1, 0]);
            g[1, 0] = MathOperations.DifferentiateWrtX2(a, b, c, d, e, f, x[0, 0], x[1, 0]); //was differentiating wrt X1 here
            return g;
        }

        public double[,] GetGNext()
        {

            gNext[0, 0] = MathOperations.DifferentiateWrtX1(a, b, c, d, e, f, x[0, 0], x[1, 0]);
            gNext[1, 0] = MathOperations.DifferentiateWrtX2(a, b, c, d, e, f, x[0, 0], x[1, 0]);
            return gNext;
        }

        public double[,] GetS()
        {
            s = MathOperations.MatriXNegativeOne(g);
            return s;
        }

        public double GetBuffer()
        {
            buffer = MathOperations.MultiplyMatrixByMatrix(MathOperations.TransposeMatrix(gNext), gNext)
                      / MathOperations.MultiplyMatrixByMatrix(MathOperations.TransposeMatrix(g), g);
            return buffer;
        }

        public double[,] GetSNext()
        {
            sNext = MathOperations.AddMatrices(MathOperations.MatriXNegativeOne(gNext), MathOperations.MultiplyMatrixByScalar(s, GetBuffer())); //the buffer here was returning zero  
            return sNext;                                                                                             //the value of s here is not what it should be
        }

        public double[,] GetNextPoint1()
        {
            var buffer = MathOperations.MultiplyMatrixByScalar(s, _lambda);
            x[0, 0] = x[0, 0] + buffer[0, 0];
            x[1, 0] = x[1, 0] + buffer[1, 0];
            return x;
        }
        public double[,] GetNextPoint2()
        {
            var buffer = MathOperations.MultiplyMatrixByScalar(sNext, _lambda2);
            x[0, 0] = x[0, 0] + buffer[0, 0];
            x[1, 0] = x[1, 0] + buffer[1, 0];
            return x;
        }

        public bool GradientCheck()
        {
            var abs = Math.Sqrt(Math.Pow(gNext[0, 0], 2) + Math.Pow(gNext[1, 0], 2));//i was using g instead of gNext at first
            if (abs <= tolerance) //i removed the condition function<=0 since its not the correct criteria
            {
                isMinimum = true;//check previous revision for correction made here.
            }
            return isMinimum;
        }
    }
}
