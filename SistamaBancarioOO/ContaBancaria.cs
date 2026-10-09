using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistamaBancarioOO
{
    public abstract class ContaBancaria
    {

        private int numero;
        private string titular;
        protected double saldo;

        protected ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            saldo = 0;
        }

        public int Numero { 
            get => numero; 
            protected set => numero = value; }

        public string Titular { 
            get => titular; 
            protected set => titular = value; }

        public void Depositar (double valor)
        {
            if (valor >= 0)
            {
                this.saldo += valor;
                Console.WriteLine($"Deposito de R${valor} realizado com sucesso.");
            }
        }

        public virtual bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
                return true;
            }

            Console.WriteLine("Saldo insulficiente.");
            return false;
        }


        public void ExibirDados()
        {
            Console.WriteLine($"Conta: {numero} | Titular: {titular} | Saldo: {saldo}.");
        }


        public bool Transferir(double valor, ContaBancaria contaDestino) {


            if (valor > 0 && valor <= saldo)
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);

                Console.WriteLine($"Transferência de R${valor} para a conta: {numero} realizado com sucesso.");
                return true;
            }

            Console.WriteLine("Transferência não realizada. \n Conta não encontrada");
            return false;
        }

    }
}
