using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEstadistica.Entidades
{
    public class estacion
    {
        [ServiceStack.DataAnnotations.AutoIncrement]
        public int idEstacion { get; set; }
        public string nombre { get; set; }
        public decimal media { get; set; }
        public decimal varianza { get; set; }
        public decimal desviacion { get; set; }
        public decimal zetaUno { get; set; }
        public decimal zetaDos { get; set; }

    }
}
