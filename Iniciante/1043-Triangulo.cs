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
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if ( ((A + B) > C) && ((A + C) > B) && ((B + C) > A) )
            {
                double perimeter = A + B + C;
                Console.WriteLine($"Perimetro = {perimeter.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                double area = 0.5*(A+B)*C;
                Console.WriteLine($"Area = {area.ToString("F1", CultureInfo.InvariantCulture)}");
            }

        }

    }
}