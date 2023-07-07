using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double n = 3.14159;
        
        double r = double.Parse(Console.ReadLine());
        
        double area = n * r * r;
        
        Console.WriteLine($"A={area:0.0000}");

    }

}