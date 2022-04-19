using System;
using TratamentoDeExecoes.Entities.Exceptions;

namespace TratamentoDeExecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithDrawLimit{ get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            WithDrawLimit = withDrawLimit;
        }

        //demais métodos

        public void Deposit(double amount)
        {
            Balance = amount;
        }

        public void WithDraw(double amount)
        {
            
            if(Balance < 0 || Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            if(amount > WithDrawLimit)
            {
                throw new DomainException("The amount exceds withdraw limit");
            }
            Balance -= amount;
        }
    }
}
