using System;

namespace AreaOfTriangle
{
    internal static class AreaOfTriangle
    {
        public static void Main(string[] args)
        {
            var sideLengths = ReadInput();

            var sideOne = sideLengths[0];
            var sideTwo = sideLengths[1];
            var sideThree = sideLengths[2];

            var s = (sideOne + sideTwo + sideThree) / 2;
            var ans = Math.Sqrt((s - sideOne) * (s - sideTwo) * (s - sideThree) * s);
            Console.WriteLine("The area of your triangle is {0} squares metres", ans);
        }

        private static double[] ReadInput()
        {
            var sides = new double[3];
            
            Console.WriteLine("Please input the 3 lengths of your triangle in Metres");
            Console.Write("What is the length of one side? ");

            var inputInvalid = true;
            while (inputInvalid)
            {
                if (double.TryParse(Console.ReadLine(), out sides[0]))
                {
                    inputInvalid = false;
                }
                else
                {
                    Console.Write("Please input a valid number: ");
                }
            }
            Console.Write("What is the length of the next side? "); 
            inputInvalid = true;
            while (inputInvalid)
            {
                if (double.TryParse(Console.ReadLine(), out sides[1]))
                {
                    inputInvalid = false;
                }
                else
                {
                    Console.Write("Please input a valid number: ");
                }
            }
            Console.Write("What is the length of the last side? "); 
            inputInvalid = true;
            while (inputInvalid)
            {
                if (double.TryParse(Console.ReadLine(), out sides[2]))
                {
                    inputInvalid = false;
                }
                else
                {
                    Console.Write("Please input a valid number: ");
                }
            }

            return sides;
        }
    }
}