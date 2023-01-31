using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total, KWh, quantidade, juros;

            Console.WriteLine("Insira o preço do KWh");
            KWh = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade utilizada");
            quantidade = double.Parse(Console.ReadLine());

            total = KWh * quantidade;
            juros = total * 0.035;
            total = total + (total * 0.035);

            Console.WriteLine("O valor a ser pago é de " + total + " e os juros totalizaram " + juros);
            Console.ReadKey();

            


        }
    }
}
