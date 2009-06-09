using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class linea : Ubicador
	{
		public linea()
		{
			X = 8;
			Y = 2;
		}
	}
}
