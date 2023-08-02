using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			if (salario <= 2000)
				Console.WriteLine("Isento");
			else if (salario > 2000 && salario <= 3000)
				Console.WriteLine($"R$ {((salario - 2000) * 0.08).ToString("F2", CultureInfo.InvariantCulture)}");
			else if (salario > 3000 && salario <= 4500)
				Console.WriteLine($"R$ {(80 + (salario - 3000) * 0.18).ToString("F2", CultureInfo.InvariantCulture)}"); // 80 == 1000*0.08
			else
				Console.WriteLine($"R$ {(350 + ((salario - 4500) * 0.28)).ToString("F2", CultureInfo.InvariantCulture)}"); // 350 == (1000*0.08 + 1500*0.18)
        }
    }
}