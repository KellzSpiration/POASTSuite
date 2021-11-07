using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.HookeAndJeevesModule.ParameterClasses
{
   public class Parameter1
    {
        public Parameter1(double _x, double _xF, double _y, double _THx, double _THy, double _THf, double _uppery, double _upperx, double _lowery, double _lowerx, double _h1, double _h2, double _lowerFx, double _lowerFy, double _upperFx, double _upperFy, double _bestPoint, double _h1F, double _h2F, double _f, int _i)
        {
            x = _x;
            xF = _xF;
            y = _y;
            THx = _THx;
            THy = _THy;
            THf = _THf;
            uppery = _uppery;
            upperx = _upperx;
            lowery = _lowery;
            lowerx = _lowerx;
            h1 = _h1;
            h2 = _h2;
            lowerFx = _lowerFx;
            lowerFy = _lowerFy;
            upperFx = _upperFx;
            upperFy = _upperFy;
            bestPoint = _bestPoint;
            h1F = _h1F;
            h2F = _h2F;
            f = _f;
            i = _i;



        }

        public Parameter1()
        {
        }

        // variable declaration using getters and setters
        public double x { get; set; }
        public double xF { get; set; }
        public double y { get; set; }
        public double THx { get; set; }
        public double THy { get; set; }
        public double THf { get; set; }
        public double uppery { get; set; }
        public double upperx { get; set; }
        public double lowery { get; set; }
        public double lowerx { get; set; }
        public double h1 { get; set; }
        public double h2 { get; set; }
        public double lowerFx { get; set; }
        public double lowerFy { get; set; }
        public double upperFx { get; set; }
        public double upperFy { get; set; }
        public double bestPoint { get; set; }
        public double h1F { get; set; }
        public double h2F { get; set; }
        public double f { get; set; }
        public int i { get; set; }

        public double[] Function { get; set; } = new double[8];

        public double[] TFunct { get; set; } = new double[8];

        public double[] UpFX { get; set; } = new double[8];

        public double[] UpFY { get; set; } = new double[8];

        public double[] LowFX { get; set; } = new double[8];

        public double[] LowFY { get; set; } = new double[8];




    }
}


