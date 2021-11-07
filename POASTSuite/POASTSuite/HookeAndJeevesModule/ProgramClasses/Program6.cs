using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.HookeAndJeevesModule.ProgramClasses
{
    public class Program6
    {
       public static void SolveFx(Parameter6 parameter6)   // the main logic method that is repeated above
        {
            parameter6.x = parameter6.THxx;
            parameter6.y = parameter6.THyy;
            parameter6.upperx = parameter6.x + parameter6.h1;
            parameter6.upperFx = Math.Pow(parameter6.upperx, 2) - (2 * (parameter6.upperx * parameter6.y)) + 2 * Math.Pow(parameter6.y, 2) + (8 * parameter6.upperx) + (3 * parameter6.y);
            parameter6.lowerx = parameter6.x - parameter6.h1;
            parameter6.lowerFx = Math.Pow(parameter6.lowerx, 2) - (2 * (parameter6.lowerx * parameter6.y)) + 2 * Math.Pow(parameter6.y, 2) + (8 * parameter6.lowerx) + (3 * parameter6.y);
            parameter6.UpFX[parameter6.i] = Math.Round(parameter6.upperFx, 3);
            parameter6.LowFX[parameter6.i] = Math.Round(parameter6.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter6.upperx, parameter6.y, parameter6.UpFX[parameter6.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter6.lowerx, parameter6.y, parameter6.LowFX[parameter6.i]);

            if (parameter6.upperFx <= parameter6.lowerFx)
            {
                parameter6.xF = parameter6.upperx;
                parameter6.uppery = parameter6.y + parameter6.h2;
                parameter6.upperFy = Math.Pow(parameter6.xF, 2) - (2 * (parameter6.xF * parameter6.uppery)) + 2 * Math.Pow(parameter6.uppery, 2) + (8 * parameter6.xF) + (3 * parameter6.uppery);
                parameter6.lowery = parameter6.y - parameter6.h1;
                parameter6.lowerFy = Math.Pow(parameter6.xF, 2) - (2 * (parameter6.xF * parameter6.lowery)) + 2 * Math.Pow(parameter6.lowery, 2) + (8 * parameter6.xF) + (3 * parameter6.lowery);
                parameter6.UpFY[parameter6.i] = Math.Round(parameter6.upperFy, 3);
                parameter6.LowFY[parameter6.i] = Math.Round(parameter6.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter6.xF, parameter6.uppery, parameter6.UpFY[parameter6.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter6.xF, parameter6.lowery, parameter6.LowFY[parameter6.i]);
            }

            else if (parameter6.lowerFx <= parameter6.upperFx)
            {
                parameter6.uppery = parameter6.y + parameter6.h2;
                parameter6.xF = parameter6.lowerx;
                parameter6.upperFy = Math.Pow(parameter6.xF, 2) - (2 * (parameter6.xF * parameter6.uppery)) + 2 * Math.Pow(parameter6.uppery, 2) + (8 * parameter6.xF) + (3 * parameter6.uppery);
                parameter6.lowery = parameter6.y - parameter6.h2;
                parameter6.lowerFy = Math.Pow(parameter6.xF, 2) - (2 * (parameter6.xF * parameter6.lowery)) + 2 * Math.Pow(parameter6.lowery, 2) + (8 * parameter6.xF) + (3 * parameter6.lowery);
                parameter6.UpFY[parameter6.i] = Math.Round(parameter6.upperFy, 3);
                parameter6.LowFY[parameter6.i] = Math.Round(parameter6.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter6.xF, parameter6.uppery, parameter6.UpFY[parameter6.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter6.xF, parameter6.lowery, parameter6.LowFY[parameter6.i]);
            }

            parameter6.bestPoint = Math.Min(Math.Min(parameter6.upperFx, parameter6.lowerFx), Math.Min(parameter6.upperFy, parameter6.lowerFy));
            parameter6.Function[parameter6.i] = Math.Round(parameter6.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter6.Function[parameter6.i]);

            // ---temporary head
            if (parameter6.bestPoint == parameter6.upperFx)
            {
                parameter6.THxx = 2 * parameter6.upperx - parameter6.x;
                parameter6.THyy = 2 * parameter6.y - parameter6.y;
                parameter6.THf = Math.Pow(parameter6.THxx, 2) - (2 * (parameter6.THxx * parameter6.THyy)) + 2 * Math.Pow(parameter6.THyy, 2) + (8 * parameter6.THxx) + (3 * parameter6.THyy);
                parameter6.TFunct[parameter6.i] = Math.Round(parameter6.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter6.THxx, parameter6.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter6.THxx, parameter6.THyy, parameter6.TFunct[parameter6.i]);
            }
            else if (parameter6.bestPoint == parameter6.lowerFx)
            {
                parameter6.THxx = 2 * parameter6.lowerx - parameter6.x;
                parameter6.THyy = 2 * parameter6.y - parameter6.y;
                parameter6.THf = Math.Pow(parameter6.THxx, 2) - (2 * (parameter6.THxx * parameter6.THyy)) + 2 * Math.Pow(parameter6.THyy, 2) + (8 * parameter6.THxx) + (3 * parameter6.THyy);
                parameter6.TFunct[parameter6.i] = Math.Round(parameter6.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter6.THxx, parameter6.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter6.THxx, parameter6.THyy, parameter6.TFunct[parameter6.i]);
            }
            else if (parameter6.bestPoint == parameter6.upperFy)
            {
                parameter6.THxx = 2 * parameter6.xF - parameter6.x;
                parameter6.THyy = 2 * parameter6.uppery - parameter6.y;
                parameter6.THf = Math.Pow(parameter6.THxx, 2) - (2 * (parameter6.THxx * parameter6.THyy)) + 2 * Math.Pow(parameter6.THyy, 2) + (8 * parameter6.THxx) + (3 * parameter6.THyy);
                parameter6.TFunct[parameter6.i] = Math.Round(parameter6.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter6.THxx, parameter6.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter6.THxx, parameter6.THyy, parameter6.TFunct[parameter6.i]);
            }
            else if (parameter6.bestPoint == parameter6.lowerFy)
            {
                parameter6.THxx = 2 * parameter6.xF - parameter6.x;
                parameter6.THyy = 2 * parameter6.lowery - parameter6.y;
                parameter6.THf = Math.Pow(parameter6.THxx, 2) - (2 * (parameter6.THxx * parameter6.THyy)) + 2 * Math.Pow(parameter6.THyy, 2) + (8 * parameter6.THxx) + (3 * parameter6.THyy);
                parameter6.TFunct[parameter6.i] = Math.Round(parameter6.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter6.THxx, parameter6.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter6.THxx, parameter6.THyy, parameter6.TFunct[parameter6.i]);
            }
        }
    }
}
