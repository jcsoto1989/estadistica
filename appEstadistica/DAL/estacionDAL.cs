using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appEstadistica.Entidades;

namespace appEstadistica.DAL
{
    public class estacionDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public estacionDAL()
        {
            _conexion = new OrmLiteConnectionFactory(DB.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public estacion getEstacion(int id)
        {
            return _db.Select<estacion>(a => a.idEstacion== id).LastOrDefault();
        }
        public void updateEstacion(estacion oEstacion)
        {
            _db.Update<estacion>(oEstacion);
        }
    }
}