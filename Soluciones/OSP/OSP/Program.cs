using System;

namespace OSP//Solucion
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangulo = new Rectangulo();
            
            rectangulo.Dibujar();
            

            var circulo = new Circulo();
            
            circulo.Dibujar();
           

            var editor = new EditorGrafico();
            editor.DibujarForma(circulo);

            Console.ReadLine();
        }
        
    }
}
