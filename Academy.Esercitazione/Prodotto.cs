using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Esercitazione
{
    public class Prodotto
    {
        public int Codice { get; set; }
        public string Descrizione { get; set; }

        public double Prezzo { get; set; }

        public double Sconto { get; set; }



        public Prodotto(string descrizione, double prezzo, double sconto)
        {
            this.Codice = -1;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Sconto = sconto;

        }

        public Prodotto(string descrizione, int codice)
        {
            this.Codice = codice;
            this.Descrizione = descrizione;
            this.Prezzo = 0;
            this.Sconto = 0;

        }

        public Prodotto(string descrizione)
        {
            this.Codice = -1;
            this.Descrizione = descrizione;
            this.Prezzo = 0;
            this.Sconto = 0;

        }

    }

    
   
}
