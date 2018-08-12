using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appEstadistica.Entidades;
using appEstadistica.DAL;

namespace appEstadistica.BLL
{
    public class estacionBLL
    {
        private estacionDAL oEstacionDAL = new estacionDAL();

        public estacion getEstacion(int id)
        {
            return oEstacionDAL.getEstacion(id);
        }

        public void updateEstacion(estacion oEstacion)
        {
            oEstacionDAL.updateEstacion(oEstacion);
        }
    }
}
