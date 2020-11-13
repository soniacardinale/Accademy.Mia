using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestStampaProdotto();
            //Testnegozio();
           //TestOfferte();

        }

        private static void TestOfferte()
        {
         System.Console.WriteLine("Inserire 3 articoli disponibili (descrizione o descrizione-codice o descrizione-prezzo-sconto) e data di inizio e fine offerta nel formato dd/mm/aaaa");
         List<ProdottoInOfferta> articoliinofferta= new List<ProdottoInOfferta>();
            for (int i = 0; i < 3; i++)
            {
                string articolo = Console.ReadLine();
                string[] res = articolo.Split(new char[] { ' ' });

                if (res.Length == 3)
                {
                    string[] inizio = res[1].Split(new char[] { '/' });
                    DateTime inizioofferta = new DateTime(Convert.ToInt32(inizio[2]), Convert.ToInt32(inizio[1]), Convert.ToInt32(inizio[0]));
                    string[] fine = res[2].Split(new char[] { '/' });
                    DateTime fineofferta = new DateTime(Convert.ToInt32(fine[2]), Convert.ToInt32(fine[1]), Convert.ToInt32(fine[0]));
                    ProdottoInOfferta nuovoarticolo = new ProdottoInOfferta (res[0], inizioofferta, fineofferta);
                    articoliinofferta.Add(nuovoarticolo);
                }

                if (res.Length == 4)
                {
                    string[] inizio = res[2].Split(new char[] { '/' });
                    DateTime inizioofferta = new DateTime(Convert.ToInt32(inizio[2]), Convert.ToInt32(inizio[1]), Convert.ToInt32(inizio[0]));
                    string[] fine = res[3].Split(new char[] { '/' });
                    DateTime fineofferta = new DateTime(Convert.ToInt32(fine[2]), Convert.ToInt32(fine[1]), Convert.ToInt32(fine[0]));
                    ProdottoInOfferta nuovoarticolo = new ProdottoInOfferta(res[0], Convert.ToInt32(res[1]), inizioofferta, fineofferta);
                    articoliinofferta.Add(nuovoarticolo);
                }

                if (res.Length == 5)
                {
                    string[] inizio = res[3].Split(new char[] { '/' });
                    DateTime inizioofferta = new DateTime(Convert.ToInt32(inizio[2]), Convert.ToInt32(inizio[1]), Convert.ToInt32(inizio[0]));
                    string[] fine = res[4].Split(new char[] { '/' });
                    DateTime fineofferta = new DateTime(Convert.ToInt32(fine[2]), Convert.ToInt32(fine[1]), Convert.ToInt32(fine[0]));
                    ProdottoInOfferta nuovoarticolo = new ProdottoInOfferta(res[0], Convert.ToDouble(res[1]), Convert.ToDouble(res[2]), inizioofferta, fineofferta);
                    articoliinofferta.Add(nuovoarticolo);
                }
            }

            System.Console.WriteLine("Gli articoli in offerta sono: ");

            foreach (var item in articoliinofferta)
            {
                if (item.InizioOfferta < DateTime.Now && item.FineOfferta.AddDays(1) > DateTime.Now)
                {
                    if (item.Codice != -1)
                    {

                        System.Console.WriteLine("Articolo: {0}, Codice: {1}", item.Descrizione, item.Codice);
                    }
                    if (item.Prezzo != 0)
                    {
                        Console.OutputEncoding = System.Text.Encoding.UTF8;
                        System.Console.WriteLine("Articolo: {0}, Prezzo: {1:C}, Sconto: {2}%", item.Descrizione, item.Prezzo, item.Sconto);
                    }
                    if (item.Prezzo == 0 && item.Codice == -1)
                    {
                        System.Console.WriteLine("Articolo: {0}", item.Descrizione);
                    }

                }

            }
            Console.ReadLine();

            
        }
       

        private static void Testnegozio()
        {
            System.Console.WriteLine("Inserire i dati del negozio: nome del negozio, proprietario e 3 articoli disponibili (descrizione o descrizione-codice o descrizione-prezzo-sconto)");
            string nomenegozio = Console.ReadLine();
            string proprietario = Console.ReadLine();
            List<Prodotto> articolidisponibili = new List<Prodotto>();
            for (int i = 0; i < 3; i++)
            {
                string articolo = Console.ReadLine();
                string[] res = articolo.Split(new char[] { ' ' });
                if (res.Length==1)
                {
                    Prodotto nuovoarticolo = new Prodotto(res[0]);
                    articolidisponibili.Add(nuovoarticolo);
                }

                if (res.Length ==2)
                {
                    Prodotto nuovoarticolo = new Prodotto(res[0], Convert.ToInt32(res[1]));
                    articolidisponibili.Add(nuovoarticolo);
                }
                if (res.Length == 3)
                {
                    Prodotto nuovoarticolo = new Prodotto(res[0], Convert.ToDouble(res[1]), Convert.ToDouble(res[2]));
                    articolidisponibili.Add(nuovoarticolo);
                }
            }

            Negozio negozio1 = new Negozio(nomenegozio, proprietario, articolidisponibili);
            System.Console.WriteLine("Il nome del negozio è {0}, il nome del proprietario è {1}.\r\nGli articoli disponibili nel negozio sono:", nomenegozio, proprietario);
            foreach (var item in articolidisponibili)
            {
                if (item.Codice != -1)
                {

                    System.Console.WriteLine("Articolo: {0}, Codice: {1}", item.Descrizione, item.Codice);
                }
                if (item.Prezzo != 0)
                {
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    System.Console.WriteLine("Articolo: {0}, Prezzo: {1:C}, Sconto: {2}%", item.Descrizione, item.Prezzo, item.Sconto);
                }
                if (item.Prezzo==0 && item.Codice == -1)
                {
                    System.Console.WriteLine("Articolo: {0}", item.Descrizione);
                }


            }

            Console.ReadLine();
        }

        private static void TestStampaProdotto()
        {
            Prodotto prova1 = new Prodotto("Alimentare", 10, 5);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Prova1: \r\n Il prodotto ha le seguenti caratteristiche: \r\n Genere: {0} \r\n Prezzo: {1:C} \r\n Sconto {2}%", prova1.Descrizione, prova1.Prezzo, prova1.Sconto);

            Prodotto prova2 = new Prodotto("Igiene della persona", 526);
            Console.WriteLine("Prova2:\r\n Il prodotto ha le seguenti caratteristiche:\r\n Genere: {1} \r\n Codice: {0}", prova2.Codice, prova2.Descrizione);

            Prodotto prova3 = new Prodotto("Abbigliamento");
            Console.WriteLine("Prova3: \r\n Il prodotto ha le seguenti caratteristiche:\r\n Genere: {0}", prova3.Descrizione);

            Console.ReadLine();

        }
    }
}
