using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades
{
    [FileHelpers.DelimitedRecord("|")]
    public class ConsultaUltNroComprobante
    {
        long cuit_emisor;
        int punto_vta;
        //int tipo_cbte;
        string resultado;
        string mensajeError;
        TiposDeComprobantes.TipoComprobante tipoComp;

        public ConsultaUltNroComprobante()
        {
            tipoComp = new FeaEntidades.TiposDeComprobantes.TipoComprobante();
        }

        public TiposDeComprobantes.TipoComprobante TipoComp
        {
            get { return tipoComp; }
            set { tipoComp = value; }
        }

        public long Cuit_emisor
        {
            get { return cuit_emisor; }
            set { cuit_emisor = value; }
        }

        public int Punto_vta
        {
            get { return punto_vta; }
            set { punto_vta = value; }
        }

        public int Tipo_cbte
        {
            get { return Convert.ToInt32(tipoComp.Codigo); }
            set { tipoComp.Codigo = Convert.ToInt16(value); }
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
