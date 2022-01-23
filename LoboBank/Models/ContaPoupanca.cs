using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoboBank.Models
{
    internal class ContaPoupanca : Conta
    {        
        private Double Rendimento { get; set; } = 0.005;

        public ContaPoupanca(Double saldo, Cliente cliente)
        {
            Saldo = saldo;
            if (Clientes is not null) Clientes.Add(cliente);
            else Console.WriteLine("Lista Nula");
        }

        public double SaldoAtual(DateTime diaDoCalculo)
        {
            return Saldo - (Rendimento * Saldo);
        }
    }
}
