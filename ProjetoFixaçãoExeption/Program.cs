using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFixaçãoExeption.Entites.Exceptions;
using ProjetoFixaçãoExeption.Entites;
using System.Globalization;

namespace ProjetoFixaçãoExeption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com dados da conta: ");
                Console.WriteLine();
                Console.Write("Numero da conta: ");
                int numeroConta = int.Parse(Console.ReadLine());
                Console.Write("Nome do Titular: ");
                string titular = Console.ReadLine();
                Console.Write("Saldo da conta: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de saque: ");
                double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ContaBancaria contaBancaria = new ContaBancaria(numeroConta, titular, saldo, limiteSaque);

                Console.Write("Dados da conta: " + contaBancaria);
                Console.WriteLine();
                Console.Write("Entre com valor de saque bancario: ");
                double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                contaBancaria.Saque(quantia);
                Console.WriteLine();
                Console.WriteLine("Dados atualizados: ");
                Console.Write(contaBancaria);
            }
            catch (DominioExceptions ex)
            {
                Console.WriteLine("Erro " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro " + ex.Message);
            }
            Console.ReadLine() ;
        }
    }
}
