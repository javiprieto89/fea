using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class informacion_comprador : Ubicador
	{
		public informacion_comprador()
		{
			X = 3;
			Y = 2;
		}
	}
}
