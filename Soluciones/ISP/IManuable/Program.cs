using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Proceso manual se hereda de la clase proceso*/
            /*Se implemeta de la interfaz IManual*/
            var manual = new ProcesoManual();
            manual.Iniciar();
            manual.Suspender();
            manual.Reiniciar();
            manual.Finalizar();

            /*Proceso automatico se hereda los metodos de La clase Proceso*/
            var automatica = new ProcesoAutomaizado();
            automatica.Iniciar();
            automatica.Finalizar();

            Console.ReadLine();
        }
    }
}
