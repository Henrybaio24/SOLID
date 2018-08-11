using System;
using System.Collections.Generic;
using System.Text;

namespace DIP //Solucion
{
    //Creamos una interfaz
    public interface IMotor
    {

    }
    //Implemetamos la interfaz
    public class NuevoMotorV12 : IMotor
    {

    }
    //Creamos una clase
    public class Volvo
    {
        private IMotor _motor;

        public Volvo(IMotor motor)
        {
            _motor = motor;
        }
    }
    //Creamos una clase e inyectamos la clase VOLVO
    public class CarrosServicio
    {
        public void CrearCarro()
        {
            var miVolvo = new Volvo(new NuevoMotorV12());
            Console.WriteLine("Se hizo la inyeccion");
        }
    }
}
