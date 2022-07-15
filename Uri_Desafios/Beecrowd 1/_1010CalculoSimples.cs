using System;

/*
 Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois 
inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após 
os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1010CalculoSimples
    {
        public static void Executar()
        {
            Console.Write("Informe o código do produto, o quantidade, e o valor unitário da primeira remeça: ");
            string peca1 = Console.ReadLine();
            Console.Write("Informe o código do produto, o quantidade, e o valor unitário da segunda remeça: ");
            string peca2 = Console.ReadLine();


            string[] Valores1 = peca1.Split(' ');
            int cod1 = Int32.Parse(Valores1[0]);
            int quant1 = Int32.Parse(Valores1[1]);
            double valor1 = Convert.ToDouble(Valores1[2]);


            string[] Valores2 = peca2.Split(' ');
            int cod2 = Int32.Parse(Valores2[0]);
            int quant2 = Int32.Parse(Valores2[1]);
            double valor2 = Convert.ToDouble(Valores2[2]);


            double total1 = valor1 * quant1;
            double total2 = valor2 * quant2;
            double totalFinal = total1 + total2;

            Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", totalFinal);
        }
    }
}
