using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.GeometryAbstract
{
    /// <summary>
    /// 
    /// </summary>
    public class Cerchio : FiguraGeometrica
    {
        private double raggio;
        /// <summary>
        /// sdfdsfgfdsgsdfgsfhfghgfdhdgfh
        /// dfghdfg
        /// hdgfh
        /// dfgh
        /// dgfhd
        /// </summary>
        /// <param name="raggio">dgfhdgfhdghjdgj</param>
        public Cerchio(double raggio)
        {
            this.raggio = raggio;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return this.raggio * this.raggio * Math.PI;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double GetPerimetro()
        {
            return 2 * this.raggio * Math.PI;
        }
    }
}
