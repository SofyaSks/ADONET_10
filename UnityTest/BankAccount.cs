using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTest
{
    public class BankAccount
    {
        public string UserName { get; set; }
        public int Balance { get; set; }

        public BankAccount(string userName, int balance)
        {
            UserName = userName;
            Balance = balance;
        }

        public void Withdraw(int amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("not enough money");
            }
            if (amount <= 0 )
            {
                throw new InvalidOperationException("no negative values");
            }

            Balance -= amount;

        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }
    }
}
