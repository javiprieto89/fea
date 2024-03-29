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
	public partial class informacion_comprobante
	{

		private int tipo_de_comprobanteField;

		private long numero_comprobanteField;

		private int punto_de_ventaField;

		private string fecha_emisionField;

		private string fecha_vencimientoField;

		private string fecha_serv_desdeField;

		private string fecha_serv_hastaField;

		private int condicion_de_pagoField;

		private bool condicion_de_pagoFieldSpecified;

		private string iva_computableField;

		private string codigo_operacionField;

		private string caeField;

		private string fecha_vencimiento_caeField;

		private string fecha_obtencion_caeField;

		private string resultadoField;

		private string motivoField;

		private string es_detalle_encriptadoField;

		[FileHelpers.FieldConverter(typeof(FeaEntidades.Converters.informacion_comprobanteReferenciasConverter))]
		//[FileHelpers.FieldNullValue(new informacion_comprobanteReferencias[0])]
		[FileHelpers.FieldIgnored()]
		private informacion_comprobanteReferencias[] referenciasField;

		/// <comentarios/>
		public int tipo_de_comprobante
		{
			get
			{
				return this.tipo_de_comprobanteField;
			}
			set
			{
				this.tipo_de_comprobanteField = value;
			}
		}

		/// <comentarios/>
		public long numero_comprobante
		{
			get
			{
				return this.numero_comprobanteField;
			}
			set
			{
				this.numero_comprobanteField = value;
			}
		}

		/// <comentarios/>
		public int punto_de_venta
		{
			get
			{
				return this.punto_de_ventaField;
			}
			set
			{
				this.punto_de_ventaField = value;
			}
		}

		/// <comentarios/>
		public string fecha_emision
		{
			get
			{
				return this.fecha_emisionField;
			}
			set
			{
				this.fecha_emisionField = value;
			}
		}

		/// <comentarios/>
		public string fecha_vencimiento
		{
			get
			{
				return this.fecha_vencimientoField;
			}
			set
			{
				this.fecha_vencimientoField = value;
			}
		}

		/// <comentarios/>
		public string fecha_serv_desde
		{
			get
			{
				return this.fecha_serv_desdeField;
			}
			set
			{
				this.fecha_serv_desdeField = value;
			}
		}

		/// <comentarios/>
		public string fecha_serv_hasta
		{
			get
			{
				return this.fecha_serv_hastaField;
			}
			set
			{
				this.fecha_serv_hastaField = value;
			}
		}

		/// <comentarios/>
		public int condicion_de_pago
		{
			get
			{
				return this.condicion_de_pagoField;
			}
			set
			{
				this.condicion_de_pagoField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool condicion_de_pagoSpecified
		{
			get
			{
				return this.condicion_de_pagoFieldSpecified;
			}
			set
			{
				this.condicion_de_pagoFieldSpecified = value;
			}
		}

		/// <comentarios/>
		public string iva_computable
		{
			get
			{
				return this.iva_computableField;
			}
			set
			{
				this.iva_computableField = value;
			}
		}

		/// <comentarios/>
		public string codigo_operacion
		{
			get
			{
				return this.codigo_operacionField;
			}
			set
			{
				this.codigo_operacionField = value;
			}
		}

		/// <comentarios/>
		public string cae
		{
			get
			{
				return this.caeField;
			}
			set
			{
				this.caeField = value;
			}
		}

		/// <comentarios/>
		public string fecha_vencimiento_cae
		{
			get
			{
				return this.fecha_vencimiento_caeField;
			}
			set
			{
				this.fecha_vencimiento_caeField = value;
			}
		}

		/// <comentarios/>
		public string fecha_obtencion_cae
		{
			get
			{
				return this.fecha_obtencion_caeField;
			}
			set
			{
				this.fecha_obtencion_caeField = value;
			}
		}

		/// <comentarios/>
		public string resultado
		{
			get
			{
				return this.resultadoField;
			}
			set
			{
				this.resultadoField = value;
			}
		}

		/// <comentarios/>
		public string motivo
		{
			get
			{
				return this.motivoField;
			}
			set
			{
				this.motivoField = value;
			}
		}

		/// <comentarios/>
		public string es_detalle_encriptado
		{
			get
			{
				return this.es_detalle_encriptadoField;
			}
			set
			{
				this.es_detalle_encriptadoField = value;
			}
		}

		/// <comentarios/>
		[System.Xml.Serialization.XmlElementAttribute("referencias")]
		public informacion_comprobanteReferencias[] referencias
		{
			get
			{
				return this.referenciasField;
			}
			set
			{
				this.referenciasField = value;
			}
		}
	}
}
