using System;
using System.Globalization;
/*
Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno.
Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada
pela mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.".
Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". 
Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem 
"Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. 
Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. Recalcule a média 
(some a pontuação do exame com a média anteriormente calculada e divida por 2). e imprima a mensagem
"Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", 
(caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) 
apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.
*/

namespace Uri_Desafios.Beecrowd_1
{
    class _1040Media3
    {
        public static void Executar()
        {
            Console.Write("Notas do Semestre: ");
            string Notas = (Console.ReadLine());

            string[] Nota = Notas.Split(' ');
            float N1 = float.Parse(Nota[0], CultureInfo.InvariantCulture);
            float N2 = float.Parse(Nota[1], CultureInfo.InvariantCulture);
            float N3 = float.Parse(Nota[2], CultureInfo.InvariantCulture);
            float N4 = float.Parse(Nota[3], CultureInfo.InvariantCulture);


            float media = (float)((N1 * 2.0) + (N2 * 3.0) + (N3 * 4.0) + (N4 * 1.0)) / (float)10.0;
            Console.WriteLine("MEDIA = " + media.ToString("0.0"));

            if (media >= 7.0)
                Console.WriteLine("Aluno aprovado.");

            else if (media < 5.0)
                Console.WriteLine("Aluno reprovado.");

            else if (media >= 5.0 || media < 0.7)
            {
                Console.WriteLine("Aluno em exame.");

                Console.Write("Nota do exame:");
                float NF = float.Parse(Console.ReadLine());

                float mediafinal = (media + NF) / (float)2.0;

                if (mediafinal >= 5.0)
                    Console.WriteLine("Aluno aprovado.");

                else if (mediafinal < 5.0)
                    Console.WriteLine("Aluno reprovado.");

                Console.Write("Media final: " + mediafinal.ToString("0.0"));
            }
        }
    }
}