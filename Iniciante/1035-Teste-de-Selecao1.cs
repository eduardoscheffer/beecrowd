using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
/*
Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

5 6 7 8 - Valores nao aceitos

2 3 2 6 - Valores aceitos
*/

class Program
{

    static void Main(string[] args)
    {
        
        int[] inputs = Console.ReadLine().Split(' ').Select(number => int.Parse(number)).ToArray();
        int A = inputs[0];
        int B = inputs[1];
        int C = inputs[2];
        int D = inputs[3];
        
        string result = ( B > C && D > A && (C + D > A + B) && (C > 0 && D > 0 && A % 2 == 0) ) ? "Valores aceitos": "Valores nao aceitos";
        Console.WriteLine(result);
         

    }
}   