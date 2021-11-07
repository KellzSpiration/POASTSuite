using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.HookeAndJeevesModule.ProgramClasses
{
    public class Program4
    {
     public  static void SolveFx(Parameter4 parameter4)   // the main logic method that is repeated above
        {
            parameter4.x = parameter4.THxx;
            parameter4.y = parameter4.THyy;
            parameter4.upperx = parameter4.x + parameter4.h1;
            parameter4.upperFx = 2 * Math.Pow(parameter4.upperx, 2) - (7 * (parameter4.upperx * parameter4.y)) + 6 * Math.Pow(parameter4.y, 2) + (5 * parameter4.upperx) + (5 * parameter4.y);
            parameter4.lowerx = parameter4.x - parameter4.h1;
            parameter4.lowerFx = 2 * Math.Pow(parameter4.lowerx, 2) - (7 * (parameter4.lowerx * parameter4.y)) + 6 * Math.Pow(parameter4.y, 2) + (5 * parameter4.lowerx) + (5 * parameter4.y);
            parameter4.UpFX[parameter4.i] = Math.Round(parameter4.upperFx, 3);
            parameter4.LowFX[parameter4.i] = Math.Round(parameter4.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter4.upperx, parameter4.y, parameter4.UpFX[parameter4.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter4.lowerx, parameter4.y, parameter4.LowFX[parameter4.i]);

            if (parameter4.upperFx <= parameter4.lowerFx)
            {
                parameter4.xF = parameter4.upperx;
                parameter4.uppery = parameter4.y + parameter4.h2;
                parameter4.upperFy = 2 * Math.Pow(parameter4.xF, 2) - (7 * (parameter4.xF * parameter4.uppery)) + 6 * Math.Pow(parameter4.uppery, 2) + (5 * parameter4.xF) + (5 * parameter4.uppery);
                parameter4.lowery = parameter4.y - parameter4.h1;
                parameter4.lowerFy = 2 * Math.Pow(parameter4.xF, 2) - (7 * (parameter4.xF * parameter4.lowery)) + 6 * Math.Pow(parameter4.lowery, 2) + (5 * parameter4.xF) + (5 * parameter4.lowery);
                parameter4.UpFY[parameter4.i] = Math.Round(parameter4.upperFy, 3);
                parameter4.LowFY[parameter4.i] = Math.Round(parameter4.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter4.xF, parameter4.uppery, parameter4.UpFY[parameter4.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter4.xF, parameter4.lowery, parameter4.LowFY[parameter4.i]);
            }

            else if (parameter4.lowerFx <= parameter4.upperFx)
            {
                parameter4.uppery = parameter4.y + parameter4.h2;
                parameter4.xF = parameter4.lowerx;
                parameter4.upperFy = 2 * Math.Pow(parameter4.xF, 2) - (7 * (parameter4.xF * parameter4.uppery)) + 6 * Math.Pow(parameter4.uppery, 2) + (5 * parameter4.xF) + (5 * parameter4.uppery);
                parameter4.lowery = parameter4.y - parameter4.h2;
                parameter4.lowerFy = 2 * Math.Pow(parameter4.xF, 2) - (7 * (parameter4.xF * parameter4.lowery)) + 6 * Math.Pow(parameter4.lowery, 2) + (5 * parameter4.xF) + (5 * parameter4.lowery);
                parameter4.UpFY[parameter4.i] = Math.Round(parameter4.upperFy, 3);
                parameter4.LowFY[parameter4.i] = Math.Round(parameter4.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter4.xF, parameter4.uppery, parameter4.UpFY[parameter4.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter4.xF, parameter4.lowery, parameter4.LowFY[parameter4.i]);
            }

            parameter4.bestPoint = Math.Min(Math.Min(parameter4.upperFx, parameter4.lowerFx), Math.Min(parameter4.upperFy, parameter4.lowerFy));
            parameter4.Function[parameter4.i] = Math.Round(parameter4.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter4.Function[parameter4.i]);

            // ---temporary head
            if (parameter4.bestPoint == parameter4.upperFx)
            {
                parameter4.THxx = 2 * parameter4.upperx - parameter4.x;
                parameter4.THyy = 2 * parameter4.y - parameter4.y;
                parameter4.THf = 2 * Math.Pow(parameter4.THxx, 2) - (7 * (parameter4.THxx * parameter4.THyy)) + 6 * Math.Pow(parameter4.THyy, 2) + (5 * parameter4.THxx) + (5 * parameter4.THyy);
                parameter4.TFunct[parameter4.i] = Math.Round(parameter4.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter4.THxx, parameter4.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter4.THxx, parameter4.THyy, parameter4.TFunct[parameter4.i]);
            }
            else if (parameter4.bestPoint == parameter4.lowerFx)
            {
                parameter4.THxx = 2 * parameter4.lowerx - parameter4.x;
                parameter4.THyy = 2 * parameter4.y - parameter4.y;
                parameter4.THf = 2 * Math.Pow(parameter4.THxx, 2) - (7 * (parameter4.THxx * parameter4.THyy)) + 6 * Math.Pow(parameter4.THyy, 2) + (5 * parameter4.THxx) + (5 * parameter4.THyy);
                parameter4.TFunct[parameter4.i] = Math.Round(parameter4.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter4.THxx, parameter4.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter4.THxx, parameter4.THyy, parameter4.TFunct[parameter4.i]);
            }
            else if (parameter4.bestPoint == parameter4.upperFy)
            {
                parameter4.THxx = 2 * parameter4.xF - parameter4.x;
                parameter4.THyy = 2 * parameter4.uppery - parameter4.y;
                parameter4.THf = 2 * Math.Pow(parameter4.THxx, 2) - (7 * (parameter4.THxx * parameter4.THyy)) + 6 * Math.Pow(parameter4.THyy, 2) + (5 * parameter4.THxx) + (5 * parameter4.THyy);
                parameter4.TFunct[parameter4.i] = Math.Round(parameter4.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter4.THxx, parameter4.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter4.THxx, parameter4.THyy, parameter4.TFunct[parameter4.i]);
            }
            else if (parameter4.bestPoint == parameter4.lowerFy)
            {
                parameter4.THxx = 2 * parameter4.xF - parameter4.x;
                parameter4.THyy = 2 * parameter4.lowery - parameter4.y;
                parameter4.THf = 2 * Math.Pow(parameter4.THxx, 2) - (7 * (parameter4.THxx * parameter4.THyy)) + 6 * Math.Pow(parameter4.THyy, 2) + (5 * parameter4.THxx) + (5 * parameter4.THyy);
                parameter4.TFunct[parameter4.i] = Math.Round(parameter4.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter4.THxx, parameter4.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter4.THxx, parameter4.THyy, parameter4.TFunct[parameter4.i]);
            }

        }
    }
}
