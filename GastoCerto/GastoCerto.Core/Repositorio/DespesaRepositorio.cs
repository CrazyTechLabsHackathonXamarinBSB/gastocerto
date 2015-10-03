﻿using Cirrious.CrossCore;
using GastoCerto.Core.Modelo;
using MvvmCross.Plugins.Sqlite;
using SQLite.Net.Async;

namespace GastoCerto.Core.Repositorio
{
    class DespesaRepositorio
    {
        private SQLiteAsyncConnection _connection;

        public async void Init()
        {
            var connectionFactory = Mvx.Resolve<IMvxSqliteConnectionFactory>();
            _connection = connectionFactory.GetAsyncConnection("GastoCertoBD");

            await _connection.CreateTableAsync<Despesa>();
        }

        public async void Inserir(Despesa despesa)
        {
            await _connection.InsertAsync(despesa);
           // _connection.Table<Despesa>()
        }

        public async void Excluir(Despesa despesa)
        {
            await _connection.DeleteAsync(despesa);
        }

        //public async ObserverCollection<Despesa> Consultar()
        //{
        //    await _connection.InsertAsync(despesa);
        //    // _connection.Table<Despesa>()
        //}



    }
}