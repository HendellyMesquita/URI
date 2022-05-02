using System;
using System.Globalization;
/*
Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes 
intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, 
deverá ser impressa a mensagem “Fora de intervalo”.

O símbolo ( representa "maior que". Por exemplo:
[0,25]  indica valores entre 0 e 25.0000, inclusive eles.
(25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000

Entrada
O arquivo de entrada contém um número com ponto flutuante qualquer.

Saída
A saída deve ser uma mensagem conforme exemplo abaixo.
*/

namespace Uri_Desafios.Beecrowd_1
{
    class _1037Intervalo
    {
        public static void Executar()
        {
            Console.WriteLine("Informe um valor para calcular o intervalo");
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (N >= 0 && N <= 25)
                Console.WriteLine("Intervalo[0,25]");

            else if (N > 25 && N <= 50)
                Console.WriteLine("Intervalo(25,50]");

            else if (N > 50 && N <= 75)
                Console.WriteLine("Intervalo(50,75]");

            else if (N > 75 && N <= 100)
                Console.WriteLine("Intervalo(75,100]");

            else
                Console.WriteLine("Fora de intervalo");

        }
    }
}
