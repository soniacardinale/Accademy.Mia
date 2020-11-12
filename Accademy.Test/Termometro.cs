using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.TemperatureSystem
{
    public class Termometro
    {
        public event TemperatureEventHandler TemperatureTooHigh;
        public void SimulateTemperatureTooHigh(int detectedtemperature)
        {
            TemperatureEventArgs args = new TemperatureEventArgs()
            {
                DetectedTemperature = detectedtemperature
            };

            if (TemperatureTooHigh != null && detectedtemperature > 25)
            {
                foreach (var item in TemperatureTooHigh.GetInvocationList())
                {
                    TemperatureEventHandler t_eh = (TemperatureEventHandler)item;
                    t_eh(this, args);
                }
            }


        }
    }
}
