using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace ProgramaTeste;

class Program
{

    static void Main(string[] args)
    {
        int[] inputs = Console.ReadLine().Split(' ').Select(number => int.Parse(number)).ToArray(); // 3 2

        IDictionary<int, Produto> cardapio = new Dictionary<int, Produto>()
        {
            { 1, new Produto("Cachorro-Quente", 4.00) },
            { 2, new Produto("X-Salada", 4.50) },
            { 3, new Produto("X-Bacon", 5.00) },
            { 4, new Produto("Torrada-Simples", 2.00) },
            { 5, new Produto("Refrigerante", 1.50) }

        };

        List<Produto> comanda = new List<Produto>();

        
        comanda.Add( cardapio[ inputs[0] ] ); // adiciona na comanda o produto com base na chave da Dictionary

        // comanda.Add( cardapio[ inputs[1] ] );

        double totalComanda = 0.00;

        foreach (Produto produto in comanda)
        {
            Console.WriteLine($"{produto.Name}: {produto.Valor.ToString("C2")}  Quantidade: {inputs[1]}");
            totalComanda += produto.Valor * inputs[1];
        }

        Console.WriteLine("TOTAL: " + totalComanda.ToString("C2"), CultureInfo.InvariantCulture);
        
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