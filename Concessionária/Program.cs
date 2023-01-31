using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionária
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int parcelas;
            double valor, entrada, total;
            string modelo;

            Console.Write("Insira o modelo do carro: ");
            modelo = Console.ReadLine();
            Console.Write("Insira o valor do carro: ");
            valor = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor da entrada" + "\n\n" + "(ATENCÃO: O CARRO PODERÁ " +
                "APENAS SER FINANCIADO" + "\n" + "EM ATÉ 50 PARCELAS SE O VALOR DA ENTRADA FOR DE NO MÍNIMO"
                + "\n" +
                "40% O VALOR TOTAL) " + "\n");
            entrada = double.Parse(Console.ReadLine());
            double quarenta_valor = valor * 0.40;
            while (entrada < quarenta_valor)
            {
                Console.Write("O valor deverá ser de no mínimo " + quarenta_valor + "\n");
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki != null)
                {
                    Console.Clear();
                }
                Console.Write("Insira o valor da entrada" + "\n");
                entrada = double.Parse(Console.ReadLine());
            }
            Console.Write("Insira o valor das parcelas, de 1 até 50" + "\n");
            parcelas = int.Parse(Console.ReadLine());

            while (parcelas < 1 || parcelas > 50)
            {
                Console.Write("Por favor, insira um valor válido" + "\n");
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki != null)
                {
                    Console.Clear();
                }
                Console.Write("Insira o valor das parcelas, de 1 até 50" + "\n");
                parcelas = int.Parse(Console.ReadLine());
            }
            valor = valor - entrada;
            total = valor / parcelas;

            Console.WriteLine("O valor de cada parcela do " + modelo + " sairá a " + total + ", totalizando " + parcelas + " parcelas");
            Console.ReadKey();


        }
    }
}
