using System;

/*
 Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
A seguir mostre a variável PROD com mensagem correspondente.   

Entrada
O arquivo de entrada contém 2 valores inteiros.

Saída
Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.”.
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1004ProdutoSimples
    {
        public static void Executar()
        {
            Console.Write("Primeiro Valor: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            int B = int.Parse(Console.ReadLine());

            int PROD = A * B;
            Console.WriteLine("PROD = " + PROD);


        }
    }
}
