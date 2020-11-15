using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.GeometryAbstract
{
    public abstract class FiguraGeometrica
    {
        public abstract double GetArea();
        public abstract double GetPerimetro();

        public string GetDescription()
        {
            Type t = this.GetType();
            string myType = t.ToString();

            string description = "I'm a " + myType + " with Area: " + GetArea() + " Perimetro: " + GetPerimetro();
            return description;
        }
    }
}
