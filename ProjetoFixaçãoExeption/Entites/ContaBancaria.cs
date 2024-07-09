using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFixaçãoExeption.Entites.Exceptions;

namespace ProjetoFixaçãoExeption.Entites
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque {  get; set; }

        public ContaBancaria()
        {

        }

        public ContaBancaria(int numeroConta, string titular, double saldo, double limiteSaque)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            if (Saldo < quantia) 
            {
                throw new DominioExceptions("Erro, não é possivel realizar saque, Saldo insuficiente!");
            }
            if (quantia > LimiteSaque)
            {
                throw new DominioExceptions("Erro, o valor de saque superior ao limite de saque!");
            }
            Saldo -= quantia;
            LimiteSaque -= quantia;
        }
        public override string ToString()
        {
            return "Numero da conta: " + NumeroConta + ", " + "Titular: " + Titular + ", " + "Saldo atual: " + Saldo.ToString("f2")
                + ", " + "Limite da saque: " + LimiteSaque.ToString("f2");
        }
    }
}
