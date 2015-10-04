using Cirrious.CrossCore;
using GastoCerto.Core.Modelo;
using MvvmCross.Plugins.Sqlite;
using SQLite.Net.Async;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GastoCerto.Core.Repositorio
{
    public class DespesaRepositorio
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
            var dinheiro = Mvx.GetSingleton<Dinheiro>();
            dinheiro.Atualizar();
        }

        public async void Excluir(Despesa despesa)
        {
            await _connection.DeleteAsync(despesa);
            var dinheiro = Mvx.GetSingleton<Dinheiro>();
            dinheiro.Atualizar();
        }


        public async Task<List<Despesa>> Consulta()
        {
            var p = _connection.Table<Despesa>();
            var resul = await p.ToListAsync();
            return resul;
        }

    }
}
