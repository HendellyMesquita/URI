using System;

/*
 Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
Entrada
O arquivo de entrada contém três valores com um dígito após o ponto decimal.

Saída
O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com
mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos 
após o ponto decimal.
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1012Area
    {

        public static void Executar()
        {
            Console.WriteLine("Informe 3 valores: ");
            string[] vet = Console.ReadLine().Split(' ');

            double vA = double.Parse(vet[0]);
            double vB = double.Parse(vet[1]);
            double vC = double.Parse(vet[2]);

            double A = (vA * vC) / 2;
            double B = Math.PI * Math.Pow(vC, 2);
            double C = ((vA + vB) * vC) / 2;
            double D = vB * vB;
            double E = vA * vB;

            Console.WriteLine("TRIANGULO: " + A.ToString("F3"));
            Console.WriteLine("CIRCULO: " + B.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + C.ToString("F3"));
            Console.WriteLine("QUADRADO: " + D.ToString("F3"));
            Console.WriteLine("RETANGULO: " + E.ToString("F3"));
        }
    }
}