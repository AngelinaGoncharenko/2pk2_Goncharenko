using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public delegate void AccountStateHandler(object sender, AccountEventArgs e);

    // определите конструктор класса, инициирующий Message и Sum
    public class AccountEventArgs
    {
        // создайте автосвойство сообщения (Message)
        public string Message { get; set; }

        // определите автосвойство суммы (Sum), на которую изменился счет,
        // причем блок set сделайте приватным, для того чтобы внешний код не
        // мог менять данную сумму.
        public decimal Sum { get; private set; }

        public AccountEventArgs(string message, decimal sum)
        {
            Message = message;
            Sum = sum;
        }
    }
}
