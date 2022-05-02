using System;

/*
Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. 
Utilize a fórmula: MAIOR AB = (a + b + abs(a - b)) / 2

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b).
Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior". 

 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1013OMaior
    {
        public static void Executar()
        {
            Console.WriteLine("Informe 3 valores: ");
            string[] vet = Console.ReadLine().Split(' ');

            int vA = int.Parse(vet[0]);
            int vB = int.Parse(vet[1]);
            int vC = int.Parse(vet[2]);

            int MAIORAB = (vA + vB + Math.Abs(vA - vB)) / 2;
            int MAIORAC = (vA + vC + Math.Abs(vA - vC)) / 2;


            int MAIOR = Math.Max(MAIORAB, MAIORAC);

           
                Console.WriteLine(MAIOR + " eh o maior");

        }
    }
}
