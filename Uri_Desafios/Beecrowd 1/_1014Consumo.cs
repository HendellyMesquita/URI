using System;

/*
Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de
combustível gasto (em litros).

Entrada
O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km),
e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

Saída
Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula,
seguido da mensagem "km/l".
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1014Consumo
    {
        public static void Executar()
        {
            Console.Write("distância percorrida: ");
            int distancia = int.Parse(Console.ReadLine());
            Console.Write("combustível gasto: ");
            double combustivel = double.Parse(Console.ReadLine());

            double consumo = distancia / combustivel;

            Console.WriteLine(consumo.ToString("F3") + " km/l");

        }
    }
}
