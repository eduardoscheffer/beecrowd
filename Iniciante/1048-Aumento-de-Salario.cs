using System;
using System.Globalization;

namespace Program;
class Program
{
	static void Main(string[] args)
	{	
		/* A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
		0 - 400.00 				15%
		400.01 - 800.00			12%
		800.01 - 1200.00		10%
		1200.01 - 2000.00		7%
		Acima de 2000.00		4% 
		Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
		*/

		double salarioColaborador = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		int percentualRaise;
		double salarioReajustado;
		double reajuste;

		if (salarioColaborador >= 0 && salarioColaborador <= 400.00)
		{
			percentualRaise = 15;
			reajuste = ((double)percentualRaise / 100) * salarioColaborador;
			salarioReajustado = salarioColaborador + reajuste;

			Console.WriteLine($"Novo salario: {salarioReajustado.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Em percentual: {percentualRaise} %");
		}
		else if (salarioColaborador >= 400.01 && salarioColaborador <= 800.00)
		{
			percentualRaise = 12;
			reajuste = ((double)percentualRaise / 100) * salarioColaborador;
			salarioReajustado = salarioColaborador + reajuste;

			Console.WriteLine($"Novo salario: {salarioReajustado.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Em percentual: {percentualRaise} %");
		}
		else if (salarioColaborador >= 800.01 && salarioColaborador <= 1200.00)
		{
			percentualRaise = 10;
			reajuste = ((double)percentualRaise / 100) * salarioColaborador;
			salarioReajustado = salarioColaborador + reajuste;

			Console.WriteLine($"Novo salario: {salarioReajustado.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Em percentual: {percentualRaise} %");
		}
		else if (salarioColaborador >= 1200.01 && salarioColaborador <= 2000.00)
		{
			percentualRaise = 7;
			reajuste = ((double)percentualRaise / 100)* salarioColaborador;
			salarioReajustado = salarioColaborador + reajuste;

			Console.WriteLine($"Novo salario: {salarioReajustado.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Em percentual: {percentualRaise} %");
		}
		else if (salarioColaborador > 2000.00)
		{
			percentualRaise = 4;
			reajuste = ((double)percentualRaise / 100) * salarioColaborador;
			salarioReajustado = salarioColaborador + reajuste;

			Console.WriteLine($"Novo salario: {salarioReajustado.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Em percentual: {percentualRaise} %");
		}
	}
}