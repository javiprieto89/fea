using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class informacion_comprobante : Ubicador
	{
		public informacion_comprobante()
		{
			X = 4;
			Y = 2;
		}
	}
}
