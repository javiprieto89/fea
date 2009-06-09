using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Converters
{
	public class resumenImportes_moneda_origenConverter : FileHelpers.ConverterBase
	{
		public override object StringToField(string from)
		{
			return Convert.ToDecimal(Decimal.Parse(from));
		}
	}
}
