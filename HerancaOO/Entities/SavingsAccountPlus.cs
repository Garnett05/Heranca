using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaOO.Entities
{
    class SavingsAccountPlus : SavingsAccount //esta linha está dando erro, pois a classe SavingsAccount está selada, não permitindo assim q ela seja herdada
    {
        /*Não é possível sobrescrever o método Withdraw pois o método original foi selado, impedindo assim a sobrescrita
        public override void Withdraw(double amount)
        {

        }*/
    }
}
