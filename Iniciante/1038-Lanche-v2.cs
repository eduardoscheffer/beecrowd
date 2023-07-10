using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace ProgramaTeste;

class Program
{

    static void Main(string[] args)
    {
        IDictionary<int, Produto> cardapio = new Dictionary<int, Produto>()
        {
            { 1, new Produto("Cachorro-Quente", 4.00) },
            { 2, new Produto("X-Salada", 4.50) },
            { 3, new Produto("X-Bacon", 5.00) },
            { 4, new Produto("Torrada-Simples", 2.00) },
            { 5, new Produto("Refrigerante", 1.50) }

        };

        List<Produto> comanda = new List<Produto>();
        List<int> quantidades = new List<int>();

        double totalComanda = 0.00;

        while (true)
        {   
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------CARDAPIO---------------------------------------------------------------");
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine(" |Cachorro-Quente = R$ 4,00|  |X-Salada = R$ 4,50|  |X-Bacon = R$ 5,00|   |Torrada-Simples = R$ 2,00|   |Refrigerante = R$ 1,50|");
            Console.ResetColor();
            Console.WriteLine("________________________________________________________________________________________________________________________________");
            Console.WriteLine();

            Console.WriteLine("Selecione o que deseja fazer");
            Console.Write("1 - Adicionar Lanche no Carrinho       2 - Finalizar Compra");
            Console.WriteLine();

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 2)
            {   
                Console.WriteLine("Saindo...");
                Console.WriteLine();
                Thread.Sleep(2000);
                break;
            }

            if (opcao == 1)
            {
                Console.WriteLine("Escolha qual lanche deseja comprar:");
                Console.Write("1 - Cachorro-Quente      2 - X-Salada        3 - X-Bacon     4 - Torrada-Simples     5 - Refrigerante");
                Console.WriteLine();

                opcao = int.Parse(Console.ReadLine());

                comanda.Add( cardapio[opcao] );

                Console.Write("Quantidade: ");
                int qtd = int.Parse(Console.ReadLine());

                quantidades.Add(qtd);

                totalComanda += cardapio[opcao].Valor * qtd;

                Console.WriteLine("Produto Adicionado ao carrinho!");
            }


        }

        Console.ForegroundColor = System.ConsoleColor.Yellow;
        Console.WriteLine("---SEU CARRINHO---");
        Console.ResetColor();

        for (int i = 0; i < comanda.Count; i++)
        {
            Console.WriteLine($"{quantidades[i]}    {comanda[i].Name}");
        }


        Console.ForegroundColor = System.ConsoleColor.Red;
        Console.WriteLine("TOTAL: " + totalComanda.ToString("C2"), CultureInfo.InvariantCulture);
        Console.ResetColor();
        
    }

}

class Produto
{
    public string Name { get; private set; }
    public double Valor { get; private set; }

    // construtor do Produto
    public Produto(string nome, double valor)
    {
        if (!string.IsNullOrWhiteSpace(nome) && double.IsPositive(valor))
        {
            Name = nome.Trim();
            Valor = valor;
        }
    }

    // Atualiza o nome do Produto
    public void SetName(string nome)
    {
        if (!string.IsNullOrWhiteSpace(nome))
        {
            Name = nome;
        }
    }

    // Atualiza o valor
    public void SetValue(double valor)
    {
        if (double.IsPositive(valor))
            Valor = valor;
        else
            Console.WriteLine("Valor deve ser positivo");
    }
}   