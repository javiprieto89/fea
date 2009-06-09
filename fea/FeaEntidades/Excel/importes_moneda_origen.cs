using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class importes_moneda_origen : Ubicador
	{
		public importes_moneda_origen()
		{
			X = 9;
			Y = 2;
		}
	}
}
