using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class comprobante : Ubicador
	{
		public comprobante()
		{
			X = 2;
			Y = 2;
		}
	}
}
