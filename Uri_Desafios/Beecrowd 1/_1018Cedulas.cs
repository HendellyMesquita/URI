using System;

/*
Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas)
no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. 
A seguir mostre o valor lido e a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

Saída
Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, 
conforme o exemplo fornecido. 
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1018Cedulas
    {
        public static void Executar()
        {
            int N = int.Parse(Console.ReadLine());

            int resto = N % 100;
            int cem = N / 100;
            int cinquenta = resto / 50;
            int vinte = (resto % 50) / 20;
            int dez = ((resto % 50) % 20) / 10;
            int cinco = (((resto % 50) % 20) % 10) / 5;
            int dois = ((((resto % 50) % 20) % 10) % 5) / 2;
            int um = (((((resto % 50) % 20) % 10) % 5) % 2) / 1;

            Console.WriteLine(N);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");

        }
    }
}
