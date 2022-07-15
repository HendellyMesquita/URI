using System;
using System.Globalization;
/*
Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. 
Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:

Perimetro = XX.X

Em caso negativo, calcule a área do trapézio que tem A e B como base e C como 
altura, mostrando a mensagem:

Area = XX.X
*/

namespace Uri_Desafios.Beecrowd_1
{
    class _1043Triangulo
    {
        public static void Executar()
        {

            Console.WriteLine("Valores de Entrada: ");
            string[] entrada = Console.ReadLine().Split(' ');

            var PrimeiroValor = float.Parse(entrada[0], CultureInfo.InvariantCulture);
            var SegundoValor = float.Parse(entrada[1], CultureInfo.InvariantCulture);
            var TerceiroValor = float.Parse(entrada[2], CultureInfo.InvariantCulture);

            if (PrimeiroValor < SegundoValor + TerceiroValor
                && PrimeiroValor > Math.Abs(SegundoValor - TerceiroValor))
            {
                var perimetro = PrimeiroValor + SegundoValor + TerceiroValor;
                Console.WriteLine("Perimetro = " + perimetro.ToString("0.00"));
                return;
            }

            var area = (PrimeiroValor + SegundoValor) / 2.0 * TerceiroValor;

            Console.WriteLine("Area = " + area.ToString("0.00"));

        }
    }
}
