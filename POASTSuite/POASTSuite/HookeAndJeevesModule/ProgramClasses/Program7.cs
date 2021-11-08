using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.HookeAndJeevesModule.ProgramClasses
{
    public class Program7
    {
        public static void SolveFx(Parameter7 parameter7)   // the main logic method that is repeated above
        {
            parameter7.x = parameter7.THxx;
            parameter7.y = parameter7.THyy;
            parameter7.upperx = parameter7.x + parameter7.h1;
            parameter7.upperFx = 9 * Math.Pow(parameter7.upperx, 2) - (2 * (parameter7.upperx * parameter7.y)) + 6 * Math.Pow(parameter7.y, 2) + (parameter7.upperx) + (2 * parameter7.y);
            parameter7.lowerx = parameter7.x - parameter7.h1;
            parameter7.lowerFx = 9 * Math.Pow(parameter7.lowerx, 2) - (2 * (parameter7.lowerx * parameter7.y)) + 6 * Math.Pow(parameter7.y, 2) + (parameter7.lowerx) + (2 * parameter7.y);
            parameter7.UpFX[parameter7.i] = Math.Round(parameter7.upperFx, 3);
            parameter7.LowFX[parameter7.i] = Math.Round(parameter7.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter7.upperx, parameter7.y, parameter7.UpFX[parameter7.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter7.lowerx, parameter7.y, parameter7.LowFX[parameter7.i]);

            if (parameter7.upperFx <= parameter7.lowerFx)
            {
                parameter7.xF = parameter7.upperx;
                parameter7.uppery = parameter7.y + parameter7.h2;
                parameter7.upperFy = 9 * Math.Pow(parameter7.xF, 2) - (2 * (parameter7.xF * parameter7.uppery)) + 6 * Math.Pow(parameter7.uppery, 2) + (parameter7.xF) + (2 * parameter7.uppery);
                parameter7.lowery = parameter7.y - parameter7.h1;
                parameter7.lowerFy = 9 * Math.Pow(parameter7.xF, 2) - (2 * (parameter7.xF * parameter7.lowery)) + 6 * Math.Pow(parameter7.lowery, 2) + (parameter7.xF) + (2 * parameter7.lowery);
                parameter7.UpFY[parameter7.i] = Math.Round(parameter7.upperFy, 3);
                parameter7.LowFY[parameter7.i] = Math.Round(parameter7.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter7.xF, parameter7.uppery, parameter7.UpFY[parameter7.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter7.xF, parameter7.lowery, parameter7.LowFY[parameter7.i]);
            }

            else if (parameter7.lowerFx <= parameter7.upperFx)
            {
                parameter7.uppery = parameter7.y + parameter7.h2;
                parameter7.xF = parameter7.lowerx;
                parameter7.upperFy = 9 * Math.Pow(parameter7.xF, 2) - (2 * (parameter7.xF * parameter7.uppery)) + 6 * Math.Pow(parameter7.uppery, 2) + (parameter7.xF) + (2 * parameter7.uppery);
                parameter7.lowery = parameter7.y - parameter7.h2;
                parameter7.lowerFy = 9 * Math.Pow(parameter7.xF, 2) - (2 * (parameter7.xF * parameter7.lowery)) + 6 * Math.Pow(parameter7.lowery, 2) + (parameter7.xF) + (2 * parameter7.lowery);
                parameter7.UpFY[parameter7.i] = Math.Round(parameter7.upperFy, 3);
                parameter7.LowFY[parameter7.i] = Math.Round(parameter7.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter7.xF, parameter7.uppery, parameter7.UpFY[parameter7.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter7.xF, parameter7.lowery, parameter7.LowFY[parameter7.i]);
            }

            parameter7.bestPoint = Math.Min(Math.Min(parameter7.upperFx, parameter7.lowerFx), Math.Min(parameter7.upperFy, parameter7.lowerFy));
            parameter7.Function[parameter7.i] = Math.Round(parameter7.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter7.Function[parameter7.i]);

            // ---temporary head
            if (parameter7.bestPoint == parameter7.upperFx)
            {
                parameter7.THxx = 2 * parameter7.upperx - parameter7.x;
                parameter7.THyy = 2 * parameter7.y - parameter7.y;
                parameter7.THf = 9 * Math.Pow(parameter7.THxx, 2) - (2 * (parameter7.THxx * parameter7.THyy)) + 6 * Math.Pow(parameter7.THyy, 2) + (parameter7.THxx) + (2 * parameter7.THyy);
                parameter7.TFunct[parameter7.i] = Math.Round(parameter7.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter7.THxx, parameter7.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter7.THxx, parameter7.THyy, parameter7.TFunct[parameter7.i]);
            }
            else if (parameter7.bestPoint == parameter7.lowerFx)
            {
                parameter7.THxx = 2 * parameter7.lowerx - parameter7.x;
                parameter7.THyy = 2 * parameter7.y - parameter7.y;
                parameter7.THf = 9 * Math.Pow(parameter7.THxx, 2) - (2 * (parameter7.THxx * parameter7.THyy)) + 6 * Math.Pow(parameter7.THyy, 2) + (parameter7.THxx) + (2 * parameter7.THyy);
                parameter7.TFunct[parameter7.i] = Math.Round(parameter7.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter7.THxx, parameter7.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter7.THxx, parameter7.THyy, parameter7.TFunct[parameter7.i]);
            }
            else if (parameter7.bestPoint == parameter7.upperFy)
            {
                parameter7.THxx = 2 * parameter7.xF - parameter7.x;
                parameter7.THyy = 2 * parameter7.uppery - parameter7.y;
                parameter7.THf = 9 * Math.Pow(parameter7.THxx, 2) - (2 * (parameter7.THxx * parameter7.THyy)) + 6 * Math.Pow(parameter7.THyy, 2) + (parameter7.THxx) + (2 * parameter7.THyy);
                parameter7.TFunct[parameter7.i] = Math.Round(parameter7.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter7.THxx, parameter7.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter7.THxx, parameter7.THyy, parameter7.TFunct[parameter7.i]);
            }
            else if (parameter7.bestPoint == parameter7.lowerFy)
            {
                parameter7.THxx = 2 * parameter7.xF - parameter7.x;
                parameter7.THyy = 2 * parameter7.lowery - parameter7.y;
                parameter7.THf = 9 * Math.Pow(parameter7.THxx, 2) - (2 * (parameter7.THxx * parameter7.THyy)) + 6 * Math.Pow(parameter7.THyy, 2) + (parameter7.THxx) + (2 * parameter7.THyy);
                parameter7.TFunct[parameter7.i] = Math.Round(parameter7.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter7.THxx, parameter7.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter7.THxx, parameter7.THyy, parameter7.TFunct[parameter7.i]);
            }

        }
    }
}
