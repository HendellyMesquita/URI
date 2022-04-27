using System;

/*
 Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

Entrada
O arquivo de entrada contém 4 valores inteiros.

Saída
Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1007Diferenca
    {
        public static void Executar()
        {
            Console.Write("Primeiro Valor: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Terceiro Valor: ");
            int C = int.Parse(Console.ReadLine());
            Console.Write("Quarto Valor: ");
            int D = int.Parse(Console.ReadLine());

            int DIFERENCA = (A * B - C * D);
            Console.WriteLine("DIFERENCA = " + DIFERENCA);


        }
    }
}
