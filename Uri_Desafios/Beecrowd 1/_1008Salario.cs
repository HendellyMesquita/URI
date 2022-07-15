using System;

/*
 Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.
A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

Entrada
O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade de horas trabalhadas e o valor que o 
funcionário recebe por hora trabalhada, respectivamente.

Saída
Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. No caso do salário, 
também deve haver um espaço em branco após o $.
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1008Salario
    {
        public static void Executar()
        {
            Console.Write("Funcionario: ");
            int funcionario = int.Parse(Console.ReadLine());
            Console.Write("Hora Trabalhada: ");
            int horaTrabalhada = int.Parse(Console.ReadLine());
            Console.Write("Valor Recebido Por Hora: ");
            double valorHora = double.Parse(Console.ReadLine());

            double salario = valorHora * horaTrabalhada;

            Console.WriteLine("NUMBER = " + funcionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString(".00"));
        }
    }
}
