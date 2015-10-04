using Cirrious.MvvmCross.ViewModels;
using GastoCerto.Core.Modelo;
using GastoCerto.Core.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GastoCerto.Core.ViewModels
{
    public class PrevisaoGastoViewModel : MvxViewModel
    {
        public PrevisaoGasto Gasto { get; private set; }

        public PrevisaoGastoViewModel()
        {
            Gasto = new PrevisaoGasto();
        }

        public ICommand Salvar
        {
            get {
                return new MvxCommand(() =>
                {
                    PrevisaoGastoRepositorio r = new PrevisaoGastoRepositorio();
                    r.Inserir(Gasto);
                });
            }
        }

        

    }
}
