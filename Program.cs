using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string d , t;

            int distancia , tempo , velocidadeMedia ;

            Console.WriteLine("------------------- ");
            Console.WriteLine("/ Velocidade media /");
            Console.WriteLine("------------------- \n");
            
             Console.Write("Digite a distância (em metros): ");
            d = Console.ReadLine();

             Console.WriteLine();

            Console.Write("Digite o tempo (em segundos): ");
            t = Console.ReadLine();

            Console.WriteLine();

            distancia = Convert.ToInt32(d);

            tempo = Convert.ToInt32(t);

            velocidadeMedia = distancia / tempo ;

            Console.ForegroundColor=ConsoleColor.Blue;
            Console.Write($"Distância percorrida (m): {distancia}\n");

            Console.ForegroundColor=ConsoleColor.Green;
            Console.Write($"Tempo gasto (s): {tempo}\n");

            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write($"Velocidade média: {velocidadeMedia} m/s ");

            Console.ResetColor();




        }  
    }
}
