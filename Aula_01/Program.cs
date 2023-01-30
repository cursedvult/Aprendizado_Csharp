using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco, total;
            int quantidade;
            string descricao;

            Console.Write("Informe a descrição do produto: ");
            descricao = Console.ReadLine();
            Console.Write("\nQuantidade Solicitada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("\nPreço do produto escolhido: ");
            preco = double.Parse(Console.ReadLine());

            total = quantidade * preco;

            Console.WriteLine("\nValor a pagar: " + total);
            Console.ReadKey();
        }
    }
}
