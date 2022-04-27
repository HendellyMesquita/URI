using System;

/*
A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:
- Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.
*/

namespace Uri_Desafios.Beecrowd_1
{
    class _1002AreaDoCirculo
    {
        public static void Executar()
        {
            double raio;
            do
            {
                Console.Write("Valor do raio: ");
                raio = Convert.ToDouble(Console.ReadLine());
                var areaCirculo = Math.PI * Math.Pow(raio, 2);
                Console.WriteLine($"Area do cirulo = {areaCirculo.ToString("F4")}");
                Console.ReadKey();

            } while (raio > 0);
        }
    }
}