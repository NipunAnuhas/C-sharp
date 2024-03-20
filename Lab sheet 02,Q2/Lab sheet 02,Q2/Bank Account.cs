using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_02_Q2
{
    internal class Bank_Account
    {
        public int AccountNumber;
        public double Balance;

        public void deposit(double amount)
        {
            Balance = Balance + amount;
        }
    }
}
