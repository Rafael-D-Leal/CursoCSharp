using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp1.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, " Word!")
                .Replace("World", "Mundo");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string ValorImportante = null;
            Console.WriteLine(ValorImportante?.Length);
        }
    }
}
