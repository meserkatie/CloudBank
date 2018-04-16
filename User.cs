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
    public static class User
    {
        private static String username = "clouduser";
        public static String Username
        {
            get { return username; }
            set { username = value; }
        }

        private static String password = "318";
        public static String Password
        {
            get { return password; }
            set { password = value; }
        }

        private static Account checking = new Account();
        public static Account Checking
        {
            get { return checking; }
            set { checking = value; }
        }

        private static Account saving = new Account();
        public static Account Saving
        {
            get { return saving; }
            set { saving = value; }
        }

        private static Account activeAccount = new Account();
        public static Account ActiveAccount
        {
            get { return activeAccount; }
            set { activeAccount = value; }
        } 

        public static void login()
        {
            checking.AccountID = 1;
            checking.Type = "Checking";
            saving.AccountID = 2;
            saving.Type = "Savings";

            Random rand = new Random();

            //fill lists with data
            //-----checking----
            List<Transaction> temp = new List<Transaction>();
            int x = 25;
            for (int i = 0; i < 25; i++)
            {
                Transaction newT = new Transaction();
                //tranasaction amount
                newT.Amount = rand.Next(25, 99);
                //transaction date
                newT.Date = "4/" + x.ToString() + "/2018";
                //transaction id
                newT.ID = i;
                //transaction vendor
                if (i % 2 == 0)
                    newT.Vendor = "Coffee Shop";
                else
                    newT.Vendor = "Home Mart";

                temp.Add(newT);
                x--;
            }

            checking.Transactions = temp;

            List<Transaction> temp1 = new List<Transaction>();
            //------savings-------
            x = 25;
            for (int i = 0; i < 25; i++)
            {
                Transaction newT = new Transaction();
                //tranasaction amount
                newT.Amount = rand.Next(25, 99);
                //transaction date
                newT.Date = "4/" + x.ToString() + "/2018";
                //transaction id
                newT.ID = i;
                //transaction vendor
                if (i % 2 == 0)
                    newT.Vendor = "Personal Withdrawal";
                else
                    newT.Vendor = "Personal Deposit";

                temp1.Add(newT);
                x--;
            }
            saving.Transactions = temp1;
        } 
    }
}