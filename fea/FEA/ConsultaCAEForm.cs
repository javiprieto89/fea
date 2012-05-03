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
			string auxCnn = System.Configuration.ConfigurationManager.ConnectionStrings["SQLServer"].ToString();
            cuitreceptorTextBox.DataBindings.Add(new Binding("Text", ce, "Cuit_receptor"));
            cuitemisorTextBox.DataBindings.Add(new Binding("Text", ce, "Cuit_emisor"));
            ptoVentaTextBox.DataBindings.Add(new Binding("Text", ce, "Punto_Vta"));
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
				caeTextBox.Text = string.Empty;
				resultadoTextBox.Text = string.Empty;
				caeTextBox.Text = string.Empty;
				estadoTextBox.Text = string.Empty;
				this.Refresh();
                
                System.Net.WebProxy wp = null;
                if (!System.Configuration.ConfigurationManager.AppSettings["Proxy"].ToUpper().Equals("NO"))
                {
                    wp = new System.Net.WebProxy(System.Configuration.ConfigurationManager.AppSettings["Proxy"], false);
                    string usuarioProxy = System.Configuration.ConfigurationManager.AppSettings["UsuarioProxy"];
                    string claveProxy = System.Configuration.ConfigurationManager.AppSettings["ClaveProxy"];
                    string dominioProxy = System.Configuration.ConfigurationManager.AppSettings["DominioProxy"];

                    System.Net.NetworkCredential networkCredential = new System.Net.NetworkCredential(usuarioProxy, claveProxy, dominioProxy);
                    wp.Credentials = networkCredential;
                }
                c = new FEArn.ConsultaCAE(System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsaa_LoginCMSService"], System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsw_Service"], System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"] & ce.Cuit_receptor.ToString() & ".p12", ce.Cuit_receptor, Aplicacion.Sesion, wp);
                
                c.ConsultarCAE(ce);
				this.Cursor = Cursors.Default;
			}
			catch(Exception ex)
			{
				Cedeira.Ex.ExceptionManager.Publish(ex);
			}
		}
	}
}