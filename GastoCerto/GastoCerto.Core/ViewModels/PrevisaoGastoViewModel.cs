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
        public Despesa Despesa { get; private set; }

        public PrevisaoGastoViewModel()
        {
            Despesa = new Despesa();
        }
    }
}
