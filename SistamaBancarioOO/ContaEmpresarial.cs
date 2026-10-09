using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistamaBancarioOO
{
    internal class ContaEmpresarial : ContaBancaria
    {

        private const double taxa = 5.00;
        private double limiteEmprestimo;

        public ContaEmpresarial(int numero, string titular, double limiteEmprestimo) : base(numero, titular)
        {

            this.limiteEmprestimo = limiteEmprestimo;

        }

        public double LimiteEmprestimo
        {
            get => limiteEmprestimo;
            set => limiteEmprestimo = value;
        }

        public override bool Sacar(double valor)
        {

            if (valor + taxa <= saldo)
            {
                saldo -= (valor + taxa);
                Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
                Console.WriteLine($"Taxa de R${taxa} cobrada.");
                return true;
            }

            Console.WriteLine("Saldo insuficiente.");
            return false;
        }

        public bool FazerEmprestimo(double valor)
        {
            if (valor > 0 && valor <= limiteEmprestimo)
            {
                saldo += valor;
                limiteEmprestimo -= valor;

                Console.WriteLine($"Empréstimo de R${valor} aprovado.");
                return true;
            }

            Console.WriteLine("Limite de empréstimo insuficiente.");
            return false;
        }

    }

    }

