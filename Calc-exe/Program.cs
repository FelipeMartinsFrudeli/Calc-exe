using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int soma;
            Console.WriteLine("Digite um numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo numero da soma:");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("\nSeu resultado é:");
            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}

