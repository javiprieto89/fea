using System;
using System.Collections.Generic;
using System.Text;

namespace FEArn
{
	public class Comprobante
	{
		string rutaCertificado;
		long cuit;
		FEAdb.db db;
		static Sesion sesion;
        FEArn.ar.gov.afip.wsw.FEResponse objFEResponse;
        LoginTicket ticket;
        FEArn.ar.gov.afip.wsw.Service objWS;
        FEArn.ar.gov.afip.wsfev1.Service objWSFEV1;
        int cantidadComprobantesXLote;

		public Comprobante(string RutaCertificado, long Cuit, Sesion Sesion)
		{
			sesion = Sesion;
			cuit = Cuit;
            ticket = new LoginTicket();
            ticket.ObtenerTicket(RutaCertificado, Cuit);
            objWS = new FEArn.ar.gov.afip.wsw.Service();
            objWS.Url = System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsw_Service"];
            objWS.Proxy = ticket.Wp;
            objWSFEV1 = new FEArn.ar.gov.afip.wsfev1.Service();
            objWSFEV1.Url = System.Configuration.ConfigurationManager.AppSettings["FEA_ar_gov_afip_wsfev1_Service"];
            objWSFEV1.Proxy = ticket.Wp;
			db = new FEAdb.db(sesion);
            cantidadComprobantesXLote = 1;
		}

		public void Enviar(FeaEntidades.Comprobante Comprobante, int CantidadComprobantes)
		{
			try
			{
				/*Limpio resultados del comprobante anterior*/
				Comprobante.Resultado = string.Empty;
				Comprobante.Motivo = string.Empty;
				Comprobante.MensajeError = string.Empty;
				Comprobante.Cae = string.Empty;

				FEArn.ar.gov.afip.wsw.FERequest objFERequest = new FEArn.ar.gov.afip.wsw.FERequest();

				FEArn.ar.gov.afip.wsw.FECabeceraRequest objFECabeceraRequest = new FEArn.ar.gov.afip.wsw.FECabeceraRequest();
                objFECabeceraRequest.cantidadreg = cantidadComprobantesXLote;

				/* Obtengo última transacción y sumo 1 */
				FEArn.ar.gov.afip.wsw.FEUltNroResponse objFEUltNroResponse = new FEArn.ar.gov.afip.wsw.FEUltNroResponse();
				objFEUltNroResponse = objWS.FEUltNroRequest(ticket.ObjAutorizacion);

				Comprobante.IdTransaccion = objFEUltNroResponse.nro.value + 1;
				objFECabeceraRequest.id = Comprobante.IdTransaccion;
				objFECabeceraRequest.presta_serv = Convert.ToInt32(Comprobante.Presta_serv);
				objFERequest.Fecr = objFECabeceraRequest;

                FEArn.ar.gov.afip.wsw.FEDetalleRequest[] arrayFEDetalleRequest = new FEArn.ar.gov.afip.wsw.FEDetalleRequest[CantidadComprobantes];
				FEArn.ar.gov.afip.wsw.FEDetalleRequest objFEDetalleRequest = new FEArn.ar.gov.afip.wsw.FEDetalleRequest();

				/* Obtengo último comprobante*/
				FEArn.ar.gov.afip.wsw.FERecuperaLastCMPResponse objFERecuperaLastCMPResponse = new FEArn.ar.gov.afip.wsw.FERecuperaLastCMPResponse();
				FEArn.ar.gov.afip.wsw.FELastCMPtype tipoComprobante = new FEArn.ar.gov.afip.wsw.FELastCMPtype();
				tipoComprobante.PtoVta = Comprobante.PuntoVenta;
				tipoComprobante.TipoCbte = Comprobante.Codigo;
                objFERecuperaLastCMPResponse = objWS.FERecuperaLastCMPRequest(ticket.ObjAutorizacion, tipoComprobante);
				Comprobante.IdComprobante = objFERecuperaLastCMPResponse.cbte_nro;

				objFEDetalleRequest.fecha_cbte = Comprobante.Fecha_cbte.ToString("yyyyMMdd");
				objFEDetalleRequest.fecha_serv_desde = Comprobante.Fecha_serv_desde.ToString("yyyyMMdd");
				objFEDetalleRequest.fecha_serv_hasta = Comprobante.Fecha_serv_hasta.ToString("yyyyMMdd");
				objFEDetalleRequest.fecha_venc_pago = Comprobante.Fecha_venc_pago.ToString("yyyyMMdd");
				objFEDetalleRequest.imp_neto = Comprobante.Imp_neto;
				objFEDetalleRequest.imp_op_ex = Comprobante.Imp_op_ex;
				objFEDetalleRequest.imp_tot_conc = Comprobante.Imp_tot_conc;
				objFEDetalleRequest.imp_total = Comprobante.Imp_total;
				objFEDetalleRequest.impto_liq = Comprobante.Impto_liq;
				objFEDetalleRequest.impto_liq_rni = Comprobante.Impto_liq_rni;
				objFEDetalleRequest.nro_doc = Comprobante.Nro_doc;
				objFEDetalleRequest.punto_vta = Comprobante.PuntoVenta;
				objFEDetalleRequest.tipo_cbte = Comprobante.Codigo;
				objFEDetalleRequest.tipo_doc = Comprobante.TipoDoc;
                
                arrayFEDetalleRequest[0] = objFEDetalleRequest;
                for (int c = 0; c < CantidadComprobantes; c++)
                {
                    Comprobante.IdComprobante = Comprobante.IdComprobante + 1;
                    objFEDetalleRequest.cbt_desde = Comprobante.IdComprobante;
                    objFEDetalleRequest.cbt_hasta = Comprobante.IdComprobante;
                    arrayFEDetalleRequest[c] = objFEDetalleRequest;
                }
				objFERequest.Fedr = arrayFEDetalleRequest;

                objFEResponse = objWS.FEAutRequest(ticket.ObjAutorizacion, objFERequest);

                if (objFEResponse.FedResp != null)
				{
                    for (int i = 0; i < objFEResponse.FedResp.Length; i++)
                    {
					    Comprobante.Motivo = objFEResponse.FedResp[i].motivo ;
					    Comprobante.Resultado = objFEResponse.FedResp[i].resultado;
					    Comprobante.Cae = objFEResponse.FedResp[i].cae;
                        InsertarComprobante(Comprobante);
                    }
				}
				else
				{
                    Comprobante.MensajeError = objFEResponse.RError.percode + "-" + objFEResponse.RError.perrmsg;
					Comprobante.IdComprobante = 0;
					Comprobante.IdTransaccion = 0;
                    InsertarComprobante(Comprobante);
				}
                
			}
			catch (Exception ex)
			{
				Cedeira.Ex.ExceptionManager.Publish(ex);
			}
		}

        public List<FeaEntidades.ComprobanteV1_IVA> RG2485V1TipoIva()
        {
            List<FeaEntidades.ComprobanteV1_IVA> lista = new List<FeaEntidades.ComprobanteV1_IVA>();
            FEArn.ar.gov.afip.wsfev1.IvaTipo[] ivaTipo;
            FEArn.ar.gov.afip.wsfev1.IvaTipoResponse objTipoIvaResponse = new FEArn.ar.gov.afip.wsfev1.IvaTipoResponse();
            objTipoIvaResponse = objWSFEV1.FEParamGetTiposIva(ticket.ObjAutorizacionfev1);
            ivaTipo = objTipoIvaResponse.ResultGet;
            if (ivaTipo.Length != 0)
            {
                for(int i = 0; i<ivaTipo.Length; i++)
                {
                    FeaEntidades.ComprobanteV1_IVA iva = new FeaEntidades.ComprobanteV1_IVA();
                    CopiarRG2485V1TipoIva(ivaTipo[i], iva);
                    lista.Add(iva);
                }
            }
            return lista;
        }

        private void CopiarRG2485V1TipoIva(FEArn.ar.gov.afip.wsfev1.IvaTipo desde, FeaEntidades.TipoIVA hasta)
        {
            hasta.Id = desde.Id;
            hasta.Baseimp = desde.Desc;
            hasta.FchDesde = desde.FchDesde;
            hasta.FchHasta = desde.FchHasta;
        }

        public List<FeaEntidades.ComprobanteV1_Tributos> RG2485V1Tributos()
        {
            List<FeaEntidades.TipoTributos> lista = new List<FeaEntidades.TipoTributos>();
            FEArn.ar.gov.afip.wsfev1.TributoTipo[] tributos;
            FEArn.ar.gov.afip.wsfev1.FETributoResponse objFETributoResponse = new FEArn.ar.gov.afip.wsfev1.FETributoResponse();
            objFETributoResponse = objWSFEV1.FEParamGetTiposTributos(ticket.ObjAutorizacionfev1);
            tributos = objFETributoResponse.ResultGet;
            if (tributos.Length != 0)
            {
                for (int i = 0; i < tributos.Length; i++)
                {
                    FeaEntidades.TipoTributos tributo = new FeaEntidades.TipoTributos();
                    CopiarRG2485V1Tributos(tributos[i], tributo);
                    lista.Add(tributo);
                }
            }
            return lista;
        }

        private void CopiarRG2485V1Tributos(FEArn.ar.gov.afip.wsfev1.TributoTipo desde, FeaEntidades.TipoTributos hasta)
        {
            hasta.Id = desde.Id;
            hasta.Baseimp = desde.Desc;
            hasta.FchDesde = desde.FchDesde;
            hasta.FchHasta = desde.FchHasta;
        }
        
        public void EnviarV1(FeaEntidades.ComprobanteV1 Comprobante, int CantidadComprobantes)
        {
            try
            {
                /*Limpio resultados del comprobante anterior*/
                Comprobante.Resultado = string.Empty;
                Comprobante.Motivo = string.Empty;
                Comprobante.MensajeError = string.Empty;
                Comprobante.Cae = string.Empty;

                FEArn.ar.gov.afip.wsfev1.FECAERequest objFERequest = new FEArn.ar.gov.afip.wsfev1.FECAERequest();

                //FEArn.ar.gov.afip.wsw.FECabeceraRequest objFECabeceraRequest = new FEArn.ar.gov.afip.wsw.FECabeceraRequest();
                //objFECabeceraRequest.cantidadreg = cantidadComprobantesXLote;

                ///* Obtengo última transacción y sumo 1 */
                //FEArn.ar.gov.afip.wsw.FEUltNroResponse objFEUltNroResponse = new FEArn.ar.gov.afip.wsw.FEUltNroResponse();
                //objFEUltNroResponse = objWS.FEUltNroRequest(ticket.ObjAutorizacion);

                //Comprobante.IdTransaccion = objFEUltNroResponse.nro.value + 1;
                //objFECabeceraRequest.id = Comprobante.IdTransaccion;
                //objFECabeceraRequest.presta_serv = Convert.ToInt32(Comprobante.Presta_serv);
                //objFERequest.Fecr = objFECabeceraRequest;

                //FEArn.ar.gov.afip.wsw.FEDetalleRequest[] arrayFEDetalleRequest = new FEArn.ar.gov.afip.wsw.FEDetalleRequest[CantidadComprobantes];
                //FEArn.ar.gov.afip.wsw.FEDetalleRequest objFEDetalleRequest = new FEArn.ar.gov.afip.wsw.FEDetalleRequest();

                ///* Obtengo último comprobante*/
                //FEArn.ar.gov.afip.wsw.FERecuperaLastCMPResponse objFERecuperaLastCMPResponse = new FEArn.ar.gov.afip.wsw.FERecuperaLastCMPResponse();
                //FEArn.ar.gov.afip.wsw.FELastCMPtype tipoComprobante = new FEArn.ar.gov.afip.wsw.FELastCMPtype();
                //tipoComprobante.PtoVta = Comprobante.PuntoVenta;
                //tipoComprobante.TipoCbte = Comprobante.Codigo;
                //objFERecuperaLastCMPResponse = objWS.FERecuperaLastCMPRequest(ticket.ObjAutorizacion, tipoComprobante);
                //Comprobante.IdComprobante = objFERecuperaLastCMPResponse.cbte_nro;

                //objFEDetalleRequest.fecha_cbte = Comprobante.Fecha_cbte.ToString("yyyyMMdd");
                //objFEDetalleRequest.fecha_serv_desde = Comprobante.Fecha_serv_desde.ToString("yyyyMMdd");
                //objFEDetalleRequest.fecha_serv_hasta = Comprobante.Fecha_serv_hasta.ToString("yyyyMMdd");
                //objFEDetalleRequest.fecha_venc_pago = Comprobante.Fecha_venc_pago.ToString("yyyyMMdd");
                //objFEDetalleRequest.imp_neto = Comprobante.Imp_neto;
                //objFEDetalleRequest.imp_op_ex = Comprobante.Imp_op_ex;
                //objFEDetalleRequest.imp_tot_conc = Comprobante.Imp_tot_conc;
                //objFEDetalleRequest.imp_total = Comprobante.Imp_total;
                //objFEDetalleRequest.impto_liq = Comprobante.Impto_liq;
                //objFEDetalleRequest.impto_liq_rni = Comprobante.Impto_liq_rni;
                //objFEDetalleRequest.nro_doc = Comprobante.Nro_doc;
                //objFEDetalleRequest.punto_vta = Comprobante.PuntoVenta;
                //objFEDetalleRequest.tipo_cbte = Comprobante.Codigo;
                //objFEDetalleRequest.tipo_doc = Comprobante.TipoDoc;

                //arrayFEDetalleRequest[0] = objFEDetalleRequest;
                //for (int c = 0; c < CantidadComprobantes; c++)
                //{
                //    Comprobante.IdComprobante = Comprobante.IdComprobante + 1;
                //    objFEDetalleRequest.cbt_desde = Comprobante.IdComprobante;
                //    objFEDetalleRequest.cbt_hasta = Comprobante.IdComprobante;
                //    arrayFEDetalleRequest[c] = objFEDetalleRequest;
                //}
                //objFERequest.Fedr = arrayFEDetalleRequest;

                //objFEResponse = objWS.FEAutRequest(ticket.ObjAutorizacion, objFERequest);

                //if (objFEResponse.FedResp != null)
                //{
                //    for (int i = 0; i < objFEResponse.FedResp.Length; i++)
                //    {
                //        Comprobante.Motivo = objFEResponse.FedResp[i].motivo;
                //        Comprobante.Resultado = objFEResponse.FedResp[i].resultado;
                //        Comprobante.Cae = objFEResponse.FedResp[i].cae;
                //        InsertarComprobanteV1(Comprobante);
                //    }
                //}
                //else
                //{
                //    Comprobante.MensajeError = objFEResponse.RError.percode + "-" + objFEResponse.RError.perrmsg;
                //    Comprobante.IdComprobante = 0;
                //    Comprobante.IdTransaccion = 0;
                //    InsertarComprobanteV1(Comprobante);
                //}

            }
            catch (Exception ex)
            {
                Cedeira.Ex.ExceptionManager.Publish(ex);
            }
        }



        private void InsertarComprobante(FeaEntidades.Comprobante Comprobante)
        {
            FEAdb.dbComprobante db = new FEAdb.dbComprobante(sesion);
            try
            {
                System.Threading.Thread.Sleep(1000);
                db.Comprobante_ins(DateTime.Now, Comprobante.IdTransaccion, Comprobante.IdComprobante, Comprobante.PuntoVenta,
                    Comprobante.Codigo, Comprobante.DescrCodigo, Comprobante.Nro_doc, Comprobante.TipoDoc,
                    Comprobante.DescrTipoDoc, Comprobante.Fecha_cbte, Comprobante.Fecha_serv_desde, Comprobante.Fecha_serv_hasta,
                    Comprobante.Fecha_venc_pago, Comprobante.Imp_neto, Comprobante.Imp_op_ex, Comprobante.Imp_tot_conc,
                    Comprobante.Impto_liq, Comprobante.Impto_liq_rni, Comprobante.Imp_total, Comprobante.Cae, Comprobante.Motivo,
                    Comprobante.Resultado, Comprobante.Presta_serv, Comprobante.MensajeError, Comprobante.Cuit_emisor);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                System.Threading.Thread.Sleep(1000);
                db.Comprobante_ins(DateTime.Now, Comprobante.IdTransaccion, Comprobante.IdComprobante, Comprobante.PuntoVenta,
                    Comprobante.Codigo, Comprobante.DescrCodigo, Comprobante.Nro_doc, Comprobante.TipoDoc,
                    Comprobante.DescrTipoDoc, Comprobante.Fecha_cbte, Comprobante.Fecha_serv_desde, Comprobante.Fecha_serv_hasta,
                    Comprobante.Fecha_venc_pago, Comprobante.Imp_neto, Comprobante.Imp_op_ex, Comprobante.Imp_tot_conc,
                    Comprobante.Impto_liq, Comprobante.Impto_liq_rni, Comprobante.Imp_total, Comprobante.Cae, Comprobante.Motivo,
                    Comprobante.Resultado, Comprobante.Presta_serv, Comprobante.MensajeError, Comprobante.Cuit_emisor);
            }
        }

        private void InsertarComprobanteV1(FeaEntidades.ComprobanteV1 Comprobante)
        {
            FEAdb.dbComprobante db = new FEAdb.dbComprobante(sesion);
            try
            {
                System.Threading.Thread.Sleep(1000);
                db.Comprobante_ins(DateTime.Now, Comprobante.IdTransaccion, Comprobante.IdComprobante, Comprobante.PuntoVenta,
                    Comprobante.Codigo, Comprobante.DescrCodigo, Comprobante.Nro_doc, Comprobante.TipoDoc,
                    Comprobante.DescrTipoDoc, Comprobante.Fecha_cbte, Comprobante.Fecha_serv_desde, Comprobante.Fecha_serv_hasta,
                    Comprobante.Fecha_venc_pago, Comprobante.Imp_neto, Comprobante.Imp_op_ex, Comprobante.Imp_tot_conc,
                    Comprobante.Impto_liq, 0, Comprobante.Imp_total, Comprobante.Cae, Comprobante.Motivo,
                    Comprobante.Resultado, Comprobante.Presta_serv, Comprobante.MensajeError, Comprobante.Cuit_emisor);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                System.Threading.Thread.Sleep(1000);
                db.Comprobante_ins(DateTime.Now, Comprobante.IdTransaccion, Comprobante.IdComprobante, Comprobante.PuntoVenta,
                    Comprobante.Codigo, Comprobante.DescrCodigo, Comprobante.Nro_doc, Comprobante.TipoDoc,
                    Comprobante.DescrTipoDoc, Comprobante.Fecha_cbte, Comprobante.Fecha_serv_desde, Comprobante.Fecha_serv_hasta,
                    Comprobante.Fecha_venc_pago, Comprobante.Imp_neto, Comprobante.Imp_op_ex, Comprobante.Imp_tot_conc,
                    Comprobante.Impto_liq, 0, Comprobante.Imp_total, Comprobante.Cae, Comprobante.Motivo,
                    Comprobante.Resultado, Comprobante.Presta_serv, Comprobante.MensajeError, Comprobante.Cuit_emisor);
            }
        }

        public int CantidadComprobantesXLote
        {
            get { return cantidadComprobantesXLote; }
            set { cantidadComprobantesXLote = value; }
        }

        public static List<FeaEntidades.Comprobante> Lista(Sesion Sesion)
		{
			List<FeaEntidades.Comprobante> comprobantesLista = new List<FeaEntidades.Comprobante>();
			FEAdb.dbComprobante db = new FEAdb.dbComprobante(Sesion);
			System.Data.DataTable dt = db.Comprobante_qry();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				FeaEntidades.Comprobante cdt = new FeaEntidades.Comprobante();
				cdt.FechaImpacto = Convert.ToDateTime(dt.Rows[i]["FechaImpacto"]);
				cdt.Cae = Convert.ToString(dt.Rows[i]["CAE"]);
				cdt.Fecha_cbte = Convert.ToDateTime(dt.Rows[i]["Fecha"]);
				cdt.Fecha_serv_desde = Convert.ToDateTime(dt.Rows[i]["FechaServicioDesde"]);
				cdt.Fecha_serv_hasta = Convert.ToDateTime(dt.Rows[i]["FechaServicioHasta"]);
				cdt.Fecha_venc_pago = Convert.ToDateTime(dt.Rows[i]["FechaVencPago"]);
				cdt.IdTransaccion = Convert.ToInt64(dt.Rows[i]["IdTransaccion"]);
				cdt.Imp_neto = Convert.ToDouble(dt.Rows[i]["Neto"]);
				cdt.Imp_op_ex = Convert.ToDouble(dt.Rows[i]["Exento"]);
				cdt.Imp_tot_conc = Convert.ToDouble(dt.Rows[i]["TotalConceptos"]);
				cdt.Imp_total = Convert.ToDouble(dt.Rows[i]["Total"]);
				cdt.Impto_liq = Convert.ToDouble(dt.Rows[i]["ImpuestoLiq"]);
				cdt.Impto_liq_rni = Convert.ToDouble(dt.Rows[i]["ImpuestoLiqRNI"]);
				cdt.Motivo = Convert.ToString(dt.Rows[i]["Motivo"]);
				cdt.Nro_doc = Convert.ToInt64(dt.Rows[i]["NroDoc"]);
				cdt.PuntoVenta = Convert.ToInt16(dt.Rows[i]["PuntoVenta"]);
				cdt.Resultado = Convert.ToString(dt.Rows[i]["Resultado"]);
				cdt.TipoDoc = Convert.ToInt16(dt.Rows[i]["TipoDoc"]);
				cdt.DescrTipoDoc = Convert.ToString(dt.Rows[i]["DescrTipoDoc"]);
				cdt.Codigo = Convert.ToInt16(dt.Rows[i]["Codigo"]);
				cdt.DescrCodigo = Convert.ToString(dt.Rows[i]["DescrCodigo"]);
				cdt.IdComprobante = Convert.ToInt32(dt.Rows[i]["IdComprobante"]);
				cdt.Presta_serv = Convert.ToBoolean(dt.Rows[i]["PrestaServicio"]);
				cdt.MensajeError = Convert.ToString(dt.Rows[i]["MensajeError"]);
                cdt.Cuit_emisor = Convert.ToInt64(dt.Rows[i]["CuitEmisor"]);
				comprobantesLista.Add(cdt);
			}
			return comprobantesLista;
		}
        public void Consultar(FeaEntidades.Comprobante Comprobante)
        {
            try
            {
                FEArn.ar.gov.afip.wsfev1.FECompConsultaReq objFECompConsultaReq = new FEArn.ar.gov.afip.wsfev1.FECompConsultaReq();
                objFECompConsultaReq.CbteTipo = Comprobante.Codigo;
                objFECompConsultaReq.CbteNro = Comprobante.IdComprobante;
                objFECompConsultaReq.PtoVta = Comprobante.PuntoVenta;
                FEArn.ar.gov.afip.wsfev1.FECompConsultaResponse objFECompConsultaResponse = new FEArn.ar.gov.afip.wsfev1.FECompConsultaResponse();
                objFECompConsultaResponse = objWSFEV1.FECompConsultar(ticket.ObjAutorizacionfev1, objFECompConsultaReq);
                System.Globalization.CultureInfo cedeiraCultura = new System.Globalization.CultureInfo(System.Configuration.ConfigurationManager.AppSettings["Cultura"], false);
                cedeiraCultura.DateTimeFormat = new System.Globalization.CultureInfo(System.Configuration.ConfigurationManager.AppSettings["CulturaDateTimeFormat"], false).DateTimeFormat;
                if (objFECompConsultaResponse.Errors != null)
                {
                    foreach(FEArn.ar.gov.afip.wsfev1.Err err in objFECompConsultaResponse.Errors)
                    {
                        Comprobante.MensajeError = err.Code + "-"+ err.Msg + "\r\n";
                    }
                }
                else
                {
                    Comprobante.MensajeError = null;
                    Comprobante.Codigo = Convert.ToInt16(objFECompConsultaResponse.ResultGet.CbteTipo);
                    Comprobante.IdComprobante = objFECompConsultaResponse.ResultGet.CbteDesde;
                    Comprobante.PuntoVenta = Convert.ToInt16(objFECompConsultaResponse.ResultGet.PtoVta);
                    Comprobante.Fecha_cbte = DateTime.ParseExact(objFECompConsultaResponse.ResultGet.CbteFch, "yyyyMMdd", cedeiraCultura);
                    Comprobante.Fecha_serv_desde = DateTime.ParseExact(objFECompConsultaResponse.ResultGet.FchServDesde, "yyyyMMdd", cedeiraCultura);
                    Comprobante.Fecha_serv_hasta = DateTime.ParseExact(objFECompConsultaResponse.ResultGet.FchServHasta, "yyyyMMdd", cedeiraCultura);
                    Comprobante.Fecha_venc_pago = DateTime.ParseExact(objFECompConsultaResponse.ResultGet.FchVtoPago, "yyyyMMdd", cedeiraCultura);
                    Comprobante.IdComprobante = objFECompConsultaResponse.ResultGet.CbteDesde;
                    Comprobante.Imp_neto = objFECompConsultaResponse.ResultGet.ImpNeto;
                    Comprobante.Imp_op_ex = objFECompConsultaResponse.ResultGet.ImpOpEx;
                    Comprobante.Imp_tot_conc = objFECompConsultaResponse.ResultGet.ImpTotConc;
                    Comprobante.Imp_total = objFECompConsultaResponse.ResultGet.ImpTotal;
                    Comprobante.Impto_liq = objFECompConsultaResponse.ResultGet.ImpIVA;
                    Comprobante.Cae = objFECompConsultaResponse.ResultGet.CodAutorizacion;
                    Comprobante.FechaImpacto = DateTime.ParseExact(objFECompConsultaResponse.ResultGet.FchProceso, "yyyyMMddHHmmss", cedeiraCultura);
                    if (objFECompConsultaResponse.ResultGet.Iva != null)
                    {
                    }
                    //Comprobante.Impto_liq_rni = objFECompConsultaResponse.ResultGet.ImpIVA;
                    Comprobante.Nro_doc = objFECompConsultaResponse.ResultGet.DocNro;
                    Comprobante.TipoDoc = Convert.ToInt16(objFECompConsultaResponse.ResultGet.DocTipo);
                    Comprobante.Resultado = objFECompConsultaResponse.ResultGet.Resultado;
                    if (objFECompConsultaResponse.ResultGet.Concepto != 0)
                    {
                        Comprobante.Motivo = objFECompConsultaResponse.ResultGet.Concepto.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Cedeira.Ex.ExceptionManager.Publish(ex);
            }
        }

		public void EnviarIBK(FeaEntidades.InterFacturas.lote_comprobantes lc)
		{
            //try
            //{
            //    //FEArn.IBK.consulta_timestamp_comprobante ctc = new FEArn.IBK.consulta_timestamp_comprobante();
            //    //ctc.cuit_vendedor = 30710015062;
            //    //ctc.cuit_canal = 30690783521;
            //    //ctc.fecha_emision_desde = "20090101";
            //    //ctc.fecha_emision_hasta = "20090228";
            //    //ctc.limite = FEArn.IBK.consulta_timestamp_comprobanteLimite.WEB;
            //    //FEArn.IBK.consulta_timestamp_response ctr = objIBK.consultaTimeStampConSchema(ctc);

            //    //FEArn.IBK.consulta_lote_comprobantes clc = new FEArn.IBK.consulta_lote_comprobantes();
            //    //clc.cuit_vendedor = lc.cabecera_lote.cuit_vendedor;
            //    //clc.cuit_canal = lc.cabecera_lote.cuit_canal;
            //    //clc.id_lote=lc.cabecera_lote.id_lote;
            //    //FEArn.IBK.consulta_lote_comprobantes_response clcr = objIBK.getLoteFacturasConSchema(clc);

            //    FEArn.IBK.lote_comprobantes lcIBK = new FEArn.IBK.lote_comprobantes();

            //    lcIBK.cabecera_lote = new FEArn.IBK.cabecera_lote();
            //    lcIBK.cabecera_lote.cantidad_reg = lc.cabecera_lote.cantidad_reg;
            //    lcIBK.cabecera_lote.cod_interno_canal = lc.cabecera_lote.cod_interno_canal;
            //    lcIBK.cabecera_lote.cuit_canal = lc.cabecera_lote.cuit_canal;
            //    lcIBK.cabecera_lote.cuit_vendedor = lc.cabecera_lote.cuit_vendedor;
            //    lcIBK.cabecera_lote.fecha_envio_lote = lc.cabecera_lote.fecha_envio_lote;
            //    lcIBK.cabecera_lote.id_lote = lc.cabecera_lote.id_lote;
            //    lcIBK.cabecera_lote.motivo = lc.cabecera_lote.motivo;
            //    lcIBK.cabecera_lote.presta_serv = lc.cabecera_lote.presta_serv;
            //    lcIBK.cabecera_lote.presta_servSpecified = lc.cabecera_lote.presta_servSpecified;
            //    lcIBK.cabecera_lote.punto_de_venta = lc.cabecera_lote.punto_de_venta;
            //    lcIBK.cabecera_lote.resultado = lc.cabecera_lote.resultado;

            //    lcIBK.comprobante = new FEArn.IBK.comprobante[lc.comprobante.Length];
				
            //    for (int i = 0; i < lc.comprobante.Length; i++)
            //    {
            //        FEArn.IBK.comprobante cIBK = new FEArn.IBK.comprobante();

            //        cIBK.cabecera = new FEArn.IBK.cabecera();
					
            //        cIBK.cabecera.informacion_comprador = new FEArn.IBK.informacion_comprador();
            //        cIBK.cabecera.informacion_comprador.codigo_doc_identificatorio = lc.comprobante[i].cabecera.informacion_comprador.codigo_doc_identificatorio;
            //        cIBK.cabecera.informacion_comprador.codigo_interno = lc.comprobante[i].cabecera.informacion_comprador.codigo_interno;
            //        cIBK.cabecera.informacion_comprador.condicion_ingresos_brutos = lc.comprobante[i].cabecera.informacion_comprador.condicion_ingresos_brutos;
            //        cIBK.cabecera.informacion_comprador.condicion_ingresos_brutosSpecified = lc.comprobante[i].cabecera.informacion_comprador.condicion_ingresos_brutosSpecified;
            //        cIBK.cabecera.informacion_comprador.condicion_IVA = lc.comprobante[i].cabecera.informacion_comprador.condicion_IVA;
            //        cIBK.cabecera.informacion_comprador.condicion_IVASpecified = lc.comprobante[i].cabecera.informacion_comprador.condicion_IVASpecified;
            //        cIBK.cabecera.informacion_comprador.contacto = lc.comprobante[i].cabecera.informacion_comprador.contacto;
            //        cIBK.cabecera.informacion_comprador.cp = lc.comprobante[i].cabecera.informacion_comprador.cp;
            //        cIBK.cabecera.informacion_comprador.denominacion = lc.comprobante[i].cabecera.informacion_comprador.denominacion;
            //        cIBK.cabecera.informacion_comprador.domicilio_calle = lc.comprobante[i].cabecera.informacion_comprador.domicilio_calle;
            //        cIBK.cabecera.informacion_comprador.domicilio_depto = lc.comprobante[i].cabecera.informacion_comprador.domicilio_depto;
            //        cIBK.cabecera.informacion_comprador.domicilio_manzana = lc.comprobante[i].cabecera.informacion_comprador.domicilio_manzana;
            //        cIBK.cabecera.informacion_comprador.domicilio_numero = lc.comprobante[i].cabecera.informacion_comprador.domicilio_numero;
            //        cIBK.cabecera.informacion_comprador.domicilio_piso = lc.comprobante[i].cabecera.informacion_comprador.domicilio_piso;
            //        cIBK.cabecera.informacion_comprador.domicilio_sector = lc.comprobante[i].cabecera.informacion_comprador.domicilio_sector;
            //        cIBK.cabecera.informacion_comprador.domicilio_torre = lc.comprobante[i].cabecera.informacion_comprador.domicilio_torre;
            //        cIBK.cabecera.informacion_comprador.email = lc.comprobante[i].cabecera.informacion_comprador.email;
            //        cIBK.cabecera.informacion_comprador.GLN = lc.comprobante[i].cabecera.informacion_comprador.GLN;
            //        cIBK.cabecera.informacion_comprador.GLNSpecified = lc.comprobante[i].cabecera.informacion_comprador.GLNSpecified;
            //        cIBK.cabecera.informacion_comprador.inicio_de_actividades = lc.comprobante[i].cabecera.informacion_comprador.inicio_de_actividades;
            //        cIBK.cabecera.informacion_comprador.localidad = lc.comprobante[i].cabecera.informacion_comprador.localidad;
            //        cIBK.cabecera.informacion_comprador.nro_doc_identificatorio = lc.comprobante[i].cabecera.informacion_comprador.nro_doc_identificatorio;
            //        cIBK.cabecera.informacion_comprador.nro_ingresos_brutos = lc.comprobante[i].cabecera.informacion_comprador.nro_ingresos_brutos;
            //        cIBK.cabecera.informacion_comprador.provincia = lc.comprobante[i].cabecera.informacion_comprador.provincia;
            //        cIBK.cabecera.informacion_comprador.telefono = lc.comprobante[i].cabecera.informacion_comprador.telefono;

            //        cIBK.cabecera.informacion_comprobante = new FEArn.IBK.informacion_comprobante();
            //        cIBK.cabecera.informacion_comprobante.cae = lc.comprobante[i].cabecera.informacion_comprobante.cae;
            //        cIBK.cabecera.informacion_comprobante.codigo_operacion = lc.comprobante[i].cabecera.informacion_comprobante.codigo_operacion;
            //        cIBK.cabecera.informacion_comprobante.condicion_de_pago = lc.comprobante[i].cabecera.informacion_comprobante.condicion_de_pago;
            //        cIBK.cabecera.informacion_comprobante.condicion_de_pagoSpecified = lc.comprobante[i].cabecera.informacion_comprobante.condicion_de_pagoSpecified;
            //        cIBK.cabecera.informacion_comprobante.es_detalle_encriptado = lc.comprobante[i].cabecera.informacion_comprobante.es_detalle_encriptado;
            //        cIBK.cabecera.informacion_comprobante.fecha_emision = lc.comprobante[i].cabecera.informacion_comprobante.fecha_emision;
            //        cIBK.cabecera.informacion_comprobante.fecha_obtencion_cae = lc.comprobante[i].cabecera.informacion_comprobante.fecha_obtencion_cae;
            //        cIBK.cabecera.informacion_comprobante.fecha_serv_desde = lc.comprobante[i].cabecera.informacion_comprobante.fecha_serv_desde;
            //        cIBK.cabecera.informacion_comprobante.fecha_serv_hasta = lc.comprobante[i].cabecera.informacion_comprobante.fecha_serv_hasta;
            //        cIBK.cabecera.informacion_comprobante.fecha_vencimiento = lc.comprobante[i].cabecera.informacion_comprobante.fecha_vencimiento;
            //        cIBK.cabecera.informacion_comprobante.fecha_vencimiento_cae = lc.comprobante[i].cabecera.informacion_comprobante.fecha_vencimiento_cae;
            //        cIBK.cabecera.informacion_comprobante.iva_computable = lc.comprobante[i].cabecera.informacion_comprobante.iva_computable;
            //        cIBK.cabecera.informacion_comprobante.motivo = lc.comprobante[i].cabecera.informacion_comprobante.motivo;
            //        cIBK.cabecera.informacion_comprobante.numero_comprobante = lc.comprobante[i].cabecera.informacion_comprobante.numero_comprobante;
            //        cIBK.cabecera.informacion_comprobante.punto_de_venta = lc.comprobante[i].cabecera.informacion_comprobante.punto_de_venta;
					
            //        cIBK.cabecera.informacion_comprobante.referencias = new FEArn.IBK.informacion_comprobanteReferencias[0];

            //        cIBK.cabecera.informacion_comprobante.resultado = lc.comprobante[i].cabecera.informacion_comprobante.resultado;
            //        cIBK.cabecera.informacion_comprobante.tipo_de_comprobante = lc.comprobante[i].cabecera.informacion_comprobante.tipo_de_comprobante;

            //        cIBK.cabecera.informacion_vendedor = new FEArn.IBK.informacion_vendedor();
            //        cIBK.cabecera.informacion_vendedor.codigo_interno = lc.comprobante[i].cabecera.informacion_vendedor.codigo_interno;
            //        cIBK.cabecera.informacion_vendedor.condicion_ingresos_brutos = lc.comprobante[i].cabecera.informacion_vendedor.condicion_ingresos_brutos;
            //        cIBK.cabecera.informacion_vendedor.condicion_ingresos_brutosSpecified = lc.comprobante[i].cabecera.informacion_vendedor.condicion_ingresos_brutosSpecified;
            //        cIBK.cabecera.informacion_vendedor.condicion_IVA = lc.comprobante[i].cabecera.informacion_vendedor.condicion_IVA;
            //        cIBK.cabecera.informacion_vendedor.condicion_IVASpecified = lc.comprobante[i].cabecera.informacion_vendedor.condicion_IVASpecified;
            //        cIBK.cabecera.informacion_vendedor.contacto = lc.comprobante[i].cabecera.informacion_vendedor.contacto;
            //        cIBK.cabecera.informacion_vendedor.cp = lc.comprobante[i].cabecera.informacion_vendedor.cp;
            //        cIBK.cabecera.informacion_vendedor.cuit = lc.comprobante[i].cabecera.informacion_vendedor.cuit;
            //        cIBK.cabecera.informacion_vendedor.domicilio_calle = lc.comprobante[i].cabecera.informacion_vendedor.domicilio_calle;
            //        cIBK.cabecera.informacion_vendedor.domicilio_depto = lc.comprobante[i].cabecera.informacion_vendedor.domicilio_depto;
            //        cIBK.cabecera.informacion_vendedor.domicilio_manzana = lc.comprobante[i].cabecera.informacion_vendedor.domicilio_manzana;
            //        cIBK.cabecera.informacion_vendedor.domicilio_numero = lc.comprobante[i].cabecera.informacion_vendedor.domicilio_numero;
            //        cIBK.cabecera.informacion_vendedor.domicilio_piso = lc.comprobante[i].cabecera.informacion_vendedor.domicilio_piso;
            //        cIBK.cabecera.informacion_vendedor.domicilio_sector = lc.comprobante[i].cabecera.informacion_vendedor.domicilio_sector;
            //        cIBK.cabecera.informacion_vendedor.domicilio_torre = lc.comprobante[i].cabecera.informacion_vendedor.domicilio_torre;
            //        cIBK.cabecera.informacion_vendedor.email = lc.comprobante[i].cabecera.informacion_vendedor.email;
            //        cIBK.cabecera.informacion_vendedor.GLN = lc.comprobante[i].cabecera.informacion_vendedor.GLN;
            //        cIBK.cabecera.informacion_vendedor.GLNSpecified = lc.comprobante[i].cabecera.informacion_vendedor.GLNSpecified;
            //        cIBK.cabecera.informacion_vendedor.inicio_de_actividades = lc.comprobante[i].cabecera.informacion_vendedor.inicio_de_actividades;
            //        cIBK.cabecera.informacion_vendedor.localidad = lc.comprobante[i].cabecera.informacion_vendedor.localidad;
            //        cIBK.cabecera.informacion_vendedor.nro_ingresos_brutos = lc.comprobante[i].cabecera.informacion_vendedor.nro_ingresos_brutos;
            //        cIBK.cabecera.informacion_vendedor.provincia = lc.comprobante[i].cabecera.informacion_vendedor.provincia;
            //        cIBK.cabecera.informacion_vendedor.telefono = lc.comprobante[i].cabecera.informacion_vendedor.telefono;


            //        cIBK.extensiones = new FEArn.IBK.extensiones();


            //        FEArn.IBK.detalle d = new FEArn.IBK.detalle();
            //        d.linea = new FEArn.IBK.linea[lc.comprobante[i].detalle.linea.Length];

            //        for (int j = 0; j < lc.comprobante[i].detalle.linea.Length; j++)
            //        {
            //            if (lc.comprobante[i].detalle.linea[j] != null)
            //            {
            //                d.linea[j] = new FEArn.IBK.linea();
            //                d.linea[j].alicuota_iva = lc.comprobante[i].detalle.linea[j].alicuota_iva;
            //                d.linea[j].alicuota_ivaSpecified = lc.comprobante[i].detalle.linea[j].alicuota_ivaSpecified;
            //                d.linea[j].cantidad = lc.comprobante[i].detalle.linea[j].cantidad;
            //                d.linea[j].cantidadSpecified = lc.comprobante[i].detalle.linea[j].cantidadSpecified;
            //                d.linea[j].codigo_producto_comprador = lc.comprobante[i].detalle.linea[j].codigo_producto_comprador;
            //                d.linea[j].codigo_producto_vendedor = lc.comprobante[i].detalle.linea[j].codigo_producto_vendedor;
            //                d.linea[j].descripcion = lc.comprobante[i].detalle.linea[j].descripcion;
							
            //                d.linea[j].GTIN = lc.comprobante[i].detalle.linea[j].GTIN;
            //                d.linea[j].GTINSpecified = lc.comprobante[i].detalle.linea[j].GTINSpecified;
            //                d.linea[j].importe_iva = lc.comprobante[i].detalle.linea[j].importe_iva;
            //                d.linea[j].importe_ivaSpecified = lc.comprobante[i].detalle.linea[j].importe_ivaSpecified;
            //                d.linea[j].importe_total_articulo = lc.comprobante[i].detalle.linea[j].importe_total_articulo;
            //                d.linea[j].importe_total_descuentos = lc.comprobante[i].detalle.linea[j].importe_total_descuentos;
            //                d.linea[j].importe_total_descuentosSpecified = lc.comprobante[i].detalle.linea[j].importe_total_descuentosSpecified;
            //                d.linea[j].importe_total_impuestos = lc.comprobante[i].detalle.linea[j].importe_total_impuestos;
            //                d.linea[j].importe_total_impuestosSpecified = lc.comprobante[i].detalle.linea[j].importe_total_impuestosSpecified;
							
            //                //TODO VER MONEDA ORIGEN

            //                if (lc.comprobante[i].detalle.linea[j].importes_moneda_origen!=null)
            //                {
            //                    d.linea[j].importes_moneda_origen = new FEArn.IBK.lineaImportes_moneda_origen();
            //                    d.linea[j].importes_moneda_origen.importe_iva=lc.comprobante[i].detalle.linea[j].importes_moneda_origen.importe_iva;
            //                    d.linea[j].importes_moneda_origen.importe_ivaSpecified=lc.comprobante[i].detalle.linea[j].importes_moneda_origen.importe_ivaSpecified;
            //                    d.linea[j].importes_moneda_origen.importe_total_articulo=lc.comprobante[i].detalle.linea[j].importes_moneda_origen.importe_total_articulo;
            //                    d.linea[j].importes_moneda_origen.importe_total_articuloSpecified=lc.comprobante[i].detalle.linea[j].importes_moneda_origen.importe_total_articuloSpecified;
            //                    d.linea[j].importes_moneda_origen.importe_total_descuentos=lc.comprobante[i].detalle.linea[j].importes_moneda_origen.importe_total_descuentos;
            //                    d.linea[j].importes_moneda_origen.importe_total_descuentosSpecified=lc.comprobante[i].detalle.linea[j].importes_moneda_origen.importe_total_descuentosSpecified;
            //                    d.linea[j].importes_moneda_origen.importe_total_impuestos=lc.comprobante[i].detalle.linea[j].importes_moneda_origen.importe_total_impuestos;
            //                    d.linea[j].importes_moneda_origen.importe_total_impuestosSpecified=lc.comprobante[i].detalle.linea[j].importes_moneda_origen.importe_total_impuestosSpecified;
            //                    d.linea[j].importes_moneda_origen.precio_unitario=lc.comprobante[i].detalle.linea[j].importes_moneda_origen.precio_unitario;
            //                    d.linea[j].importes_moneda_origen.precio_unitarioSpecified=lc.comprobante[i].detalle.linea[j].importes_moneda_origen.precio_unitarioSpecified;
            //                }

            //                if (lc.comprobante[i].detalle.linea[j].impuestos != null)
            //                {
            //                    d.linea[j].impuestos = new FEArn.IBK.lineaImpuestos[lc.comprobante[i].detalle.linea[j].impuestos.Length];
            //                    for (int k = 0; k < d.linea[j].impuestos.Length; k++)
            //                    {
            //                        d.linea[j].impuestos[k] = new FEArn.IBK.lineaImpuestos();
            //                        d.linea[j].impuestos[k].codigo_impuesto = lc.comprobante[i].detalle.linea[j].impuestos[k].codigo_impuesto;
            //                        d.linea[j].impuestos[k].descripcion_impuesto = lc.comprobante[i].detalle.linea[j].impuestos[k].descripcion_impuesto;
            //                        d.linea[j].impuestos[k].importe_impuesto = lc.comprobante[i].detalle.linea[j].impuestos[k].importe_impuesto;
            //                        d.linea[j].impuestos[k].importe_impuesto_moneda_origen = lc.comprobante[i].detalle.linea[j].impuestos[k].importe_impuesto_moneda_origen;
            //                        d.linea[j].impuestos[k].importe_impuesto_moneda_origenSpecified = lc.comprobante[i].detalle.linea[j].impuestos[k].importe_impuesto_moneda_origenSpecified;
            //                        d.linea[j].impuestos[k].porcentaje_impuesto = lc.comprobante[i].detalle.linea[j].impuestos[k].porcentaje_impuesto;
            //                        d.linea[j].impuestos[k].porcentaje_impuestoSpecified = lc.comprobante[i].detalle.linea[j].impuestos[k].porcentaje_impuestoSpecified;
            //                    }
            //                }
            //                //TODO VER DESCUENTOS
            //                if (lc.comprobante[i].detalle.linea[j].descuentos != null)
            //                {
            //                    d.linea[j].descuentos = new FEArn.IBK.lineaDescuentos[lc.comprobante[i].detalle.linea[j].descuentos.Length];
            //                    for (int k = 0; k < d.linea[j].descuentos.Length; k++)
            //                    {
            //                        d.linea[j].descuentos[k] = new FEArn.IBK.lineaDescuentos();
            //                        d.linea[j].descuentos[k].descripcion_descuento = lc.comprobante[i].detalle.linea[j].descuentos[k].descripcion_descuento;
            //                        d.linea[j].descuentos[k].importe_descuento = lc.comprobante[i].detalle.linea[j].descuentos[k].importe_descuento;
            //                        d.linea[j].descuentos[k].importe_descuento_moneda_origen = lc.comprobante[i].detalle.linea[j].descuentos[k].importe_descuento_moneda_origen;
            //                        d.linea[j].descuentos[k].importe_descuento_moneda_origenSpecified = lc.comprobante[i].detalle.linea[j].descuentos[k].importe_descuento_moneda_origenSpecified;
            //                        d.linea[j].descuentos[k].porcentaje_descuento = lc.comprobante[i].detalle.linea[j].descuentos[k].porcentaje_descuento;
            //                        d.linea[j].descuentos[k].porcentaje_descuentoSpecified = lc.comprobante[i].detalle.linea[j].descuentos[k].porcentaje_descuentoSpecified;
            //                    }
            //                }

            //                d.linea[j].indicacion_exento_gravado = lc.comprobante[i].detalle.linea[j].indicacion_exento_gravado;
            //                d.linea[j].numeroLinea = lc.comprobante[i].detalle.linea[j].numeroLinea;
            //                d.linea[j].precio_unitario = lc.comprobante[i].detalle.linea[j].precio_unitario;
            //                d.linea[j].precio_unitarioSpecified = lc.comprobante[i].detalle.linea[j].precio_unitarioSpecified;
            //                d.linea[j].unidad = lc.comprobante[i].detalle.linea[j].unidad;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
					
            //        cIBK.Item = d;

					
            //        cIBK.resumen = new FEArn.IBK.resumen();
            //        cIBK.resumen.cant_alicuotas_iva = lc.comprobante[i].resumen.cant_alicuotas_iva;
            //        cIBK.resumen.cant_alicuotas_ivaSpecified = lc.comprobante[i].resumen.cant_alicuotas_ivaSpecified;
            //        cIBK.resumen.codigo_moneda = lc.comprobante[i].resumen.codigo_moneda;

            //        cIBK.resumen.descuentos = new FEArn.IBK.resumenDescuentos[0];

            //        cIBK.resumen.cant_alicuotas_iva = lc.comprobante[i].resumen.cant_alicuotas_iva;
            //        cIBK.resumen.cant_alicuotas_ivaSpecified = lc.comprobante[i].resumen.cant_alicuotas_ivaSpecified;
            //        cIBK.resumen.codigo_moneda = lc.comprobante[i].resumen.codigo_moneda;

            //        cIBK.resumen.importe_operaciones_exentas = lc.comprobante[i].resumen.importe_operaciones_exentas;
            //        cIBK.resumen.importe_total_concepto_no_gravado = lc.comprobante[i].resumen.importe_total_concepto_no_gravado;
            //        cIBK.resumen.importe_total_factura = lc.comprobante[i].resumen.importe_total_factura;
            //        cIBK.resumen.importe_total_impuestos_internos = lc.comprobante[i].resumen.importe_total_impuestos_internos;
            //        cIBK.resumen.importe_total_impuestos_internosSpecified = lc.comprobante[i].resumen.importe_total_impuestos_internosSpecified;
            //        cIBK.resumen.importe_total_impuestos_municipales = lc.comprobante[i].resumen.importe_total_impuestos_municipales;
            //        cIBK.resumen.importe_total_impuestos_municipalesSpecified = lc.comprobante[i].resumen.importe_total_impuestos_municipalesSpecified;
            //        cIBK.resumen.importe_total_impuestos_nacionales = lc.comprobante[i].resumen.importe_total_impuestos_nacionales;
            //        cIBK.resumen.importe_total_impuestos_nacionalesSpecified = lc.comprobante[i].resumen.importe_total_impuestos_nacionalesSpecified;
            //        cIBK.resumen.importe_total_ingresos_brutos = lc.comprobante[i].resumen.importe_total_ingresos_brutos;
            //        cIBK.resumen.importe_total_ingresos_brutosSpecified = lc.comprobante[i].resumen.importe_total_ingresos_brutosSpecified;
            //        cIBK.resumen.importe_total_neto_gravado = lc.comprobante[i].resumen.importe_total_neto_gravado;

            //        if (lc.comprobante[i].resumen.importes_moneda_origen!=null)
            //        {
            //            cIBK.resumen.importes_moneda_origen = new FEArn.IBK.resumenImportes_moneda_origen();
            //            cIBK.resumen.importes_moneda_origen.importe_operaciones_exentas = lc.comprobante[i].resumen.importes_moneda_origen.importe_operaciones_exentas;
            //            cIBK.resumen.importes_moneda_origen.importe_total_concepto_no_gravado = lc.comprobante[i].resumen.importes_moneda_origen.importe_total_concepto_no_gravado;
            //            cIBK.resumen.importes_moneda_origen.importe_total_factura = lc.comprobante[i].resumen.importes_moneda_origen.importe_total_factura;
            //            cIBK.resumen.importes_moneda_origen.importe_total_impuestos_internos = lc.comprobante[i].resumen.importes_moneda_origen.importe_total_impuestos_internos;
            //            cIBK.resumen.importes_moneda_origen.importe_total_impuestos_internosSpecified = lc.comprobante[i].resumen.importes_moneda_origen.importe_total_impuestos_internosSpecified;
            //            cIBK.resumen.importes_moneda_origen.importe_total_impuestos_municipales = lc.comprobante[i].resumen.importes_moneda_origen.importe_total_impuestos_municipales;
            //            cIBK.resumen.importes_moneda_origen.importe_total_impuestos_municipalesSpecified = lc.comprobante[i].resumen.importes_moneda_origen.importe_total_impuestos_municipalesSpecified;
            //            cIBK.resumen.importes_moneda_origen.importe_total_impuestos_nacionales = lc.comprobante[i].resumen.importes_moneda_origen.importe_total_impuestos_nacionales;
            //            cIBK.resumen.importes_moneda_origen.importe_total_impuestos_nacionalesSpecified = lc.comprobante[i].resumen.importes_moneda_origen.importe_total_impuestos_nacionalesSpecified;
            //            cIBK.resumen.importes_moneda_origen.importe_total_ingresos_brutos = lc.comprobante[i].resumen.importes_moneda_origen.importe_total_ingresos_brutos;
            //            cIBK.resumen.importes_moneda_origen.importe_total_ingresos_brutosSpecified = lc.comprobante[i].resumen.importes_moneda_origen.importe_total_ingresos_brutosSpecified;
            //            cIBK.resumen.importes_moneda_origen.importe_total_neto_gravado = lc.comprobante[i].resumen.importes_moneda_origen.importe_total_neto_gravado;
            //            cIBK.resumen.importes_moneda_origen.impuesto_liq = lc.comprobante[i].resumen.importes_moneda_origen.impuesto_liq;
            //            cIBK.resumen.importes_moneda_origen.impuesto_liq_rni = lc.comprobante[i].resumen.importes_moneda_origen.impuesto_liq_rni;
            //        }
					
            //        cIBK.resumen.impuesto_liq = lc.comprobante[i].resumen.impuesto_liq;
            //        cIBK.resumen.impuesto_liq_rni = lc.comprobante[i].resumen.impuesto_liq_rni;

            //        if (lc.comprobante[i].resumen.descuentos!=null)
            //        {
            //            cIBK.resumen.descuentos = new FEArn.IBK.resumenDescuentos[lc.comprobante[i].resumen.descuentos.Length];
            //            for (int l = 0; l < lc.comprobante[i].resumen.descuentos.Length; l++)
            //            {
            //                cIBK.resumen.descuentos[l] = new FEArn.IBK.resumenDescuentos();
            //                cIBK.resumen.descuentos[l].alicuota_iva_descuento = lc.comprobante[i].resumen.descuentos[l].alicuota_iva_descuento;
            //                cIBK.resumen.descuentos[l].alicuota_iva_descuentoSpecified = lc.comprobante[i].resumen.descuentos[l].alicuota_iva_descuentoSpecified;
            //                cIBK.resumen.descuentos[l].descripcion_descuento = lc.comprobante[i].resumen.descuentos[l].descripcion_descuento;
            //                cIBK.resumen.descuentos[l].importe_descuento = lc.comprobante[i].resumen.descuentos[l].importe_descuento;
            //                cIBK.resumen.descuentos[l].importe_descuento_moneda_origen = lc.comprobante[i].resumen.descuentos[l].importe_descuento_moneda_origen;
            //                cIBK.resumen.descuentos[l].importe_descuento_moneda_origenSpecified = lc.comprobante[i].resumen.descuentos[l].importe_descuento_moneda_origenSpecified;
            //                cIBK.resumen.descuentos[l].importe_iva_descuento = lc.comprobante[i].resumen.descuentos[l].importe_iva_descuento;
            //                cIBK.resumen.descuentos[l].importe_iva_descuento_moneda_origen = lc.comprobante[i].resumen.descuentos[l].importe_iva_descuento_moneda_origen;
            //                cIBK.resumen.descuentos[l].importe_iva_descuento_moneda_origenSpecified = lc.comprobante[i].resumen.descuentos[l].importe_iva_descuento_moneda_origenSpecified;
            //                cIBK.resumen.descuentos[l].importe_iva_descuentoSpecified = lc.comprobante[i].resumen.descuentos[l].importe_iva_descuentoSpecified;
            //                cIBK.resumen.descuentos[l].porcentaje_descuento = lc.comprobante[i].resumen.descuentos[l].porcentaje_descuento;
            //                cIBK.resumen.descuentos[l].porcentaje_descuentoSpecified = lc.comprobante[i].resumen.descuentos[l].porcentaje_descuentoSpecified;
            //            } 
            //        }

            //        if (lc.comprobante[i].resumen.impuestos!=null)
            //        {
            //            cIBK.resumen.impuestos = new FEArn.IBK.resumenImpuestos[lc.comprobante[i].resumen.impuestos.Length];
            //            for (int l = 0; l < lc.comprobante[i].resumen.impuestos.Length; l++)
            //            {
            //                cIBK.resumen.impuestos[l] = new FEArn.IBK.resumenImpuestos();
            //                cIBK.resumen.impuestos[l].codigo_impuesto = lc.comprobante[i].resumen.impuestos[l].codigo_impuesto;
            //                cIBK.resumen.impuestos[l].codigo_jurisdiccion = lc.comprobante[i].resumen.impuestos[l].codigo_jurisdiccion;
            //                cIBK.resumen.impuestos[l].codigo_jurisdiccionSpecified = lc.comprobante[i].resumen.impuestos[l].codigo_jurisdiccionSpecified;
            //                cIBK.resumen.impuestos[l].descripcion = lc.comprobante[i].resumen.impuestos[l].descripcion;
            //                cIBK.resumen.impuestos[l].importe_impuesto = lc.comprobante[i].resumen.impuestos[l].importe_impuesto;
            //                cIBK.resumen.impuestos[l].importe_impuesto_moneda_origen = lc.comprobante[i].resumen.impuestos[l].importe_impuesto_moneda_origen;
            //                cIBK.resumen.impuestos[l].importe_impuesto_moneda_origenSpecified = lc.comprobante[i].resumen.impuestos[l].importe_impuesto_moneda_origenSpecified;
            //                cIBK.resumen.impuestos[l].jurisdiccion_municipal = lc.comprobante[i].resumen.impuestos[l].jurisdiccion_municipal;
            //                cIBK.resumen.impuestos[l].porcentaje_impuesto = lc.comprobante[i].resumen.impuestos[l].porcentaje_impuesto;
            //                cIBK.resumen.impuestos[l].porcentaje_impuestoSpecified = lc.comprobante[i].resumen.impuestos[l].porcentaje_impuestoSpecified;
            //            } 
            //        }

            //        cIBK.resumen.observaciones = lc.comprobante[i].resumen.observaciones;
            //        cIBK.resumen.tipo_de_cambio = lc.comprobante[i].resumen.tipo_de_cambio;

            //        lcIBK.comprobante[i] = cIBK;
            //    }

            //    FEArn.IBK.FacturaWebServiceConSchemaSoapBindingQSService objIBK;

            //    objIBK = new FEArn.IBK.FacturaWebServiceConSchemaSoapBindingQSService();
            //    System.Security.Cryptography.X509Certificates.X509Certificate cert = System.Security.Cryptography.X509Certificates.X509Certificate.CreateFromCertFile(@"C:\Documents and Settings\lucasele\Mis documentos\Visual Studio 2005\Projects\FEA\fea\Certificados\interfacturas-30710015062.cer");
            //    objIBK.ClientCertificates.Add(cert);
            //    objIBK.Proxy = Wp;

            //    FEArn.IBK.lote_comprobantes_response lcr = objIBK.receiveFacturasConSchema(lcIBK);

            //}
            //catch (Exception ex)
            //{
            //    Cedeira.Ex.ExceptionManager.Publish(ex);
            //}
		}
	}
}
