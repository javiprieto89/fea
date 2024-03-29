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
	public partial class lineaDescuentos
	{

		private string descripcion_descuentoField;

		private double porcentaje_descuentoField;

		private bool porcentaje_descuentoFieldSpecified;

		private double importe_descuentoField;

		private double importe_descuento_moneda_origenField;

		private bool importe_descuento_moneda_origenFieldSpecified;

		/// <comentarios/>
		public string descripcion_descuento
		{
			get
			{
				return this.descripcion_descuentoField;
			}
			set
			{
				this.descripcion_descuentoField = value;
			}
		}

		/// <comentarios/>
		public double porcentaje_descuento
		{
			get
			{
				return this.porcentaje_descuentoField;
			}
			set
			{
				this.porcentaje_descuentoField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool porcentaje_descuentoSpecified
		{
			get
			{
				return this.porcentaje_descuentoFieldSpecified;
			}
			set
			{
				this.porcentaje_descuentoFieldSpecified = value;
			}
		}

		/// <comentarios/>
		public double importe_descuento
		{
			get
			{
				return this.importe_descuentoField;
			}
			set
			{
				this.importe_descuentoField = value;
			}
		}

		/// <comentarios/>
		public double importe_descuento_moneda_origen
		{
			get
			{
				return this.importe_descuento_moneda_origenField;
			}
			set
			{
				this.importe_descuento_moneda_origenField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool importe_descuento_moneda_origenSpecified
		{
			get
			{
				return this.importe_descuento_moneda_origenFieldSpecified;
			}
			set
			{
				this.importe_descuento_moneda_origenFieldSpecified = value;
			}
		}
	}
}
