using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        int valor = int.Parse(Console.ReadLine()); // 120

        List<int> cedulas = new List<int> {100, 50, 20, 10, 5, 2, 1};
        Console.WriteLine(valor);

        foreach (int cedula in cedulas)
        {
            int qtdCedula = valor / cedula;
            
            Console.WriteLine($"{qtdCedula} nota(s) de R$ {cedula},00");
            valor = valor % cedula;
        }

    }
}   