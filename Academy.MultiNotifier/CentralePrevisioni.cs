using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.MultiNotifier
{
    public class CentralePrevisioni
    {
        List<Notifier> lstNotifier = new List<Notifier>();

        public void addNotifier(Notifier notifier)
        {
            lstNotifier.Add(notifier);
            notifier.TemperatureChanged += Notifier_TemperatureChanged;
        }

        private void Notifier_TemperatureChanged(Notifier sender, WeatherEventArgs args)
        {

        }
    }
}
