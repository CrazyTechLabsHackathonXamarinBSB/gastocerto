using SQLite.Net.Attributes;
using System;

namespace GastoCerto.Core.Modelo
{
    public class Despesa
    {
        [PrimaryKey, AutoIncrement]
        public long id { get; set; }
        public DateTime data { get; set; }
        public string justificativa { get; set; }
        public decimal valor { get; set; } 
    }
}
