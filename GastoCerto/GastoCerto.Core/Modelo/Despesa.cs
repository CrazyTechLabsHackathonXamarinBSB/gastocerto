using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoCerto.Core.Modelo
{
    public class Despesa
    {
        public long id { get; set; }
        public DateTime data { get; set; }
        public string justificativa { get; set; }

        public decimal valor { get; set; } 
    }
}
