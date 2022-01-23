using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoboBank.Models
{
    abstract class Conta
    {
        public ulong Numero { get; set; }

        protected Double Saldo { get; set; } = 0;

        protected List<Cliente>? Clientes { get; set; }

        public List<int>? Movimentacoes { get; set; }

        public void Depositar(double valorDeposito)
        {
            if (valorDeposito>0) Saldo += valorDeposito;
            else Console.WriteLine("Valor inválido para Depósito");
        }

        public virtual void Sacar(double valorSaque)
        {
            if (valorSaque <= Saldo) Saldo -= valorSaque;
            else Console.WriteLine("Saldo Insuficiente para esse valor de Saque");
        }
    }
}
