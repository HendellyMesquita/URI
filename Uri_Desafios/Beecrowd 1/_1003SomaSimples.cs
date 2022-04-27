using System;

/*
 Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA. A seguir escrever o valor desta variável.

Entrada
O arquivo de entrada contém 2 valores inteiros.

Saída
Imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade seguido pelo valor correspondente à soma de A e B. 
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1003SomaSimples
    {
        public static void Executar()
        {
            Console.Write("Primeiro Valor: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            int B = int.Parse(Console.ReadLine());

            int SOMA = A + B;
            Console.WriteLine("SOMA = " + SOMA);


        }
    }
}
