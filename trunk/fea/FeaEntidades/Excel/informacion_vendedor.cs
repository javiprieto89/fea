using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class informacion_vendedor : Ubicador
	{
		public informacion_vendedor()
		{
			X = 6;
			Y = 2;
		}
	}
}
