using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.MultiNotifier
{
    public class WeatherEventArgs
    {
        public String Temp { get; set; }
    }

    public delegate void WeatherEventHandler(Notifier sender, WeatherEventArgs args);


    class Program
    {
        static void Main(string[] args)
        {
            CentralePrevisioni cp = new CentralePrevisioni();

            for (int i = 1; i < 51; i++)
            {
                Notifier n = new Notifier(i);
                cp.addNotifier(n);
            }

            Console.ReadLine();
        }
    }
}
