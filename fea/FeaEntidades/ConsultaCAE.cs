using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades
{
    [FileHelpers.DelimitedRecord("|")]
    public class ConsultaCAE
    {
        long cuit_receptor;
        long cuit_emisor;
		DateTime fecha_cbte;
		int punto_vta;
		int tipo_cbte;
		int cbt_nro;
		double imp_total = 0;
		string cae;
		string resultado;
		string mensajeError;

        public ConsultaCAE()
        {
        }

        //Esta propiedad es para llamar al certificado correspondiente
        public long Cuit_receptor
        {
            get { return cuit_receptor; }
            set { cuit_receptor = value; }
        }

        public long Cuit_emisor
        {
            get { return cuit_emisor; }
            set { cuit_emisor = value; }
        }

        public DateTime Fecha_cbte
        {
            get { return fecha_cbte; }
            set { fecha_cbte = value; }
        }

        public int Punto_vta
        {
            get { return punto_vta; }
            set { punto_vta = value; }
        }

        public int Tipo_cbte
        {
            get { return tipo_cbte; }
            set { tipo_cbte = value; }
        }

        public int Cbt_nro
        {
            get { return cbt_nro; }
            set { cbt_nro = value; }
        }

        public Double Imp_total
        {
            get { return imp_total; }
            set { imp_total = value; }
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
    }
}
