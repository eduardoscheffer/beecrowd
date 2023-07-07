using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int number = int.Parse(Console.ReadLine());
        int hoursWorked = int.Parse(Console.ReadLine());
        double amountPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"NUMBER = {number}");
        Console.WriteLine($"SALARY = U$ {(hoursWorked * amountPerHour):0.00}");

    }

}