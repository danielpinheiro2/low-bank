using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowBank_Windows
{
    public class Cliente
    {
        public string Nome;
        public string CPF;
        public string Conta;
        public decimal Saldo;

        public Cliente(string nome, string cpf, string conta, decimal saldo)
        {
            Nome = nome;
            CPF = cpf;
            Conta = conta;
            Saldo = saldo;
        }
    }
}
