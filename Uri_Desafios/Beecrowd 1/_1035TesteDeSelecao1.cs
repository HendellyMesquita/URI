using System;

/*
Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A,
e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par escrever a mensagem 
"Valores aceitos", senão escrever "Valores nao aceitos".

Entrada
Quatro números inteiros A, B, C e D.

Saída
Mostre a respectiva mensagem após a validação dos valores.
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1035TesteDeSelecao1
    {
        public static void Executar()
        {
            Console.WriteLine("Informe 4 valores: ");
            string[] vet = Console.ReadLine().Split(' ');

            int vA = int.Parse(vet[0]);
            int vB = int.Parse(vet[1]);
            int vC = int.Parse(vet[2]);
            int vD = int.Parse(vet[3]);

            int CeD = vC + vD;
            int AeB = vA + vB;
            int ParA = vA % 2;

            if (vB > vC && vD > vA && CeD > AeB && vC > 0 && vD > 0 && ParA == 0)
            {
                Console.WriteLine("Valores aceitos");
                return;
            }

            Console.WriteLine("Valores nao aceitos");
        }
    }

}
