using Cirrious.MvvmCross.ViewModels;
using SQLite.Net.Attributes;
using System;

namespace GastoCerto.Core.Modelo
{
    public class Despesa : MvxNotifyPropertyChanged
    {
        private long _Id;
        private DateTime _Data = DateTime.Now;
        private string _Justificativa;
        private decimal _Valor;
        private string _Foto;

        [PrimaryKey, AutoIncrement]
        public long Id { get { return _Id; } set { _Id = value; RaisePropertyChanged(() => Id); } }
        public DateTime Data { get { return _Data; } set { _Data = value; RaisePropertyChanged(() => Data); } }
        public string Justificativa { get { return _Justificativa; } set { _Justificativa = value; RaisePropertyChanged(() => Justificativa); } }
        public decimal Valor { get { return _Valor; } set { _Valor = value; RaisePropertyChanged(() => Valor); } }
        public string Foto { get { return _Foto; } set { _Foto = value; RaisePropertyChanged(() => Foto); } }


    }
}
