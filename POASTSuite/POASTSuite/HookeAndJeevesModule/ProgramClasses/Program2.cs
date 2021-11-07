using POASTSuite.HookeAndJeevesModule.ParameterClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace POASTSuite.HookeAndJeevesModule.ProgramClasses
{
   public class Program2
    {
        public static void SolveFx(Parameter2 parameter2)   // the main logic method that is repeated above
        {
            parameter2.x = parameter2.THx;
            parameter2.y = parameter2.THy;
            parameter2.upperx = parameter2.x + parameter2.h1;
            parameter2.upperFx = 5 * Math.Pow(parameter2.upperx, 2) - (3 * (parameter2.upperx * parameter2.y)) + 6 * Math.Pow(parameter2.y, 2) + (parameter2.upperx) + (2 * parameter2.y);
            parameter2.lowerx = parameter2.x - parameter2.h1;
            parameter2.lowerFx = 5 * Math.Pow(parameter2.lowerx, 2) - (3 * (parameter2.lowerx * parameter2.y)) + 6 * Math.Pow(parameter2.y, 2) + (parameter2.lowerx) + (2 * parameter2.y);
            parameter2.UpFX[parameter2.i] = Math.Round(parameter2.upperFx, 3);
            parameter2.LowFX[parameter2.i] = Math.Round(parameter2.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter2.upperx, parameter2.y, parameter2.UpFX[parameter2.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter2.lowerx, parameter2.y, parameter2.LowFX[parameter2.i]);

            if (parameter2.upperFx <= parameter2.lowerFx)
            {
                parameter2.xF = parameter2.upperx;
                parameter2.uppery = parameter2.y + parameter2.h2;
                parameter2.upperFy = 5 * Math.Pow(parameter2.xF, 2) - (3 * (parameter2.xF * parameter2.uppery)) + 6 * Math.Pow(parameter2.uppery, 2) + (parameter2.xF) + (2 * parameter2.uppery);
                parameter2.lowery = parameter2.y - parameter2.h1;
                parameter2.lowerFy = 5 * Math.Pow(parameter2.xF, 2) - (3 * (parameter2.xF * parameter2.lowery)) + 6 * Math.Pow(parameter2.lowery, 2) + (parameter2.xF) + (2 * parameter2.lowery);
                parameter2.UpFY[parameter2.i] = Math.Round(parameter2.upperFy, 3);
                parameter2.LowFY[parameter2.i] = Math.Round(parameter2.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter2.xF, parameter2.uppery, parameter2.UpFY[parameter2.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter2.xF, parameter2.lowery, parameter2.LowFY[parameter2.i]);
            }

            else if (parameter2.lowerFx <= parameter2.upperFx)
            {
                parameter2.uppery = parameter2.y + parameter2.h2;
                parameter2.xF = parameter2.lowerx;
                parameter2.upperFy = 5 * Math.Pow(parameter2.xF, 2) - (3 * (parameter2.xF * parameter2.uppery)) + 6 * Math.Pow(parameter2.uppery, 2) + (parameter2.xF) + (2 * parameter2.uppery);
                parameter2.lowery = parameter2.y - parameter2.h2;
                parameter2.lowerFy = 5 * Math.Pow(parameter2.xF, 2) - (3 * (parameter2.xF * parameter2.lowery)) + 6 * Math.Pow(parameter2.lowery, 2) + (parameter2.xF) + (2 * parameter2.lowery);
                parameter2.UpFY[parameter2.i] = Math.Round(parameter2.upperFy, 3);
                parameter2.LowFY[parameter2.i] = Math.Round(parameter2.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter2.xF, parameter2.uppery, parameter2.UpFY[parameter2.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter2.xF, parameter2.lowery, parameter2.LowFY[parameter2.i]);
            }

            parameter2.bestPoint = Math.Min(Math.Min(parameter2.upperFx, parameter2.lowerFx), Math.Min(parameter2.upperFy, parameter2.lowerFy));
            parameter2.Function[parameter2.i] = Math.Round(parameter2.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter2.Function[parameter2.i]);

            // ---temporary head
            if (parameter2.bestPoint == parameter2.upperFx)
            {
                parameter2.THx = 2 * parameter2.upperx - parameter2.x;
                parameter2.THy = 2 * parameter2.y - parameter2.y;
                parameter2.THf = 5 * Math.Pow(parameter2.THx, 2) - (3 * (parameter2.THx * parameter2.THy)) + 6 * Math.Pow(parameter2.THy, 2) + (parameter2.THx) + (2 * parameter2.THy);
                parameter2.TFunct[parameter2.i] = Math.Round(parameter2.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter2.THx, parameter2.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter2.THx, parameter2.THy, parameter2.TFunct[parameter2.i]);
            }
            else if (parameter2.bestPoint == parameter2.lowerFx)
            {
                parameter2.THx = 2 * parameter2.lowerx - parameter2.x;
                parameter2.THy = 2 * parameter2.y - parameter2.y;
                parameter2.THf = 5 * Math.Pow(parameter2.THx, 2) - (3 * (parameter2.THx * parameter2.THy)) + 6 * Math.Pow(parameter2.THy, 2) + (parameter2.THx) + (2 * parameter2.THy);
                parameter2.TFunct[parameter2.i] = Math.Round(parameter2.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter2.THx, parameter2.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter2.THx, parameter2.THy, parameter2.TFunct[parameter2.i]);
            }
            else if (parameter2.bestPoint == parameter2.upperFy)
            {
                parameter2.THx = 2 * parameter2.xF - parameter2.x;
                parameter2.THy = 2 * parameter2.uppery - parameter2.y;
                parameter2.THf = 5 * Math.Pow(parameter2.THx, 2) - (3 * (parameter2.THx * parameter2.THy)) + 6 * Math.Pow(parameter2.THy, 2) + (parameter2.THx) + (2 * parameter2.THy);
                parameter2.TFunct[parameter2.i] = Math.Round(parameter2.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter2.THx, parameter2.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter2.THx, parameter2.THy, parameter2.TFunct[parameter2.i]);
            }
            else if (parameter2.bestPoint == parameter2.lowerFy)
            {
                parameter2.THx = 2 * parameter2.xF - parameter2.x;
                parameter2.THy = 2 * parameter2.lowery - parameter2.y;
                parameter2.THf = 5 * Math.Pow(parameter2.THx, 2) - (3 * (parameter2.THx * parameter2.THy)) + 6 * Math.Pow(parameter2.THy, 2) + (parameter2.THx) + (2 * parameter2.THy);
                parameter2.TFunct[parameter2.i] = Math.Round(parameter2.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter2.THx, parameter2.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter2.THx, parameter2.THy, parameter2.TFunct[parameter2.i]);
            }

        }
    }
}

