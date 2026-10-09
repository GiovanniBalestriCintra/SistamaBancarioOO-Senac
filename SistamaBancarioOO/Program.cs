namespace SistamaBancarioOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ContaCorrente conta1 = new ContaCorrente(1, "Pedro Gustavo", 10);
            //ContaCorrente conta2 = new ContaCorrente(2, "Daniel Roger", 20);


            ContaPoupanca conta1 = new ContaPoupanca(1, "Pedro Gustavo", 10);
            ContaPoupanca conta2 = new ContaPoupanca(2, "Daniel Roger", 20);
            ContaEmpresarial conta3 = new ContaEmpresarial(3, "Vinicios Carvalho", 50);


            conta1.Depositar(1000);

            conta3.Depositar(50);

            conta3.Transferir(10, conta2);


            conta1.ExibirDados();
            Console.WriteLine("-------------------------------");
            conta2.ExibirDados(); 
            Console.WriteLine("-------------------------------");
            conta3.ExibirDados();




        }
    }
}
