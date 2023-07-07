using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double valor = double.Parse(Console.ReadLine()); // 576.73
        
        List<int> notas = new List<int>
        {
            100,
            50,
            20,
            10,
            5,
            2
        };
        
		var moedas = new List<double>
		{
			1.00,
			0.50,
			0.25,
			0.10,
			0.05,
			0.01
		};
        
        // calculo da quantidade de notas:
        Console.WriteLine("NOTAS:");
        foreach (int nota in notas) 
        {
            
            int qtdNota = (int) (valor / nota);
            Console.WriteLine(qtdNota + " nota(s) de R$ " + nota.ToString("0.00"));
            valor = (double) Math.Round(valor % nota, 2);
            
        }
        
        // Console.WriteLine("RESTO: " + valor); // 1.73 quando sai das notas
        
        // calculo da quantidade de moedas:
		Console.WriteLine("MOEDAS:");
        foreach (double moeda in moedas)
		{
			int qtdMoeda = (int) (valor / moeda);
			Console.WriteLine(qtdMoeda + " moeda(s) de R$ " + moeda.ToString("0.00"));
			valor = (double) Math.Round((valor % moeda), 2);
		}
    }
}