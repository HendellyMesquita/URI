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
                {"CALCULO SIMPLES - INICIANTE", _1010CalculoSimples.Executar},
                {"ESFERA - INICIANTE", _1011Esfera.Executar},
                {"AREA - INICIANTE", _1012Area.Executar},
                {"OMAIOR - INICIANTE", _1013OMaior.Executar},
                {"CONSUMO - INICIANTE", _1014Consumo.Executar},
                {"DISTANCIA ENTRE DOIS PONTOS - INICIANTE", _1015DistanciaEntreDoisPontos.Executar},
                {"DISTANCIA - INICIANTE", _1016Distancia.Executar},
                {"GASTO COMBUSTIVEL - INICIANTE", _1017GastodeCombustivel.Executar},
                {"CEDULAS - INICIANTE", _1018Cedulas.Executar},
                {"CONVERSAO DE TEMPO - INICIANTE", _1019ConversaoDeTempo.Executar},
                {"IDADE EM DIAS - INICIANTE", _1020IdadeEmDias.Executar},
                {"NOTAS E MOEAS - INICIANTE", _1021NotasEMoedas.Executar},
                {"TESTE DE SELEÇÃO 1 - INICIANTE", _1035TesteDeSelecao1.Executar},
                {"FORMULA DE BHASKARA - INICIANTE", _1036FormulaDeBhaskara.Executar},
                {"INTERVALO - INICIANTE", _1037Intervalo.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}