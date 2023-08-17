using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace LowBank_Windows
{
    public class Cliente
    {
        public string Nome;
        public string CPF;
        public string Conta;
        public decimal Saldo;
        public string Senha;

        public Cliente(string nome, string cpf, string conta, decimal saldo, string senha)
        {
            Nome = nome;
            CPF = cpf;
            Conta = conta;
            Saldo = saldo;
            Senha = senha;
        }

        public static Cliente Parse(string text)
        {
            //quebrar informações por virgula
            string[] informacoes = text.Split(',');

            string cpf = informacoes[0];
            string conta = informacoes[1];
            string nome = informacoes[2];
            string saldo = informacoes[3];
            string senha = informacoes[4];
            decimal saldoDecimal = decimal.Parse(saldo);

            return new Cliente(nome, cpf, conta, saldoDecimal, senha);
        }
    }
}
