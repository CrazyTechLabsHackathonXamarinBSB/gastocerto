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
using Cirrious.MvvmCross.Droid.Views;

namespace GastoCerto.Droid.Views
{
    [Activity(Label = "Bem-Vindo!", Theme = "@style/CustomActionBarTheme")]
    public class PrincipalView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ActionBar.SetCustomView(Resource.Layout.Principal);
            ActionBar.SetDisplayShowCustomEnabled(true);
            SetContentView(Resource.Layout.Principal);
        }
    }
}