using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public class Impiegato : Persona, IPrintLetter
    {
        public String Matricola { get; set; }

        public Impiegato()
            : base("aaaaaa", "bbbbb")
        {
            Indirizzo = "lhlkhl";
        }

        public Impiegato(string nome, string cognome, int eta)
            : base(nome, cognome)
        {
            Eta = eta;
        }

        public void StampaLettera(string testo)
        {
            string txt = testo.ToLower();
            Console.WriteLine(txt);
        }
    }
}
