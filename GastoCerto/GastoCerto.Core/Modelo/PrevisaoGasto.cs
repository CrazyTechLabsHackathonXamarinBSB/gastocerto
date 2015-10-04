using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoCerto.Core.Modelo
{
    public class PrevisaoGasto: MvxNotifyPropertyChanged
    {
        private DateTime _Data;
        private decimal _Saldo;

        public decimal Saldo { get; set; }

        public DateTime Data { get { return _Data; } set { _Data = value; RaisePropertyChanged(() => Data); } }


    }
}
