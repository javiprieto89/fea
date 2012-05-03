using System;
using System.Collections.Generic;
using System.Text;

namespace FEArn
{
    public class ConsultaCAE
    {
        const string DEFAULT_SERVICIO = "wsfe";
		string rutaCertificado;
		long cuit;
		FEArn.ar.gov.afip.wsw.FEAuthRequest objAutorizacion;
		FEArn.ar.gov.afip.wsw.Service objWSFE;
		System.Net.WebProxy wp;
		FEArn.ar.gov.afip.wsw.FEResponse objFEResponse;
		FEAdb.db db;
		static Sesion sesion;

        public ConsultaCAE(string urlWsaa, string urlWsfe, string RutaCertificado, long Cuit, Sesion Sesion, System.Net.WebProxy Wp)
		{
			sesion = Sesion;
			cuit = Cuit;
			rutaCertificado = RutaCertificado;
			LoginTicket objTicketRespuesta;
			string strTicketRespuesta;
			try
			{
				objTicketRespuesta = new LoginTicket();
				strTicketRespuesta = objTicketRespuesta.ObtenerLoginTicketResponse(DEFAULT_SERVICIO, urlWsaa, RutaCertificado, false, Wp);
				objAutorizacion = new FEArn.ar.gov.afip.wsw.FEAuthRequest();
				objAutorizacion.Token = objTicketRespuesta.Token;
				objAutorizacion.Sign = objTicketRespuesta.Sign;
				objAutorizacion.cuit = cuit;
				objFEResponse = new FEArn.ar.gov.afip.wsw.FEResponse();
				objFEResponse.RError = new FEArn.ar.gov.afip.wsw.vError();
			}
			catch(Exception ex)
			{
				Cedeira.Ex.ExceptionManager.Publish(ex);
			}
			db = new FEAdb.db(sesion);
			objWSFE = new FEArn.ar.gov.afip.wsw.Service();
			objWSFE.Url = urlWsfe;
			objWSFE.Proxy = Wp;
		}

		public FEArn.ar.gov.afip.wsw.FEAuthRequest ObjAutorizacion
		{
			get { return objAutorizacion; }
			set { objAutorizacion = value; }
		}

		public FEArn.ar.gov.afip.wsw.Service ObjWSFE
		{
			get { return objWSFE; }
			set { objWSFE = value; }
		}

		public System.Net.WebProxy Wp
		{
			get { return wp; }
			set { wp = value; }
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
            CAEresponse = objWSFE.FEConsultaCAERequest(objAutorizacion, CAErequest);
        }
    }
}
