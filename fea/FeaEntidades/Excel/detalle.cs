using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class detalle : Ubicador
	{
		public detalle()
		{
			X = 7;
			Y = 2;
		}
	}
}
