using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoCerto.Core.Modelo
{
    public class Dinheiro : MvxNotifyPropertyChanged
    {
        public string Saldo { get; set; }
        public string Gastos { get; set; }
    }
}
