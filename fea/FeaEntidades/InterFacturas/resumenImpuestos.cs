using System;
using System.Collections.Generic;
using System.Text;

namespace FeaEntidades.InterFacturas
{
	/// <comentarios/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://lote.schemas.cfe.ib.com.ar/")]
	[FileHelpers.DelimitedRecord("|")]
	public partial class resumenImpuestos
	{

		private int codigo_impuestoField;

		private string descripcionField;

		private int codigo_jurisdiccionField;

		private bool codigo_jurisdiccionFieldSpecified;

		private string jurisdiccion_municipalField;

		private double porcentaje_impuestoField;

		private bool porcentaje_impuestoFieldSpecified;

		private double importe_impuestoField;

		private double importe_impuesto_moneda_origenField;

		private bool importe_impuesto_moneda_origenFieldSpecified;

		/// <comentarios/>
		public int codigo_impuesto
		{
			get
			{
				return this.codigo_impuestoField;
			}
			set
			{
				this.codigo_impuestoField = value;
			}
		}

		/// <comentarios/>
		public string descripcion
		{
			get
			{
				return this.descripcionField;
			}
			set
			{
				this.descripcionField = value;
			}
		}

		/// <comentarios/>
		public int codigo_jurisdiccion
		{
			get
			{
				return this.codigo_jurisdiccionField;
			}
			set
			{
				this.codigo_jurisdiccionField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool codigo_jurisdiccionSpecified
		{
			get
			{
				return this.codigo_jurisdiccionFieldSpecified;
			}
			set
			{
				this.codigo_jurisdiccionFieldSpecified = value;
			}
		}

		/// <comentarios/>
		public string jurisdiccion_municipal
		{
			get
			{
				return this.jurisdiccion_municipalField;
			}
			set
			{
				this.jurisdiccion_municipalField = value;
			}
		}

		/// <comentarios/>
		public double porcentaje_impuesto
		{
			get
			{
				return this.porcentaje_impuestoField;
			}
			set
			{
				this.porcentaje_impuestoField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool porcentaje_impuestoSpecified
		{
			get
			{
				return this.porcentaje_impuestoFieldSpecified;
			}
			set
			{
				this.porcentaje_impuestoFieldSpecified = value;
			}
		}

		/// <comentarios/>
		public double importe_impuesto
		{
			get
			{
				return this.importe_impuestoField;
			}
			set
			{
				this.importe_impuestoField = value;
			}
		}

		/// <comentarios/>
		public double importe_impuesto_moneda_origen
		{
			get
			{
				return this.importe_impuesto_moneda_origenField;
			}
			set
			{
				this.importe_impuesto_moneda_origenField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool importe_impuesto_moneda_origenSpecified
		{
			get
			{
				return this.importe_impuesto_moneda_origenFieldSpecified;
			}
			set
			{
				this.importe_impuesto_moneda_origenFieldSpecified = value;
			}
		}
	}
}
