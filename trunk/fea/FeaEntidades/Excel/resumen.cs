using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class resumen : Ubicador
	{
		public resumen()
		{
			X = 12;
			Y = 2;
		}
	}
}
