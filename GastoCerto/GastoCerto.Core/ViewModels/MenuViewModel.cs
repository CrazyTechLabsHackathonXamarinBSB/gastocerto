using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoCerto.Core.ViewModels
{
    public class MenuViewModel :  MvxViewModel
    {
        public MvxCommand DefinirGastoMax { get; private set; }
        public MvxCommand AdicionarGasto { get; private set; }

        public MenuViewModel()
        {
            DefinirGastoMax = new MvxCommand(ExecuteDefinirGastoMax);
            AdicionarGasto = new MvxCommand(ExecuteAdicionarGasto);

        }

        private void ExecuteDefinirGastoMax()
        {
            ShowViewModel<PrevisaoGastoViewModel>();
        }

        private void ExecuteAdicionarGasto()
        {
            ShowViewModel<AdicionarDespesaViewModel>();

        }



    }
}
