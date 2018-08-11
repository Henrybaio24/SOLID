using System;
using System.Collections.Generic;
using System.Text;

namespace LSP //Solucion
{
   
    //Creamos una interfaz
    public interface IMascota
    {
        void Acariciar();
    }
    //Creamos una clase abstracta
    public abstract class Animal
    {
        public abstract void Alimentar();
    }
    //Creamos una clase Perro y heredamos e implementamos  
    public class Perro : Animal, IMascota
    {
        public override void Alimentar()
        {
            Console.WriteLine("El perro tiene hambre");
        }

        public void Acariciar()
        {
            Console.WriteLine("Acariciar al perro");
        }
    }
    //Creamos una clase gato y heredamos e implementamos  
    public class Gato : Animal, IMascota
    {
        public override void Alimentar()
        {
            Console.WriteLine("Alimentar al gato");
        }

        public void Acariciar()
        {
            Console.WriteLine("Acariciar al gato ahora");
        }
    }
}
