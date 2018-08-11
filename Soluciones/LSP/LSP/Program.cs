using System;

namespace LSP //Solucion
{

    class Program
    {
        static void Main(string[] args)
        {
            //Aunque cambiemos Gato por Perro o viceversa el programa nos debe seguir funcionando
            var animal = new Gato();
            animal.Acariciar();
            animal.Alimentar();



            Console.ReadLine();

        }
    }
}
