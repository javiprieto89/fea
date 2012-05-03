using System;
using System.Collections.Generic;
using System.Text;
using Cedeira.SV;
using System.Data;	

namespace FEAdb
{
	public class dbComprobante : db
	{
		public dbComprobante(Idb_Sesion Sesion)
			: base(Sesion)
		{
		}
		public DataTable Comprobante_qry()
		{
			StringBuilder a = new StringBuilder(String.Empty);
            a.Append("SELECT * FROM comprobantes order by FechaImpacto desc;");
			return (DataTable)Ejecutar(a.ToString(), TipoRetorno.TB, Transaccion.NoAcepta, m_Sesion.CnnStr);
		}
		public void Comprobante_ins(DateTime FechaImpacto, long IdTransaccion, long IdComprobante, short PuntoVenta,
			short Codigo, string DescrCodigo, long NroDoc, short TipoDoc, string DescrTipoDoc, DateTime Fecha, 
			DateTime FechaServicioDesde, DateTime FechaServicioHasta, DateTime FechaVencPago, double Neto, 
			double Exento, double TotalConceptos, double ImpuestoLiq, double ImpuestoLiqRNI, double Total, 
			string CAE, string Motivo, string Resultado, bool PrestaServicio, string MensajeError, long Cuit_emisor)
		{
			StringBuilder a = new StringBuilder(String.Empty);
			a.Append("insert Comprobantes values (");
			a.Append("'"+FechaImpacto.ToString("yyyyMMdd HH:mm:ss", cedeiraCultura.DateTimeFormat) + "', ");
			a.Append(IdTransaccion + ", ");
			a.Append(IdComprobante + ", ");
			a.Append(PuntoVenta + ", ");
			a.Append(Codigo + ", ");
			a.Append("'"+DescrCodigo+"', ");
			a.Append(NroDoc + ", ");
			a.Append(TipoDoc + ", ");
			a.Append("'"+DescrTipoDoc+"', ");
			a.Append("'"+Fecha.ToString("yyyyMMdd")+"', ");
			a.Append("'"+FechaServicioDesde.ToString("yyyyMMdd")+"', ");
			a.Append("'"+FechaServicioHasta.ToString("yyyyMMdd")+"', ");
			a.Append("'"+FechaVencPago.ToString("yyyyMMdd")+"', ");
			a.Append(Neto + ", ");
			a.Append(Exento + ", ");
			a.Append(TotalConceptos + ", ");
			a.Append(ImpuestoLiq + ", ");
			a.Append(ImpuestoLiqRNI + ", ");
			a.Append(Total + ", ");
			a.Append("'"+CAE+"', ");
			a.Append("'"+Motivo+"', ");
			a.Append("'"+Resultado+"', ");
            if (PrestaServicio == true)
            {
                a.Append("1, ");
            }
            else
            {
                a.Append("0, ");
            }
			a.Append("'"+MensajeError+"', ");
            a.Append(Cuit_emisor);
			a.Append(") ");

			Ejecutar(a.ToString(), TipoRetorno.None, Transaccion.NoAcepta, m_Sesion.CnnStr);
		}
	}
}
