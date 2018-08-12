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
            // TODO: This line of code loads data into the 'dsValor.dato2' table. You can move, or remove it, as needed.
            this.dato2TableAdapter.Fill(this.dsValor.dato2);
            // TODO: This line of code loads data into the 'dsValor.dato1' table. You can move, or remove it, as needed.
            this.dato1TableAdapter.Fill(this.dsValor.dato1);
            estacion oEstacion = oEstacionBLL.getEstacion(1);
            lblMedia1.Text = oEstacion.media.ToString();
            lblVarianza1.Text = oEstacion.varianza.ToString();
            lblDesviacion1.Text = oEstacion.desviacion.ToString();
            lblZetaUno1.Text = oEstacion.zetaUno.ToString();
            lblZetaDos1.Text = oEstacion.zetaDos.ToString();

            oEstacion = oEstacionBLL.getEstacion(2);
            lblMedia2.Text = oEstacion.media.ToString();
            lblVarianza2.Text = oEstacion.varianza.ToString();
            lblDesviacion2.Text = oEstacion.desviacion.ToString();
            lblZetaUno2.Text = oEstacion.zetaUno.ToString();
            lblZetaDos2.Text = oEstacion.zetaDos.ToString();
        }

        private void btnAnadir1_Click(object sender, EventArgs e)
        {
            dato oDato = new dato()
            {
                valor = nudValor1.Value,
                idEstacion=1   
            };
            oDatoBLL.addDato(oDato);
            refrescar(1);
            nudValor1.Value = 0;
        }

        private void refrescar(int idEstacion)
        {
            estacion oEstacion = oEstacionBLL.getEstacion(idEstacion);
            if (idEstacion == 1)
            {
                lblMedia1.Text = oEstacion.media.ToString();
                lblVarianza1.Text = oEstacion.varianza.ToString();
                lblDesviacion1.Text = oEstacion.desviacion.ToString();
                lblZetaUno1.Text = oEstacion.zetaUno.ToString();
                lblZetaDos1.Text = oEstacion.zetaDos.ToString();
                this.dato1TableAdapter.Fill(this.dsValor.dato1);
            }
            else
            {
                lblMedia2.Text = oEstacion.media.ToString();
                lblVarianza2.Text = oEstacion.varianza.ToString();
                lblDesviacion2.Text = oEstacion.desviacion.ToString();
                lblZetaUno2.Text = oEstacion.zetaUno.ToString();
                lblZetaDos2.Text = oEstacion.zetaDos.ToString();
                this.dato2TableAdapter.Fill(this.dsValor.dato2);
            }
                
            
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickDgv(sender, e);
        }

        private void clickDgv(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                dato oDato = new dato()
                {
                    idDato = int.Parse(senderGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()),
                    idEstacion = int.Parse(senderGrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString())
                };
                if (e.ColumnIndex == 7)//Modificar
                {
                    oDato.valor = decimal.Parse(senderGrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    oDato.frecuencia = int.Parse(senderGrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                    oDatoBLL.updateDato(oDato);
                }
                else//Eliminar
                    oDatoBLL.deleleDato(oDato);
                refrescar(oDato.idEstacion);
            }
        }

        private void btnAnadir2_Click(object sender, EventArgs e)
        {
            dato oDato = new dato()
            {
                valor = nudValor2.Value,
                idEstacion = 2
            };
            oDatoBLL.addDato(oDato);
            refrescar(2);
            nudValor2.Value = 0;
        }

        private void dgvEstacion2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickDgv(sender, e);
        }
    }
}
