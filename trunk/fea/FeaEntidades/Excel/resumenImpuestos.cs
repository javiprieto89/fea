using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class resumenImpuestos : Ubicador
	{
		public resumenImpuestos()
		{
			X = 15;
			Y = 2;
		}
	}
}
