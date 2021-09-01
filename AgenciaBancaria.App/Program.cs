using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua teste", "384759387", "Paulista", "Pernambuco");
                Cliente cliente = new Cliente("Paulo", "123456", "987234", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " + conta.Situacao + " - " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                string senha = "abc123456789";

                conta.Abrir(senha);

                Console.WriteLine("Conta " + conta.Situacao + " - " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Sacar(10, senha);

                Console.WriteLine("Saldo: R$" + conta.Saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
