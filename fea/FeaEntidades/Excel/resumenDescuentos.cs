using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class resumenDescuentos : Ubicador
	{
		public resumenDescuentos()
		{
			X = 14;
			Y = 2;
		}
	}
}
