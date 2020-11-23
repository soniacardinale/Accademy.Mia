using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.MultiNotifier
{
    public class Notifier
    {
        public int ID { get; }

        public Notifier(int id)
        {
            this.ID = id;
        }

        public event WeatherEventHandler TemperatureChanged;
    }
}
