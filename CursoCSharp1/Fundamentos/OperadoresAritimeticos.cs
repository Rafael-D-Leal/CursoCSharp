using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CursoCSharp1.Fundamentos
{
    internal class OperadoresAritimeticos
    {
        public static void Executar()
        {
            // Preço de Desconto
            //var preco = 1000.0;
            // var imposto = 355;
            // var desconto = 0.1;

            //double total = preco + imposto;
            //var totalComDesconto = total - (total * desconto);
            //Console.WriteLine("O preço final é {0}", totalComDesconto);

            // IMC
            //double peso = 91.2;
            Console.Write("Digite a peso: ");
            double.TryParse(Console.ReadLine(), out double peso);
            //double altura = 1.82;
            Console.Write("Digite a altura: ");
            double.TryParse(Console.ReadLine(), out double altura);
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            // Número Par/Impar

            //int par = 24;
            //int impar = 55;
            //Console.WriteLine("{0}/2 tem o resto {1}", par, par % 2);
            //Console.WriteLine("{0}/2 tem o resto {1}", impar, impar % 2);
        }
    }
}