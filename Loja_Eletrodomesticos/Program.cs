using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Eletrodomesticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto;
            int parcela;
            double valor, entrada;

            Console.Write("Digite o nome do produto: ");
            produto = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            valor = double.Parse(Console.ReadLine());
            Console.Write("Digite o número de parcelas: ");
            parcela = int.Parse(Console.ReadLine());
                while ( parcela < 1 || parcela > 5)
            {
                Console.Write("O valor das parcelas vão de 1 a 5 apenas");
                ConsoleKeyInfo cki = Console.ReadKey();
                if(cki != null)
                {
                    Console.Clear();
                }
                Console.Write("Digite o número de parcelas: ");
                parcela = int.Parse(Console.ReadLine());

            }
            Console.Write("Digite o valor de entrada: ");
            entrada = double.Parse(Console.ReadLine());

            valor = valor - entrada;
            double valor_parcela = valor / parcela;

            Console.WriteLine("O valor de cada parcela do produto " + produto + "sairá a: " + valor_parcela);
            Console.ReadKey();

        }
    }
}
