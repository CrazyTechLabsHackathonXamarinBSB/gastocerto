using Cirrious.CrossCore;
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
    public class AdicionarDespesaViewModel : MvxViewModel
    {
        public Despesa Despesa { get; private set; }

        public AdicionarDespesaViewModel()
        {
            Despesa = new Despesa();
        }

        public ICommand Salvar
        {
            get
            {
                return new MvxCommand(() =>
                {
                    var r = Mvx.GetSingleton<DespesaRepositorio>();
                    r.Inserir(Despesa);
                });
            }
        }

    }
}
