using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Helper
{
    public class RandomHelper
    {
        public static int GetRandomInt(int min, int max)
        {
            int seed = Guid.NewGuid().GetHashCode();
            Random r = new Random(seed);
            return r.Next(min, max);

        }
    }
}
