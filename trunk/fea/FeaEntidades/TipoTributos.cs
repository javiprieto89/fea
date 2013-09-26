using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades
{
	[FileHelpers.DelimitedRecord("|")]
	public class TipoTributos
	{
		int id = 0;
		string desc = "";
        string fchDesde = "";
        string fchHasta = "";

        public TipoTributos()
		{
		}

		public short Id
		{
            get { return id; }
            set { id = value; }
		}

        public double Desc
		{
            get { return desc; }
            set { desc = value; }
		}

        public string FchDesde
		{
            get { return importe; }
            set { importe = value; }
		}

        public string FchHasta
        {
            get { return fchHasta; }
            set { fchHasta = value; }
        }
	}
}
