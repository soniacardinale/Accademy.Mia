using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public class Persona : IComparable
    {
        protected String Nome;
        protected String Cognome;
        protected int Eta;

        public Ruolo Inquadramento;

        public string Indirizzo { get; set; }

        public Persona()
        {

        }
        public Persona(string nome, string cognome, Ruolo r)
        {
            Nome = nome;
            Cognome = cognome;
            this.Inquadramento = r;
        }
        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
            Inquadramento = Ruolo.TerzoLivello;
        }

        public void SetEta(int x)
        {
            this.Eta = x;
        }
        public override string ToString()
        {
            string s = "Persona: " + Nome + "\t\t" + Cognome + "\r\n"
                        + "Età: " + Eta + "\r\n"
                        + "Indirizzo: " + Indirizzo;
            return s;
        }
        public override bool Equals(object obj)
        {
            Persona p = (Persona)obj;
            return (this.Nome == p.Nome && this.Cognome == p.Cognome);
        }
        public override int GetHashCode()
        {
            String s = this.Nome + this.Cognome;
            return s.GetHashCode();
        }
        // Returns:
        //     A value that indicates the relative order of the objects being compared. The
        //     return value has these meanings: Value Meaning Less than zero This instance precedes
        //     obj in the sort order. Zero This instance occurs in the same position in the
        //     sort order as obj. Greater than zero This instance follows obj in the sort order.
        public int CompareTo(object obj)
        {
            Persona p = (Persona)obj;
            //return this.Eta - p.Eta;
            return (int)this.Inquadramento - (int)p.Inquadramento;
        }
    }
}
