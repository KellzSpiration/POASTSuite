using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.HookeAndJeevesModule.ProgramClasses
{
    public class Program9
    {
        public static void SolveFx(Parameter9 parameter9)   // the main logic method that is repeated above
        {
            parameter9.x = parameter9.THxx;
            parameter9.y = parameter9.THyy;
            parameter9.upperx = parameter9.x + parameter9.h1;
            parameter9.upperFx = 7 * Math.Pow(parameter9.upperx, 2) - (3 * (parameter9.upperx * parameter9.y)) + 6 * Math.Pow(parameter9.y, 2) + (7 * parameter9.upperx) + (2 * parameter9.y);
            parameter9.lowerx = parameter9.x - parameter9.h1;
            parameter9.lowerFx = 7 * Math.Pow(parameter9.lowerx, 2) - (3 * (parameter9.lowerx * parameter9.y)) + 6 * Math.Pow(parameter9.y, 2) + (7 * parameter9.lowerx) + (2 * parameter9.y);
            parameter9.UpFX[parameter9.i] = Math.Round(parameter9.upperFx, 3);
            parameter9.LowFX[parameter9.i] = Math.Round(parameter9.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter9.upperx, parameter9.y, parameter9.UpFX[parameter9.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter9.lowerx, parameter9.y, parameter9.LowFX[parameter9.i]);

            if (parameter9.upperFx <= parameter9.lowerFx)
            {
                parameter9.xF = parameter9.upperx;
                parameter9.uppery = parameter9.y + parameter9.h2;
                parameter9.upperFy = 7 * Math.Pow(parameter9.xF, 2) - (3 * (parameter9.xF * parameter9.uppery)) + 6 * Math.Pow(parameter9.uppery, 2) + (7 * parameter9.xF) + (2 * parameter9.uppery);
                parameter9.lowery = parameter9.y - parameter9.h1;
                parameter9.lowerFy = 7 * Math.Pow(parameter9.xF, 2) - (3 * (parameter9.xF * parameter9.lowery)) + 6 * Math.Pow(parameter9.lowery, 2) + (7 * parameter9.xF) + (2 * parameter9.lowery);
                parameter9.UpFY[parameter9.i] = Math.Round(parameter9.upperFy, 3);
                parameter9.LowFY[parameter9.i] = Math.Round(parameter9.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter9.xF, parameter9.uppery, parameter9.UpFY[parameter9.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter9.xF, parameter9.lowery, parameter9.LowFY[parameter9.i]);
            }

            else if (parameter9.lowerFx <= parameter9.upperFx)
            {
                parameter9.uppery = parameter9.y + parameter9.h2;
                parameter9.xF = parameter9.lowerx;
                parameter9.upperFy = 7 * Math.Pow(parameter9.xF, 2) - (3 * (parameter9.xF * parameter9.uppery)) + 6 * Math.Pow(parameter9.uppery, 2) + (7 * parameter9.xF) + (2 * parameter9.uppery);
                parameter9.lowery = parameter9.y - parameter9.h2;
                parameter9.lowerFy = 7 * Math.Pow(parameter9.xF, 2) - (3 * (parameter9.xF * parameter9.lowery)) + 6 * Math.Pow(parameter9.lowery, 2) + (7 * parameter9.xF) + (2 * parameter9.lowery);
                parameter9.UpFY[parameter9.i] = Math.Round(parameter9.upperFy, 3);
                parameter9.LowFY[parameter9.i] = Math.Round(parameter9.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter9.xF, parameter9.uppery, parameter9.UpFY[parameter9.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter9.xF, parameter9.lowery, parameter9.LowFY[parameter9.i]);
            }

            parameter9.bestPoint = Math.Min(Math.Min(parameter9.upperFx, parameter9.lowerFx), Math.Min(parameter9.upperFy, parameter9.lowerFy));
            parameter9.Function[parameter9.i] = Math.Round(parameter9.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter9.Function[parameter9.i]);

            // ---temporary head
            if (parameter9.bestPoint == parameter9.upperFx)
            {
                parameter9.THxx = 2 * parameter9.upperx - parameter9.x;
                parameter9.THyy = 2 * parameter9.y - parameter9.y;
                parameter9.THf = 7 * Math.Pow(parameter9.THxx, 2) - (3 * (parameter9.THxx * parameter9.THyy)) + 6 * Math.Pow(parameter9.THyy, 2) + (7 * parameter9.THxx) + (2 * parameter9.THyy);
                parameter9.TFunct[parameter9.i] = Math.Round(parameter9.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter9.THxx, parameter9.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter9.THxx, parameter9.THyy, parameter9.TFunct[parameter9.i]);
            }
            else if (parameter9.bestPoint == parameter9.lowerFx)
            {
                parameter9.THxx = 2 * parameter9.lowerx - parameter9.x;
                parameter9.THyy = 2 * parameter9.y - parameter9.y;
                parameter9.THf = 7 * Math.Pow(parameter9.THxx, 2) - (3 * (parameter9.THxx * parameter9.THyy)) + 6 * Math.Pow(parameter9.THyy, 2) + (7 * parameter9.THxx) + (2 * parameter9.THyy);
                parameter9.TFunct[parameter9.i] = Math.Round(parameter9.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter9.THxx, parameter9.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter9.THxx, parameter9.THyy, parameter9.TFunct[parameter9.i]);
            }
            else if (parameter9.bestPoint == parameter9.upperFy)
            {
                parameter9.THxx = 2 * parameter9.xF - parameter9.x;
                parameter9.THyy = 2 * parameter9.uppery - parameter9.y;
                parameter9.THf = 7 * Math.Pow(parameter9.THxx, 2) - (3 * (parameter9.THxx * parameter9.THyy)) + 6 * Math.Pow(parameter9.THyy, 2) + (7 * parameter9.THxx) + (2 * parameter9.THyy);
                parameter9.TFunct[parameter9.i] = Math.Round(parameter9.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter9.THxx, parameter9.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter9.THxx, parameter9.THyy, parameter9.TFunct[parameter9.i]);
            }
            else if (parameter9.bestPoint == parameter9.lowerFy)
            {
                parameter9.THxx = 2 * parameter9.xF - parameter9.x;
                parameter9.THyy = 2 * parameter9.lowery - parameter9.y;
                parameter9.THf = 7 * Math.Pow(parameter9.THxx, 2) - (3 * (parameter9.THxx * parameter9.THyy)) + 6 * Math.Pow(parameter9.THyy, 2) + (7 * parameter9.THxx) + (2 * parameter9.THyy);
                parameter9.TFunct[parameter9.i] = Math.Round(parameter9.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter9.THxx, parameter9.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter9.THxx, parameter9.THyy, parameter9.TFunct[parameter9.i]);
            }
        }
    }
}
