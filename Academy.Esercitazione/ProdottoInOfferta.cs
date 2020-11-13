using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Esercitazione
{
    public class ProdottoInOfferta : Prodotto
    {
        public DateTime InizioOfferta { get; set; }
        public DateTime FineOfferta { get; set; }

        public ProdottoInOfferta()
       : base("Genere")
        {
            Descrizione = "aaa";
        }
        public ProdottoInOfferta(string descrizione, double prezzo, double sconto, DateTime inizio, DateTime fine) : base(descrizione)
        {
            this.Codice = -1;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Sconto = sconto;
            this.InizioOfferta = inizio;
            this.FineOfferta = fine;
        }

        public ProdottoInOfferta(string descrizione, int codice, DateTime inizio, DateTime fine) : base(descrizione)
        {
            this.Codice = codice;
            this.Descrizione = descrizione;
            this.Prezzo = 0;
            this.Sconto = 0;
            this.InizioOfferta = inizio;
            this.FineOfferta = fine;

        }

        public ProdottoInOfferta(string descrizione, DateTime inizio, DateTime fine) : base(descrizione)
        {
            this.Codice = -1;
            this.Descrizione = descrizione;
            this.Prezzo = 0;
            this.Sconto = 0;
            this.InizioOfferta = inizio;
            this.FineOfferta = fine;

        }

    }
 
   


 
}
