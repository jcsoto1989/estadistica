using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEstadistica.DAL
{
    public class estacionDAL
    {
   {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public estacionDAL()
        {
            _conexion = new OrmLiteConnectionFactory(DB.Default.conexion, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }
        /* public int InsertarComanda(Comanda comanda)
         {
             _db.Insert<Comanda>(comanda);
             return _db.Select<Comanda>().Last().IdComanda;
         }

         public List<Comanda> ListaComandas(int idMesa)
         {
             return _db.Select<Comanda>(a => a.IdMesa == idMesa && a.IdEstadoComanda != 5);
         }

         public void ActualizarComanda(Comanda comanda)
         {
             _db.Update<Comanda>(comanda);
         }

         public Comanda BuscarComandaDAL(int idComanda)
         {
             return _db.Select<Comanda>(a => a.IdComanda == idComanda).LastOrDefault();
         }*/
    }
}