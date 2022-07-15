using System;
using System.Globalization;
/*
Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, 
ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
                                    ______Y______
                                    |     |     |
                                    | Q2  | Q1  |
                                    |_____O_____X
                                    |     |     |
                                    | Q3  |  Q4 |
                                    |_____|_____|

Se o ponto estiver na origem, escreva a mensagem “Origem”.

Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
*/
namespace Uri_Desafios.Beecrowd_1
{
    class _1041CoordenadasDeUmPonto
    {
        public static void Executar()
        {
            string[] vet = Console.ReadLine().Split(' ');

            double X = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (X == 0 && Y == 0)
                Console.WriteLine("Origem");
            else if (Y == 0)
                Console.WriteLine("Eixo X");
            else if (X == 0)
                Console.WriteLine("Eixo Y");
            else if (X > 0 && Y > 0)
                Console.WriteLine("Q1");
            else if (X < 0 && Y > 0)
                Console.WriteLine("Q2");
            else if (X < 0 && Y < 0)
                Console.WriteLine("Q3");
            else if (X > 0 && Y < 0)
                Console.WriteLine("Q4");
            else
                Console.WriteLine("Valor Informado Não é um Valor Valido");

        }

    }
}
