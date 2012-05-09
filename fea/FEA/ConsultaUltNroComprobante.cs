using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FEA
{
    public partial class ConsultaUltNroComprobante : Form
    {
        FEArn.ConsultaUltNroComprobante c;
        FeaEntidades.ConsultaUltNroComprobante cunc = new FeaEntidades.ConsultaUltNroComprobante();
        public ConsultaUltNroComprobante(FeaEntidades.ConsultaUltNroComprobante Cunc)
        {
            InitializeComponent();
            cunc = Cunc;
        }

        private void ConsultaUltNroComprobante_Load(object sender, EventArgs e)
        {
            cuitemisorTextBox.DataBindings.Add(new Binding("Text", cunc, "Cuit_emisor"));
            ptoVtaTextBox.DataBindings.Add(new Binding("Text", cunc, "Punto_vta"));
            tipoCompComboBox.DataSource = FEArn.TiposDeComprobantes.TipoComprobante.Lista();
            tipoCompComboBox.DisplayMember = "Descr";
            tipoCompComboBox.ValueMember = "Codigo";
            tipoCompComboBox.DataBindings.Add(new Binding("SelectedItem", cunc, "TipoComp"));
            estadoTextBox.DataBindings.Add(new Binding("Text", cunc, "MensajeError"));
            resultadoTextBox.DataBindings.Add(new Binding("Text", cunc, "Resultado"));
        }

        private void ConsultaUltNroComprobanteButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            resultadoTextBox.Text = string.Empty;
            estadoTextBox.Text = string.Empty;
            this.Refresh();

            c = new FEArn.ConsultaUltNroComprobante(System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsw_Service"], System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"] + cunc.Cuit_emisor.ToString() + ".p12", cunc.Cuit_emisor, Aplicacion.Sesion);
            FEArn.ar.gov.afip.wsw.FERecuperaLastCMPResponse cr = new FEArn.ar.gov.afip.wsw.FERecuperaLastCMPResponse();
            cr = c.ConsultarUltNroComprobante(cunc);
            if (cr.RError.perrmsg == "OK")
            {
                MessageBox.Show("Consulta concluida satisfactoriamente.", "Información", MessageBoxButtons.OK);
                resultadoTextBox.Text = "El último Nro. de Comprobante Emitido es: " + cr.cbte_nro.ToString();
                estadoTextBox.Text = cr.RError.percode + " - " + cr.RError.perrmsg;
            }
            else
            {
                MessageBox.Show("Consulta concluida con error.", "Información", MessageBoxButtons.OK);
                resultadoTextBox.Text = "";
                estadoTextBox.Text = cr.RError.percode + " - " + cr.RError.perrmsg;
            }
            this.Cursor = Cursors.Default;
        }
    }
}