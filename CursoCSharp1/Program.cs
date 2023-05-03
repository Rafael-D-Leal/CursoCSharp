using System;
using System.Collections.Generic;

using CursoCSharp1.Fundamentos;

namespace CursoCSharp1{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", CursoCSharp1.Fundamentos.PrimeiroPrograma.Executar },
                {"Comentários - Fundamentos", Comentários.Executar },
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar }, 
                {"Inferencias - Fundamentos", Inferencia.Executar },
                {"Interpolacao - Fundamentos", Interpolacao.Executar },
                {"Notaçao Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Numero - Fundamentos", FormantandoNumero.Executar },
                {"Conversão - Fundamentos", Conversao.Executar },
                {"Operações Aritméticas - Fundamentos", OperadoresAritimeticos.Executar },
                {"Operadores Relacioanis - Fundamentos", OperadoresRelacionais.Executar  },
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar },



                });

        central.SelecionarEExecutar();
        }
    }
}