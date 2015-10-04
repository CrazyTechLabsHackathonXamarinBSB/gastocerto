using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using GastoCerto.Core.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoCerto.Core.Modelo
{
    public class Dinheiro : MvxNotifyPropertyChanged
    {
        private string _saldo;
        private string _gastos;

        public async void Atualizar()
        {
            var despesaRepositorio = Mvx.GetSingleton<DespesaRepositorio>();
            var despesas = await despesaRepositorio.Consulta();
            var somaTotal = despesas.Sum(d => d.Valor);
            Gastos = string.Format("{0:C2}", somaTotal);

            var previsaoGastoRepositorio = Mvx.GetSingleton<PrevisaoGastoRepositorio>();
            var saldo = await previsaoGastoRepositorio.Consulta();
            var somaTotalSaldo = saldo.Sum(d => d.Saldo);
            Saldo = string.Format("{0:C2}", somaTotalSaldo);
        }

        public string Saldo { get { return _saldo; } set { _saldo = value; RaisePropertyChanged(() => Saldo); } }
        public string Gastos { get { return _gastos; } set { _gastos = value; RaisePropertyChanged(() => Gastos); } }
    }
}
