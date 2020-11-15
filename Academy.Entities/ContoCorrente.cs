using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Entities
{
    public class ContoCorrente
    {
        public int MyProperty { get; set; }

        private string numeroConto;
        private double saldo;
        private Cliente owner;

        public List<Movimento> Movimenti { get; }
        public ContoCorrente(Cliente owner)
        {
            Movimenti = new List<Movimento>();
            this.owner = owner;
        }

        public Cliente GetOwner()
        {
            return this.owner;
        }

        public string GetNumeroConto()
        {
            return numeroConto;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public ContoCorrente(string numeroConto)
        {
            this.numeroConto = numeroConto;
            saldo = 0;
        }
        public OperationResult Deposita(double cifra)
        {
            saldo += cifra;
            Movimento deposito = new Movimento()
            {
                Tipo = TipoMovimento.Deposito,
                Importo = cifra,
                Data = DateTime.Now
            };

            //Movimento deposito = new Movimento();
            //deposito.Tipo = TipoMovimento.Deposito;
            //deposito.Importo = cifra;
            //deposito.Data = DateTime.Now;

            Movimenti.Add(deposito);

            return OperationResult.Operazione_OK;
        }
        public OperationResult Preleva(double cifra)
        {
            OperationResult result = OperationResult.FondiInsufficienti;
            if (saldo >= cifra)
            {
                saldo -= cifra;

                Movimenti.Add(new Movimento()
                {
                    Tipo = TipoMovimento.Prelievo,
                    Importo = cifra,
                    Data = DateTime.Now
                });

                result = OperationResult.Operazione_OK;
            }
            return result;
        }

        public OperationResult Bonifico(double cifra, ContoCorrente beneficiario)
        {
            Movimenti.Add(new Movimento()
            {
                Tipo = TipoMovimento.Bonifico,
                Importo = cifra,
                Data = DateTime.Now,
                Beneficiario = beneficiario.GetNumeroConto()
            });
            return OperationResult.Operazione_OK;
        }
    }
}
