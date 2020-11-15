using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Entities
{
    public class Movimento
    {
        public TipoMovimento Tipo { get; set; }
        public double Importo { get; set; }
        public DateTime Data { get; set; }
        public String Beneficiario { get; set; }
    }
}
