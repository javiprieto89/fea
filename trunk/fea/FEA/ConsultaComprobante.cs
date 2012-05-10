using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FEA
{
    public partial class ConsultaComprobante : Form
    {
        FEArn.Comprobante c;
        FeaEntidades.Comprobante ce = new FeaEntidades.Comprobante();

        public ConsultaComprobante(FeaEntidades.Comprobante Comprobante)
        {
            InitializeComponent();
            ce = Comprobante;
        }

        private void ConsultarComprobanteButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                detalleTextBox.Text = "";
                resultadoTextBox.Text = string.Empty;
                //motivoTextBox.Text = string.Empty;
                estadoTextBox.Text = string.Empty;
                c = new FEArn.Comprobante(System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"] + ce.Cuit_emisor.ToString() + ".p12", ce.Cuit_emisor, Aplicacion.Sesion);
                c.Consultar(ce);
                string texto = "";
                if (ce.MensajeError == null || ce.MensajeError == "")
                {
                    texto += "Tipo Doc: " + ce.Tipo_doc.Codigo + "-" + ce.DescrTipoDoc + "  Nro. Doc: " + ce.Nro_doc + "\r\n";
                    texto += "Fec. Comprobante: " + ce.Fecha_cbte.ToString("dd/MM/yyyy") + "\r\n";
                    texto += "Fec. Servicio desde: " + ce.Fecha_serv_desde.ToString("dd/MM/yyyy") + " al " + ce.Fecha_serv_hasta.ToString("dd/MM/yyyy") + "\r\n";
                    texto += "Fec. Proceso: " + ce.FechaImpacto + "\r\n\r\n";
                    texto += "Importe Neto: " + ce.Imp_neto + "\r\n";
                    texto += "Importe Exento: " + ce.Imp_op_ex + "\r\n";
                    texto += "Importe Total Concepto: " + ce.Imp_tot_conc + "\r\n";
                    texto += "Importe Iva: " + ce.Impto_liq + "\r\n";
                    texto += "Importe Total: " + ce.Imp_total + "\r\n\r\n";
                    texto += "CAE: " + ce.Cae + "\r\n";
                    detalleTextBox.Text = texto;
                    resultadoTextBox.Text = ce.Resultado;
                }
                else
                {
                    detalleTextBox.Text = "";
                    resultadoTextBox.Text = "";
                    estadoTextBox.Text = ce.MensajeError;
                }
                FeaEntidades.TiposDeComprobantes.TipoComprobante tipoComp = ((FeaEntidades.TiposDeComprobantes.TipoComprobante)tipoComprobanteComboBox.SelectedItem);
            }
            catch (Exception ex)
            {
                Cedeira.Ex.ExceptionManager.Publish(ex);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ConsultaComprobante_Load(object sender, EventArgs e)
        {
            cuitemisorTextBox.DataBindings.Add(new Binding("Text", ce, "Cuit_emisor"));
            ptoVentaTextBox.DataBindings.Add(new Binding("Text", ce, "PuntoVenta"));
            tipoComprobanteComboBox.DataSource = FEArn.TiposDeComprobantes.TipoComprobante.Lista();
            tipoComprobanteComboBox.DisplayMember = "Descr";
            tipoComprobanteComboBox.ValueMember = "Codigo";
            tipoComprobanteComboBox.DataBindings.Add(new Binding("SelectedItem", ce, "TipoComp"));
            nrocomprobanteTextBox.DataBindings.Add(new Binding("Text", ce, "IdComprobante"));
            estadoTextBox.DataBindings.Add(new Binding("Text", ce, "MensajeError"));
            //motivoTextBox.DataBindings.Add(new Binding("Text", ce, "Motivo"));
            resultadoTextBox.DataBindings.Add(new Binding("Text", ce, "Resultado"));
        }
    }
}