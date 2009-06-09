using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class impuestos : Ubicador
	{
		public impuestos()
		{
			X = 10;
			Y = 2;
		}
	}
}
