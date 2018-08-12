using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appEstadistica.Entidades;
using appEstadistica.DAL;

namespace appEstadistica.BLL
{
    public class datoBLL
    {
        private datoDAL oDatoDAL=new datoDAL();
        private estacionBLL oEstacionBLL = new estacionBLL();
        public void deleleDato(dato oDato)
        {
            oDatoDAL.deleteDato(oDato.idDato);
            List<dato> datos = oDatoDAL.datos(oDato.idEstacion);
            calcular(oDato.idEstacion, datos);
        }

        public void updateDato(dato oDato)
        {
            List<dato> datos = oDatoDAL.datos(oDato.idEstacion);
            datos.Single<dato>(a => a.idDato== oDato.idDato).frecuencia=oDato.frecuencia;
            datos.Single<dato>(a => a.idDato == oDato.idDato).valor = oDato.valor;
            calcular(oDato.idEstacion, datos);
        }

        public void addDato(dato oDato)
        {
            List<dato> datos = oDatoDAL.datos(oDato.idEstacion);
            if (datos.Count<dato>(a => a.valor == oDato.valor)>0)
                datos.Single<dato>(a => a.valor == oDato.valor).frecuencia++;
            else
            {
                oDato.frecuencia = 1;
                datos.Add(oDato);
            }
            calcular(oDato.idEstacion, datos);
        }

        private void calcular(int idEstacion, List<dato> datos)
        {
            estacion oEstacion = oEstacionBLL.getEstacion(idEstacion);
            oEstacion.media = 0;
            decimal total = datos.Sum(a => a.frecuencia);
            foreach (dato dato in datos)
            {
                dato.probabilidad = dato.frecuencia / total;
                dato.xPx = dato.valor * dato.probabilidad;
                oEstacion.media += dato.xPx;
            }
            oEstacion.varianza = 0;
            foreach (dato dato in datos)
            {
                dato.xuPx = Convert.ToDecimal(Math.Pow(Decimal.ToDouble(dato.valor - oEstacion.media), 2)) * dato.probabilidad;
                oEstacion.varianza += dato.xuPx;
            }
            oEstacion.desviacion = Convert.ToDecimal(Math.Sqrt(Decimal.ToDouble(oEstacion.varianza)));
            oEstacion.zetaUno = (decimal)-1.28*oEstacion.desviacion+oEstacion.media;
            oEstacion.zetaDos = (decimal)1.28 * oEstacion.desviacion + oEstacion.media;
            oEstacionBLL.updateEstacion(oEstacion);
            oDatoDAL.updateDatos(datos);
        }
    }
}
