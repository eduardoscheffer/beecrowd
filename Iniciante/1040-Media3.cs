using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using c_sharp_completo_poo.enumeracoesEComposicoes.exercicioTeste.Entities;
using c_sharp_completo_poo.enumeracoesEComposicoes.exercicioTeste.Entities.Enums;

namespace Programa;

class Program
{
    static void Main()
    {
        List<double> notas =  Console.ReadLine().Split(' ').Select(num => double.Parse(num)).ToList();
        double[] pesos = { 2.0, 3.0, 4.0, 1.0 };

        double media = ((notas[0] * pesos[0]) + (notas[1] * pesos[1]) + (notas[2] * pesos[2] )+ (notas[3] * pesos[3])) / pesos.Sum() ;
        bool aprovado;
        aprovado = media >= 7.0 ? true: false;

        if (media >= 5.0 && media <= 6.9) 
        {
            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno em exame.");

            Console.Write("Nota do exame: ");
            double notaExame = double.Parse(Console.ReadLine());
            media = (media + notaExame) / 2;
            if (media > 5.0) Console.WriteLine("Aluno aprovado.");
            if (media <= 4.9) Console.WriteLine("Aluno reprovado.");
            Console.WriteLine($"Media final {media.ToString("F1", CultureInfo.InvariantCulture)}");
        }

        if (aprovado)
        {
            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno aprovado.");
        }
        
            

    }

    
}

