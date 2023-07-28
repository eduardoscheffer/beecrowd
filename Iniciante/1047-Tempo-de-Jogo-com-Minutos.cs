using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Program
{
	class Program
	{
		static void Main()
		{   
			/*
			Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.
			Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.
			*/
			CultureInfo.CurrentCulture = new CultureInfo("en-US");

			List<string> valores = Console.ReadLine().Split(' ').ToList();
		
			var tempoInicial = new TimeSpan(int.Parse(valores[0]), int.Parse(valores[1]), 0);
			var tempoFinal = new TimeSpan(int.Parse(valores[2]), int.Parse(valores[3]), 0);
			
			if (tempoFinal < tempoInicial)
			{	
				tempoFinal = tempoFinal.Add(new TimeSpan(0, 24, 0, 0));
			}
			if (tempoFinal == tempoInicial)
				Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
			
			else
			{
				TimeSpan intervalo = tempoFinal.Subtract(tempoInicial);

				Console.WriteLine($"O JOGO DUROU {intervalo.Hours} HORA(S) E {intervalo.Minutes} MINUTO(S)");
			}
		}
	}
}