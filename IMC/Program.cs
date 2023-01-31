using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Insira seu peso em quilos");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua altura em metros");
            altura = double.Parse(Console.ReadLine());

            altura *= altura;
            imc = peso / altura;

            Console.WriteLine("Seu IMC é de " + imc);
            Console.ReadKey();
        }
    }
}
