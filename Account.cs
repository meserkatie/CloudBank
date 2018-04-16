using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CloudBank
{
    public class Account
    {
        private String type;
        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        private int accountID;
        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        private List<Transaction> transactions;
        public List<Transaction> Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }
    }
}