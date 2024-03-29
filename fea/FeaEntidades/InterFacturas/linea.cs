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
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://lote.schemas.cfe.ib.com.ar/", IsNullable = false)]
	[FileHelpers.DelimitedRecord("|")]
	public partial class linea
	{

		private long gTINField;

		private bool gTINFieldSpecified;

		private string codigo_producto_vendedorField;

		private string codigo_producto_compradorField;

		private string descripcionField;

		private double cantidadField;

		private bool cantidadFieldSpecified;

		private string unidadField;

		private double precio_unitarioField;

		private bool precio_unitarioFieldSpecified;

		private double importe_total_articuloField;

		private double alicuota_ivaField;

		private bool alicuota_ivaFieldSpecified;

		private double importe_ivaField;

		private bool importe_ivaFieldSpecified;

		private string indicacion_exento_gravadoField;

		private double importe_total_descuentosField;

		private bool importe_total_descuentosFieldSpecified;

		private double importe_total_impuestosField;

		private bool importe_total_impuestosFieldSpecified;

		private int numeroLineaField;

		[FileHelpers.FieldConverter(typeof(FeaEntidades.Converters.lineaImportes_moneda_origenConverter))]
		[FileHelpers.FieldIgnored()]
		private lineaImportes_moneda_origen importes_moneda_origenField;

		//[FileHelpers.FieldArrayLength(1,1)]
		[FileHelpers.FieldConverter(typeof(FeaEntidades.Converters.lineaDescuentosConverter))]
		[FileHelpers.FieldIgnored()]
		private lineaDescuentos[] descuentosField;

		//[FileHelpers.FieldArrayLength(1,1)]
		[FileHelpers.FieldConverter(typeof(FeaEntidades.Converters.lineaImpuestosConverter))]
		[FileHelpers.FieldIgnored()]
		private lineaImpuestos[] impuestosField;


		/// <comentarios/>
		public long GTIN
		{
			get
			{
				return this.gTINField;
			}
			set
			{
				this.gTINField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool GTINSpecified
		{
			get
			{
				return this.gTINFieldSpecified;
			}
			set
			{
				this.gTINFieldSpecified = value;
			}
		}

		/// <comentarios/>
		public string codigo_producto_vendedor
		{
			get
			{
				return this.codigo_producto_vendedorField;
			}
			set
			{
				this.codigo_producto_vendedorField = value;
			}
		}

		/// <comentarios/>
		public string codigo_producto_comprador
		{
			get
			{
				return this.codigo_producto_compradorField;
			}
			set
			{
				this.codigo_producto_compradorField = value;
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
		public double cantidad
		{
			get
			{
				return this.cantidadField;
			}
			set
			{
				this.cantidadField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool cantidadSpecified
		{
			get
			{
				return this.cantidadFieldSpecified;
			}
			set
			{
				this.cantidadFieldSpecified = value;
			}
		}

		/// <comentarios/>
		public string unidad
		{
			get
			{
				return this.unidadField;
			}
			set
			{
				this.unidadField = value;
			}
		}

		/// <comentarios/>
		public double precio_unitario
		{
			get
			{
				return this.precio_unitarioField;
			}
			set
			{
				this.precio_unitarioField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool precio_unitarioSpecified
		{
			get
			{
				return this.precio_unitarioFieldSpecified;
			}
			set
			{
				this.precio_unitarioFieldSpecified = value;
			}
		}

		/// <comentarios/>
		public double importe_total_articulo
		{
			get
			{
				return this.importe_total_articuloField;
			}
			set
			{
				this.importe_total_articuloField = value;
			}
		}

		/// <comentarios/>
		public double alicuota_iva
		{
			get
			{
				return this.alicuota_ivaField;
			}
			set
			{
				this.alicuota_ivaField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool alicuota_ivaSpecified
		{
			get
			{
				return this.alicuota_ivaFieldSpecified;
			}
			set
			{
				this.alicuota_ivaFieldSpecified = value;
			}
		}

		/// <comentarios/>
		public double importe_iva
		{
			get
			{
				return this.importe_ivaField;
			}
			set
			{
				this.importe_ivaField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool importe_ivaSpecified
		{
			get
			{
				return this.importe_ivaFieldSpecified;
			}
			set
			{
				this.importe_ivaFieldSpecified = value;
			}
		}

		/// <comentarios/>
		public string indicacion_exento_gravado
		{
			get
			{
				return this.indicacion_exento_gravadoField;
			}
			set
			{
				this.indicacion_exento_gravadoField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlElementAttribute("descuentos")]
		public lineaDescuentos[] descuentos
		{
			get
			{
				return this.descuentosField;
			}
			set
			{
				this.descuentosField = value;
			}
		}

		/// <comentarios/>
		public double importe_total_descuentos
		{
			get
			{
				return this.importe_total_descuentosField;
			}
			set
			{
				this.importe_total_descuentosField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool importe_total_descuentosSpecified
		{
			get
			{
				return this.importe_total_descuentosFieldSpecified;
			}
			set
			{
				this.importe_total_descuentosFieldSpecified = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlElementAttribute("impuestos")]
		public lineaImpuestos[] impuestos
		{
			get
			{
				return this.impuestosField;
			}
			set
			{
				this.impuestosField = value;
			}
		}

		/// <comentarios/>
		public double importe_total_impuestos
		{
			get
			{
				return this.importe_total_impuestosField;
			}
			set
			{
				this.importe_total_impuestosField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool importe_total_impuestosSpecified
		{
			get
			{
				return this.importe_total_impuestosFieldSpecified;
			}
			set
			{
				this.importe_total_impuestosFieldSpecified = value;
			}
		}

		/// <comentarios/>
		public lineaImportes_moneda_origen importes_moneda_origen
		{
			get
			{
				return this.importes_moneda_origenField;
			}
			set
			{
				this.importes_moneda_origenField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int numeroLinea
		{
			get
			{
				return this.numeroLineaField;
			}
			set
			{
				this.numeroLineaField = value;
			}
		}
	}
}
