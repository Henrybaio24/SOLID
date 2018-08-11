using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var servicio = new CarrosServicio();
            servicio.CrearCarro();


            Console.ReadLine();
        }
    }
}
