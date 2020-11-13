using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.DBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string item = this.lst_Clienti.SelectedItem.ToString();
             string[] splittedString = item.Split(new char[] { ' ' });
             int ID = Int32.Parse(splittedString[0]);
            string connectionString = @"Data Source=WINAPHDFXGCXX6X\SQLEXPRESS;Initial Catalog=AcademyDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlcmdText = "SELECT TOP(1000)[ID],[NumeroConto],[Saldo] FROM [AcademyDB].[dbo].[ContiCorrenti]";
                SqlCommand cmd = new SqlCommand(sqlcmdText, conn);

                conn.Open(); //apro la connessione
                SqlDataReader dr = cmd.ExecuteReader(); //è la stessa cosa di uno stream di byte: li posiziono tutti in cima e li comincio a scorrere

                while (dr.Read())
                {
                 
             
                    string saldo = dr[2].ToString();
                    this.lst_ContiCorrenti.Items.Add(saldo);
                }

                conn.Close();
            }
        }

        private void btn_Clienti_Click(object sender, EventArgs e)
        { 
             string connectionString = @"Data Source=WINAPHDFXGCXX6X\SQLEXPRESS;Initial Catalog=AcademyDB;Integrated Security=True";
        
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
               
                
                string sqlcmdText = "SELECT TOP (1000) [ID],[FirstName],[LastName],[FiscalCode] FROM[AcademyDB].[dbo].[Clients]";
                SqlCommand cmd = new SqlCommand(sqlcmdText, conn);

                conn.Open(); //apro la connessione
                SqlDataReader dr = cmd.ExecuteReader(); //è la stessa cosa di uno stream di byte: li posiziono tutti in cima e li comincio a scorrere

                while (dr.Read())
                {
                    string id = dr[0].ToString();
                    string firstName = dr[1].ToString();
                    string lastName = dr[2].ToString();

                    string item = id+ " " + firstName + " " + lastName;
                    this.lst_Clienti.Items.Add(item);
                }

                conn.Close(); 
            }
        }

        private void lst_ContiCorrenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
