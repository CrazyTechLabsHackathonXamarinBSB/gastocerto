using Cirrious.MvvmCross.ViewModels;
using SQLite.Net.Attributes;
using System;

namespace GastoCerto.Core.Modelo
{
    public class Despesa : MvxNotifyPropertyChanged
    {
        private long _Id;
        private DateTime _Data;
        private string _Justificativa;
        private decimal _Valor;

        [PrimaryKey, AutoIncrement]
        public long Id { get { return _Id; } set { _Id = value; RaisePropertyChanged(() => Id); } }
        public DateTime Data { get { return _Data; } set { _Data = value; RaisePropertyChanged(() => Data); } }
        public string Justificativa { get { return _Justificativa; } set { _Justificativa = value; RaisePropertyChanged(() => justificativa); } }
        public decimal Valor { get { return _Valor; } set { _Valor = value; RaisePropertyChanged(() => Valor); } }

    }
}
