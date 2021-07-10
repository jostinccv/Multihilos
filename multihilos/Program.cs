using System;
using System.Threading;


namespace multihilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Jefe";

            Thread t1 = new Thread(Recoge);
            Thread t2 = new Thread(Recoge);

            t1.Name = "Recoje bates Trujillo";
            t2.Name = "Recoje bates Balaguer";

            t1.Start();
            t2.Start();

            Recoge();

            Console.WriteLine("Saludos se ha terminado el partido buenas noches");
            Console.WriteLine("Hecho por jostin cepeda, 2019-8082");

        }

        static void Recoge()
        {
            for(int i=1; i<10; i++)
            {
                Console.WriteLine($" Recoge. {i} bate por {Thread.CurrentThread.Name}");
                Thread.Sleep(100);
            }
        }
    }
}
