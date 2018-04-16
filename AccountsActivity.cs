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
    [Activity(Label = "AccountsActivity")]
    public class AccountsActivity : Activity
    {
        //Step 2--Declare Class Variables
        Button btnLogout;
        Button btnChecking;
        Button btnSavings;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            //Step 1
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Accounts);

            //Step 3--Find Controls
            btnLogout = FindViewById<Button>(Resource.Id.btnLogout);
            btnChecking = FindViewById<Button>(Resource.Id.btnChecking);
            btnSavings = FindViewById<Button>(Resource.Id.btnSavings);

            //Step 4--Event Handler(s)
            btnLogout.Click += BtnLogout_Click;
            btnSavings.Click += BtnSavings_Click;
            btnChecking.Click += BtnChecking_Click;
        }

        private void BtnChecking_Click(object sender, EventArgs e)
        {
            User.ActiveAccount = User.Checking;
            StartActivity(typeof(TransactionsActivity));
        }

        private void BtnSavings_Click(object sender, EventArgs e)
        {
            User.ActiveAccount = User.Saving;
            StartActivity(typeof(TransactionsActivity));
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }
    }
}