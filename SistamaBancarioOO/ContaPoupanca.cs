using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistamaBancarioOO
{
    internal class ContaPoupanca : ContaBancaria
    {

        private double taxaRendimento;

        public double TaxaRendimento
        {
            get => taxaRendimento;
            private set => taxaRendimento = value;
        }



        public ContaPoupanca(int numero, string titular, double taxaRendimento) : base(numero, titular)
        {
            TaxaRendimento = taxaRendimento;
        }



        public void AplicarRendimento()
        {
            saldo += saldo * (TaxaRendimento / 100);
        }
    }
}
