using Cirrious.CrossCore.Converters;
using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GastoCerto.Core.Modelo
{
    public class PrevisaoGasto : MvxNotifyPropertyChanged
    {
        private DateTime _Data = DateTime.Now;
        private decimal _Saldo;

        public decimal Saldo { get { return _Saldo; } set { _Saldo = value; RaisePropertyChanged(() => Saldo); } }

        public DateTime Data { get { return _Data; } set { _Data = value; RaisePropertyChanged(() => Data); } }
    }
}
