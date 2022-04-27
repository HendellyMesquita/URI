using System;
using System.Collections.Generic;
using Uri_Desafios.Beecrowd_1;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                {"HELLO WORLD - INICIANTE", _1000HelloWord.Executar},
                {"EXTREMAMENTE BASICO - INICIANTE", _1001ExtremamenteBasico.Executar},
                {"CALCULO DA AREA DE UM CIRCULO - INICIANTE", _1002AreaDoCirculo.Executar},
                {"SOMA SIMPLES - INICIANTE", _1003SomaSimples.Executar},
                {"PRODUTO SIMPLES - INICIANTE", _1004ProdutoSimples.Executar},
                {"MEDIA 1 - INICIANTE", _1005Media1.Executar},
                {"MEDIA 2 - INICIANTE", _1006Media2.Executar},
                {"DIFERENÇA - INICIANTE", _1007Diferenca.Executar},
                {"SALARIO - INICIANTE", _1008Salario.Executar},
                {"SALARIO COM BONUS - INICIANTE", _1009SalarioComBonus.Executar},
            
             
            });

            central.SelecionarEExecutar();
        }
    }
}