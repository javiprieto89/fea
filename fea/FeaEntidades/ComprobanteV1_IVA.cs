using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades
{
	[FileHelpers.DelimitedRecord("|")]
	public class ComprobanteV1_IVA
	{
		short id = 0;
		double baseImp = 0;
		double importe = 0;
		
		public ComprobanteV1_IVA()
		{
		}

		public short Id
		{
            get { return id; }
            set { id = value; }
		}

        public double Baseimp
		{
            get { return baseImp; }
            set { baseImp = value; }
		}

        public double Importe
		{
            get { return importe; }
            set { importe = value; }
		}
	}
}
