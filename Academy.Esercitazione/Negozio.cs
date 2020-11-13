using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Esercitazione
{
    public class Negozio
    {
        public string NomeNegozio { get; set; }
        public string Proprietario { get; set; }
        public List<Prodotto> Prodotti { get; set; }

        public Negozio(string nomenegozio, string proprietario)
        {
            this.NomeNegozio = nomenegozio;
            this.Proprietario = proprietario;   
        }

        public Negozio(string nomenegozio, string proprietario, Prodotto articolo)
        {
            List<Prodotto> unarticolo = new List<Prodotto>();
            this.NomeNegozio = nomenegozio;
            this.Proprietario = proprietario;
            unarticolo.Add(articolo);
            this.Prodotti = unarticolo;
        }

        public Negozio(string nomenegozio, string proprietario, List<Prodotto> articoli)
        {
            this.NomeNegozio = nomenegozio;
            this.Proprietario = proprietario;
            this.Prodotti = articoli;
        }

    }

   

   
}
