using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class descuentos : Ubicador
	{
		public descuentos()
		{
			X = 11;
			Y = 2;
		}
	}
}
