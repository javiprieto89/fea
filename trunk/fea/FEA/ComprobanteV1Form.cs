using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FEA
{
	public partial class ComprobanteV1Form : Form
	{
		FEArn.Comprobante c;
		FeaEntidades.ComprobanteV1 ce=new FeaEntidades.ComprobanteV1();
        List<FeaEntidades.ComprobanteV1_IVA> iva = new List<FeaEntidades.ComprobanteV1_IVA>();
		public ComprobanteV1Form()
		{
			InitializeComponent();
		}

		private void ComprobanteForm_Load(object sender, EventArgs e)
		{
			ptoVentaTextBox.DataBindings.Add(new Binding("Text", ce, "PuntoVenta"));
			prestaServicioCheckBox.DataBindings.Add(new Binding("Checked", ce, "Presta_serv"));
			tipoComprobanteComboBox.DataSource = FEArn.TiposDeComprobantes.TipoComprobante.Lista();
			tipoComprobanteComboBox.DisplayMember = "Descr";
			tipoComprobanteComboBox.ValueMember = "Codigo";
            tipoComprobanteComboBox.DataBindings.Add(new Binding("SelectedItem", ce, "TipoComp"));
			fecha_cbteDateTimePicker.DataBindings.Add(new Binding("Value", ce, "Fecha_cbte"));
			fecha_serv_desdeDateTimePicker.DataBindings.Add(new Binding("Value", ce, "Fecha_serv_desde"));
			fecha_serv_hastaDateTimePicker.DataBindings.Add(new Binding("Value", ce, "Fecha_serv_hasta"));
			fecha_venc_pagoDateTimePicker.DataBindings.Add(new Binding("Value", ce, "Fecha_venc_pago"));
			imp_netoTextBox.DataBindings.Add(new Binding("Text", ce, "Imp_neto"));
			imp_op_exTextBox.DataBindings.Add(new Binding("Text", ce, "Imp_op_ex"));
			imp_tot_concTextBox.DataBindings.Add(new Binding("Text", ce, "Imp_tot_conc"));
			imp_totalTextBox.DataBindings.Add(new Binding("Text", ce, "Imp_total"));
			impto_liqTextBox.DataBindings.Add(new Binding("Text", ce, "Impto_liq"));
			impto_liq_rniTextBox.Text = "0";
			tipo_docComboBox.DataSource = FEArn.Documentos.Documento.Lista();
			tipo_docComboBox.DisplayMember = "Descr";
			tipo_docComboBox.ValueMember = "Codigo";
			tipo_docComboBox.DataBindings.Add(new Binding("SelectedItem", ce, "Tipo_doc"));
			nro_docTextBox.DataBindings.Add(new Binding("Text", ce, "Nro_doc"));
			estadoTextBox.DataBindings.Add(new Binding("Text", ce, "MensajeError"));
			motivoTextBox.DataBindings.Add(new Binding("Text", ce, "Motivo"));
			resultadoTextBox.DataBindings.Add(new Binding("Text", ce, "Resultado"));
			caeTextBox.DataBindings.Add(new Binding("Text", ce, "Cae"));
            cuitemisorTextBox.DataBindings.Add(new Binding("Text", ce, "Cuit_emisor"));
            dgvIVA.DataSource = new List<FeaEntidades.ComprobanteV1_IVA>();
            dgvIVA.Refresh();

		}

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void EnviarButtonV1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            caeTextBox.Text = string.Empty;
            resultadoTextBox.Text = string.Empty;
            motivoTextBox.Text = string.Empty;
            estadoTextBox.Text = string.Empty;
            this.Refresh();

            ce.Iva = iva;
            c = new FEArn.Comprobante(System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"] + ce.Cuit_emisor.ToString() + ".p12", ce.Cuit_emisor, Aplicacion.Sesion);
            
            //Para armar combo
            List<FeaEntidades.TipoIVA> listaTipoIVA;
            listaTipoIVA = c.RG2485V1TipoIva();

            //Para armar combo
            List<FeaEntidades.Tributos> listaTipoTributos;
            listaTipoTributos = c.RG2485V1Tributos();

            c.EnviarV1(ce, Convert.ToInt32(CantCompAProcesarTextBox.Text));
            this.Cursor = Cursors.Default;
        }

        private void IVAAddRowButton_Click(object sender, EventArgs e)
        {
            dgvIVA.DataSource = new List<FeaEntidades.ComprobanteV1_IVA>();
            iva.Add(new FeaEntidades.ComprobanteV1_IVA());
            dgvIVA.DataSource = iva;
            dgvIVA.Refresh();
        }

        private void IVADeleteRowButton_Click(object sender, EventArgs e)
        {
            if (this.dgvIVA.SelectedRows.Count > 0)
            {
                iva.Remove(iva[this.dgvIVA.SelectedRows[0].Index]);
                dgvIVA.DataSource = new List<FeaEntidades.ComprobanteV1_IVA>();
                dgvIVA.DataSource = iva;
                dgvIVA.Refresh();
            } 
        }

        private void dgvIVA_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
	}
}