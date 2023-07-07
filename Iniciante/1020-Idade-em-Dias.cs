using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        int anos = days / 365;
        int meses = days % 365 / 30;
        days = (days % 365) % 30;
        
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{days} dia(s)");
    }
}