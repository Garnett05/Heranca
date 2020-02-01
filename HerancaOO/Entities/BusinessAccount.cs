using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaOO.Entities
{
    class BusinessAccount : Account // BusinessAccount está herdando de Account todos os seus métodos e atributos
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        //neste dois pontos está sendo feita a reutilização do construtor da Account, utilizando o base e passando os argumentos em comum entre as classes
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }            
        }
    }
}
