using Cirrious.MvvmCross.ViewModels;
using GastoCerto.Core.Modelo;
using GastoCerto.Core.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoCerto.Core.ViewModels
{
    public class MenuViewModel :  MvxViewModel
    {

        public Dinheiro Dinheiro { get; private set; }
        
        public MvxCommand DefinirGastoMax { get; private set; }
        public MvxCommand AdicionarGasto { get; private set; }
        public MvxCommand PesquisarDespesa { get; private set; }

        public decimal ValorSaldo { get; set; }
        public decimal ValorDespesa { get; set; }


        public MenuViewModel()
        {
            
            DefinirGastoMax = new MvxCommand(ExecuteDefinirGastoMax);
            AdicionarGasto = new MvxCommand(ExecuteAdicionarGasto);
            PesquisarDespesa = new MvxCommand(ExecutePesquisarDespesa);
            Dinheiro = new Dinheiro();
            AtualizarSaldo();   

        }


        private  void AtualizarSaldo()
        {
         
            Dinheiro.Saldo = "R$ 100,00";
            Dinheiro.Gastos = "R$ 80,00";
        }


        private void ExecuteDefinirGastoMax()
        {
            ShowViewModel<PrevisaoGastoViewModel>();
        }

        private void ExecuteAdicionarGasto()
        {
            ShowViewModel<AdicionarDespesaViewModel>();

        }

        private void ExecutePesquisarDespesa()
        {
            ShowViewModel<PesquisarDespesaViewModel>();
        }

    }
}
