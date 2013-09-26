using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades
{
	[FileHelpers.DelimitedRecord("|")]
	public class ComprobanteV1_Tributos
	{
		short id = 0;               //int (2)
        string desc = "";           //string (80)
		double baseImp = 0;         //double (13 + 2)
        double alic = 0;            //double (3 + 2)
        double importe = 0;         //double (13 + 2)

        public ComprobanteV1_Tributos()
		{
		}

		public short Id
		{
            get { return id; }
            set { id = value; }
		}

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public double Baseimp
		{
            get { return baseImp; }
            set { baseImp = value; }
		}

        public double Alic
        {
            get { return alic; }
            set { alic = value; }
        }

        public double Importe
		{
            get { return importe; }
            set { importe = value; }
		}
	}
}
