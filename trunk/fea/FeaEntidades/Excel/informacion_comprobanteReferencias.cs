using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class informacion_comprobanteReferencias : Ubicador
	{
		public informacion_comprobanteReferencias()
		{
			X = 5;
			Y = 2;
		}
	}
}
