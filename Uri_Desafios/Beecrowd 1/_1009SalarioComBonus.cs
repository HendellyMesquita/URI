using System;

/*
Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). 
Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.

Entrada
O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais, 
representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.

Saída
Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1009SalarioComBonus
    {
        public static void Executar()
        {
            Console.Write("Funcionario: ");
            string funcionario = Console.ReadLine();
            Console.Write("Salario: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Total vendas No mes: R$ ");
            double VendasNoMes = double.Parse(Console.ReadLine());

            double TOTAL = salario + VendasNoMes * 0.15;

            Console.WriteLine("TOTAL =  "+ TOTAL.ToString(".00"));
        }
    }
}
