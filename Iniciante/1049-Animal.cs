using System;
using System.Globalization;

namespace Program;

class Program
{
    static void checkVertebradoType(string animal, string onivoroOuCarnivoro)
	{
		if (animal.ToLower() == "ave")
			if (onivoroOuCarnivoro.ToLower() == "carnivoro")
				Console.WriteLine("aguia");
			else
				Console.WriteLine("pomba");
		if (animal.ToLower() == "mamifero")
			if (onivoroOuCarnivoro.ToLower() == "onivoro")
				Console.WriteLine("homem");
			else
				Console.WriteLine("vaca");
	}

	static void checkInvertebradoType(string animal, string onivoroOuCarnivoro)
	{
		if (animal.ToLower() == "inseto")
			if (onivoroOuCarnivoro.ToLower() == "hematofago")
				Console.WriteLine("pulga");
			else
				Console.WriteLine("lagarta");
		if (animal.ToLower() == "anelideo")
			if (onivoroOuCarnivoro.ToLower() == "onivoro")
				Console.WriteLine("sanguessuga");
			else
				Console.WriteLine("minhoca");
	}

	static void Main(string[] args)
	{
		string esqueleto = Console.ReadLine();
		string animal = Console.ReadLine();
		string onivoroOuCarnivoro = Console.ReadLine();

		if (esqueleto.ToLower() == "vertebrado")
			checkVertebradoType(animal, onivoroOuCarnivoro);
		else
			checkInvertebradoType(animal, onivoroOuCarnivoro);
	}
}