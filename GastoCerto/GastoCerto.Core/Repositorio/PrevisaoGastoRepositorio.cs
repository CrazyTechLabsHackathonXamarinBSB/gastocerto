using Cirrious.CrossCore;
using GastoCerto.Core.Modelo;
using MvvmCross.Plugins.Sqlite;
using SQLite.Net.Async;
using System.Collections.Generic;

namespace GastoCerto.Core.Repositorio
{
    public class PrevisaoGastoRepositorio
    {
        private SQLiteAsyncConnection _connection;

        public async void Init()
        {
            var connectionFactory = Mvx.Resolve<IMvxSqliteConnectionFactory>();
            _connection = connectionFactory.GetAsyncConnection("GastoCertoBD");

            await _connection.CreateTableAsync<PrevisaoGastoRepositorio>();
        }

        public async void Inserir(PrevisaoGasto despesa)
        {
            await _connection.InsertAsync(despesa);
        }

        public async void Excluir(PrevisaoGasto despesa)
        {
            await _connection.DeleteAsync(despesa);
        }


        //public async AsyncTableQuery<PrevisaoGasto> Consulta()
        //{
        //    var p = _connection.Table<PrevisaoGasto>();
        //    return await p.ToListAsync();
        //}


    }
}
