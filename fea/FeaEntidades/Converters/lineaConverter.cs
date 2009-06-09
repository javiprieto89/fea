using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Converters
{
	public class lineaConverter : FileHelpers.ConverterBase
	{
		public override object StringToField(string from)
		{
			return Convert.ToDecimal(Decimal.Parse(from));
		}
	}
}
