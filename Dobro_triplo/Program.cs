using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobro_triplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Bem vindo");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Se um número for positivo, calcularemos seu dobro.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Se um número for negativo, calcularemos seu triplo.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Insira um número" + "\n");
            numero = double.Parse(Console.ReadLine());

            if (numero >= 0) 
            {
                numero = numero * 2;
                Console.Write("O número é positivo, e seu total é de " + numero);
                Console.ReadKey();
            }else
            {
                numero = numero * 3;
                Console.Write("O número é negativo, e seu total é de " + numero);
                Console.ReadKey();
            }
        }
    }
}
