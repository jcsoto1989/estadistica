using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEstadistica.Entidades
{
    public class dato
    {
        [ServiceStack.DataAnnotations.AutoIncrement]
        public int idDato { get; set; }
        public int idEstacion { get; set; }
        public Decimal valor { get; set; }
        public int frecuencia { get; set; }
        public Decimal probabilidad { get; set; }
        public Decimal xPx { get; set; }
        public Decimal xuPx { get; set; }

    }
}
