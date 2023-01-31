using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_e_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Bem vindo!");
            Console.ReadKey();
            Console.Write("Se os valores forem iguais, eles serão somados.");
            Console.ReadKey();
            Console.Write("Se os valores forem diferentes, eles serão multiplicados!");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Digite um valor ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor novamente ");
            b = double.Parse(Console.ReadLine());
            if(a == b)
            {
                c = a + b;
                Console.WriteLine("O valor total é de " + c);
            }
            else
            {
                c = a * b;
                Console.WriteLine("O valor total é de " + c);
            }
        }
    }
}
