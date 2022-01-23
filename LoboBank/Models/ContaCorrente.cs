using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoboBank.Models
{
    internal class ContaCorrente:Conta
    {
        private double ChequeEspecial { get; set; } = 100;

        private double JurosChequeEspecial { get; set; } = 0.12;        

        public ContaCorrente(double saldo, double chequeEspecial, Cliente cliente)
        {
            Saldo = saldo;
            ChequeEspecial = chequeEspecial;
            if (Clientes is not null) Clientes.Add(cliente);
            else Console.WriteLine("Lista Nula");
        }

        public override void Sacar(double valorSaque)
        {
            if (valorSaque <= (Saldo + ChequeEspecial)) 
            {
                Saldo -= valorSaque;
                if (valorSaque <= Saldo) Console.WriteLine("Saldo Insuficiente, Você entrou no cheque especial");
            }
            else Console.WriteLine("Seu saldo mais o cheque especial não cobre este valor de Saque");
        }

        public double SaldoAtual(DateTime diaDoCalculo)
        {
            return Saldo - (JurosChequeEspecial * Saldo) ;
        }

        public void Transferir(Conta conta, double valorDeTranferencia)
        {
            Sacar(valorDeTranferencia);
            conta.Depositar(valorDeTranferencia);
        }



    }
}
