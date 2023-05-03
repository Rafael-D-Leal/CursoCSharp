using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp1.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("area é" + area);

            // Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Esta Chovendo" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade é" + idade);

            SByte saldoDeGols = sbyte.MinValue;
                //Byte com sinal atras ou seja -1 por exemplo
                Console.WriteLine("Saldo de Gols" + saldoDeGols);

            short Salario = short.MaxValue;
            Console.WriteLine("Salário" + Salario);

            int menorValorInt = int.MinValue; // Mais usadi dos inteiros
            Console.WriteLine("Menor Valor Int" + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira" + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor Long" + menorValorInt);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial" + populacaoBrasileira);

            float precoComputador = 1299.99f;
            Console.WriteLine("Computador $" + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor Apple $" + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancias entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra" + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
