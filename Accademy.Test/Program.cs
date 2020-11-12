using Accademy.Helper;
using Accademy.TemperatureSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.TemperatureSystem
{
    class Program
    {
        static void Main(string[] args)
        {
                Termometro t = new Termometro();

                subscriber1 S1 = new subscriber1(t);
                subscriber2 S2 = new subscriber2(t);

                for (int i = 0; i < 50; i++)
                {
                    t.SimulateTemperatureTooHigh(RandomHelper.GetRandomInt(20, 30));
                }
            Console.ReadLine();


        }
    }
}
