using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TemperatureSystem
{
    public class TemperatureEventArgs
    {
        public double DetectedTemperature { get; set; }
    }

    public delegate void TemperatureEventHandler(object sender, TemperatureEventArgs args);
}
