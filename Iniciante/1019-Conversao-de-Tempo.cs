using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        int sec = int.Parse(Console.ReadLine()); // segundos do usuário. Por ex: 61
        TimeSpan tempo = new TimeSpan(0, 0, sec);

        // int hours = tempo.Hours;
        // if (tempo.Days > 0) hours += (tempo.Days * 24);
        // Utilizando condição ternária:
        int hours = tempo.Days > 0 ? tempo.Hours + (tempo.Days * 24): tempo.Hours; // se o tempo der mais de um dia, converte o dia pra horas e soma nas horas do timespan (tempo.Hours + (tempo.days * 24));


        Console.WriteLine($"{hours}:{tempo.Minutes}:{tempo.Seconds}");
        

    }
}   