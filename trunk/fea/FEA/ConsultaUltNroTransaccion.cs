using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FEA
{
    public partial class ConsultaUltNroTransaccion : Form
    {
        FEArn.ConsultaUltNroTransaccion c;
        FeaEntidades.ConsultaUltNroTransaccion ce = new FeaEntidades.ConsultaUltNroTransaccion();

        public ConsultaUltNroTransaccion()
        {
            InitializeComponent();
        }

        private void ConsultaUltNroTransaccion_Load(object sender, EventArgs e)
        {
            cuitemisorTextBox.DataBindings.Add(new Binding("Text", ce, "Cuit_emisor"));
            estadoTextBox.DataBindings.Add(new Binding("Text", ce, "MensajeError"));
            resultadoTextBox.DataBindings.Add(new Binding("Text", ce, "Resultado"));
            cuitemisorTextBox.Text = "20225018805";
        }

        private void ConsultaUltNroTransaccionButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            resultadoTextBox.Text = string.Empty;
            estadoTextBox.Text = string.Empty;
            this.Refresh();

            c = new FEArn.ConsultaUltNroTransaccion(System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsw_Service"], System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"] + ce.Cuit_emisor.ToString() + ".p12", ce.Cuit_emisor, Aplicacion.Sesion);
            FEArn.ar.gov.afip.wsw.FEUltNroResponse cr = new FEArn.ar.gov.afip.wsw.FEUltNroResponse();
            cr = c.ConsultarUltNroTransacion(ce);
            if (cr.RError.perrmsg == "OK")
            {
                MessageBox.Show("Consulta concluida satisfactoriamente.", "Información", MessageBoxButtons.OK);
                resultadoTextBox.Text = "El último Nro. de Transacción es: " + cr.nro.value.ToString();
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

        private void CantMaxRenglonesButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            resultadoTextBox.Text = string.Empty;
            estadoTextBox.Text = string.Empty;
            this.Refresh();

            c = new FEArn.ConsultaUltNroTransaccion(System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsw_Service"], System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"] + ce.Cuit_emisor.ToString() + ".p12", ce.Cuit_emisor, Aplicacion.Sesion);
            FEArn.ar.gov.afip.wsw.FERecuperaQTYResponse cr = new FEArn.ar.gov.afip.wsw.FERecuperaQTYResponse();
            cr = c.ConsultarCantMaxRenglones(ce);
            if (cr.RError.perrmsg == "OK")
            {
                MessageBox.Show("Consulta concluida satisfactoriamente.", "Información", MessageBoxButtons.OK);
                resultadoTextBox.Text = "La Cantidad Máxima de Renglones es: " + cr.qty.value.ToString();
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

        private void DummyAppServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                resultadoTextBox.Text = string.Empty;
                estadoTextBox.Text = string.Empty;
                this.Refresh();

                c = new FEArn.ConsultaUltNroTransaccion(System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsw_Service"], System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"] + ce.Cuit_emisor.ToString() + ".p12", ce.Cuit_emisor, Aplicacion.Sesion);
                string texto = c.ConsultarDummyAppServer();
                resultadoTextBox.Text = texto;
                estadoTextBox.Text = "";
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                resultadoTextBox.Text = ex.Message;
            }
        }

        private void DummyAuthServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                resultadoTextBox.Text = string.Empty;
                estadoTextBox.Text = string.Empty;
                this.Refresh();

                c = new FEArn.ConsultaUltNroTransaccion(System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsw_Service"], System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"] + ce.Cuit_emisor.ToString() + ".p12", ce.Cuit_emisor, Aplicacion.Sesion);
                string texto = c.ConsultarDummyAuthServer();
                resultadoTextBox.Text = texto;
                estadoTextBox.Text = "";
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                resultadoTextBox.Text = ex.Message;
            }
        }

        private void DummyDbServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                resultadoTextBox.Text = string.Empty;
                estadoTextBox.Text = string.Empty;
                this.Refresh();

                c = new FEArn.ConsultaUltNroTransaccion(System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsw_Service"], System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"] + ce.Cuit_emisor.ToString() + ".p12", ce.Cuit_emisor, Aplicacion.Sesion);
                string texto = c.ConsultarDummyDbServer();
                resultadoTextBox.Text = texto;
                estadoTextBox.Text = "";
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                resultadoTextBox.Text = ex.Message;
            }
        }
    }
}