using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace Android_calculatrice
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText firstValue;
        EditText secondValue;
        EditText result;


        Button ButtonSuppr;
        Button ButtonPlus;
        Button ButtonMoin;
        Button ButtonMultiple;
        Button ButtonDivision;
        Button ButtonEgale;

        double a, b, c;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            firstValue = FindViewById<EditText>(Resource.Id.editText1);
            secondValue = FindViewById<EditText>(Resource.Id.editText2);
            result = FindViewById<EditText>(Resource.Id.editText3);

            ButtonSuppr = FindViewById<Button>(Resource.Id.btnSuppr);
            ButtonPlus = FindViewById<Button>(Resource.Id.btnPlus);
            ButtonMoin = FindViewById<Button>(Resource.Id.btnMoin);
            ButtonMultiple = FindViewById<Button>(Resource.Id.btnMultiple);
            ButtonDivision = FindViewById<Button>(Resource.Id.btnDivision);
            ButtonEgale = FindViewById<Button>(Resource.Id.btnEgale);

            computationButtons();

        }

        protected void computationButtons()
        {
            ButtonPlus.Click += delegate
            {
                try
                {

                    a = double.Parse(firstValue.Text);
                    b = double.Parse(secondValue.Text);
                    c = a + b;
                    result.Text = c.ToString();


                }
                catch (Exception ex)
                {


                    firstValue.Text = "Input Number(s)";
                    secondValue.Text = "Input Number(s)";
                    result.Text = "Invalid Operation";
                }
            };

            ButtonMoin.Click += delegate
            {
                try
                {
                    a = double.Parse(firstValue.Text);
                    b = double.Parse(secondValue.Text);
                    c = a - b;
                    result.Text = c.ToString();
                }
                catch (Exception ex)
                {


                    firstValue.Text = "Input Number(s)";
                    secondValue.Text = "Input Number(s)";
                    result.Text = "Invalid Operation";
                }
            };

            ButtonMultiple.Click += delegate
            {
                try
                {
                    a = double.Parse(firstValue.Text);
                    b = double.Parse(secondValue.Text);
                    c = a * b;
                    result.Text = c.ToString();
                }
                catch (Exception ex)
                {


                    firstValue.Text = "Input Number(s)";
                    secondValue.Text = "Input Number(s)";
                    result.Text = "Invalid Operation";
                }
            };
            ButtonDivision.Click += delegate
            {
                try
                {
                    a = double.Parse(firstValue.Text);
                    b = double.Parse(secondValue.Text);
                    c = a / b;
                    result.Text = c.ToString();

                }
                catch (Exception ex)
                {


                    result.Text = ex.Message;
                    firstValue.Text = "Input Number(s)";
                    secondValue.Text = "Input Number(s)";
                    result.Text = "Invalid Operation";

                }
            };
            ButtonSuppr.Click += delegate
            {
                secondValue.Text = "";
                firstValue.Text = "";
                result.Text = "";
            };

        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}