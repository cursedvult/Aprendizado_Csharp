using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurosCompostos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capital, montante, juros, total_juros;
            int tempo;

            Console.WriteLine("Insira o valor do capital a ser aplicado: ");
            capital = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o tempo que vai deixar o capital acumulando: ");
            tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a taxa de juros compostos :");
            juros = double.Parse(Console.ReadLine());

            montante = capital * Math.Pow((1 + (juros/100)), tempo);
            total_juros = montante - capital;

            Console.WriteLine("O montante será de " + montante + " reais e o total dos juros foi de " + total_juros + " reais");
            Console.ReadKey();
        }
    }
}
