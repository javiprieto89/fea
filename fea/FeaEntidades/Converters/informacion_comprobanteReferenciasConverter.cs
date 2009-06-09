using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.Converters
{
	public class informacion_comprobanteReferenciasConverter : FileHelpers.ConverterBase
	{
		public override object StringToField(string from)
		{
			return null;
		}
		public override string FieldToString(object from)
		{
			return base.FieldToString(from);
		}
		protected override bool CustomNullHandling
		{
			get
			{
				return base.CustomNullHandling;
			}
		}
	}
}
