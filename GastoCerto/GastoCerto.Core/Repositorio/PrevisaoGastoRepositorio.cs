using Cirrious.CrossCore;
using GastoCerto.Core.Modelo;
using MvvmCross.Plugins.Sqlite;
using SQLite.Net.Async;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GastoCerto.Core.Repositorio
{
    public class PrevisaoGastoRepositorio
    {
        private SQLiteAsyncConnection _connection;

        public async void Init()
        {
            var connectionFactory = Mvx.Resolve<IMvxSqliteConnectionFactory>();
            _connection = connectionFactory.GetAsyncConnection("GastoCertoBD");

            await _connection.CreateTableAsync<PrevisaoGasto>();
        }

        public async void Inserir(PrevisaoGasto despesa)
        {
            try
            {
                await _connection.InsertAsync(despesa);
            }
            catch (System.Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            var dinheiro = Mvx.GetSingleton<Dinheiro>();
            dinheiro.Atualizar();
        }

        public async void Excluir(PrevisaoGasto despesa)
        {
            await _connection.DeleteAsync(despesa);
            var dinheiro = Mvx.GetSingleton<Dinheiro>();
            dinheiro.Atualizar();
        }
        
        public async Task<List<PrevisaoGasto>> Consulta()
        {
            var p = _connection.Table<PrevisaoGasto>();
            return await p.ToListAsync();
        }
    }
}
