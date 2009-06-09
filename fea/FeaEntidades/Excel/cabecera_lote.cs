using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class cabecera_lote : Ubicador
	{
		public cabecera_lote()
		{
			X = 2;
			Y = 2;
			//Tipo = new FeaEntidades.InterFacturas.cabecera_lote().GetType();
		}
	}
}
