using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Excel
{
	[FileHelpers.DelimitedRecord("|")]
	public class resumenImportes_moneda_origen : Ubicador
	{
		public resumenImportes_moneda_origen()
		{
			X = 13;
			Y = 2;
		}
	}
}
