using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.HookeAndJeevesModule.ProgramClasses
{
   public class Program3
    {
        public static void SolveFx(Parameter3 parameter3)   // the main logic method that is repeated above
        {
            parameter3.x = parameter3.THx;
            parameter3.y = parameter3.THy;
            parameter3.upperx = parameter3.x + parameter3.h1;
            parameter3.upperFx = Math.Pow(parameter3.upperx, 2) - (4 * (parameter3.upperx * parameter3.y)) + 3 * Math.Pow(parameter3.y, 2) + (2 * parameter3.upperx) + (parameter3.y);
            parameter3.lowerx = parameter3.x - parameter3.h1;
            parameter3.lowerFx = Math.Pow(parameter3.lowerx, 2) - (4 * (parameter3.lowerx * parameter3.y)) + 3 * Math.Pow(parameter3.y, 2) + (2 * parameter3.lowerx) + (parameter3.y);
            parameter3.UpFX[parameter3.i] = Math.Round(parameter3.upperFx, 3);
            parameter3.LowFX[parameter3.i] = Math.Round(parameter3.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter3.upperx, parameter3.y, parameter3.UpFX[parameter3.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter3.lowerx, parameter3.y, parameter3.LowFX[parameter3.i]);

            if (parameter3.upperFx <= parameter3.lowerFx)
            {
                parameter3.xF = parameter3.upperx;
                parameter3.uppery = parameter3.y + parameter3.h2;
                parameter3.upperFy = Math.Pow(parameter3.xF, 2) - (4 * (parameter3.xF * parameter3.uppery)) + 3 * Math.Pow(parameter3.uppery, 2) + (2 * parameter3.xF) + (parameter3.uppery);
                parameter3.lowery = parameter3.y - parameter3.h1;
                parameter3.lowerFy = Math.Pow(parameter3.xF, 2) - (4 * (parameter3.xF * parameter3.lowery)) + 3 * Math.Pow(parameter3.lowery, 2) + (2 * parameter3.xF) + (parameter3.lowery);
                parameter3.UpFY[parameter3.i] = Math.Round(parameter3.upperFy, 3);
                parameter3.LowFY[parameter3.i] = Math.Round(parameter3.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter3.xF, parameter3.uppery, parameter3.UpFY[parameter3.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter3.xF, parameter3.lowery, parameter3.LowFY[parameter3.i]);
            }

            else if (parameter3.lowerFx <= parameter3.upperFx)
            {
                parameter3.uppery = parameter3.y + parameter3.h2;
                parameter3.xF = parameter3.lowerx;
                parameter3.upperFy = Math.Pow(parameter3.xF, 2) - (4 * (parameter3.xF * parameter3.uppery)) + 3 * Math.Pow(parameter3.uppery, 2) + (2 * parameter3.xF) + (parameter3.uppery);
                parameter3.lowery = parameter3.y - parameter3.h2;
                parameter3.lowerFy = Math.Pow(parameter3.xF, 2) - (4 * (parameter3.xF * parameter3.lowery)) + 3 * Math.Pow(parameter3.lowery, 2) + (2 * parameter3.xF) + (parameter3.lowery);
                parameter3.UpFY[parameter3.i] = Math.Round(parameter3.upperFy, 3);
                parameter3.LowFY[parameter3.i] = Math.Round(parameter3.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter3.xF, parameter3.uppery, parameter3.UpFY[parameter3.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter3.xF, parameter3.lowery, parameter3.LowFY[parameter3.i]);
            }

            parameter3.bestPoint = Math.Min(Math.Min(parameter3.upperFx, parameter3.lowerFx), Math.Min(parameter3.upperFy, parameter3.lowerFy));
            parameter3.Function[parameter3.i] = Math.Round(parameter3.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter3.Function[parameter3.i]);

            // ---temporary head
            if (parameter3.bestPoint == parameter3.upperFx)
            {
                parameter3.THx = 2 * parameter3.upperx - parameter3.x;
                parameter3.THy = 2 * parameter3.y - parameter3.y;
                parameter3.THf = Math.Pow(parameter3.THx, 2) - (4 * (parameter3.THx * parameter3.THy)) + 3 * Math.Pow(parameter3.THy, 2) + (2 * parameter3.THx) + (parameter3.THy);
                parameter3.TFunct[parameter3.i] = Math.Round(parameter3.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter3.THx, parameter3.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter3.THx, parameter3.THy, parameter3.TFunct[parameter3.i]);
            }
            else if (parameter3.bestPoint == parameter3.lowerFx)
            {
                parameter3.THx = 2 * parameter3.lowerx - parameter3.x;
                parameter3.THy = 2 * parameter3.y - parameter3.y;
                parameter3.THf = Math.Pow(parameter3.THx, 2) - (4 * (parameter3.THx * parameter3.THy)) + 3 * Math.Pow(parameter3.THy, 2) + (2 * parameter3.THx) + (parameter3.THy);
                parameter3.TFunct[parameter3.i] = Math.Round(parameter3.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter3.THx, parameter3.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter3.THx, parameter3.THy, parameter3.TFunct[parameter3.i]);
            }
            else if (parameter3.bestPoint == parameter3.upperFy)
            {
                parameter3.THx = 2 * parameter3.xF - parameter3.x;
                parameter3.THy = 2 * parameter3.uppery - parameter3.y;
                parameter3.THf = Math.Pow(parameter3.THx, 2) - (4 * (parameter3.THx * parameter3.THy)) + 3 * Math.Pow(parameter3.THy, 2) + (2 * parameter3.THx) + (parameter3.THy);
                parameter3.TFunct[parameter3.i] = Math.Round(parameter3.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter3.THx, parameter3.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter3.THx, parameter3.THy, parameter3.TFunct[parameter3.i]);
            }
            else if (parameter3.bestPoint == parameter3.lowerFy)
            {
                parameter3.THx = 2 * parameter3.xF - parameter3.x;
                parameter3.THy = 2 * parameter3.lowery - parameter3.y;
                parameter3.THf = Math.Pow(parameter3.THx, 2) - (4 * (parameter3.THx * parameter3.THy)) + 3 * Math.Pow(parameter3.THy, 2) + (2 * parameter3.THx) + (parameter3.THy);
                parameter3.TFunct[parameter3.i] = Math.Round(parameter3.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter3.THx, parameter3.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter3.THx, parameter3.THy, parameter3.TFunct[parameter3.i]);
            }
        }
    }
}
