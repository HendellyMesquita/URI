using System;

/*
 Dois carros (X e Y) partem em uma mesma direção. O carro X sai com velocidade constante de 
60 Km/h e o carro Y sai com velocidade constante de 90 Km/h.

Em uma hora (60 minutos) o carro Y consegue se distanciar 30 quilômetros do carro X, ou seja, 
consegue se afastar um quilômetro a cada 2 minutos.

Leia a distância (em Km) e calcule quanto tempo leva (em minutos) para o carro Y tomar essa 
distância do outro carro.

Entrada
O arquivo de entrada contém um número inteiro.

Saída
Imprima o tempo necessário seguido da mensagem "minutos".
 */

/*
 Para resolver esse exercício tente usar uma regra de três:

Carro X : 60 km/h

Carro Y : 90 km/h

Em 1 h a diferença entre eles é de 30 km

Considerando a distância que vc recebeu:

60 - 30
x  - Distancia
Ai é só resolver :

x = (60 * Distancia) / 30;
 */

namespace Uri_Desafios.Beecrowd_1
{
    class _1016Distancia
    {
        public static void Executar()
        {
            Console.Write("distância percorrida: ");
            int distancia = int.Parse(Console.ReadLine());

            int percorrido = (60 * distancia) / 30;

            Console.WriteLine(percorrido + " minutos");
        }
    }
}
