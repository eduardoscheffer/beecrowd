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
            List<int> valores = Console.ReadLine().Split(' ').Select(val => int.Parse(val)).ToList();
            List<int> valoresIniciais = new List<int>
            {
                valores[0],
                valores[1],
                valores[2]
            };

            valores.Sort();
            foreach (var val in valores)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine();

            foreach (var val in valoresIniciais)
            {
                Console.WriteLine(val);
            }
        }

    }
}