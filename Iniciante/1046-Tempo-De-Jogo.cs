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
			Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
			16 2	O JOGO DUROU 10 HORA(S)
			*/
			CultureInfo.CurrentCulture = new CultureInfo("en-US");

			List<string> valores = Console.ReadLine().Split(' ').ToList();
			int A = int.Parse(valores[0]);
			var B = int.Parse(valores[1]);
			
			if (B <= A)
				Console.WriteLine($"O JOGO DUROU {(B + 24) - A} HORA(S)");
			else
				Console.WriteLine($"O JOGO DUROU {(B - A)} HORA(S)");

		}
	}
}