using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{	
		Dictionary<int, string> destinations = new Dictionary<int, string>()
		{
			{ 61, "Brasilia" },
			{ 71, "Salvador" },
			{ 11, "Sao Paulo" },
			{ 21, "Rio de Janeiro" },
			{ 32, "Juiz de Fora" },
			{ 19, "Campinas" },
			{ 27, "Vitoria" },
			{ 31, "Belo Horizonte" }
		};

		var DDD = int.Parse(Console.ReadLine());

		if (!destinations.ContainsKey(DDD))
			Console.WriteLine("DDD nao cadastrado");
		else
			Console.WriteLine(destinations.GetValueOrDefault(DDD));
        
        // FAZ A MESMA COISA:
		// foreach (var destination in destinations)
		// {
		// 	if (destination.Key != DDD)
		// 		continue;
		// 	if (destination.Key == DDD)
		// 		Console.WriteLine(destination.Value);
		// }
	}
}