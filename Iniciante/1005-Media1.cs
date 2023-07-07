using System;
using System.Globalization;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       double a = double.Parse(Console.ReadLine());
       double b = double.Parse(Console.ReadLine());
       double media = (((a * 3.5) + (b * 7.5)) / 11);
       
       Console.WriteLine($"MEDIA = {media:0.00000}");
    }
}