using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2;
            string tmp;

            Console.WriteLine("Digite um número: ");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);

            Console.WriteLine("Digite mais um número: ");
            tmp = Console.ReadLine();
            num2 = int.Parse(tmp);

            double resultado;

            //resultado = num1 + num2;
            //Console.WriteLine("Soma: " + resultado);

            somar(num1, num2);

            resultado = num1 - num2;
            Console.WriteLine("Subtração: " + resultado);

            resultado = num1 * num2;
            Console.WriteLine("Multiplicação: " + resultado);

            resultado = num1 / num2;
            Console.WriteLine("Divisão: " + resultado);

            Console.ReadKey();


        }

        static void somar(double num1, double num2) {            
            double resultado;
            resultado = num1 + num2;
            Console.WriteLine("Soma: " + resultado);
        }
    }
}
