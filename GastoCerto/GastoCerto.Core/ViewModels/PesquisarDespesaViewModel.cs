using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using GastoCerto.Core.Modelo;
using GastoCerto.Core.Repositorio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GastoCerto.Core.ViewModels
{
    public class PesquisarDespesaViewModel : MvxViewModel
    {
        private readonly ObservableCollection<Despesa> _Despesas = new ObservableCollection<Despesa>();
        public ObservableCollection<Despesa> Despesas
        {
            get
            {
                return _Despesas;
            }
        }

        public async void Init()
        {
            var despesaRepositorio = Mvx.GetSingleton<DespesaRepositorio>();
            var resultadoConsulta = await despesaRepositorio.Consulta();

            foreach (var despesa in resultadoConsulta)
            {
                Despesas.Add(despesa);
            }
        }

    }
}
