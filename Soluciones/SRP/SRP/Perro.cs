using System;
using System.Collections.Generic;
using System.Text;

namespace SRP //Solucion
{
    //Dejamos los metodos del que son del Perro
    public class Perro
    {
        public void Ladrar()
        {
            Console.WriteLine("El perro esta ladrando");
        }
        public void Aullar()
        {
            Console.WriteLine("El perro esta Aullando");
        }
    }
    //Creamos otra clase para poner el metodo distinto del perro

    public class DibujarPerro
    {
        public void Dibujar()
        {
            Console.WriteLine("Dibujando al perro");
        }

    }
}
