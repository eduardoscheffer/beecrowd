using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main()
        {   
            double x, y;
            string[] points = Console.ReadLine().Split(' ');
            x = double.Parse(points[0], CultureInfo.InvariantCulture); 
            y = double.Parse(points[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo y");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
        }

    }
}