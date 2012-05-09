using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades
{
    public class ConsultaUltNroTransaccion
    {
        long cuit_emisor;
        string resultado;
        string mensajeError;

        public ConsultaUltNroTransaccion()
        {
        }

        public long Cuit_emisor
        {
            get { return cuit_emisor; }
            set { cuit_emisor = value; }
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
