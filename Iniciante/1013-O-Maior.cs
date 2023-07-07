using System;
using System.Globalization;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        List<double> valores = new List<double>();
        
        foreach (string val in inputs) 
        {
            valores.Add( double.Parse(val) );
            
        }
        
        double biggest = 0.00;
        foreach (double val in valores)
        {
            if (val > biggest) biggest = val;
        }
        
        Console.WriteLine($"{biggest} eh o maior");
        
    }
}