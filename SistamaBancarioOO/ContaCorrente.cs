using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistamaBancarioOO
{
    internal class ContaCorrente : ContaBancaria
    {

        private double LimiteChequeEspecial;

        public ContaCorrente(int numero, string titular, double limiteChequeEspecial) : base(numero, titular)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
        }

        public double LimiteChequeEspecial1 { 
            get => LimiteChequeEspecial;
            private set => LimiteChequeEspecial = value; 
        }

        public override bool Sacar(double valor)
        {
            double saldoDisponivel = saldo + LimiteChequeEspecial;
            if (valor <= saldoDisponivel)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
                return true;
            }
            Console.WriteLine("Saldo e limite insulficiente para saque na Conta Corrente.");
            return false;


        }


    }
}
