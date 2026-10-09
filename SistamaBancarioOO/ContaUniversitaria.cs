using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistamaBancarioOO
{

    internal class ContaUniversitaria : ContaBancaria
    {

        private const double rendimentoUniversitario = 0.05;

        public ContaUniversitaria(int numero, string titular, double rendimentoUniversitario) : base(numero, titular)
        {
            RendimentoUniversitario = rendimentoUniversitario;
        }

        public double RendimentoUniversitario { 
            get => RendimentoUniversitario; 
            set => RendimentoUniversitario = value; 
        }

        public void AdicionarRendimentoUniversitario()
        {

            saldo += saldo * RendimentoUniversitario;

        }
    }
}
