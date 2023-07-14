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
            
            // 2.0 6.5 4.0 9.0
            string[] notas =  Console.ReadLine().Split(' ');
            double N1, N2, N3, N4;

            N1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            N4 = double.Parse(notas[3], CultureInfo.InvariantCulture);

            double media = Math.Floor(((N1 * 2) + (N2 * 3) + (N3 * 4 )+ (N4 * 1))) / 10 ;
            
            if (media >= 5.0 && media <= 6.9) 
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno em exame.");

                Console.Write("Nota do exame: ");
                double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media = (media + notaExame) / 2;
                if (media > 5.0) Console.WriteLine("Aluno aprovado.");
                if (media <= 4.9) Console.WriteLine("Aluno reprovado.");
                Console.WriteLine($"Media final {media.ToString("F1", CultureInfo.InvariantCulture)}");
                return;
            }

            if (media >= 7.0)
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno reprovado.");
            }
        }

    }

}