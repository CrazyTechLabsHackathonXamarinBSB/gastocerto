using Cirrious.MvvmCross.ViewModels;
using GastoCerto.Core.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoCerto.Core.ViewModels
{
    public class PrevisaoGastoViewModel : MvxViewModel
    {
        private DateTime _data = DateTime.Now;
        private Decimal _valor = new decimal();

        public DateTime Data
        {
            get { return _data; }
            set { _data= value; RaisePropertyChanged(() => Data); }
        }

        public Decimal Valor
        {
            get { return _valor; }
            set { _valor = value; RaisePropertyChanged(() => Valor); }
        }
    }
}
