using System;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Random r = new Random();
            int NumeroGanador = r.Next(1, 10);
            bool win = false;

            do
            {
                Console.Write("Ingrese un Valor en 0 a 10 ");
                string s = Console.ReadLine();
                int i = int.Parse(s);

                if( i> NumeroGanador)
                {
                    Console.WriteLine(" El numero es alto ");
                }
                else if( i< NumeroGanador)
                {
                    Console.WriteLine(" EL numero es bajo ");
                }
                else if( i == NumeroGanador)
                {
                    Console.WriteLine(" FELICIDADES HAS GANADO =)");
                    win = true;
                }

            } while (win == false);
            Console.WriteLine(" Gracias por jugar !!!!");
            Console.WriteLine(" Presione una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
