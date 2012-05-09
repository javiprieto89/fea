namespace FEA
{
	partial class PrincipalForm
	{
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.nuevoComprobanteButton = new System.Windows.Forms.Button();
            this.ComprobantesDataGridView = new System.Windows.Forms.DataGridView();
            this.fechaImpactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idComprobanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntoVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrTipoDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrodocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestaservDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechacbteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaservdesdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaservhastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavencpagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impnetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impopexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imptotconcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imptotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imptoliqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imptoliqrniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajeErrorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit_emisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrincipalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ultNroComprobanteButton = new System.Windows.Forms.Button();
            this.ultTransaccionButton = new System.Windows.Forms.Button();
            this.ticketButton = new System.Windows.Forms.Button();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.signTextBox = new System.Windows.Forms.TextBox();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.signLabel = new System.Windows.Forms.Label();
            this.cuitTextBox = new System.Windows.Forms.TextBox();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.ConsultarComprobanteButton = new System.Windows.Forms.Button();
            this.PanelPruebas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ComprobantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteBindingSource)).BeginInit();
            this.PanelPruebas.SuspendLayout();
            this.SuspendLayout();
            // 
            // nuevoComprobanteButton
            // 
            this.nuevoComprobanteButton.Location = new System.Drawing.Point(14, 4);
            this.nuevoComprobanteButton.Name = "nuevoComprobanteButton";
            this.nuevoComprobanteButton.Size = new System.Drawing.Size(509, 48);
            this.nuevoComprobanteButton.TabIndex = 21;
            this.nuevoComprobanteButton.Text = "Generar nuevo comprobante";
            this.nuevoComprobanteButton.UseVisualStyleBackColor = false;
            this.nuevoComprobanteButton.Click += new System.EventHandler(this.nuevoComprobanteButton_Click);
            // 
            // ComprobantesDataGridView
            // 
            this.ComprobantesDataGridView.AllowUserToAddRows = false;
            this.ComprobantesDataGridView.AllowUserToDeleteRows = false;
            this.ComprobantesDataGridView.AllowUserToOrderColumns = true;
            this.ComprobantesDataGridView.AutoGenerateColumns = false;
            this.ComprobantesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ComprobantesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ComprobantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComprobantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaImpactoDataGridViewTextBoxColumn,
            this.idTransaccionDataGridViewTextBoxColumn,
            this.idComprobanteDataGridViewTextBoxColumn,
            this.puntoVentaDataGridViewTextBoxColumn,
            this.caeDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descrCodigoDataGridViewTextBoxColumn,
            this.tipoDocDataGridViewTextBoxColumn1,
            this.descrTipoDocDataGridViewTextBoxColumn,
            this.nrodocDataGridViewTextBoxColumn,
            this.prestaservDataGridViewCheckBoxColumn,
            this.fechacbteDataGridViewTextBoxColumn,
            this.fechaservdesdeDataGridViewTextBoxColumn,
            this.fechaservhastaDataGridViewTextBoxColumn,
            this.fechavencpagoDataGridViewTextBoxColumn,
            this.impnetoDataGridViewTextBoxColumn,
            this.impopexDataGridViewTextBoxColumn,
            this.imptotconcDataGridViewTextBoxColumn,
            this.imptotalDataGridViewTextBoxColumn,
            this.imptoliqDataGridViewTextBoxColumn,
            this.imptoliqrniDataGridViewTextBoxColumn,
            this.resultadoDataGridViewTextBoxColumn,
            this.motivoDataGridViewTextBoxColumn,
            this.mensajeErrorDataGridViewTextBoxColumn,
            this.Cuit_emisor});
            this.ComprobantesDataGridView.DataSource = this.comprobanteBindingSource;
            this.ComprobantesDataGridView.Location = new System.Drawing.Point(14, 88);
            this.ComprobantesDataGridView.Name = "ComprobantesDataGridView";
            this.ComprobantesDataGridView.ReadOnly = true;
            this.ComprobantesDataGridView.Size = new System.Drawing.Size(920, 336);
            this.ComprobantesDataGridView.TabIndex = 22;
            this.ComprobantesDataGridView.DoubleClick += new System.EventHandler(this.ComprobantesDataGridView_DoubleClick);
            // 
            // fechaImpactoDataGridViewTextBoxColumn
            // 
            this.fechaImpactoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaImpactoDataGridViewTextBoxColumn.DataPropertyName = "FechaImpacto";
            dataGridViewCellStyle1.Format = "F";
            dataGridViewCellStyle1.NullValue = null;
            this.fechaImpactoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaImpactoDataGridViewTextBoxColumn.HeaderText = "Fecha Impacto";
            this.fechaImpactoDataGridViewTextBoxColumn.Name = "fechaImpactoDataGridViewTextBoxColumn";
            this.fechaImpactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaImpactoDataGridViewTextBoxColumn.Width = 95;
            // 
            // idTransaccionDataGridViewTextBoxColumn
            // 
            this.idTransaccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idTransaccionDataGridViewTextBoxColumn.DataPropertyName = "IdTransaccion";
            this.idTransaccionDataGridViewTextBoxColumn.HeaderText = "N° Transaccion";
            this.idTransaccionDataGridViewTextBoxColumn.Name = "idTransaccionDataGridViewTextBoxColumn";
            this.idTransaccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTransaccionDataGridViewTextBoxColumn.Width = 97;
            // 
            // idComprobanteDataGridViewTextBoxColumn
            // 
            this.idComprobanteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idComprobanteDataGridViewTextBoxColumn.DataPropertyName = "IdComprobante";
            this.idComprobanteDataGridViewTextBoxColumn.HeaderText = "N° Comprobante";
            this.idComprobanteDataGridViewTextBoxColumn.Name = "idComprobanteDataGridViewTextBoxColumn";
            this.idComprobanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idComprobanteDataGridViewTextBoxColumn.Width = 101;
            // 
            // puntoVentaDataGridViewTextBoxColumn
            // 
            this.puntoVentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.puntoVentaDataGridViewTextBoxColumn.DataPropertyName = "PuntoVenta";
            this.puntoVentaDataGridViewTextBoxColumn.HeaderText = "Punto Venta";
            this.puntoVentaDataGridViewTextBoxColumn.Name = "puntoVentaDataGridViewTextBoxColumn";
            this.puntoVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.puntoVentaDataGridViewTextBoxColumn.Width = 84;
            // 
            // caeDataGridViewTextBoxColumn
            // 
            this.caeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.caeDataGridViewTextBoxColumn.DataPropertyName = "Cae";
            this.caeDataGridViewTextBoxColumn.HeaderText = "CAE";
            this.caeDataGridViewTextBoxColumn.Name = "caeDataGridViewTextBoxColumn";
            this.caeDataGridViewTextBoxColumn.ReadOnly = true;
            this.caeDataGridViewTextBoxColumn.Width = 53;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 65;
            // 
            // descrCodigoDataGridViewTextBoxColumn
            // 
            this.descrCodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descrCodigoDataGridViewTextBoxColumn.DataPropertyName = "DescrCodigo";
            this.descrCodigoDataGridViewTextBoxColumn.HeaderText = "Descripción Código";
            this.descrCodigoDataGridViewTextBoxColumn.Name = "descrCodigoDataGridViewTextBoxColumn";
            this.descrCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descrCodigoDataGridViewTextBoxColumn.Width = 114;
            // 
            // tipoDocDataGridViewTextBoxColumn1
            // 
            this.tipoDocDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipoDocDataGridViewTextBoxColumn1.DataPropertyName = "TipoDoc";
            this.tipoDocDataGridViewTextBoxColumn1.HeaderText = "Tipo Doc";
            this.tipoDocDataGridViewTextBoxColumn1.Name = "tipoDocDataGridViewTextBoxColumn1";
            this.tipoDocDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tipoDocDataGridViewTextBoxColumn1.Width = 70;
            // 
            // descrTipoDocDataGridViewTextBoxColumn
            // 
            this.descrTipoDocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descrTipoDocDataGridViewTextBoxColumn.DataPropertyName = "DescrTipoDoc";
            this.descrTipoDocDataGridViewTextBoxColumn.HeaderText = "Descripción Tipo Doc";
            this.descrTipoDocDataGridViewTextBoxColumn.Name = "descrTipoDocDataGridViewTextBoxColumn";
            this.descrTipoDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.descrTipoDocDataGridViewTextBoxColumn.Width = 106;
            // 
            // nrodocDataGridViewTextBoxColumn
            // 
            this.nrodocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nrodocDataGridViewTextBoxColumn.DataPropertyName = "Nro_doc";
            this.nrodocDataGridViewTextBoxColumn.HeaderText = "Nro id comprador";
            this.nrodocDataGridViewTextBoxColumn.Name = "nrodocDataGridViewTextBoxColumn";
            this.nrodocDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrodocDataGridViewTextBoxColumn.ToolTipText = "Nro.  de identificación del comprador";
            this.nrodocDataGridViewTextBoxColumn.Width = 104;
            // 
            // prestaservDataGridViewCheckBoxColumn
            // 
            this.prestaservDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.prestaservDataGridViewCheckBoxColumn.DataPropertyName = "Presta_serv";
            this.prestaservDataGridViewCheckBoxColumn.HeaderText = "Presta servicio";
            this.prestaservDataGridViewCheckBoxColumn.Name = "prestaservDataGridViewCheckBoxColumn";
            this.prestaservDataGridViewCheckBoxColumn.ReadOnly = true;
            this.prestaservDataGridViewCheckBoxColumn.Width = 74;
            // 
            // fechacbteDataGridViewTextBoxColumn
            // 
            this.fechacbteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechacbteDataGridViewTextBoxColumn.DataPropertyName = "Fecha_cbte";
            this.fechacbteDataGridViewTextBoxColumn.HeaderText = "Fecha comprobante";
            this.fechacbteDataGridViewTextBoxColumn.Name = "fechacbteDataGridViewTextBoxColumn";
            this.fechacbteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechacbteDataGridViewTextBoxColumn.Width = 116;
            // 
            // fechaservdesdeDataGridViewTextBoxColumn
            // 
            this.fechaservdesdeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaservdesdeDataGridViewTextBoxColumn.DataPropertyName = "Fecha_serv_desde";
            this.fechaservdesdeDataGridViewTextBoxColumn.HeaderText = "Fecha servicio desde";
            this.fechaservdesdeDataGridViewTextBoxColumn.Name = "fechaservdesdeDataGridViewTextBoxColumn";
            this.fechaservdesdeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaservdesdeDataGridViewTextBoxColumn.Width = 122;
            // 
            // fechaservhastaDataGridViewTextBoxColumn
            // 
            this.fechaservhastaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaservhastaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_serv_hasta";
            this.fechaservhastaDataGridViewTextBoxColumn.HeaderText = "Fecha servicio hasta";
            this.fechaservhastaDataGridViewTextBoxColumn.Name = "fechaservhastaDataGridViewTextBoxColumn";
            this.fechaservhastaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaservhastaDataGridViewTextBoxColumn.Width = 119;
            // 
            // fechavencpagoDataGridViewTextBoxColumn
            // 
            this.fechavencpagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechavencpagoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_venc_pago";
            this.fechavencpagoDataGridViewTextBoxColumn.HeaderText = "Vencimiento";
            this.fechavencpagoDataGridViewTextBoxColumn.Name = "fechavencpagoDataGridViewTextBoxColumn";
            this.fechavencpagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechavencpagoDataGridViewTextBoxColumn.ToolTipText = "Fecha de vencimiento de la factura";
            this.fechavencpagoDataGridViewTextBoxColumn.Width = 90;
            // 
            // impnetoDataGridViewTextBoxColumn
            // 
            this.impnetoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.impnetoDataGridViewTextBoxColumn.DataPropertyName = "Imp_neto";
            this.impnetoDataGridViewTextBoxColumn.HeaderText = "Importe neto";
            this.impnetoDataGridViewTextBoxColumn.Name = "impnetoDataGridViewTextBoxColumn";
            this.impnetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.impnetoDataGridViewTextBoxColumn.Width = 84;
            // 
            // impopexDataGridViewTextBoxColumn
            // 
            this.impopexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.impopexDataGridViewTextBoxColumn.DataPropertyName = "Imp_op_ex";
            this.impopexDataGridViewTextBoxColumn.HeaderText = "Importe de operaciones exentas";
            this.impopexDataGridViewTextBoxColumn.Name = "impopexDataGridViewTextBoxColumn";
            this.impopexDataGridViewTextBoxColumn.ReadOnly = true;
            this.impopexDataGridViewTextBoxColumn.Width = 133;
            // 
            // imptotconcDataGridViewTextBoxColumn
            // 
            this.imptotconcDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.imptotconcDataGridViewTextBoxColumn.DataPropertyName = "Imp_tot_conc";
            this.imptotconcDataGridViewTextBoxColumn.HeaderText = "Importe total conceptos";
            this.imptotconcDataGridViewTextBoxColumn.Name = "imptotconcDataGridViewTextBoxColumn";
            this.imptotconcDataGridViewTextBoxColumn.ReadOnly = true;
            this.imptotconcDataGridViewTextBoxColumn.ToolTipText = "Importe total de conceptos que no integran el precio neto gravado";
            this.imptotconcDataGridViewTextBoxColumn.Width = 131;
            // 
            // imptotalDataGridViewTextBoxColumn
            // 
            this.imptotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.imptotalDataGridViewTextBoxColumn.DataPropertyName = "Imp_total";
            this.imptotalDataGridViewTextBoxColumn.HeaderText = "Importe total";
            this.imptotalDataGridViewTextBoxColumn.Name = "imptotalDataGridViewTextBoxColumn";
            this.imptotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.imptotalDataGridViewTextBoxColumn.Width = 83;
            // 
            // imptoliqDataGridViewTextBoxColumn
            // 
            this.imptoliqDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.imptoliqDataGridViewTextBoxColumn.DataPropertyName = "Impto_liq";
            this.imptoliqDataGridViewTextBoxColumn.HeaderText = "Impuesto liquidado";
            this.imptoliqDataGridViewTextBoxColumn.Name = "imptoliqDataGridViewTextBoxColumn";
            this.imptoliqDataGridViewTextBoxColumn.ReadOnly = true;
            this.imptoliqDataGridViewTextBoxColumn.Width = 110;
            // 
            // imptoliqrniDataGridViewTextBoxColumn
            // 
            this.imptoliqrniDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.imptoliqrniDataGridViewTextBoxColumn.DataPropertyName = "Impto_liq_rni";
            this.imptoliqrniDataGridViewTextBoxColumn.HeaderText = "Impuesto liquidado rni";
            this.imptoliqrniDataGridViewTextBoxColumn.Name = "imptoliqrniDataGridViewTextBoxColumn";
            this.imptoliqrniDataGridViewTextBoxColumn.ReadOnly = true;
            this.imptoliqrniDataGridViewTextBoxColumn.ToolTipText = "Impuesto liquidado a RNI o percepción a no categorizados";
            this.imptoliqrniDataGridViewTextBoxColumn.Width = 113;
            // 
            // resultadoDataGridViewTextBoxColumn
            // 
            this.resultadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.resultadoDataGridViewTextBoxColumn.DataPropertyName = "Resultado";
            this.resultadoDataGridViewTextBoxColumn.HeaderText = "Resultado";
            this.resultadoDataGridViewTextBoxColumn.Name = "resultadoDataGridViewTextBoxColumn";
            this.resultadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultadoDataGridViewTextBoxColumn.Width = 80;
            // 
            // motivoDataGridViewTextBoxColumn
            // 
            this.motivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.motivoDataGridViewTextBoxColumn.DataPropertyName = "Motivo";
            this.motivoDataGridViewTextBoxColumn.HeaderText = "Motivo";
            this.motivoDataGridViewTextBoxColumn.Name = "motivoDataGridViewTextBoxColumn";
            this.motivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.motivoDataGridViewTextBoxColumn.Width = 64;
            // 
            // mensajeErrorDataGridViewTextBoxColumn
            // 
            this.mensajeErrorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mensajeErrorDataGridViewTextBoxColumn.DataPropertyName = "MensajeError";
            this.mensajeErrorDataGridViewTextBoxColumn.HeaderText = "Mensaje Error";
            this.mensajeErrorDataGridViewTextBoxColumn.Name = "mensajeErrorDataGridViewTextBoxColumn";
            this.mensajeErrorDataGridViewTextBoxColumn.ReadOnly = true;
            this.mensajeErrorDataGridViewTextBoxColumn.Width = 89;
            // 
            // Cuit_emisor
            // 
            this.Cuit_emisor.DataPropertyName = "Cuit_emisor";
            this.Cuit_emisor.HeaderText = "Cuit_emisor";
            this.Cuit_emisor.Name = "Cuit_emisor";
            this.Cuit_emisor.ReadOnly = true;
            this.Cuit_emisor.Width = 86;
            // 
            // comprobanteBindingSource
            // 
            this.comprobanteBindingSource.DataSource = typeof(FeaEntidades.Comprobante);
            // 
            // ultNroComprobanteButton
            // 
            this.ultNroComprobanteButton.Location = new System.Drawing.Point(527, 28);
            this.ultNroComprobanteButton.Name = "ultNroComprobanteButton";
            this.ultNroComprobanteButton.Size = new System.Drawing.Size(405, 24);
            this.ultNroComprobanteButton.TabIndex = 31;
            this.ultNroComprobanteButton.Text = "Consultar Ultimo Nro. Comprobante Emitido";
            this.ultNroComprobanteButton.UseVisualStyleBackColor = false;
            this.ultNroComprobanteButton.Click += new System.EventHandler(this.ultNroComprobanteButton_Click);
            // 
            // ultTransaccionButton
            // 
            this.ultTransaccionButton.Location = new System.Drawing.Point(527, 4);
            this.ultTransaccionButton.Name = "ultTransaccionButton";
            this.ultTransaccionButton.Size = new System.Drawing.Size(405, 24);
            this.ultTransaccionButton.TabIndex = 32;
            this.ultTransaccionButton.Text = "Consultar Ultimo Nro. Transacción";
            this.ultTransaccionButton.UseVisualStyleBackColor = false;
            this.ultTransaccionButton.Click += new System.EventHandler(this.ultTransaccionButton_Click);
            // 
            // ticketButton
            // 
            this.ticketButton.Location = new System.Drawing.Point(3, 4);
            this.ticketButton.Name = "ticketButton";
            this.ticketButton.Size = new System.Drawing.Size(506, 76);
            this.ticketButton.TabIndex = 21;
            this.ticketButton.Text = "Obtener Ticket";
            this.ticketButton.UseVisualStyleBackColor = true;
            this.ticketButton.Visible = false;
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.Enabled = false;
            this.tokenTextBox.Location = new System.Drawing.Point(561, 1);
            this.tokenTextBox.Multiline = true;
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tokenTextBox.Size = new System.Drawing.Size(345, 20);
            this.tokenTextBox.TabIndex = 22;
            this.tokenTextBox.Visible = false;
            // 
            // signTextBox
            // 
            this.signTextBox.Enabled = false;
            this.signTextBox.Location = new System.Drawing.Point(561, 27);
            this.signTextBox.Multiline = true;
            this.signTextBox.Name = "signTextBox";
            this.signTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.signTextBox.Size = new System.Drawing.Size(345, 20);
            this.signTextBox.TabIndex = 23;
            this.signTextBox.Visible = false;
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Location = new System.Drawing.Point(517, 4);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(38, 13);
            this.tokenLabel.TabIndex = 24;
            this.tokenLabel.Text = "Token";
            this.tokenLabel.Visible = false;
            // 
            // signLabel
            // 
            this.signLabel.AutoSize = true;
            this.signLabel.Location = new System.Drawing.Point(527, 27);
            this.signLabel.Name = "signLabel";
            this.signLabel.Size = new System.Drawing.Size(28, 13);
            this.signLabel.TabIndex = 25;
            this.signLabel.Text = "Sign";
            this.signLabel.Visible = false;
            // 
            // cuitTextBox
            // 
            this.cuitTextBox.Enabled = false;
            this.cuitTextBox.Location = new System.Drawing.Point(561, 53);
            this.cuitTextBox.Name = "cuitTextBox";
            this.cuitTextBox.Size = new System.Drawing.Size(345, 20);
            this.cuitTextBox.TabIndex = 26;
            this.cuitTextBox.Visible = false;
            // 
            // cuitLabel
            // 
            this.cuitLabel.AutoSize = true;
            this.cuitLabel.Location = new System.Drawing.Point(523, 56);
            this.cuitLabel.Name = "cuitLabel";
            this.cuitLabel.Size = new System.Drawing.Size(32, 13);
            this.cuitLabel.TabIndex = 27;
            this.cuitLabel.Text = "CUIT";
            this.cuitLabel.Visible = false;
            // 
            // ConsultarComprobanteButton
            // 
            this.ConsultarComprobanteButton.Location = new System.Drawing.Point(14, 58);
            this.ConsultarComprobanteButton.Name = "ConsultarComprobanteButton";
            this.ConsultarComprobanteButton.Size = new System.Drawing.Size(509, 24);
            this.ConsultarComprobanteButton.TabIndex = 34;
            this.ConsultarComprobanteButton.Text = "Consultar Comprobante";
            this.ConsultarComprobanteButton.UseVisualStyleBackColor = false;
            this.ConsultarComprobanteButton.Click += new System.EventHandler(this.ConsultarComprobanteButton_Click);
            // 
            // PanelPruebas
            // 
            this.PanelPruebas.Controls.Add(this.cuitLabel);
            this.PanelPruebas.Controls.Add(this.cuitTextBox);
            this.PanelPruebas.Controls.Add(this.signLabel);
            this.PanelPruebas.Controls.Add(this.tokenLabel);
            this.PanelPruebas.Controls.Add(this.signTextBox);
            this.PanelPruebas.Controls.Add(this.tokenTextBox);
            this.PanelPruebas.Controls.Add(this.ticketButton);
            this.PanelPruebas.Location = new System.Drawing.Point(14, 99);
            this.PanelPruebas.Name = "PanelPruebas";
            this.PanelPruebas.Size = new System.Drawing.Size(918, 86);
            this.PanelPruebas.TabIndex = 23;
            this.PanelPruebas.Visible = false;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 427);
            this.Controls.Add(this.ConsultarComprobanteButton);
            this.Controls.Add(this.ultTransaccionButton);
            this.Controls.Add(this.ComprobantesDataGridView);
            this.Controls.Add(this.PanelPruebas);
            this.Controls.Add(this.nuevoComprobanteButton);
            this.Controls.Add(this.ultNroComprobanteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CedFEA";
            ((System.ComponentModel.ISupportInitialize)(this.ComprobantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteBindingSource)).EndInit();
            this.PanelPruebas.ResumeLayout(false);
            this.PanelPruebas.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Button nuevoComprobanteButton;
		private System.Windows.Forms.DataGridView ComprobantesDataGridView;
		private System.Windows.Forms.BindingSource comprobanteBindingSource;
        private System.Windows.Forms.ToolTip PrincipalToolTip;
        private System.Windows.Forms.Button ultNroComprobanteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaImpactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComprobanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntoVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrTipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrodocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prestaservDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacbteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaservdesdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaservhastaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavencpagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impnetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impopexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imptotconcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imptotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imptoliqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imptoliqrniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensajeErrorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit_emisor;
        private System.Windows.Forms.Button ultTransaccionButton;
        private System.Windows.Forms.Button ticketButton;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.TextBox signTextBox;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.Label signLabel;
        private System.Windows.Forms.TextBox cuitTextBox;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.Button ConsultarComprobanteButton;
        private System.Windows.Forms.Panel PanelPruebas;
	}
}

