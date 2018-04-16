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

namespace CloudBank.Activities
{
    [Activity(Label = "TransactionsActivity")]
    public class TransactionsActivity : Activity
    {
        //Step 2--Declare Class Variables
        Button btnBack;
        Button btnLogout;
        TextView txtTime;
        ListView lvTransactions;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            //Step 1
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Transactions);

            //Step 3--Find Controls
            btnLogout = FindViewById<Button>(Resource.Id.btnLogout);
            btnBack = FindViewById<Button>(Resource.Id.btnBack);
            lvTransactions = FindViewById<ListView>(Resource.Id.lvTransactions);
            txtTime = FindViewById<TextView>(Resource.Id.txtTime);

            //ListView
            txtTime.Text = "Last Updated: " + DateTime.Now.ToString();
            List<Transaction> temp = new List<Transaction>();

            temp = User.ActiveAccount.Transactions;

            ArrayAdapter<Transaction> adapter = new ArrayAdapter<Transaction>(this, Android.Resource.Layout.SimpleListItem1, temp);

            lvTransactions.Adapter = adapter;
            //Step 4--Event Handler(s)
            btnLogout.Click += BtnLogout_Click;
            btnBack.Click += BtnBack_Click;

            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(AccountsActivity));
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}