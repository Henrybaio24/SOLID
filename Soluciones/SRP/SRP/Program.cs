using System;

namespace SRP//Solucion
{
    class Program
    {
        static void Main(string[] args)
        {
            var perro = new Perro();
            perro.Ladrar();
            perro.Aullar();

            var dibujar = new DibujarPerro();
            dibujar.Dibujar();

            Console.ReadLine();

        }
    }
}
