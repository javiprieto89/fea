using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FEA
{
	public partial class ComprobanteForm : Form
	{
		FEArn.Comprobante c;
		FeaEntidades.Comprobante ce=new FeaEntidades.Comprobante();
		public ComprobanteForm()
		{
			InitializeComponent();
		}

		private void ComprobanteForm_Load(object sender, EventArgs e)
		{
			string auxCnn = System.Configuration.ConfigurationManager.ConnectionStrings["SQLServer"].ToString();

			System.Net.WebProxy wp=null;
			if (!System.Configuration.ConfigurationManager.AppSettings["Proxy"].ToUpper().Equals("NO"))
			{
				wp = new System.Net.WebProxy(System.Configuration.ConfigurationManager.AppSettings["Proxy"], false);
				string usuarioProxy = System.Configuration.ConfigurationManager.AppSettings["UsuarioProxy"];
				string claveProxy = System.Configuration.ConfigurationManager.AppSettings["ClaveProxy"];
				string dominioProxy = System.Configuration.ConfigurationManager.AppSettings["DominioProxy"];
				
				System.Net.NetworkCredential networkCredential = new System.Net.NetworkCredential(usuarioProxy, claveProxy, dominioProxy);
				wp.Credentials = networkCredential;

				//System.Net.CredentialCache credentialCache = new System.Net.CredentialCache();
				//string wsaaurl = System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsaa_LoginCMSService"];
				//credentialCache.Add(new Uri(wsaaurl), "NTLM", networkCredential);
				//string wsfeurl = System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsw_Service"];
				//credentialCache.Add(new Uri(wsfeurl), "NTLM", networkCredential);
				//wp.Credentials = credentialCache;
			}
			c = new FEArn.Comprobante(System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsaa_LoginCMSService"], System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsw_Service"], System.Configuration.ConfigurationManager.AppSettings["rutaCertificadoAFIP"], Convert.ToInt64(System.Configuration.ConfigurationManager.AppSettings["CUIT"]), Aplicacion.Sesion, wp);

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
			impto_liq_rniTextBox.DataBindings.Add(new Binding("Text", ce, "Impto_liq_rni"));
			tipo_docComboBox.DataSource = FEArn.Documentos.Documento.Lista();
			tipo_docComboBox.DisplayMember = "Descr";
			tipo_docComboBox.ValueMember = "Codigo";
			tipo_docComboBox.DataBindings.Add(new Binding("SelectedItem", ce, "Tipo_doc"));
			nro_docTextBox.DataBindings.Add(new Binding("Text", ce, "Nro_doc"));
			estadoTextBox.DataBindings.Add(new Binding("Text", ce, "MensajeError"));
			motivoTextBox.DataBindings.Add(new Binding("Text", ce, "Motivo"));
			resultadoTextBox.DataBindings.Add(new Binding("Text", ce, "Resultado"));
			caeTextBox.DataBindings.Add(new Binding("Text", ce, "Cae"));
		}

        private void EnviarButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            caeTextBox.Text = string.Empty;
            resultadoTextBox.Text = string.Empty;
            motivoTextBox.Text = string.Empty;
            caeTextBox.Text = string.Empty;
            estadoTextBox.Text = string.Empty;
            this.Refresh();
            c.Enviar(ce);
            this.Cursor = Cursors.Default;
        }

		private void XMLButton_Click(object sender, EventArgs e)
		{
            //FeaEntidades.InterFacturas.lote_comprobantes lote = GenerarLoteDePrueba();

            //System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(lote.GetType());
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //sb.Append(lote.cabecera_lote.cuit_vendedor);
            //sb.Append("-");
            //sb.Append(lote.cabecera_lote.punto_de_venta);
            //sb.Append("-");
            //sb.Append(lote.comprobante[0].cabecera.informacion_comprobante.tipo_de_comprobante);
            //sb.Append("-");
            //sb.Append(lote.comprobante[0].cabecera.informacion_comprobante.numero_comprobante);
            //sb.Append(".xml");
            //System.IO.Stream fs = new System.IO.FileStream(sb.ToString(), System.IO.FileMode.Create);
            //System.Xml.XmlWriter writer = new System.Xml.XmlTextWriter(fs, System.Text.Encoding.GetEncoding("ISO-8859-1"));
            //x.Serialize(writer, lote);
            //fs.Close();
		}
        //private FeaEntidades.InterFacturas.lote_comprobantes GenerarLoteDePrueba()
        //{
            //FeaEntidades.InterFacturas.lote_comprobantes lote = new FeaEntidades.InterFacturas.lote_comprobantes();

            //FeaEntidades.InterFacturas.cabecera_lote cab = new FeaEntidades.InterFacturas.cabecera_lote();
            //cab.cantidad_reg = 1;
            //cab.cuit_canal = 30690783521;
            //cab.cuit_vendedor = 30710015062;
            //cab.id_lote = 21;
            //cab.presta_servSpecified = true;
            //cab.presta_serv = 1;
            //cab.punto_de_venta = 1;
            //lote.cabecera_lote = cab;

            //FeaEntidades.InterFacturas.cabecera compcab = new FeaEntidades.InterFacturas.cabecera();

            //FeaEntidades.InterFacturas.informacion_comprador infcompra = new FeaEntidades.InterFacturas.informacion_comprador();
            //infcompra.codigo_doc_identificatorio = 80;
            //infcompra.nro_doc_identificatorio = 30500001735;
            //infcompra.domicilio_calle = "Tte. Gral. Perón";
            //infcompra.domicilio_numero = "407";
            //infcompra.cp = "1038";
            //infcompra.localidad = "C.A.B.A.";
            //infcompra.provincia = "1";
            //infcompra.denominacion = "BANCO DE GALICIA S.A.";
            //infcompra.condicion_IVASpecified = true;
            //infcompra.condicion_IVA = 1;

            //compcab.informacion_comprador = infcompra;

            //FeaEntidades.InterFacturas.informacion_comprobante infcomprob = new FeaEntidades.InterFacturas.informacion_comprobante();
            //infcomprob.tipo_de_comprobante = 1;
            //infcomprob.numero_comprobante = 18;
            //infcomprob.punto_de_venta = cab.punto_de_venta;
            //infcomprob.fecha_emision = System.DateTime.Today.ToString("yyyyMMdd");
            //infcomprob.fecha_vencimiento = System.DateTime.Today.ToString("yyyyMMdd");
            //infcomprob.fecha_serv_desde = "20090101";
            //infcomprob.fecha_serv_hasta = "20090131";
            //compcab.informacion_comprobante = infcomprob;

            //FeaEntidades.InterFacturas.informacion_vendedor infovend = new FeaEntidades.InterFacturas.informacion_vendedor();
            //infovend.cuit = 30710015062;
            //infovend.condicion_IVA = 1;
            //infovend.condicion_IVASpecified = true;
            //infovend.razon_social = "CEDEIRA SOFTWARE FACTORY S.R.L.";
            //infovend.domicilio_calle = "Arenales";
            //infovend.domicilio_numero = "3457";
            //infovend.domicilio_piso = "3";
            //infovend.domicilio_depto = "A";
            //infovend.cp = "1425";
            //infovend.localidad = "C.A.B.A.";
            //infovend.provincia = "1";
            //infovend.nro_ingresos_brutos = "1171649-05";
            //infovend.inicio_de_actividades = "20070307";
            //infovend.condicion_ingresos_brutosSpecified = true;
            //infovend.condicion_ingresos_brutos = 1;
            //infovend.email = "info@cedeira.com.ar";
            //infovend.telefono = "15-5493-9857";
            //compcab.informacion_vendedor = infovend;

            //FeaEntidades.InterFacturas.comprobante comp = new FeaEntidades.InterFacturas.comprobante();
            //comp.cabecera = compcab;

            //FeaEntidades.InterFacturas.detalle det = new FeaEntidades.InterFacturas.detalle();

            //FeaEntidades.InterFacturas.linea li = new FeaEntidades.InterFacturas.linea();
            //li.numeroLinea = 1;
            //li.descripcion = "Servicio de Software Factory de Enero de 2009. Cantidad de recursos: 4 (cuatro). Nuevos desarrollos.";
            //li.importe_total_articulo = 43612.80;

            //li.impuestos = new FeaEntidades.InterFacturas.lineaImpuestos[2];
			
            //FeaEntidades.InterFacturas.lineaImpuestos impuestoIVA = new FeaEntidades.InterFacturas.lineaImpuestos();
            //impuestoIVA.codigo_impuesto = 1;
            //impuestoIVA.descripcion_impuesto = "IVA";
            //impuestoIVA.porcentaje_impuestoSpecified = true;
            //impuestoIVA.importe_impuesto = 100;
            //impuestoIVA.porcentaje_impuesto = 21;
            //li.impuestos[0] = impuestoIVA;

            //FeaEntidades.InterFacturas.lineaImpuestos impuestoOTRO = new FeaEntidades.InterFacturas.lineaImpuestos();
            //impuestoOTRO.codigo_impuesto = 2;
            //impuestoOTRO.descripcion_impuesto = "Otro impuesto";
            //impuestoOTRO.porcentaje_impuestoSpecified = true;
            //impuestoOTRO.importe_impuesto = 200;
            //impuestoOTRO.porcentaje_impuesto = 42;
            //li.impuestos[1] = impuestoOTRO;

            //li.descuentos = new FeaEntidades.InterFacturas.lineaDescuentos[1];
			
            //FeaEntidades.InterFacturas.lineaDescuentos descuento = new FeaEntidades.InterFacturas.lineaDescuentos();
            //descuento.descripcion_descuento = "descuento de prueba";
            //descuento.importe_descuento = 10;
            //descuento.porcentaje_descuentoSpecified = true;
            //descuento.porcentaje_descuento = .5;
            //li.descuentos[0] = descuento;

            //li.importe_total_impuestos = 1000;
            //li.importe_total_impuestosSpecified = true;

            //li.importe_total_descuentos = 2000;
            //li.importe_total_descuentosSpecified = true;

            //det.linea[0] = li;
            //det.comentarios = "MesaD,BcaPrivada,Directorio,GAF,Transf.y PagosJud.";

            //comp.detalle = det;

            //FeaEntidades.InterFacturas.resumen r = new FeaEntidades.InterFacturas.resumen();
            //r.importe_total_factura = 52771.49;
            //r.tipo_de_cambio = 1;
            //r.codigo_moneda = "PES";
            //r.importe_total_neto_gravado = 43612.80;
            //r.importe_total_concepto_no_gravado = 0;
            //r.importe_operaciones_exentas = 0;
            //r.impuesto_liq = 9158.69;
            //r.impuesto_liq_rni = 0;
            //r.observaciones = "Servicio Prestado en la Ciudad Autónoma de Bs.As.";

            //comp.resumen = r;

            //comp.resumen.descuentos = new FeaEntidades.InterFacturas.resumenDescuentos[1];
            //FeaEntidades.InterFacturas.resumenDescuentos dresumen = new FeaEntidades.InterFacturas.resumenDescuentos();
            //dresumen.descripcion_descuento = "descuento global";
            //dresumen.importe_descuento = 10000;
            //dresumen.porcentaje_descuento = 5;
            //dresumen.alicuota_iva_descuentoSpecified = true;
            //dresumen.alicuota_iva_descuento = 10.5;
            //comp.resumen.descuentos[0] = dresumen;

            //comp.resumen.impuestos = new FeaEntidades.InterFacturas.resumenImpuestos[1];
            //FeaEntidades.InterFacturas.resumenImpuestos dimpuesto = new FeaEntidades.InterFacturas.resumenImpuestos();
            //dimpuesto.codigo_impuesto = 1;
            //dimpuesto.codigo_jurisdiccion = 1;
            //dimpuesto.codigo_jurisdiccionSpecified = true;
            //dimpuesto.descripcion = "impuesto global de prueba";
            //dimpuesto.importe_impuesto = 1000000;
            //dimpuesto.porcentaje_impuesto = 5;
            //dimpuesto.porcentaje_impuestoSpecified = true;
            //comp.resumen.impuestos[0] = dimpuesto;
			
            //lote.comprobante[0] = comp;

            //return lote;
        //}
        //private FeaEntidades.InterFacturas.lote_comprobantes GenerarLoteDePruebaEnDolares()
        //{
            //FeaEntidades.InterFacturas.lote_comprobantes lote = new FeaEntidades.InterFacturas.lote_comprobantes();

            //FeaEntidades.InterFacturas.cabecera_lote cab = new FeaEntidades.InterFacturas.cabecera_lote();
            //cab.cantidad_reg = 1;
            //cab.cuit_canal = 30690783521;
            //cab.cuit_vendedor = 30710015062;
            //cab.id_lote = 96;
            //cab.presta_servSpecified = true;
            //cab.presta_serv = 1;
            //cab.punto_de_venta = 1;
            //lote.cabecera_lote = cab;

            //FeaEntidades.InterFacturas.cabecera compcab = new FeaEntidades.InterFacturas.cabecera();

            //FeaEntidades.InterFacturas.informacion_comprador infcompra = new FeaEntidades.InterFacturas.informacion_comprador();
            //infcompra.codigo_doc_identificatorio = 80;
            //infcompra.nro_doc_identificatorio = 30500001735;
            //infcompra.domicilio_calle = "Tte. Gral. Perón";
            //infcompra.domicilio_numero = "407";
            //infcompra.cp = "1038";
            //infcompra.localidad = "C.A.B.A.";
            //infcompra.provincia = "1";
            //infcompra.denominacion = "BANCO DE GALICIA S.A.";
            //infcompra.condicion_IVASpecified = true;
            //infcompra.condicion_IVA = 1;

            //compcab.informacion_comprador = infcompra;

            //FeaEntidades.InterFacturas.informacion_comprobante infcomprob = new FeaEntidades.InterFacturas.informacion_comprobante();
            //infcomprob.tipo_de_comprobante = 1;
            //infcomprob.numero_comprobante = 49;
            //infcomprob.punto_de_venta = cab.punto_de_venta;
            //infcomprob.fecha_emision = System.DateTime.Today.ToString("yyyyMMdd");
            //infcomprob.fecha_vencimiento = System.DateTime.Today.ToString("yyyyMMdd");
            //infcomprob.fecha_serv_desde = "20090101";
            //infcomprob.fecha_serv_hasta = "20090131";
            //compcab.informacion_comprobante = infcomprob;

            //FeaEntidades.InterFacturas.informacion_vendedor infovend = new FeaEntidades.InterFacturas.informacion_vendedor();
            //infovend.cuit = 30710015062;
            //infovend.condicion_IVA = 1;
            //infovend.condicion_IVASpecified = true;
            //infovend.razon_social = "CEDEIRA SOFTWARE FACTORY S.R.L.";
            //infovend.domicilio_calle = "Arenales";
            //infovend.domicilio_numero = "3457";
            //infovend.domicilio_piso = "3";
            //infovend.domicilio_depto = "A";
            //infovend.cp = "1425";
            //infovend.localidad = "C.A.B.A.";
            //infovend.provincia = "1";
            //infovend.nro_ingresos_brutos = "1171649-05";
            //infovend.inicio_de_actividades = "20070307";
            //infovend.condicion_ingresos_brutosSpecified = true;
            //infovend.condicion_ingresos_brutos = 1;
            //infovend.email = "info@cedeira.com.ar";
            //infovend.telefono = "15-5493-9857";
            //compcab.informacion_vendedor = infovend;

            //FeaEntidades.InterFacturas.comprobante comp = new FeaEntidades.InterFacturas.comprobante();
            //comp.cabecera = compcab;

            //FeaEntidades.InterFacturas.detalle det = new FeaEntidades.InterFacturas.detalle();

            //FeaEntidades.InterFacturas.linea li = new FeaEntidades.InterFacturas.linea();
            //li.numeroLinea = 1;
            //li.descripcion = "Servicio de Software Factory de Enero de 2009. Cantidad de recursos: 4 (cuatro). Nuevos desarrollos.";
            //li.importe_total_articulo = 43612.80;
            //li.importe_ivaSpecified = true;
            //li.importe_iva = 9158.69;
            //li.alicuota_ivaSpecified = true;
            //li.alicuota_iva = 21;


            //FeaEntidades.InterFacturas.lineaImportes_moneda_origen limo = new FeaEntidades.InterFacturas.lineaImportes_moneda_origen();
            //limo.importe_total_articulo = 14537.6;
            //limo.importe_total_articuloSpecified = true;
            //limo.importe_iva = 3052.9;
            //limo.importe_ivaSpecified = true;
            //li.importes_moneda_origen = limo;

            ////li.impuestos = new FeaEntidades.InterFacturas.lineaImpuestos[2];

            ////FeaEntidades.InterFacturas.lineaImpuestos impuestoIVA = new FeaEntidades.InterFacturas.lineaImpuestos();
            ////impuestoIVA.codigo_impuesto = 1;
            ////impuestoIVA.descripcion_impuesto = "IVA";
            ////impuestoIVA.porcentaje_impuestoSpecified = true;
            ////impuestoIVA.importe_impuesto = 100;
            ////impuestoIVA.porcentaje_impuesto = 21;
            ////li.impuestos[0] = impuestoIVA;

            ////FeaEntidades.InterFacturas.lineaImpuestos impuestoOTRO = new FeaEntidades.InterFacturas.lineaImpuestos();
            ////impuestoOTRO.codigo_impuesto = 2;
            ////impuestoOTRO.descripcion_impuesto = "Otro impuesto";
            ////impuestoOTRO.porcentaje_impuestoSpecified = true;
            ////impuestoOTRO.importe_impuesto = 200;
            ////impuestoOTRO.porcentaje_impuesto = 42;
            ////li.impuestos[1] = impuestoOTRO;

            ////li.descuentos = new FeaEntidades.InterFacturas.lineaDescuentos[1];

            ////FeaEntidades.InterFacturas.lineaDescuentos descuento = new FeaEntidades.InterFacturas.lineaDescuentos();
            ////descuento.descripcion_descuento = "descuento de prueba";
            ////descuento.importe_descuento = 10;
            ////descuento.porcentaje_descuentoSpecified = true;
            ////descuento.porcentaje_descuento = .5;
            ////li.descuentos[0] = descuento;

            ////li.importe_total_impuestos = 1000;
            ////li.importe_total_impuestosSpecified = true;

            ////li.importe_total_descuentos = 2000;
            ////li.importe_total_descuentosSpecified = true;

            //det.linea[0] = li;
            //det.comentarios = "MesaD,BcaPrivada,Directorio,GAF,Transf.y PagosJud.";

            //comp.detalle = det;

            //FeaEntidades.InterFacturas.resumen r = new FeaEntidades.InterFacturas.resumen();
            //r.tipo_de_cambio = 3;
            //r.codigo_moneda = "DOL";
            //r.importe_total_neto_gravado = 43612.80;
            //r.importe_total_concepto_no_gravado = 0;
            //r.importe_operaciones_exentas = 0;
            //r.impuesto_liq = 9158.69;
            //r.impuesto_liq_rni = 0;
            //r.importe_total_factura = 52771.49;
            //r.observaciones = "Servicio Prestado en la Ciudad Autónoma de Bs.As.";

            //FeaEntidades.InterFacturas.resumenImportes_moneda_origen rimo = new FeaEntidades.InterFacturas.resumenImportes_moneda_origen();
            //rimo.importe_total_neto_gravado = 14537.6;
            //rimo.importe_total_concepto_no_gravado = 0;
            //rimo.importe_operaciones_exentas = 0;
            //rimo.impuesto_liq = 3052.9;
            //rimo.impuesto_liq_rni = 0;
            //rimo.importe_total_factura = 17590.5;
            //r.importes_moneda_origen = rimo;


            //comp.resumen = r;

            ////comp.resumen.descuentos = new FeaEntidades.InterFacturas.resumenDescuentos[1];
            ////FeaEntidades.InterFacturas.resumenDescuentos dresumen = new FeaEntidades.InterFacturas.resumenDescuentos();
            ////dresumen.descripcion_descuento = "descuento global";
            ////dresumen.importe_descuento = 10000;
            ////dresumen.porcentaje_descuento = 5;
            ////dresumen.alicuota_iva_descuentoSpecified = true;
            ////dresumen.alicuota_iva_descuento = 10.5;
            ////comp.resumen.descuentos[0] = dresumen;

            ////comp.resumen.impuestos = new FeaEntidades.InterFacturas.resumenImpuestos[1];
            ////FeaEntidades.InterFacturas.resumenImpuestos dimpuesto = new FeaEntidades.InterFacturas.resumenImpuestos();
            ////dimpuesto.codigo_impuesto = 1;
            ////dimpuesto.codigo_jurisdiccion = 1;
            ////dimpuesto.codigo_jurisdiccionSpecified = true;
            ////dimpuesto.descripcion = "impuesto global de prueba";
            ////dimpuesto.importe_impuesto = 1000000;
            ////dimpuesto.porcentaje_impuesto = 5;
            ////dimpuesto.porcentaje_impuestoSpecified = true;
            ////comp.resumen.impuestos[0] = dimpuesto;

            //lote.comprobante[0] = comp;

            //return lote;
        //}
		private void ExcelButton_Click(object sender, EventArgs e)
		{
			try
			{
                //FeaEntidades.InterFacturas.lote_comprobantes lote = new FeaEntidades.InterFacturas.lote_comprobantes();
                //FeaEntidades.InterFacturas.cabecera compcab = new FeaEntidades.InterFacturas.cabecera();
                //FeaEntidades.InterFacturas.comprobante comp = new FeaEntidades.InterFacturas.comprobante();
                //comp.cabecera = compcab;
                //lote.comprobante[0] = comp;

                //List<FeaEntidades.Excel.Ubicador> lista = FeaEntidades.Excel.Ubicador.Lista();
                //foreach (FeaEntidades.Excel.Ubicador u in lista)
                //{
                //    FileHelpers.DataLink.ExcelStorage provider = new FileHelpers.DataLink.ExcelStorage(u.GetType());
                //    provider.StartRow = u.X;
                //    provider.StartColumn = u.Y;
                //    //provider.FileName = "..\\..\\Comprobantes.xls";
                //    provider.FileName = @"C:\Documents and Settings\l0737860\Mis documentos\Factura A Modelo-v1.8.xls";
                //    provider.SheetName = "XML";
                //    Object[] oArray = (Object[])System.Array.CreateInstance(u.GetType(), 10);
                //    oArray = (Object[])provider.ExtractRecords();

                //    foreach(Object o in oArray)
                //    {
                //        FileHelpers.DataLink.ExcelStorage providerInterno = new FileHelpers.DataLink.ExcelStorage(System.Type.GetType("FeaEntidades.InterFacturas." + ((FeaEntidades.Excel.Ubicador)o).Tipo + ", FeaEntidades"));
                //        providerInterno.StartRow = ((FeaEntidades.Excel.Ubicador)o).Y;
                //        providerInterno.StartColumn = ((FeaEntidades.Excel.Ubicador)o).X+1;
                //        //providerInterno.FileName = "..\\..\\Comprobantes.xls";
                //        providerInterno.FileName = @"C:\Documents and Settings\l0737860\Mis documentos\Factura A Modelo-v1.8.xls";
                //        providerInterno.SheetName = "XML";
                //        Object[] oArrayInterno = (Object[])System.Array.CreateInstance(System.Type.GetType("FeaEntidades.InterFacturas." + ((FeaEntidades.Excel.Ubicador)o).Tipo + ", FeaEntidades"), 10);
                //        oArrayInterno = (Object[])providerInterno.ExtractRecords();

                //        if (oArrayInterno.Length>0)
                //        {
                //            switch (oArrayInterno.GetType().ToString())
                //            {
                //                case "FeaEntidades.InterFacturas.cabecera_lote[]":
                //                    lote.cabecera_lote = (FeaEntidades.InterFacturas.cabecera_lote)oArrayInterno[0];
                //                    break;
                //                case "FeaEntidades.InterFacturas.informacion_comprador[]":
                //                    compcab.informacion_comprador = (FeaEntidades.InterFacturas.informacion_comprador)oArrayInterno[0];
                //                    break;
                //                case "FeaEntidades.InterFacturas.informacion_comprobante[]":
                //                    compcab.informacion_comprobante = (FeaEntidades.InterFacturas.informacion_comprobante)oArrayInterno[0];
                //                    break;
                //                case "FeaEntidades.InterFacturas.informacion_comprobanteReferencias[]":
                //                    compcab.informacion_comprobante.referencias = (FeaEntidades.InterFacturas.informacion_comprobanteReferencias[])oArrayInterno;
                //                    break;
                //                case "FeaEntidades.InterFacturas.informacion_vendedor[]":
                //                    compcab.informacion_vendedor = (FeaEntidades.InterFacturas.informacion_vendedor)oArrayInterno[0];
                //                    break;
                //                case "FeaEntidades.InterFacturas.detalle[]":
                //                    comp.detalle = (FeaEntidades.InterFacturas.detalle)oArrayInterno[0];
                //                    break;
                //                case "FeaEntidades.InterFacturas.linea[]":
                //                    comp.detalle.linea = (FeaEntidades.InterFacturas.linea[])oArrayInterno;
                //                    break;
                //                case "FeaEntidades.InterFacturas.lineaImportes_moneda_origen[]":
                //                    break;
                //                case "FeaEntidades.InterFacturas.lineaImpuestos[]":
                //                    break;
                //                case "FeaEntidades.InterFacturas.lineaDescuentos[]":
                //                    break;
                //                case "FeaEntidades.InterFacturas.resumen[]":
                //                    comp.resumen = (FeaEntidades.InterFacturas.resumen)oArrayInterno[0];
                //                    break;
                //                case "FeaEntidades.InterFacturas.resumenDescuentos[]":
                //                    comp.resumen.descuentos = (FeaEntidades.InterFacturas.resumenDescuentos[])oArrayInterno;
                //                    break;
                //                case "FeaEntidades.InterFacturas.resumenImportes_moneda_origen[]":
                //                    break;
                //                case "FeaEntidades.InterFacturas.resumenImpuestos[]":
                //                    comp.resumen.impuestos = (FeaEntidades.InterFacturas.resumenImpuestos[])oArrayInterno;
                //                    break;
                //            }
                //        }
                //    }
                //}

                //System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(lote.GetType());
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();
                //sb.Append(lote.cabecera_lote.cuit_vendedor);
                //sb.Append("-");
                //sb.Append(lote.cabecera_lote.punto_de_venta.ToString("0000"));
                //sb.Append("-");
                //sb.Append(lote.comprobante[0].cabecera.informacion_comprobante.tipo_de_comprobante.ToString("00"));
                //sb.Append("-");
                //sb.Append(lote.comprobante[0].cabecera.informacion_comprobante.numero_comprobante.ToString("00000000"));
                //sb.Append(".xml");
                //System.IO.Stream fs = new System.IO.FileStream(sb.ToString(), System.IO.FileMode.Create);
                //System.Xml.XmlWriter writer = new System.Xml.XmlTextWriter(fs, System.Text.Encoding.GetEncoding("ISO-8859-1"));
                //x.Serialize(writer, lote);
                //fs.Close();

			}
			catch(Exception ex)
			{
				Cedeira.Ex.ExceptionManager.Publish(ex);
			}
		}
	}
}