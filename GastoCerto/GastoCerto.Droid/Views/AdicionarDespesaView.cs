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

    [Activity(Label = "LANÇAMENTO DE DESPESAS")]
    public class AdicionarDespesaView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AdicionarDespesa);
        }

    }
}