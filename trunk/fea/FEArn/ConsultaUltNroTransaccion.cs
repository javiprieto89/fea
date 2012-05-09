using System;
using System.Collections.Generic;
using System.Text;

namespace FEArn
{
    public class ConsultaUltNroTransaccion
    {
        long cuit;
		FEAdb.db db;
		static Sesion sesion;
        LoginTicket ticket;
        FEArn.ar.gov.afip.wsw.Service objWS;

        public ConsultaUltNroTransaccion(string urlWsfe, string RutaCertificado, long Cuit, Sesion Sesion)
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

        public FEArn.ar.gov.afip.wsw.FEUltNroResponse ConsultarUltNroTransacion(FeaEntidades.ConsultaUltNroTransaccion ConsultaUltNro)
        {
            /*Limpio resultados de la consulta CAE anterior*/
            ConsultaUltNro.Resultado = string.Empty;
            ConsultaUltNro.MensajeError = string.Empty;
            FEArn.ar.gov.afip.wsw.FEUltNroResponse FEUltNroResponse = new FEArn.ar.gov.afip.wsw.FEUltNroResponse();
            FEUltNroResponse = objWS.FEUltNroRequest(ticket.ObjAutorizacion);
            return FEUltNroResponse;
        }

        public FEArn.ar.gov.afip.wsw.FERecuperaQTYResponse ConsultarCantMaxRenglones(FeaEntidades.ConsultaUltNroTransaccion ConsultaCantMaxRenglones)
        {
            /*Limpio resultados de la consulta CAE anterior*/
            ConsultaCantMaxRenglones.Resultado = string.Empty;
            ConsultaCantMaxRenglones.MensajeError = string.Empty;
            FEArn.ar.gov.afip.wsw.FERecuperaQTYResponse FERecuperaQTYResponse = new FEArn.ar.gov.afip.wsw.FERecuperaQTYResponse();
            FERecuperaQTYResponse = objWS.FERecuperaQTYRequest(ticket.ObjAutorizacion);
            return FERecuperaQTYResponse;
        }

        public string ConsultarDummyAppServer()
        {
            FEArn.ar.gov.afip.wsw.DummyResponse dr = new FEArn.ar.gov.afip.wsw.DummyResponse();
            dr = objWS.FEDummy();
            return dr.appserver.ToString();
        }

        public string ConsultarDummyAuthServer()
        {
            FEArn.ar.gov.afip.wsw.DummyResponse dr = new FEArn.ar.gov.afip.wsw.DummyResponse();
            dr = objWS.FEDummy();
            return dr.authserver.ToString();
        }

        public string ConsultarDummyDbServer()
        {
            FEArn.ar.gov.afip.wsw.DummyResponse dr = new FEArn.ar.gov.afip.wsw.DummyResponse();
            dr = objWS.FEDummy();
            return dr.dbserver.ToString();
        }
    }
}
