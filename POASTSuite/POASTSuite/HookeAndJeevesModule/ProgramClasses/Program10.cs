using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.HookeAndJeevesModule.ProgramClasses
{
    public class Program10
    {
        public static void SolveFx(Parameter10 parameter10)   // the main logic method that is repeated above
        {
            parameter10.x = parameter10.THxx;
            parameter10.y = parameter10.THyy;
            parameter10.upperx = parameter10.x + parameter10.h1;
            parameter10.upperFx = 5 * Math.Pow(parameter10.upperx, 2) - (4 * (parameter10.upperx * parameter10.y)) + 9 * Math.Pow(parameter10.y, 2) + (parameter10.upperx) + (2 * parameter10.y);
            parameter10.lowerx = parameter10.x - parameter10.h1;
            parameter10.lowerFx = 5 * Math.Pow(parameter10.lowerx, 2) - (4 * (parameter10.lowerx * parameter10.y)) + 9 * Math.Pow(parameter10.y, 2) + (parameter10.lowerx) + (2 * parameter10.y);
            parameter10.UpFX[parameter10.i] = Math.Round(parameter10.upperFx, 3);
            parameter10.LowFX[parameter10.i] = Math.Round(parameter10.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter10.upperx, parameter10.y, parameter10.UpFX[parameter10.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter10.lowerx, parameter10.y, parameter10.LowFX[parameter10.i]);

            if (parameter10.upperFx <= parameter10.lowerFx)
            {
                parameter10.xF = parameter10.upperx;
                parameter10.uppery = parameter10.y + parameter10.h2;
                parameter10.upperFy = 5 * Math.Pow(parameter10.xF, 2) - (4 * (parameter10.xF * parameter10.uppery)) + 9 * Math.Pow(parameter10.uppery, 2) + (parameter10.xF) + (2 * parameter10.uppery);
                parameter10.lowery = parameter10.y - parameter10.h1;
                parameter10.lowerFy = 5 * Math.Pow(parameter10.xF, 2) - (4 * (parameter10.xF * parameter10.lowery)) + 9 * Math.Pow(parameter10.lowery, 2) + (parameter10.xF) + (2 * parameter10.lowery);
                parameter10.UpFY[parameter10.i] = Math.Round(parameter10.upperFy, 3);
                parameter10.LowFY[parameter10.i] = Math.Round(parameter10.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter10.xF, parameter10.uppery, parameter10.UpFY[parameter10.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter10.xF, parameter10.lowery, parameter10.LowFY[parameter10.i]);
            }

            else if (parameter10.lowerFx <= parameter10.upperFx)
            {
                parameter10.uppery = parameter10.y + parameter10.h2;
                parameter10.xF = parameter10.lowerx;
                parameter10.upperFy = 5 * Math.Pow(parameter10.xF, 2) - (4 * (parameter10.xF * parameter10.uppery)) + 9 * Math.Pow(parameter10.uppery, 2) + (parameter10.xF) + (2 * parameter10.uppery);
                parameter10.lowery = parameter10.y - parameter10.h2;
                parameter10.lowerFy = 5 * Math.Pow(parameter10.xF, 2) - (4 * (parameter10.xF * parameter10.lowery)) + 9 * Math.Pow(parameter10.lowery, 2) + (parameter10.xF) + (2 * parameter10.lowery);
                parameter10.UpFY[parameter10.i] = Math.Round(parameter10.upperFy, 3);
                parameter10.LowFY[parameter10.i] = Math.Round(parameter10.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter10.xF, parameter10.uppery, parameter10.UpFY[parameter10.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter10.xF, parameter10.lowery, parameter10.LowFY[parameter10.i]);
            }

            parameter10.bestPoint = Math.Min(Math.Min(parameter10.upperFx, parameter10.lowerFx), Math.Min(parameter10.upperFy, parameter10.lowerFy));
            parameter10.Function[parameter10.i] = Math.Round(parameter10.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter10.Function[parameter10.i]);

            // ---temporary head
            if (parameter10.bestPoint == parameter10.upperFx)
            {
                parameter10.THxx = 2 * parameter10.upperx - parameter10.x;
                parameter10.THyy = 2 * parameter10.y - parameter10.y;
                parameter10.THf = 5 * Math.Pow(parameter10.THxx, 2) - (4 * (parameter10.THxx * parameter10.THyy)) + 9 * Math.Pow(parameter10.THyy, 2) + (parameter10.THxx) + (2 * parameter10.THyy);
                parameter10.TFunct[parameter10.i] = Math.Round(parameter10.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter10.THxx, parameter10.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter10.THxx, parameter10.THyy, parameter10.TFunct[parameter10.i]);
            }
            else if (parameter10.bestPoint == parameter10.lowerFx)
            {
                parameter10.THxx = 2 * parameter10.lowerx - parameter10.x;
                parameter10.THyy = 2 * parameter10.y - parameter10.y;
                parameter10.THf = 5 * Math.Pow(parameter10.THxx, 2) - (4 * (parameter10.THxx * parameter10.THyy)) + 9 * Math.Pow(parameter10.THyy, 2) + (parameter10.THxx) + (2 * parameter10.THyy);
                parameter10.TFunct[parameter10.i] = Math.Round(parameter10.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter10.THxx, parameter10.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter10.THxx, parameter10.THyy, parameter10.TFunct[parameter10.i]);
            }
            else if (parameter10.bestPoint == parameter10.upperFy)
            {
                parameter10.THxx = 2 * parameter10.xF - parameter10.x;
                parameter10.THyy = 2 * parameter10.uppery - parameter10.y;
                parameter10.THf = 5 * Math.Pow(parameter10.THxx, 2) - (4 * (parameter10.THxx * parameter10.THyy)) + 9 * Math.Pow(parameter10.THyy, 2) + (parameter10.THxx) + (2 * parameter10.THyy);
                parameter10.TFunct[parameter10.i] = Math.Round(parameter10.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter10.THxx, parameter10.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter10.THxx, parameter10.THyy, parameter10.TFunct[parameter10.i]);
            }
            else if (parameter10.bestPoint == parameter10.lowerFy)
            {
                parameter10.THxx = 2 * parameter10.xF - parameter10.x;
                parameter10.THyy = 2 * parameter10.lowery - parameter10.y;
                parameter10.THf = 5 * Math.Pow(parameter10.THxx, 2) - (4 * (parameter10.THxx * parameter10.THyy)) + 9 * Math.Pow(parameter10.THyy, 2) + (parameter10.THxx) + (2 * parameter10.THyy);
                parameter10.TFunct[parameter10.i] = Math.Round(parameter10.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter10.THxx, parameter10.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter10.THxx, parameter10.THyy, parameter10.TFunct[parameter10.i]);
            }
        }
    }
}
