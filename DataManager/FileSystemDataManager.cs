using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class FIleSystemDataManager : IDataManager
    {
        private string bankDir = @"D:\temp\BankDB";
        private string usersFileName;
        private string clientiFileName;
        private string ccFileName;
        private string movimentiFileName;

        /// <summary>
        /// 
        /// </summary>
        public FIleSystemDataManager()
        {
            usersFileName = System.IO.Path.Combine(bankDir, "Users.txt");
            clientiFileName = System.IO.Path.Combine(bankDir, "Clienti.txt");
            ccFileName = System.IO.Path.Combine(bankDir, "ContiCorrenti.txt");
            movimentiFileName = System.IO.Path.Combine(bankDir, "Movimenti.txt");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newCliente"></param>
        /// <returns></returns>
        public DataOperationResult CreateNewCliente(Cliente newCliente)
        {
            DataOperationResult result = new DataOperationResult();
            // Write a row in Clienti.txt
            try
            {
                //   comment .... https://stackoverflow.com/a/21795858

                using (System.IO.StreamWriter sw_clienti = File.AppendText(clientiFileName))
                {

                    string s_new_cliente = newCliente.Username + ";" +
                                         newCliente.FirstName + ";" +
                                         newCliente.LastName + ";" +
                                         newCliente.CF;
                    sw_clienti.WriteLine(s_new_cliente);
                    sw_clienti.Close();
                }

                using (System.IO.StreamWriter sw_cc = File.AppendText(ccFileName))
                {
                    ContoCorrente new_cc = newCliente.mioConto;
                    string s_new_cc = new_cc.GetNumeroConto() + ";" + new_cc.GetSaldo() + ";" + newCliente.Username;
                    sw_cc.WriteLine(s_new_cc);
                    sw_cc.Close();
                }

                result.IsOK = true;
            }
            catch (Exception excp)
            {
                result.IsOK = false;
                result.Message = excp.Message;
            }


            return result;
        }

        public ContoCorrente GetContocorrenteByUsername(string username)
        {
            ContoCorrente cc_result = null;

            using (System.IO.StreamReader file = new System.IO.StreamReader(ccFileName))
            {
                string line;
                char[] chararray = new char[1]; // se scrivessi char[] ca starei dichiarando un puntatore vuoto
                chararray[0] = ';';
                while (!String.IsNullOrEmpty(line = file.ReadLine())) // quella tra paresntesi si chiama guardia ed e' un espressione booleana
                {
                    String[] resultArray = line.Split(chararray);
                    string current_user = resultArray[2];
                    if (username == current_user)
                    {
                        cc_result = new ContoCorrente(resultArray[0]);
                        break;
                    }
                }
                file.Close();
            }

            return cc_result;
        }

        public bool LoginIsOK(string username, string password)
        {

            bool result = false;
            // per stampare su due righe \r\n quindi ora sta interpretando come caratteri di escape
            // quindi o metto doppio backslash oppure metto chiocciola davanti ai doppi apici


            string line;
            char[] chararray = new char[1]; // se scrivessi char[] ca starei dichiarando un puntatore vuoto
            chararray[0] = ';';
            System.IO.StreamReader file = new System.IO.StreamReader(usersFileName);
            while ((line = file.ReadLine()) != null) // quella tra paresntesi si chiama guardia ed e' un espressione booleana
            {
                String[] resultArray = line.Split(chararray);
                string current_user = resultArray[0];
                string current_pw = resultArray[1];
                if (username == current_user && password == current_pw)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public bool UserIsAnOwner(string username)
        {
            bool result = false;
            string line;
            char[] chararray = new char[1]; // se scrivessi char[] ca starei dichiarando un puntatore vuoto
            chararray[0] = ';';
            using (System.IO.StreamReader file = new System.IO.StreamReader(ccFileName))
            {
                while (!String.IsNullOrEmpty(line = file.ReadLine())) // quella tra paresntesi si chiama guardia ed e' un espressione booleana
                {
                    String[] resultArray = line.Split(chararray);
                    string current_user = resultArray[2];
                    if (username == current_user)
                    {
                        result = true;
                        break;
                    }
                }
                file.Close();
            }
            return result;
        }
    }
}
