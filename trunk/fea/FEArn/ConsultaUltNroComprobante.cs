using System;
using System.Collections.Generic;
using System.Text;

namespace FEArn
{
    public class ConsultaUltNroComprobante
    {
        long cuit;
		FEAdb.db db;
		static Sesion sesion;
        LoginTicket ticket;
        FEArn.ar.gov.afip.wsw.Service objWS;

        public ConsultaUltNroComprobante(string urlWsfe, string RutaCertificado, long Cuit, Sesion Sesion)
		{
			sesion = Sesion;
			cuit = Cuit;
            ticket = new LoginTicket();
            ticket.ObtenerTicket(RutaCertificado, Cuit);
            objWS = new FEArn.ar.gov.afip.wsw.Service();
            objWS.Url = urlWsfe;
            objWS.Proxy = ticket.Wp;
			db = new FEAdb.db(sesion);
    	}

        public FEArn.ar.gov.afip.wsw.FERecuperaLastCMPResponse ConsultarUltNroComprobante(FeaEntidades.ConsultaUltNroComprobante ConsultaUltNro)
        {
            /*Limpio resultados de la consulta CAE anterior*/
            ConsultaUltNro.Resultado = string.Empty;
            ConsultaUltNro.MensajeError = string.Empty;
            FEArn.ar.gov.afip.wsw.FERecuperaLastCMPResponse objFERecuperaLastCMPResponse = new FEArn.ar.gov.afip.wsw.FERecuperaLastCMPResponse();
            FEArn.ar.gov.afip.wsw.FELastCMPtype tipoComprobante = new FEArn.ar.gov.afip.wsw.FELastCMPtype();
            tipoComprobante.PtoVta = ConsultaUltNro.Punto_vta;
            tipoComprobante.TipoCbte = ConsultaUltNro.Tipo_cbte;
            FEArn.ar.gov.afip.wsw.FERecuperaLastCMPResponse FERecuperaLastCMPResponse = new FEArn.ar.gov.afip.wsw.FERecuperaLastCMPResponse();
            FERecuperaLastCMPResponse = objWS.FERecuperaLastCMPRequest(ticket.ObjAutorizacion, tipoComprobante);
            return FERecuperaLastCMPResponse;
        }
    }
}
