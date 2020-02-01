using System;
using HerancaOO.Entities;

namespace HerancaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Jarbas", 700.00, 300.00);
            Console.WriteLine(account.Balance);            
        }
    }
}
