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
    
    public class datoDAL
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public datoDAL()
        {
            _conexion = new OrmLiteConnectionFactory(DB.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void deleteDato(int idDato)
        {
            _db.Delete<dato>(a => a.idDato == idDato);
        }

        public List<dato> datos(int idEstacion)
        {
            return _db.Select<dato>(a => a.idEstacion==idEstacion);
        }

        public dato getDato(decimal valor)
        {
            return _db.Select<dato>(a => a.valor== valor).LastOrDefault();
        }

        public void updateDatos(List<dato> datos)
        {
            foreach (dato item in datos)
            {
                if (item.idDato != 0)
                    _db.Update<dato>(item);
                else
                    _db.Insert<dato>(item);
            }
        }
    }
}
