using System;
using System.Globalization;

/*
 Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. 
Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, 
caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada
Leia três valores de ponto flutuante (double) A, B e C.

Saída
Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular".
Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. 
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1036FormulaDeBhaskara
    {
        public static void Executar()
        {
            Console.WriteLine("Informe as entrada para o calculo de Bhaskara");
            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            double delta = (b * b) - (4 * a * c);
            double raiz = Math.Sqrt(delta);
            var x1 = ((-(b)) + raiz) / (2 * a);
            var x2 = ((-(b)) - raiz) / (2 * a);

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
                return;
            }
            Console.WriteLine("R1 = " + x1.ToString("F5"), CultureInfo.InvariantCulture);
            Console.WriteLine("R2 = " + x2.ToString("F5"), CultureInfo.InvariantCulture);
        }


    }
}
