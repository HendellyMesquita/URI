using System;

/*
Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno.
A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). 
Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

Entrada
O arquivo de entrada contém 2 valores com uma casa decimal cada um.

Saída
Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 5 dígitos após o ponto decimal e com um espaço em branco antes e depois da igualdade. 
Utilize variáveis de dupla precisão (double) ".
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1005Media1
    {
        public static void Executar()
        {
            Console.Write("Primeiro Valor: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            double B = double.Parse(Console.ReadLine());

            double MEDIA = (A * 3.5 + B * 7.5) / 11;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("0.00000"));



        }
    }
}
