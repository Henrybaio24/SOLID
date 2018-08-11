using System;
using System.Collections.Generic;
using System.Text;

namespace OSP //Solucion
{
        //Abierto para la extension
        public abstract class Forma
        {
            public abstract void Dibujar();
        }
        public class Rectangulo : Forma
        {
            public override void Dibujar()
            {
                Console.WriteLine("Dibujar un rectangulo");

            }
        }
        public class Circulo : Forma
        {
            public override void Dibujar()
            {
               Console.WriteLine("Dibujar un circulo");
            }
        }
        // Cerrado para la modificacion
        public class EditorGrafico
        {
            public void DibujarForma(Forma forma)
            {
                forma.Dibujar();
            }
        }
    
}
