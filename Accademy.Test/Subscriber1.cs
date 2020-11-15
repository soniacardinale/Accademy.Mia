using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TemperatureSystem
{
    public class subscriber1
    {
        private Termometro _t;

        public subscriber1(Termometro t)
        {
            this._t = t;
            this._t.TemperatureTooHigh += _t_TemperatureTooHigh;
        }

        private void _t_TemperatureTooHigh(object sender, TemperatureEventArgs args)
        {

            Console.WriteLine("I'm Subscriber1 \r\n Detected Temperature: {0} is too hoigh", args.DetectedTemperature);
        }

    }
}

