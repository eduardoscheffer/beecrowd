using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
/*
Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.


10.0 20.1 5.1   	R1 = -0.29788   R2 = -1.71212


0.0 20.0 5.0        Impossivel calcular
*/

class Program
{

    static void CalculateBaskhara(double A, double B, double C) 
    {
        double delta = Math.Pow(B, 2) - 4 * A * C;

        double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
        double x2 = (-B - Math.Sqrt(delta)) / (2 * A);


        if (delta <= 0 || A == 0) Console.WriteLine("Impossivel calcular");

        else
        {

        Console.WriteLine($"R1 = {x1.ToString("F5", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"R2 = {x2.ToString("F5", CultureInfo.InvariantCulture)}");

        }    
    }

    static void Main(string[] args)
    {
        
        double[] inputs = Console.ReadLine().Split(' ').Select(number => double.Parse(number)).ToArray();
        double A = inputs[0];
        double B = inputs[1];
        double C = inputs[2];
        
        
        CalculateBaskhara(A, B, C);
         

    }
}   