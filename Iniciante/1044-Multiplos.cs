using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) { 

        List<int> valores = Console.ReadLine().Split(' ').Select(val => int.Parse(val)).ToList();
		string message = (valores[1] % valores[0] == 0 || valores[0] % valores[1] == 0) ? "Sao Multiplos": "Nao sao Multiplos";
		Console.WriteLine(message);

    }

}