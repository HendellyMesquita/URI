using System;

/*
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos"
ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.
*/
namespace Uri_Desafios.Beecrowd_1
{
    class _1044Multiplos
    {
        public static void Executar()
        {
            Console.WriteLine("Valores de Entrada: ");
            string[] entrada = Console.ReadLine().Split(' ');

            var PrimeiroValor = int.Parse(entrada[0]);
            var SegundoValor = int.Parse(entrada[1]);
          
            
            if(PrimeiroValor % SegundoValor == 0 || SegundoValor % PrimeiroValor == 0)
            {
                Console.WriteLine("Sao Multiplos");
                return;
            }

            Console.WriteLine("Nao sao Multiplos");
        }
    }
}

