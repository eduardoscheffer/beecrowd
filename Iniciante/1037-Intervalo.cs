using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        
        double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // Console.WriteLine(val);
        
        if (val >= 0.00 && val <= 25.00)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (val > 25.00 && val <= 50.00)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (val > 50.00 && val <= 75.00)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (val > 75.00 && val <= 100.00)
        {
            Console.WriteLine("Intervalo (75,100]");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }


    }
}   