using appEstadistica.BLL;
using appEstadistica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEstadistica.UI
{
    public partial class frmPrincipal : Form
    {
        private datoBLL oDatoBLL = new datoBLL();
        private estacionBLL oEstacionBLL = new estacionBLL();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsValor.dato1' table. You can move, or remove it, as needed.
            this.dato1TableAdapter.Fill(this.dsValor.dato1);
            estacion oEstacion = oEstacionBLL.getEstacion(1);
            lblMedia1.Text = oEstacion.media.ToString();
            lblVarianza1.Text = oEstacion.varianza.ToString();
            lblDesviacion1.Text = oEstacion.desviacion.ToString();
            lblZetaUno1.Text = oEstacion.zetaUno.ToString();
            lblZetaDos1.Text = oEstacion.zetaDos.ToString();

            /*estacion oEstacion = estacionBLL.getEstacion(2);
            lblMedia2.Text = oEstacion.media.ToString();
            lblVarianza2.Text = oEstacion.varianza.ToString();
            lblDesviacion2.Text = oEstacion.desviacion.ToString();
            lblZetaUno2.Text = oEstacion.zetaUno.ToString();
            lblZetaDos2.Text = oEstacion.zetaDos.ToString();
            */
        }

        private void btnAnadir1_Click(object sender, EventArgs e)
        {
            dato oDato = new dato()
            {
                valor = nudValor1.Value,
                idEstacion=1   
            };
            oDatoBLL.calcular(oDato);
            estacion oEstacion = oEstacionBLL.getEstacion(1);
            lblMedia1.Text = oEstacion.media.ToString();
            lblVarianza1.Text = oEstacion.varianza.ToString();
            lblDesviacion1.Text = oEstacion.desviacion.ToString();
            lblZetaUno1.Text = oEstacion.zetaUno.ToString();
            lblZetaDos1.Text = oEstacion.zetaDos.ToString();
            this.dato1TableAdapter.Fill(this.dsValor.dato1);
        }
    }
}
