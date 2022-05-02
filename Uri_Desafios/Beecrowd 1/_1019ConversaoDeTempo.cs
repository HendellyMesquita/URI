using System;

/*
Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica,
e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, 
conforme exemplo fornecido.


 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1019ConversaoDeTempo
    {
        public static void Executar()
        {

            Console.Write("Informe os segundos a ser convertidos: ");
            int segundos = int.Parse(Console.ReadLine());

            int resto = segundos % 3600;

            int hora = segundos / 3600;
            int minuto = resto / 60;
            int seg = resto % 60;

            Console.WriteLine(hora + ":" + minuto + ":" + seg);


        }
    }
}
