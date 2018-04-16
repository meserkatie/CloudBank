using Android.App;
using Android.Widget;
using Android.OS;

namespace CloudBank.Activities
{
    [Activity(Label = "CloudBank", MainLauncher = true)]
    public class MainActivity : Activity
    {
        //Step 2--Declare Class Variables
        EditText txtUsername;
        EditText txtPassword;
        Button btnLogin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Step 1
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Step 3--Find Controls
            txtUsername = FindViewById<EditText>(Resource.Id.txtUsername);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);

            //Step 4--Event Handler(s)
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            string inputUN = txtUsername.Text.ToLower();

            if(inputUN.Equals(User.Username) && txtPassword.Text.Equals(User.Password))
            {
                //login
                User.login();
                StartActivity(typeof(AccountsActivity));
            }
            else
            {
                //Error
                Toast.MakeText(this, "Incorrect Credentials", ToastLength.Short).Show();
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            
        }
    }
}

