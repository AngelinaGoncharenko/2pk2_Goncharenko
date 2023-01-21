using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace pz_ClassWriting
{
    internal class BankAccount
    {
        public string name = "Angelina";
        public int AccountNumber = 1735;
        public int Amount = 10000;
        public string AccountType = "debit";


        public void Print()
        {
            Console.WriteLine($"Owner's name: {name} \nAccount number: {AccountNumber} \nAccount type: {AccountType} \nThe amount in the account: {Amount}");
        }
    }
}
