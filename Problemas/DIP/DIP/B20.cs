using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    //La clase mayor depende de una clase menor
    public class B20
    {

    }

    public class Volvo
    {
        private B20 _motor;

        public Volvo()
        {
            _motor = new B20();
        }
    }
}
