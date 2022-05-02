using System;

/*
Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. 
Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.
Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

Entrada
O arquivo de entrada contém um valor inteiro.

Saída
Imprima a saída conforme exemplo fornecido.
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1020IdadeEmDias
    {
        public static void Executar()
        {
            Console.Write("Informe os dias a ser convertidos: ");
            int N = int.Parse(Console.ReadLine());

            int resto = N % 365;
            int ano = N / 365;
            int meses = (resto % 365) / 30;
            int dias = resto % 30;

            Console.WriteLine(ano + "ano(s)");
            Console.WriteLine(meses + "mes(es)");
            Console.WriteLine(dias + "dia(s)");

        }

    }
}
