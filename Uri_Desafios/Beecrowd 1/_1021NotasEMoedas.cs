using System;
using System.Globalization;

/*
Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, 
calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. 
As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. 
A seguir mostre a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

Saída
Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

Obs: Utilize ponto (.) para separar a parte decimal.
 */

namespace Uri_Desafios.Beecrowd_1
{

    class _1021NotasEMoedas
    {
        public static void Executar()
        {

            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int resto, nota, moeda, calculo;
            resto = (int)(N * 100 + 0.5);

            Console.WriteLine("NOTAS:");

            nota = 100;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ 100.00");
            resto = resto % (nota * 100);

            nota = 50;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ 50.00");
            resto = resto % (nota * 100);

            nota = 20;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ 20.00");
            resto = resto % (nota * 100);

            nota = 10;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ 10.00");
            resto = resto % (nota * 100);

            nota = 5;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ 5.00");
            resto = resto % (nota * 100);

            nota = 2;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ 2.00");
            resto = resto % (nota * 100);


            Console.WriteLine("MOEDAS:");

            moeda = 100;
            calculo = resto / moeda;
            Console.WriteLine(calculo + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            calculo = resto / moeda;
            Console.WriteLine(calculo + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            calculo = resto / moeda;
            Console.WriteLine(calculo + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            calculo = resto / moeda;
            Console.WriteLine(calculo + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            calculo = resto / moeda;
            Console.WriteLine(calculo + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            moeda = 1;
            calculo = resto / moeda;
            Console.WriteLine(calculo + " moeda(s) de R$ 0.01");

        }
    }
}
