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
                c = new FEArn.Comprobante(System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"] + ce.Cuit_emisor.ToString() + ".p12", ce.Cuit_emisor, Aplicacion.Sesion);
                c.Consultar(ce);
            }
            catch (Exception ex)
            {
                Cedeira.Ex.ExceptionManager.Publish(ex);
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
            nrocomprobanteTextBox.DataBindings.Add(new Binding("Text", ce, "Cbt_nro"));
        }

    }
}