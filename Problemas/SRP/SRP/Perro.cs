using System;
using System.Collections.Generic;
using System.Text;

namespace SRP //Problema
{
    public class Perro
    {
        //Tenemos dos metodos que hace el perro y uno que no
        //Dejamos los dos metodos que son del perro
        public void Ladrar()
        {
            Console.WriteLine("El perro esta ladrando");
        }
        public void Aullar()
        {
            Console.WriteLine("El perro esta aullando");
        }
        //El que no es debemos sacarlo y crear otra clase
        public void Dibujar()
        {
            Console.WriteLine("El perro esta dibujando");
        }
    }
}
