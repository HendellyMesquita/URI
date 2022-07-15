using System;
using System.Collections.Generic;
using System.Globalization;
/*
Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente,
uma linha em branco e em seguida, os valores na sequência como foram lidos.
*/
namespace Uri_Desafios.Beecrowd_1
{
    internal class _1042SortSimples
    {
        public static void Executar()
        {

            Console.WriteLine("Valores de Entrada: ");
            string[] entrada = Console.ReadLine().Split(' ');
            var valor = new List<int>();

            valor.Add(int.Parse(entrada[0], CultureInfo.InvariantCulture));
            valor.Add(int.Parse(entrada[1], CultureInfo.InvariantCulture));
            valor.Add(int.Parse(entrada[2], CultureInfo.InvariantCulture));

            valor.Sort();

            foreach (var item in valor)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            foreach (var item in entrada)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
