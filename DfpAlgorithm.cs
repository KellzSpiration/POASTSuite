using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.DFPModule
{
    class DfpAlgorithm
    {
        public DfpAlgorithm(double x1, double x2, double a, double b, double c, double d, double ee, double f)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.ee = ee;
            this.f = f;
            g = new double[2, 1];
            H1 = new double[,]
            {
                {1,0},
                {0,1}
            };
            q = new double[2, 1];
            S1 = new double[2, 1];
            g2 = new double[2, 1];
            g3 = new double[2, 1];
            X1 = new double[2, 1];
            X1[0, 0] = x1;
            X1[1, 0] = x2;
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

            //New Member Fields
            arrayQ1 = new double[5];
            arrayQ2 = new double[5];

            arrayA1 = new double[5];
            arrayA2 = new double[5];
            arrayA3 = new double[5];
            arrayA4 = new double[5];

            arrayB1 = new double[5];
            arrayB2 = new double[5];
            arrayB3 = new double[5];
            arrayB4 = new double[5];

            arrayH1 = new double[5];
            arrayH2 = new double[5];
            arrayH3 = new double[5];
            arrayH4 = new double[5];

        }

        const double tolerance = 0.001;

        double a;
        double b;
        double c;
        double d;
        double ee;
        double f;
        public double[,] g2;
        public double[,] g3;
        public double[,] S2;
        public double _L1;
        public double _L2;
        public double[] arrayG1;
        public double[] arrayG2;
        public double[] arrayS1;
        public double[] arrayS2;
        public double[] arrayLambda;
        public double[] arrayX1;
        public double[] arrayX2;
        public double[] arrayFunction;
        public double[,] X1;

        public double[] arrayQ1;
        public double[] arrayQ2;

        public double[] arrayA1;
        public double[] arrayA2;
        public double[] arrayA3;
        public double[] arrayA4;

        public double[] arrayB1;
        public double[] arrayB2;
        public double[] arrayB3;
        public double[] arrayB4;

        public double[] arrayH1;
        public double[] arrayH2;
        public double[] arrayH3;
        public double[] arrayH4;


        public double[,] H1;
        public double[,] q;


        public double[,] g;


        public double[,] S1;


        public double buffer;

        double _function;


        public double Function
        {
            get { return _function; }
            set
            {
                //MODEL (fx Equation)
                _function = (a * Math.Pow(X1[0, 0], 2)) + (b * Math.Pow(X1[1, 0], 2)) + (c * X1[0, 0] * X1[1, 0]) + (d * X1[0, 0]) + (ee * Math.Pow(X1[1, 0], 2)) + f;

            }
        }

        public bool isMinimum;


        //removed the IsMinimum property that was here

        public int i;
        public void BeginDfpAlgorithm()//a lot of changes here
        {
            i = 0;//changes here
            GetG();
            arrayG1[i] = g[0, 0];
            arrayG2[i] = g[1, 0];
            GetS();
            arrayS1[i] = S1[0, 0];
            arrayS2[i] = S1[1, 0];
            GetLambda();
            arrayLambda[i] = _L1;
            GetNextPoint2();
            arrayX1[i] = X1[0, 0];
            arrayX2[i] = X1[1, 0];
            GetG_2();

            arrayFunction[i] = Function;

            GradientCheck();
            if (isMinimum != true)
            {

                while (isMinimum != true)
                {
                    i++;
                    arrayG1[i] = g2[0, 0];
                    arrayG2[i] = g2[1, 0];

                    GetqDiff();
                    arrayQ1[i] = q[0, 0];
                    arrayQ2[i] = q[1, 0];

                    GetA();
                    arrayA1[i] = A1[0, 0];
                    arrayA2[i] = A1[0, 1];
                    arrayA3[i] = A1[1, 0];
                    arrayA4[i] = A1[1, 1];

                    GetB();
                    arrayB1[i] = B1[0, 0];
                    arrayB2[i] = B1[0, 1];
                    arrayB3[i] = B1[1, 0];
                    arrayB4[i] = B1[1, 1];

                    GetH2();
                    arrayH1[i] = H2[0, 0];
                    arrayH2[i] = H2[0, 1];
                    arrayH3[i] = H2[1, 0];
                    arrayH4[i] = H2[1, 1];

                    GetS2();
                    arrayS1[i] = S2[0, 0];
                    arrayS2[i] = S2[1, 0];
                    GetLambda2();
                    arrayLambda[i] = _L2;
                    GetNextPoint3();
                    arrayX1[i] = X1[0, 0];
                    arrayX2[i] = X1[1, 0];

                    //g[0, 0] = g2[0, 0];
                    //g[1, 0] = g2[1, 0];
                    //S1[0, 0] = S2[0, 0];           //CHECK
                    //S1[1, 0] = S2[1, 0];           //CHECK 
                    arrayFunction[i] = Function;
                    GetG_2();
                    GradientCheck();
                }
            }






        }
        public string writeFunction()   //RE STRUCTURE //Remove ee and f 
        {
            return string.Concat($" {a}(x1)^2 + {b}(x2)^2 + {c}(x1)(x2) + {d}(x1) ");
            //return string.Concat($"{a}X1^2 + {b}X2^2 + {c}X1X2 + {d}X1 + {ee}X2^2 + {f}");

        }


        public double GetLambda()
        {
            _L1 = -(2 * (a * X1[0, 0] * S1[0, 0]) + 2 * (b * X1[1, 0] * S1[1, 0]) + c * X1[0, 0] * S1[1, 0] + c * X1[1, 0] * S1[0, 0] + d * S1[0, 0]) / (2 * (a * S1[0, 0] * S1[0, 0]) + (2 * (b * S1[1, 0] * S1[1, 0]) + (2 * (c * S1[0, 0] * S1[1, 0]))));
            _L1 = Math.Round(Convert.ToDouble(_L1), 4);
            return _L1;

        }



        public double GetLambda2()
        {
            _L2 = -(2 * (a * X1[0, 0] * S2[0, 0]) + 2 * (b * X1[1, 0] * S2[1, 0]) + c * X1[0, 0] * S2[1, 0] + c * X1[1, 0] * S2[0, 0] + d * S2[0, 0]) / (2 * (a * S2[0, 0] * S2[0, 0]) + (2 * (b * S2[1, 0] * S2[1, 0]) + (2 * (c * S2[0, 0] * S2[1, 0]))));
            _L2 = Math.Round(Convert.ToDouble(_L2), 4);
            return _L2;


            //for only quadratic equations of the form specified above
        }

        public double[,] GetG()
        {
            //the line of code that was instantiating a new object which was only available within this method,
            //causing my g field to return empty
            g[0, 0] = DfpOperations.DifferentiateWrtoX1(a, b, c, d, ee, f, X1[0, 0], X1[1, 0]);
            g[1, 0] = DfpOperations.DifferentiateWrtoX2(a, b, c, d, ee, f, X1[0, 0], X1[1, 0]); //was differentiating wrt X1 here
            return g;
        }

        public double[,] GetG_2()
        {

            g2[0, 0] = DfpOperations.DifferentiateWrtoX1(a, b, c, d, ee, f, X1[0, 0], X1[1, 0]);
            g2[1, 0] = DfpOperations.DifferentiateWrtoX2(a, b, c, d, ee, f, X1[0, 0], X1[1, 0]);
            return g2;
        }

        public double[,] GetG_3()
        {

            g3[0, 0] = DfpOperations.DifferentiateWrtoX1(a, b, c, d, ee, f, X1[0, 0], X1[1, 0]);
            g3[1, 0] = DfpOperations.DifferentiateWrtoX2(a, b, c, d, ee, f, X1[0, 0], X1[1, 0]);
            return g3;
        }


        public double GetBuffer()             //Check
        {

            return buffer;
        }


        public double[,] GetS()
        {
            S1 = DfpOperations.MatrixMultiplication(H1, g);
            S1 = DfpOperations.ScalarMatrixMultiplication(S1, -1);
            return S1;
        }

        public double[,] GetS2()
        {
            S2 = DfpOperations.MatrixMultiplication(H2, g2);
            S2 = DfpOperations.ScalarMatrixMultiplication(S2, -1);
            return S2;
        }

        /*
        public double[,] GetSNext()             //Check
        {
            S2 = DfpOperations.AddMatrices(DfpOperations.MatriXNegativeOne(g2), DfpOperations.ScalarMatrixMultiplication(S1, GetBuffer())); //the buffer here was returning zero  
           return S2;                                                                                             //the value of s here is not what it should be
        }
        */

        //NEW Members 
        public double[,] GetqDiff()
        {

            q[0, 0] = g2[0, 0] - g[0, 0];
            q[1, 0] = g2[1, 0] - g[1, 0];

            return q;
        }

        public double[,] buffer2 = new double[2, 2];
        public double[,] A1;

        public double[,] GetA()
        {
            double[,] Si_SiT = DfpOperations.MatrixMultiplication(S1, DfpOperations.TransposeMatrix(S1));   //Si*Si'
            double[,] SiT_qi = DfpOperations.MatrixMultiplication(DfpOperations.TransposeMatrix(S1), q);    //Si'*qi

            buffer2[0, 0] = Si_SiT[0, 0] / SiT_qi[0, 0];
            buffer2[0, 1] = Si_SiT[0, 1] / SiT_qi[0, 0];
            buffer2[1, 0] = Si_SiT[1, 0] / SiT_qi[0, 0];
            buffer2[1, 1] = Si_SiT[1, 1] / SiT_qi[0, 0];

            A1 = buffer2;

            return A1;
        }


        public double[,] buffer4 = new double[2, 2];
        public double[,] B1;
        public double[,] GetB()
        {
            double[,] Hq = DfpOperations.MatrixMultiplication(H1, q);

            double[,] Hq_HqT = DfpOperations.MatrixMultiplication(Hq, DfpOperations.TransposeMatrix(Hq)); // (Hq)*(Hq)'

            double[,] qiT_Hi_qi = DfpOperations.MatrixMultiplication(DfpOperations.TransposeMatrix(q), Hq);  //q'*(Hq)
            buffer4[0, 0] = -Hq_HqT[0, 0] / qiT_Hi_qi[0, 0];
            buffer4[0, 1] = -Hq_HqT[0, 1] / qiT_Hi_qi[0, 0];
            buffer4[1, 0] = -Hq_HqT[1, 0] / qiT_Hi_qi[0, 0];
            buffer4[1, 1] = -Hq_HqT[1, 1] / qiT_Hi_qi[0, 0];

            B1 = buffer4;


            return B1;
        }

        public double[,] buffer6;
        public double[,] H2;
        public double[,] GetH2()
        {
            buffer6 = DfpOperations.AddMatrices(A1, B1);
            H2 = DfpOperations.AddMatrices(H1, buffer6);

            return H2;
        }




        public double[,] GetNextPoint2()
        {
            var buffer = DfpOperations.ScalarMatrixMultiplication(S1, _L1);
            X1[0, 0] = X1[0, 0] + buffer[0, 0];
            X1[1, 0] = X1[1, 0] + buffer[1, 0];
            return X1;
        }
        public double[,] GetNextPoint3()
        {
            var buffer = DfpOperations.ScalarMatrixMultiplication(S2, _L2);
            X1[0, 0] = X1[0, 0] + buffer[0, 0];
            X1[1, 0] = X1[1, 0] + buffer[1, 0];
            return X1;
        }

        public bool GradientCheck()   //CHECK
        {
            var abs = Math.Sqrt(Math.Pow(g2[0, 0], 2) + Math.Pow(g2[1, 0], 2));//i was using g instead of gNext at first
            if (abs <= tolerance) //i removed the condition function<=0 since its not the correct criteria
            {
                isMinimum = true;//check previous revision for correction made here.
            }
            return isMinimum;
        }

    }
}

