using System;
using System.Collections.Generic;
using System.Text;

namespace FEArn
{
    public class ConsultaCAE
    {
		long cuit;
		FEAdb.db db;
		static Sesion sesion;
        LoginTicket ticket;
        FEArn.ar.gov.afip.wsw.Service objWS;

        public ConsultaCAE(string urlWsfe, string RutaCertificado, long Cuit, Sesion Sesion)
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

        public FEArn.ar.gov.afip.wsw.FEConsultaCAEResponse ConsultarCAE(FeaEntidades.ConsultaCAE ConsultaCAE)
        {
            /*Limpio resultados de la consulta CAE anterior*/
            ConsultaCAE.Resultado = string.Empty;
            ConsultaCAE.MensajeError = string.Empty;
            FEArn.ar.gov.afip.wsw.FEConsultaCAEReq CAErequest = new FEArn.ar.gov.afip.wsw.FEConsultaCAEReq();
            CAErequest.cuit_emisor = ConsultaCAE.Cuit_emisor;
            CAErequest.fecha_cbte = ConsultaCAE.Fecha_cbte.ToString("yyyyMMdd");
            CAErequest.punto_vta = ConsultaCAE.Punto_vta;
            CAErequest.tipo_cbte = ConsultaCAE.Tipo_cbte;
            CAErequest.cbt_nro = ConsultaCAE.Cbt_nro;
            CAErequest.imp_total = ConsultaCAE.Imp_total;
            CAErequest.cae = ConsultaCAE.Cae;
            FEArn.ar.gov.afip.wsw.FEConsultaCAEResponse CAEresponse = new FEArn.ar.gov.afip.wsw.FEConsultaCAEResponse();
            CAEresponse = objWS.FEConsultaCAERequest(ticket.ObjAutorizacion, CAErequest);
            return CAEresponse;
        }
    }
}
