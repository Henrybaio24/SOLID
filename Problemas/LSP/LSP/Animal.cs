using System;
using System.Collections.Generic;
using System.Text;

namespace LSP //Problema
{
    public abstract class Animal
    {
        public abstract void Alimentar();
        public abstract void Acariciar();
    }

    public class Perro : Animal
    {
        public override void Alimentar()
        {
            // Alimentar al perro
        }

        public override void Acariciar()
        {
            // Acariciar al perro
        }
    }

    public class Escorpion : Animal
    {
        public override void Alimentar()
        {
            // Alimentar al escorpion
        }

        public override void Acariciar()
        {
            // Estas loco ????!
        }
    }
}
