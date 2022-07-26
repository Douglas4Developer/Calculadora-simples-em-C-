using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora para iniciar com C#

            double numero1, numero2;
            string tmp;

            Console.WriteLine("Digite um número: ");
            tmp = Console.ReadLine();
            numero1 = int.Parse(tmp);

            Console.WriteLine("Digite mais um número: ");
            Console.ReadLine();
            numero2 = int.Parse(tmp);

            double resultado;
            //Fazendo a soma dos numeros digitados e armazenando no resultado
            resultado = numero1 + numero2;
            Console.WriteLine("Soma: " + resultado);

            //Fazendo a subtração dos numeros digitados e armazenando no resultado
            resultado = numero1 - numero2;
            Console.WriteLine("Subtração: " + resultado);

            //Fazendo a Multiplicação dos numeros digitados e armazenando no resultado
            resultado = numero1 * numero2;
            Console.WriteLine("Multiplicação: " + resultado);

             //Fazendo a divisão dos numeros digitados e armazenando no resultado
            resultado = numero1 / numero2;
            Console.WriteLine("Divisão: " + resultado);
        }
    }
}