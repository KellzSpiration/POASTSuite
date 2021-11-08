using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.HookeAndJeevesModule.ProgramClasses
{
    public class Program8
    {
        public static void SolveFx(Parameter8 parameter8)   // the main logic method that is repeated above
        {
            parameter8.x = parameter8.THxx;
            parameter8.y = parameter8.THyy;
            parameter8.upperx = parameter8.x + parameter8.h1;
            parameter8.upperFx = 6 * Math.Pow(parameter8.upperx, 2) - (9 * (parameter8.upperx * parameter8.y)) + 4 * Math.Pow(parameter8.y, 2) + (2 * parameter8.upperx) + (2 * parameter8.y);
            parameter8.lowerx = parameter8.x - parameter8.h1;
            parameter8.lowerFx = 6 * Math.Pow(parameter8.lowerx, 2) - (9 * (parameter8.lowerx * parameter8.y)) + 4 * Math.Pow(parameter8.y, 2) + (2 * parameter8.lowerx) + (2 * parameter8.y);
            parameter8.UpFX[parameter8.i] = Math.Round(parameter8.upperFx, 3);
            parameter8.LowFX[parameter8.i] = Math.Round(parameter8.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter8.upperx, parameter8.y, parameter8.UpFX[parameter8.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter8.lowerx, parameter8.y, parameter8.LowFX[parameter8.i]);

            if (parameter8.upperFx <= parameter8.lowerFx)
            {
                parameter8.xF = parameter8.upperx;
                parameter8.uppery = parameter8.y + parameter8.h2;
                parameter8.upperFy = 6 * Math.Pow(parameter8.xF, 2) - (9 * (parameter8.xF * parameter8.uppery)) + 4 * Math.Pow(parameter8.uppery, 2) + (2 * parameter8.xF) + (2 * parameter8.uppery);
                parameter8.lowery = parameter8.y - parameter8.h1;
                parameter8.lowerFy = 6 * Math.Pow(parameter8.xF, 2) - (9 * (parameter8.xF * parameter8.lowery)) + 4 * Math.Pow(parameter8.lowery, 2) + (2 * parameter8.xF) + (2 * parameter8.lowery);
                parameter8.UpFY[parameter8.i] = Math.Round(parameter8.upperFy, 3);
                parameter8.LowFY[parameter8.i] = Math.Round(parameter8.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter8.xF, parameter8.uppery, parameter8.UpFY[parameter8.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter8.xF, parameter8.lowery, parameter8.LowFY[parameter8.i]);
            }

            else if (parameter8.lowerFx <= parameter8.upperFx)
            {
                parameter8.uppery = parameter8.y + parameter8.h2;
                parameter8.xF = parameter8.lowerx;
                parameter8.upperFy = 6 * Math.Pow(parameter8.xF, 2) - (9 * (parameter8.xF * parameter8.uppery)) + 4 * Math.Pow(parameter8.uppery, 2) + (2 * parameter8.xF) + (2 * parameter8.uppery);
                parameter8.lowery = parameter8.y - parameter8.h2;
                parameter8.lowerFy = 6 * Math.Pow(parameter8.xF, 2) - (9 * (parameter8.xF * parameter8.lowery)) + 4 * Math.Pow(parameter8.lowery, 2) + (2 * parameter8.xF) + (2 * parameter8.lowery);
                parameter8.UpFY[parameter8.i] = Math.Round(parameter8.upperFy, 3);
                parameter8.LowFY[parameter8.i] = Math.Round(parameter8.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter8.xF, parameter8.uppery, parameter8.UpFY[parameter8.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter8.xF, parameter8.lowery, parameter8.LowFY[parameter8.i]);
            }

            parameter8.bestPoint = Math.Min(Math.Min(parameter8.upperFx, parameter8.lowerFx), Math.Min(parameter8.upperFy, parameter8.lowerFy));
            parameter8.Function[parameter8.i] = Math.Round(parameter8.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter8.Function[parameter8.i]);

            // ---temporary head
            if (parameter8.bestPoint == parameter8.upperFx)
            {
                parameter8.THxx = 2 * parameter8.upperx - parameter8.x;
                parameter8.THyy = 2 * parameter8.y - parameter8.y;
                parameter8.THf = 6 * Math.Pow(parameter8.THxx, 2) - (9 * (parameter8.THxx * parameter8.THyy)) + 4 * Math.Pow(parameter8.THyy, 2) + (2 * parameter8.THxx) + (2 * parameter8.THyy);
                parameter8.TFunct[parameter8.i] = Math.Round(parameter8.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter8.THxx, parameter8.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter8.THxx, parameter8.THyy, parameter8.TFunct[parameter8.i]);
            }
            else if (parameter8.bestPoint == parameter8.lowerFx)
            {
                parameter8.THxx = 2 * parameter8.lowerx - parameter8.x;
                parameter8.THyy = 2 * parameter8.y - parameter8.y;
                parameter8.THf = 6 * Math.Pow(parameter8.THxx, 2) - (9 * (parameter8.THxx * parameter8.THyy)) + 4 * Math.Pow(parameter8.THyy, 2) + (2 * parameter8.THxx) + (2 * parameter8.THyy);
                parameter8.TFunct[parameter8.i] = Math.Round(parameter8.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter8.THxx, parameter8.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter8.THxx, parameter8.THyy, parameter8.TFunct[parameter8.i]);
            }
            else if (parameter8.bestPoint == parameter8.upperFy)
            {
                parameter8.THxx = 2 * parameter8.xF - parameter8.x;
                parameter8.THyy = 2 * parameter8.uppery - parameter8.y;
                parameter8.THf = 6 * Math.Pow(parameter8.THxx, 2) - (9 * (parameter8.THxx * parameter8.THyy)) + 4 * Math.Pow(parameter8.THyy, 2) + (2 * parameter8.THxx) + (2 * parameter8.THyy);
                parameter8.TFunct[parameter8.i] = Math.Round(parameter8.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter8.THxx, parameter8.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter8.THxx, parameter8.THyy, parameter8.TFunct[parameter8.i]);
            }
            else if (parameter8.bestPoint == parameter8.lowerFy)
            {
                parameter8.THxx = 2 * parameter8.xF - parameter8.x;
                parameter8.THyy = 2 * parameter8.lowery - parameter8.y;
                parameter8.THf = 6 * Math.Pow(parameter8.THxx, 2) - (9 * (parameter8.THxx * parameter8.THyy)) + 4 * Math.Pow(parameter8.THyy, 2) + (2 * parameter8.THxx) + (2 * parameter8.THyy);
                parameter8.TFunct[parameter8.i] = Math.Round(parameter8.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter8.THxx, parameter8.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter8.THxx, parameter8.THyy, parameter8.TFunct[parameter8.i]);
            }
        }
    }
}
