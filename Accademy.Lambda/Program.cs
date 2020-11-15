using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Lambda   //funzioni Lambda
{
    class Program
    {
        public delegate bool FilterInt(int i);
        public delegate bool MyDelegate(int i, string s);
        public delegate bool NewDelegate();
        static void Main(string[] args)
        {
            List<int> lst = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            FilterInt filterOdd = new FilterInt(IsOdd);
            List<int> result = FilterInts(lst, IsOdd);
            //posso fare il filtro IsEven, senza cambiare FilterInts
            //non creo il delegate, lo crea direttamente il compilatore
            //List<int> result = FilterInts(lst, IsEven);
            //terzo metodo 
            //List<int> result = FilterInts(lst, i => (i % 2) == 1);

            MyDelegate lambda = (i, s) =>
              {
                  if (i > s.Length)
                  {
                      return true;
                  }
                  else
                  {
                      return false;
                  }

              };

            NewDelegate newlambda = () => { return true; };

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }


        public static bool IsOdd(int x)
        {
            return (x % 2) == 1;
        }

        public static bool IsEven(int x)
        {
            return(x % 2) == 0;
        }
        public static List<int> FilterInts(List<int> inputLst, FilterInt filter)
        {
            List<int> resultLst = new List<int>();
            foreach (var item in inputLst)
            {
                if (filter(item))
                {
                    resultLst.Add(item);
                }
            }
            return resultLst;

        }

    }
    
}
