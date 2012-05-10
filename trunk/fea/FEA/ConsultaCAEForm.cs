using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FEA
{
	public partial class ConsultaCAEForm : Form
	{
		FEArn.ConsultaCAE c;
		FeaEntidades.ConsultaCAE ce=new FeaEntidades.ConsultaCAE();

		public ConsultaCAEForm(FeaEntidades.ConsultaCAE ConsultaCAE)
		{
			InitializeComponent();
            ce = ConsultaCAE;

		}

		private void ConsultaCAEForm_Load(object sender, EventArgs e)
		{
            cuitreceptorTextBox.DataBindings.Add(new Binding("Text", ce, "Cuit_receptor"));
            cuitemisorTextBox.DataBindings.Add(new Binding("Text", ce, "Cuit_emisor"));
            ptoVentaTextBox.DataBindings.Add(new Binding("Text", ce, "Punto_vta"));
			tipoComprobanteComboBox.DataSource = FEArn.TiposDeComprobantes.TipoComprobante.Lista();
			tipoComprobanteComboBox.DisplayMember = "Descr";
			tipoComprobanteComboBox.ValueMember = "Codigo";
            tipoComprobanteComboBox.DataBindings.Add(new Binding("SelectedItem", ce, "Tipo_cbte"));
            nrocomprobanteTextBox.DataBindings.Add(new Binding("Text", ce, "Cbt_nro"));
			fecha_cbteDateTimePicker.DataBindings.Add(new Binding("Value", ce, "Fecha_cbte"));
			imp_totalTextBox.DataBindings.Add(new Binding("Text", ce, "Imp_total"));
			estadoTextBox.DataBindings.Add(new Binding("Text", ce, "MensajeError"));
			resultadoTextBox.DataBindings.Add(new Binding("Text", ce, "Resultado"));
			caeTextBox.DataBindings.Add(new Binding("Text", ce, "Cae"));
		}

		private void ConsultaCAEButton_Click(object sender, EventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;
                resultadoTextBox.Text = string.Empty;
                estadoTextBox.Text = string.Empty;
                this.Refresh();

                c = new FEArn.ConsultaCAE(System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsw_Service"], System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"] + ce.Cuit_receptor.ToString() + ".p12", ce.Cuit_receptor, Aplicacion.Sesion);
                FEArn.ar.gov.afip.wsw.FEConsultaCAEResponse cr = new FEArn.ar.gov.afip.wsw.FEConsultaCAEResponse();
                cr = c.ConsultarCAE(ce);
                if (cr.RError.perrmsg == "OK")
                {
                    MessageBox.Show("Consulta concluida satisfactoriamente.", "Información", MessageBoxButtons.OK);
                    resultadoTextBox.Text = "El resultado es: " + cr.Resultado.ToString();
                    estadoTextBox.Text = cr.RError.percode + " - " + cr.RError.perrmsg;
                }
                else
                {
                    MessageBox.Show("Consulta concluida con error.", "Información", MessageBoxButtons.OK);
                    resultadoTextBox.Text = "";
                    estadoTextBox.Text = cr.RError.percode + " - " + cr.RError.perrmsg;
                }
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
	}
}