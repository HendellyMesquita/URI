using System;

/*
Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. 
A seguir, calcule e mostre o valor da conta a pagar.

CODIGO      ESPECIFICAÇÃO       PREÇO
----------------------------------------
1           Cachorro Quente     R$ 4.50
2           X-Salada            R$ 4.50
3           X-Bacon             R$ 5.00    
4           Torrada Simples     R$ 2.00
5           Refrigerante        R$ 1.50

Entrada
O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item
conforme tabela acima.

Saída
O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.
 */
namespace Uri_Desafios.Beecrowd_1
{
    class _1038Lanche
    {
        public static void Executar()
        {

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" CODIGO          ESPECIFICAÇÃO           PREÇO  ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("   1             Cachorro Quente         R$ 4.50");
            Console.WriteLine("   2             X - Salada              R$ 4.50");
            Console.WriteLine("   3             X - Bacon               R$ 5.00");
            Console.WriteLine("   4             Torrada Simples         R$ 2.00");
            Console.WriteLine("   5             Refrigerante            R$ 1.50");
            Console.WriteLine();
            Console.WriteLine("Selecione o Pedido e informe a Quantidade");

            string[] entrada = Console.ReadLine().Split(' ');

            int codigo = int.Parse(entrada[0]);
            int quant = int.Parse(entrada[1]);


            switch (codigo)
            {
                case 1:
                    double CachorroQuente = quant * 4.00;
                    Console.WriteLine("Total: R$ " + CachorroQuente.ToString(".00"));
                    break;
                case 2:
                    double XSalada = quant * 4.50;
                    Console.WriteLine("Total: R$ " + XSalada.ToString(".00"));
                    break;
                case 3:
                    double XBacon = quant * 5.00;
                    Console.WriteLine("Total: R$ " + XBacon.ToString(".00"));
                    break;
                case 4:
                    double Torrada = quant * 2.00;
                    Console.WriteLine("Total: R$ " + Torrada.ToString(".00"));
                    break;
                case 5:
                    double Refrigerante = quant * 1.50;
                    Console.WriteLine("Total: R$ " + Refrigerante.ToString(".00"));
                    break;
                default:
                    Console.WriteLine("Valor informado Não e um valor valido. Finalizando...");
                    break;
            }

        }


    }
}
