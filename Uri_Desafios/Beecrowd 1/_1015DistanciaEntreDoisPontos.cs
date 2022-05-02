using System;

/*
Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano,
p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, 
segundo a fórmula:
             ________________________
Distancia =\/ (x2 -x1)² + (y2 -y1)²

Entrada
O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de 
ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

Saída
Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1015DistanciaEntreDoisPontos
    {
        public static void Executar()
        {
            Console.Write("Valores ponto 1: ");
            string valorPonto1 = Console.ReadLine();
            Console.Write("Valores ponto 2: ");
            string valorPonto2 = Console.ReadLine();

            string[] ponto1 = valorPonto1.Split(' ');
            double x1 = Convert.ToDouble(ponto1[0]);
            double y1 = Convert.ToDouble(ponto1[1]);

            string[] ponto2 = valorPonto2.Split(' ');
            double x2 = Convert.ToDouble(ponto2[0]);
            double y2 = Convert.ToDouble(ponto2[1]);

            double distancia = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}
