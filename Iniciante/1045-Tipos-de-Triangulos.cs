using System.Globalization;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Program
{
	class Program
	{

		static void CheckTriangleType(double A, double B, double C)
		{
			if (A >= (B + C)) 
			{
				Console.WriteLine("NAO FORMA TRIANGULO");
				return;
			}
			if (Math.Pow(A, 2) == ( Math.Pow(B, 2) + Math.Pow(C, 2) )) Console.WriteLine("TRIANGULO RETANGULO");
			if (Math.Pow(A, 2) > ( Math.Pow(B, 2) + Math.Pow(C, 2) )) Console.WriteLine("TRIANGULO OBTUSANGULO");
			if (Math.Pow(A, 2) < ( Math.Pow(B, 2) + Math.Pow(C, 2) )) Console.WriteLine("TRIANGULO ACUTANGULO");
			if (A == B && A == C && B == C) Console.WriteLine("TRIANGULO EQUILATERO");
			if ((A == B && A != C) || (A == C && A != B) || (B == C && B != A)) Console.WriteLine("TRIANGULO ISOSCELES");
		}

		static void Main()
		{   
			CultureInfo.CurrentCulture = new CultureInfo("en-US");
			/*
			Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:
			se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
			se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
			se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
			se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
			se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
			se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
			*/

			List<double> valores = Console.ReadLine().Split(' ').Select(val => double.Parse(val)).ToList();
			valores.Sort((x, y) => y.CompareTo(x));

			var A = valores[0];
			var B = valores[1];
			var C = valores[2];

			CheckTriangleType(A, B, C);
			
		}
	}
}