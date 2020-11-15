using Academy.Helper;
using HumanResources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Console
{
    /// <summary>
    /// Comment NOw 14:15 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ///TestWebSite(args[0]);
            TestRecursion();
            //TestDictionary();
            //TestSplit();
            //TestReadFile();
            //TestHR();
            //TestGeometry();
            //TestGeometryAbstract();
            //TestLoops();
            //try
            //{
            //    TestRandom();
            //}
            //catch (RandomArgumentsException excp)
            //{
            //    throw;
            //}

            // TestGeneric();

            //TestUni_001();
            //TestUni_002();
            // Test_Tris();
        }

        private static void TestRecursion()
        {
            // n! = n(n - 1)!
            System.Console.WriteLine("Please Enter a Number");

            //read number from user    
            int number = Convert.ToInt32(System.Console.ReadLine());

            //invoke the static method    
            double factorial = Factorial_Iteration(number);

            //print the factorial result    
            System.Console.WriteLine("factorial of" + number + "=" + factorial.ToString());
        }

        public static double Factorial_Recursion(int number)
        {
            System.Console.WriteLine(number);
            if (number == 0)
                return 1;
            return number * Factorial_Recursion(number - 1);  //Recursive call    
        }


        public static double Factorial_Iteration(int number)
        {
            if (number == 0)
                return 1;

            double factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }


        private static void TestWebSite(string url)
        {
            // go to web site url
            // print ok if found
            // else print not found

            System.Console.WriteLine(url);
        }

        private static void TestDictionary()
        {
            Dictionary<Guid, Persona> dic_persone = new Dictionary<Guid, Persona>();

            dic_persone.Add(Guid.NewGuid(), new Persona());


            Dictionary<string, string> openWith = new Dictionary<string, string>();

            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // The Add method throws an exception if the new key is
            // already in the dictionary.
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                System.Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            // The Item property is another name for the indexer, so you
            // can omit its name when accessing elements.
            System.Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            // The indexer can be used to change the value associated
            // with a key.
            openWith["rtf"] = "winword.exe";
            System.Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            // If a key does not exist, setting the indexer for that key
            // adds a new key/value pair.
            openWith["doc"] = "winword.exe";

            // The indexer throws an exception if the requested key is
            // not in the dictionary.
            try
            {
                System.Console.WriteLine("For key = \"tif\", value = {0}.",
                    openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                System.Console.WriteLine("Key = \"tif\" is not found.");
            }

            // When a program often has to try keys that turn out not to
            // be in the dictionary, TryGetValue can be a more efficient
            // way to retrieve values.
            string value = "";
            if (openWith.TryGetValue("tif", out value))
            {
                System.Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }
            else
            {
                System.Console.WriteLine("Key = \"tif\" is not found.");
            }

            // ContainsKey can be used to test keys before inserting
            // them.
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                System.Console.WriteLine("Value added for key = \"ht\": {0}",
                    openWith["ht"]);
            }

            // When you use foreach to enumerate dictionary elements,
            // the elements are retrieved as KeyValuePair objects.
            System.Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                System.Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            // To get the values alone, use the Values property.
            Dictionary<string, string>.ValueCollection valueColl =
                openWith.Values;

            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for dictionary values.
            System.Console.WriteLine();
            foreach (string s in valueColl)
            {
                System.Console.WriteLine("Value = {0}", s);
            }

            // To get the keys alone, use the Keys property.
            Dictionary<string, string>.KeyCollection keyColl =
                openWith.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for dictionary keys.
            System.Console.WriteLine();
            foreach (string s in keyColl)
            {
                System.Console.WriteLine("Key = {0}", s);
            }

            // Use the Remove method to remove a key/value pair.
            System.Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                System.Console.WriteLine("Key \"doc\" is not found.");
            }

            /* This code example produces the following output:

            An element with Key = "txt" already exists.
            For key = "rtf", value = wordpad.exe.
            For key = "rtf", value = winword.exe.
            Key = "tif" is not found.
            Key = "tif" is not found.
            Value added for key = "ht": hypertrm.exe

            Key = txt, Value = notepad.exe
            Key = bmp, Value = paint.exe
            Key = dib, Value = paint.exe
            Key = rtf, Value = winword.exe
            Key = doc, Value = winword.exe
            Key = ht, Value = hypertrm.exe

            Value = notepad.exe
            Value = paint.exe
            Value = paint.exe
            Value = winword.exe
            Value = winword.exe
            Value = hypertrm.exe

            Key = txt
            Key = bmp
            Key = dib
            Key = rtf
            Key = doc
            Key = ht

            Remove("doc")
            Key "doc" is not found.
            */
        }


        /// <summary>
        /// Convertire in formato decimale il seguente numero binario senza segno
        /// </summary>
        private static void TestUni_002()
        {
            string b = "11011001";
            int converted_binary = Academy.Helper.RandomHelper.ConvertBynaryToInt(b);
            System.Console.WriteLine(converted_binary);

        }

        /// <summary>
        /// Scrivere un programma "Tutti uguali" che prevede un array di 10 numeri interi contenente valori a piacere (senza bisogno di chiederli all’utente) 
        /// e stampa "tutti uguali" se i valori dell’array sono tutti uguali, oppure stampa "non tutti uguali" altrimenti. 
        /// (Il programma deve essere scritto facendo finta di non sapere quali siano i valori inseriti nell’array). 
        /// Per riempire l'array, utilizzar la classe Helper in due casi: il primo restituisce
        /// valori casuali, il secondo restituisce valori uguali
        /// </summary>
        private static void TestUni_001()
        {
            int[] array_uguali = new int[10];

            int[] array_diversi = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array_uguali[i] = Academy.Helper.RandomHelper.GetSameint(100);
                array_diversi[i] = Academy.Helper.RandomHelper.GetRandomInt(1, 100);
            }

            bool tuttiUguali_1 = ArrayIsComposedofSameNumber(array_uguali);
            bool tuttiUguali_2 = ArrayIsComposedofSameNumber(array_diversi);

            if (tuttiUguali_1)
                System.Console.WriteLine("array_uguali result: Tutti Uguali");
            else
                System.Console.WriteLine("array_uguali result: non Tutti Uguali");

            if (tuttiUguali_2)
                System.Console.WriteLine("array_diversi result: Tutti Uguali");
            else
                System.Console.WriteLine("array_diversi result: non Tutti Uguali");
        }

        private static bool ArrayIsComposedofSameNumber(int[] array_of_int)
        {
            bool tuttiuguali = true;

            int first = array_of_int[0];
            for (int i = 1; i < array_of_int.Length; i++)
            {
                if (array_of_int[i] != first)
                {
                    tuttiuguali = false;
                    break;
                }
            }
            return tuttiuguali;
        }

        private static bool ArrayIsComposedofAllDifferentNumber(int[] array_of_int)
        {
            bool result = true;
            for (int i = 0; i < array_of_int.Length; i++)
            {
                for (int j = i + 1; j < array_of_int.Length; j++)
                {
                    if (array_of_int[i] == array_of_int[j])
                    {
                        result = false;
                        break;
                    }
                }
                if (result == false)
                    break;
            }
            return result;
        }



        private static void TestGeneric()
        {

            Dictionary<string, Persona> dict_str_person = new Dictionary<string, Persona>();

            List<int> lst_int = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            if (lst_int.Contains(3))
                System.Console.WriteLine("3 is in List");

            List<Persona> lst_persona = new List<Persona>();
            Persona mario = new Persona("Mario", "Rossi");
            Persona maria = new Persona("Maria", "Bianchi");
            Persona gianni = new Persona("Gianni", "Giallo");

            foreach (Persona item in lst_persona)
            {

            }

            lst_persona.Add(mario);
            lst_persona.Add(maria);
            lst_persona.Add(gianni);

            Persona p = new Persona("Mario", "Rossi");

            if (lst_persona.Contains(p))
                System.Console.WriteLine("Persona is in List");
            else
                System.Console.WriteLine("Persona is NOT in List");

            System.Console.WriteLine(p.Equals(mario));
            System.Console.WriteLine(p.GetHashCode());
            System.Console.WriteLine(mario.GetHashCode());



            Persona sosia_mario = mario;

            //System.Console.WriteLine(sosia_mario.GetHashCode());
            //System.Console.WriteLine(mario.GetHashCode());


        }
        private static void TestRandom()
        {
            String dir = @"D:\temp";
            String filename = "Academy_random.txt";
            String path = System.IO.Path.Combine(dir, filename);

            int min = 1001;
            int max = 1000;

            System.IO.StreamWriter Academy_randomFile = new System.IO.StreamWriter(path);
            for (int i = 0; i < 50; i++)
            {

                //int r = Academy.Helper.RandomHelper.GetRandomInt(min, max);
                //Academy_randomFile.WriteLine(r);
                try
                {
                    int r = Academy.Helper.RandomHelper.GetRandomInt(min, max);
                    Academy_randomFile.WriteLine(r);
                }
                catch (RandomArgumentsException excp)
                {
                    System.Console.WriteLine(excp.Message);
                    break;
                }
                finally
                {
                    //................
                }
            }

            Academy_randomFile.Close();

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                int randomInt = 0;
                try
                {
                    randomInt = Int32.Parse(line);
                }
                catch (FormatException excp)
                {
                    System.Console.WriteLine(excp.Message);
                }
                System.Console.WriteLine(randomInt + 1000);
            }
            file.Close();
            //System.Console.ReadLine();
        }
        private static void TestLoops()
        {
            // declare string s ="lkjljlkj"
            // transform s in char array
            // use 'for' loop to invert array chars
            // transform the new array in string
            // console writeline the new string

            string s = "1234567890";

            char[] arrayName = s.ToCharArray();
            int length = arrayName.Length;
            char[] newArr = new char[length];




            for (int i = 0; i < length; i++)
            {
                newArr[length - 1 - i] = arrayName[i];
            }

            List<char> charList = new List<char>();
            /* 0) dichairazione di una lista di char
             * 1) Ciclo for di 10 iterazioni per inserire nella lista una serie di caratteri
             * 2) dichiarare un array di char della stessa lunghezza della lista
             * 3) ciclo foreach sulla lista e inserimento inverso nell'array 
             * 4) trasformare l'array in una lista
             * 5) ciclo foreach sulla seconda lista (con la stringa in ordine inverso) per stampare i char
             */

            // 1)
            for (int i = 64; i < 74; i++)
            {
                charList.Add(Convert.ToChar(i));
            }

            // 2)
            char[] newCharArrray = new char[charList.Count];

            // 3)
            int j = charList.Count - 1;
            foreach (char c in charList)
            {
                newCharArrray[j] = c;
                j--;
            }

            // 4)
            List<char> newList = newCharArrray.ToList();

            // 5)
            foreach (char c in newList)
            {
                System.Console.WriteLine(c);

            }


            for (int i = 0; i < newList.Count; i++)
            {
                System.Console.WriteLine(newList.ElementAt(i));
            }
        }
        private static void TestGeometryAbstract()
        {
            GeometryAbstract.Quadrato q1 = new GeometryAbstract.Quadrato(11.009);
            GeometryAbstract.Cerchio c1 = new GeometryAbstract.Cerchio(9.25);

            PrintFiguraAbstract(q1);
            PrintFiguraAbstract(c1);

        }
        private static void PrintFiguraAbstract(GeometryAbstract.FiguraGeometrica f)
        {
            string s = f.GetDescription();
            System.Console.WriteLine(s);
        }
        private static void TestGeometry()
        {
            Academy.Geometry.Quadrato q1 = new Academy.Geometry.Quadrato(12.98);
            Academy.Geometry.Cerchio c1 = new Academy.Geometry.Cerchio(11.75);
            Academy.Geometry.Rettangolo r1 = new Academy.Geometry.Rettangolo(11.77, 33.99);
            Academy.Geometry.Triangolo t1 = new Academy.Geometry.Triangolo(3, 4, 5);
            //System.Console.WriteLine("Area {0}, Perimetro {1}", q1.GetArea(), q1.GetPerimetro());
            //System.Console.WriteLine("Area {0}, Perimetro {1}", c1.GetArea(), c1.GetPerimetro());

            //PrintQuadrato(q1);
            //PrintCerchio(c1);

            PrintFigura(q1);
            PrintFigura(c1);
            PrintFigura(r1);
            PrintFigura(t1);
        }
        private static void PrintFigura(Academy.Geometry.IFiguraGeometrica f)
        {
            System.Console.WriteLine("Area {0}, Perimetro {1}", f.GetArea(), f.GetPerimetro());
        }
        private static void PrintCerchio(Academy.Geometry.Cerchio c1)
        {
            System.Console.WriteLine("Area {0}, Perimetro {1}", c1.GetArea(), c1.GetPerimetro());
        }
        private static void PrintQuadrato(Academy.Geometry.Quadrato q1)
        {
            System.Console.WriteLine("Area {0}, Perimetro {1}", q1.GetArea(), q1.GetPerimetro());
        }
        private static void TestHR()
        {

            Persona mario = new Persona("Mario", "Rossi");


            Impiegato imp = new Impiegato();

            //System.Console.WriteLine(mario.ToString());

            String s1 = "";
            s1 = String.Empty;

            String s2 = "aaaa";
            String s3 = String.Concat(s1, s2);

            System.Console.WriteLine(s3.Length);


            //System.Console.WriteLine("Istanza mario: {0}, {1}", mario.Nome, mario.Cognome);
            System.Console.ReadLine();
        }
        private static void TestSplit()
        {
            // using String[] Split(char[] separator, StringSplitOptions options);
            string s = "25.67\t998.41";
            char[] chararray = new char[1];
            chararray[0] = '\t'; // ascii code  0x09 

            char carriageReturn = '\r'; // ascii code 0x13

            char lineFeed = '\n';  // ascii code 0x10

            char a = 'a'; // ascii code 0x61 -> 00100101
            char b = 'b'; // ascii code 0x62
            char c = 'c'; // ascii code 0x63

            String[] resultArray = s.Split(chararray);

            string temperature = resultArray[0];
            string pressure = resultArray[1];

            float temp_float = float.Parse(temperature, CultureInfo.InvariantCulture);
            float press_float = float.Parse(pressure, CultureInfo.InvariantCulture);

            System.Console.WriteLine("Temperatura {0} Pressione {1}", temp_float, press_float);
            System.Console.ReadLine();
        }
        private static void TestReadFile()
        {
            String dir = @"D:\temp";
            String filename = "pressione.txt";
            String path = dir + @"\" + filename;

            String out_temp = "temperature.txt";
            String out_press = "pressure.txt";

            System.IO.StreamWriter tempOutputFile = new System.IO.StreamWriter(
                                    System.IO.Path.Combine(dir, out_temp));

            System.IO.StreamWriter pressOutputFile = new System.IO.StreamWriter(
                                    System.IO.Path.Combine(dir, out_press));

            int var1 = 1000;
            string s1 = "aaaaaa";

            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            float max_float = float.MaxValue;
            float min_float = float.MinValue;

            float min_temp = max_float;
            float min_press = max_float;

            float max_temp = min_float;
            float max_press = min_float;

            float sum_temp = 0;
            float sum_press = 0;

            char[] chararray = new char[1];
            chararray[0] = '\t'; // ascii code  0x09 

            while ((line = file.ReadLine()) != null)
            {
                if (counter > 0)
                {
                    String[] resultArray = line.Split(chararray);

                    tempOutputFile.WriteLine(resultArray[0]);
                    pressOutputFile.WriteLine(resultArray[1]);

                    float temp_float = float.Parse(resultArray[0], CultureInfo.InvariantCulture);
                    float press_float = float.Parse(resultArray[1], CultureInfo.InvariantCulture);

                    if (temp_float > max_temp)
                        max_temp = temp_float;
                    if (temp_float < min_temp)
                        min_temp = temp_float;

                    if (press_float > max_press)
                        max_press = press_float;
                    if (press_float < min_press)
                        min_press = press_float;

                    sum_temp = sum_temp + temp_float;
                    sum_press += press_float;

                }
                counter++;
            }
            file.Close();
            tempOutputFile.Close();
            pressOutputFile.Close();

            float media_temp = sum_temp / (counter - 1);
            float media_press = sum_press / (counter - 1);

            System.Console.WriteLine(media_temp);
            System.Console.WriteLine(media_press);

            System.Console.WriteLine("There were {0} lines. {1} and {2}", counter, var1, s1);
            System.Console.WriteLine("Max temperature {0}, Min Temperature {1}", max_temp, min_temp);
            System.Console.WriteLine("Max pressure {0}, Min pressure {1}", max_press, min_press);
            System.Console.ReadLine();
        }
    }
}
