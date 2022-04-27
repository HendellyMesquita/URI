using System;

/*
Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, 
a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

Entrada
O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

Saída
Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. 
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1006Media2
    {
        public static void Executar()
        {
            Console.Write("Primeiro Valor: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Terceiro Valor: ");
            double C = double.Parse(Console.ReadLine());

            double MEDIA = (A * 2 + B * 3 + C* 5) / 10;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("0.0"));


        }
    }
}
