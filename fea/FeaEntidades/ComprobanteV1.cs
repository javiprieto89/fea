using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades
{
	[FileHelpers.DelimitedRecord("|")]
	public class ComprobanteV1
	{
		DateTime fechaImpacto;
		long idTransaccion;
		bool presta_serv;
		DateTime fecha_cbte = System.DateTime.Now;
		DateTime fecha_serv_desde = System.DateTime.Now;
		DateTime fecha_serv_hasta = System.DateTime.Now;
		DateTime fecha_venc_pago = System.DateTime.Now;
		short puntoVenta;
		TiposDeComprobantes.TipoComprobante tipoComp;

		double imp_neto = 0;
		double imp_op_ex = 0;
		double imp_tot_conc = 0;
		double imp_total = 0;
		double impto_liq = 0;
		List<ComprobanteV1_Tributos> tributos;
        List<ComprobanteV1_IVA> iva;
		long nro_doc;
		Documentos.Documento tipo_doc;
        long cuit_emisor;
		string cae;
		string resultado;
		string motivo;
		string mensajeError;

		public ComprobanteV1()
		{
			tipo_doc = new Documentos.CUIT();
			tipoComp = new TiposDeComprobantes.Facturas.A();
		}

        public TiposDeComprobantes.TipoComprobante TipoComp
        {
            get { return tipoComp; }
            set { tipoComp = value; }
        }

        public Documentos.Documento Tipo_doc
        {
            get { return tipo_doc; }
            set { tipo_doc = value; }
        }

		public DateTime FechaImpacto
		{
			get { return fechaImpacto; }
			set { fechaImpacto = value; }
		}

		public long IdTransaccion
		{
			get { return idTransaccion; }
			set { idTransaccion = value; }
		}

		public bool Presta_serv
		{
			get { return presta_serv; }
			set { presta_serv = value; }
		}

		public DateTime Fecha_cbte
		{
			get { return fecha_cbte; }
			set { fecha_cbte = value; }
		}

		public DateTime Fecha_serv_desde
		{
			get { return fecha_serv_desde; }
			set { fecha_serv_desde = value; }
		}

		public DateTime Fecha_serv_hasta
		{
			get { return fecha_serv_hasta; }
			set { fecha_serv_hasta = value; }
		}

		public DateTime Fecha_venc_pago
		{
			get { return fecha_venc_pago; }
			set { fecha_venc_pago = value; }
		}

		public short PuntoVenta
		{
			get { return puntoVenta; }
			set { puntoVenta = value; }
		}

		public double Imp_neto
		{
			get { return imp_neto; }
			set { imp_neto = value; }
		}

		public double Imp_op_ex
		{
			get { return imp_op_ex; }
			set { imp_op_ex = value; }
		}

		public double Imp_tot_conc
		{
			get { return imp_tot_conc; }
			set { imp_tot_conc = value; }
		}

		public double Imp_total
		{
			get { return imp_total; }
			set { imp_total = value; }
		}

		public double Impto_liq
		{
			get { return impto_liq; }
			set { impto_liq = value; }
		}

		public long Nro_doc
		{
			get { return nro_doc; }
			set { nro_doc = value; }
		}

		public string Resultado
		{
			get { return resultado; }
			set 
			{
				resultado = value;
				EnResultadoChanged(EventArgs.Empty);
			}
		}
		public event EventHandler ResultadoChanged;
		protected virtual void EnResultadoChanged(EventArgs e) { if (ResultadoChanged != null) ResultadoChanged(this, e); }

		public string Cae
		{
			get { return cae; }
			set 
			{ 
				cae = value;
				EnCaeChanged(EventArgs.Empty);
			}
		}
		public event EventHandler CaeChanged;
		protected virtual void EnCaeChanged(EventArgs e) { if (CaeChanged != null) CaeChanged(this, e); }

		public string Motivo
		{
			get { return motivo; }
			set
			{
				motivo = value;
				EnMotivoChanged(EventArgs.Empty);
			}
		}
		public event EventHandler MotivoChanged;
		protected virtual void EnMotivoChanged(EventArgs e) { if (MotivoChanged != null) MotivoChanged(this, e); }

		public string MensajeError
		{
			get { return mensajeError; }
			set
			{
				mensajeError = value;
				EnMensajeErrorChanged(EventArgs.Empty);
			}

		}
		public event EventHandler MensajeErrorChanged;
		protected virtual void EnMensajeErrorChanged(EventArgs e) { if (MensajeErrorChanged != null) MensajeErrorChanged(this, e); }
        
		public short TipoDoc
		{
			get { return tipo_doc.Codigo; }
			set { tipo_doc.Codigo = value; }
		}

		public string DescrTipoDoc
		{
			get { return tipo_doc.Descr; }
			set { tipo_doc.Descr = value; }
		}

		public short Codigo
		{
			get { return tipoComp.Codigo; }
			set { tipoComp.Codigo = value; }
		}

		public string DescrCodigo
		{
			get { return tipoComp.Descr; }
			set { tipoComp.Descr = value; }
		}

		public long IdComprobante
		{
			get { return tipoComp.IdComprobante; }
			set { tipoComp.IdComprobante = value; }
		}

        public long Cuit_emisor
        {
            get { return cuit_emisor; }
            set { cuit_emisor = value; }
        }

        public List<ComprobanteV1_Tributos> Tributos
        {
            get { return tributos; }
            set { tributos = value; }
        }
        
        public List<ComprobanteV1_IVA> Iva
        {
            get { return iva; }
            set { iva = value; }
        }
	}
}
