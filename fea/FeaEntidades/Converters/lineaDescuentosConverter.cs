using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Converters
{
	public class lineaDescuentosConverter : FileHelpers.ConverterBase
	{
		public override object StringToField(string from)
		{
			return Convert.ToDecimal(Decimal.Parse(from));
		}
	}
}
