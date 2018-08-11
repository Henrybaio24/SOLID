using System;
using System.Collections.Generic;
using System.Text;

namespace ISP //Problema
{
    public abstract class Proceso
    {
        public abstract void Iniciar();
        public abstract void Suspender();
        public abstract void Reanudar();
        public abstract void Finalizar();
    }
    //El proceso manual puede utilizar los cuatro metodos
    public class ProcesoManual : Proceso
    {
        public override void Iniciar()
        {
            //...
        }
        public override void Suspender()
        {
            //...
        }
        public override void Reanudar()
        {
            //...
        }
        public override void Finalizar()
        {
            //...
        }
    }
    //El proceso automatico puede utilizar solo dos metodos ya que lo hace una maquina
    public class ProcesoAutomaizado : Proceso
    {
        public override void Iniciar()
        {
            //...
        }
        public override void Suspender()
        {
            throw new NotImplementedException();
        }
        public override void Reanudar()
        {
            throw new NotImplementedException();
        }
        public override void Finalizar()
        {
            //...
        }
    }
