using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.HookeAndJeevesModule.ProgramClasses
{
    public class Program5
    {
       public static void SolveFx(Parameter5 parameter5)   // the main logic method that is repeated above
        {
            parameter5.x = parameter5.THxx;
            parameter5.y = parameter5.THyy;
            parameter5.upperx = parameter5.x + parameter5.h1;
            parameter5.upperFx = 6 * Math.Pow(parameter5.upperx, 2) - (5 * (parameter5.upperx * parameter5.y)) + 2 * Math.Pow(parameter5.y, 2) + (4 * parameter5.upperx) + (2 * parameter5.y);
            parameter5.lowerx = parameter5.x - parameter5.h1;
            parameter5.lowerFx = 6 * Math.Pow(parameter5.lowerx, 2) - (5 * (parameter5.lowerx * parameter5.y)) + 2 * Math.Pow(parameter5.y, 2) + (4 * parameter5.lowerx) + (2 * parameter5.y);
            parameter5.UpFX[parameter5.i] = Math.Round(parameter5.upperFx, 3);
            parameter5.LowFX[parameter5.i] = Math.Round(parameter5.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter5.upperx, parameter5.y, parameter5.UpFX[parameter5.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter5.lowerx, parameter5.y, parameter5.LowFX[parameter5.i]);

            if (parameter5.upperFx <= parameter5.lowerFx)
            {
                parameter5.xF = parameter5.upperx;
                parameter5.uppery = parameter5.y + parameter5.h2;
                parameter5.upperFy = 6 * Math.Pow(parameter5.xF, 2) - (5 * (parameter5.xF * parameter5.uppery)) + 2 * Math.Pow(parameter5.uppery, 2) + (4 * parameter5.xF) + (2 * parameter5.uppery);
                parameter5.lowery = parameter5.y - parameter5.h1;
                parameter5.lowerFy = 6 * Math.Pow(parameter5.xF, 2) - (5 * (parameter5.xF * parameter5.lowery)) + 2 * Math.Pow(parameter5.lowery, 2) + (4 * parameter5.xF) + (2 * parameter5.lowery);
                parameter5.UpFY[parameter5.i] = Math.Round(parameter5.upperFy, 3);
                parameter5.LowFY[parameter5.i] = Math.Round(parameter5.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter5.xF, parameter5.uppery, parameter5.UpFY[parameter5.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter5.xF, parameter5.lowery, parameter5.LowFY[parameter5.i]);
            }

            else if (parameter5.lowerFx <= parameter5.upperFx)
            {
                parameter5.uppery = parameter5.y + parameter5.h2;
                parameter5.xF = parameter5.lowerx;
                parameter5.upperFy = 6 * Math.Pow(parameter5.xF, 2) - (5 * (parameter5.xF * parameter5.uppery)) + 2 * Math.Pow(parameter5.uppery, 2) + (4 * parameter5.xF) + (2 * parameter5.uppery);
                parameter5.lowery = parameter5.y - parameter5.h2;
                parameter5.lowerFy = 6 * Math.Pow(parameter5.xF, 2) - (5 * (parameter5.xF * parameter5.lowery)) + 2 * Math.Pow(parameter5.lowery, 2) + (4 * parameter5.xF) + (2 * parameter5.lowery);
                parameter5.UpFY[parameter5.i] = Math.Round(parameter5.upperFy, 3);
                parameter5.LowFY[parameter5.i] = Math.Round(parameter5.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter5.xF, parameter5.uppery, parameter5.UpFY[parameter5.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter5.xF, parameter5.lowery, parameter5.LowFY[parameter5.i]);
            }

            parameter5.bestPoint = Math.Min(Math.Min(parameter5.upperFx, parameter5.lowerFx), Math.Min(parameter5.upperFy, parameter5.lowerFy));
            parameter5.Function[parameter5.i] = Math.Round(parameter5.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter5.Function[parameter5.i]);

            // ---temporary head
            if (parameter5.bestPoint == parameter5.upperFx)
            {
                parameter5.THxx = 2 * parameter5.upperx - parameter5.x;
                parameter5.THyy = 2 * parameter5.y - parameter5.y;
                parameter5.THf = 6 * Math.Pow(parameter5.THxx, 2) - (5 * (parameter5.THxx * parameter5.THyy)) + 2 * Math.Pow(parameter5.THyy, 2) + (4 * parameter5.THxx) + (2 * parameter5.THyy);
                parameter5.TFunct[parameter5.i] = Math.Round(parameter5.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter5.THxx, parameter5.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter5.THxx, parameter5.THyy, parameter5.TFunct[parameter5.i]);
            }
            else if (parameter5.bestPoint == parameter5.lowerFx)
            {
                parameter5.THxx = 2 * parameter5.lowerx - parameter5.x;
                parameter5.THyy = 2 * parameter5.y - parameter5.y;
                parameter5.THf = 6 * Math.Pow(parameter5.THxx, 2) - (5 * (parameter5.THxx * parameter5.THyy)) + 2 * Math.Pow(parameter5.THyy, 2) + (4 * parameter5.THxx) + (2 * parameter5.THyy);
                parameter5.TFunct[parameter5.i] = Math.Round(parameter5.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter5.THxx, parameter5.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter5.THxx, parameter5.THyy, parameter5.TFunct[parameter5.i]);
            }
            else if (parameter5.bestPoint == parameter5.upperFy)
            {
                parameter5.THxx = 2 * parameter5.xF - parameter5.x;
                parameter5.THyy = 2 * parameter5.uppery - parameter5.y;
                parameter5.THf = 6 * Math.Pow(parameter5.THxx, 2) - (5 * (parameter5.THxx * parameter5.THyy)) + 2 * Math.Pow(parameter5.THyy, 2) + (4 * parameter5.THxx) + (2 * parameter5.THyy);
                parameter5.TFunct[parameter5.i] = Math.Round(parameter5.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter5.THxx, parameter5.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter5.THxx, parameter5.THyy, parameter5.TFunct[parameter5.i]);
            }
            else if (parameter5.bestPoint == parameter5.lowerFy)
            {
                parameter5.THxx = 2 * parameter5.xF - parameter5.x;
                parameter5.THyy = 2 * parameter5.lowery - parameter5.y;
                parameter5.THf = 6 * Math.Pow(parameter5.THxx, 2) - (5 * (parameter5.THxx * parameter5.THyy)) + 2 * Math.Pow(parameter5.THyy, 2) + (4 * parameter5.THxx) + (2 * parameter5.THyy);
                parameter5.TFunct[parameter5.i] = Math.Round(parameter5.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter5.THxx, parameter5.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter5.THxx, parameter5.THyy, parameter5.TFunct[parameter5.i]);
            }

        }
    }
}