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
    public class Transaction
    {
        private double amount;
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private String date;
        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        private String vendor;
        public String Vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        public String viewTransaction()
        {
            return date + "\n" + vendor + "\n" + Amount.ToString("c");
        }

        public override string ToString()
        {
            return date + "\n" + vendor + "\n" + Amount.ToString("c");
        }

    }
}