using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades
{
	[FileHelpers.DelimitedRecord("|")]
	public class ComprobanteV1_CbtesAsoc
	{
		int tipo = 0;           //int (3)
		int ptoVta = 0;         //int (4)
		long nro = 0;           //long (8)

        public ComprobanteV1_CbtesAsoc()
		{
		}

        public int Tipo
		{
            get { return tipo; }
            set { tipo = value; }
		}

        public int PtoVta
		{
            get { return ptoVta; }
            set { ptoVta = value; }
		}

        public long Nro
		{
            get { return nro; }
            set { nro = value; }
		}
	}
}
