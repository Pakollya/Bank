using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public delegate void AccountStateHandler(object sendler, AccountEventArgs e);

    public class AccountEventArgs
    {
        public string Message { get; private set; }

        public decimal Summ { get; private set; }

        public AccountEventArgs(string _mes, decimal _sum)
        {
            Message = _mes;
            Summ = _sum;
        }
    }
}
