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
            this.PrincipalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PanelPruebas = new System.Windows.Forms.Panel();
            this.verificarCaeTextBox = new System.Windows.Forms.TextBox();
            this.verificarCaeButton = new System.Windows.Forms.Button();
            this.ultCompAutTextBox = new System.Windows.Forms.TextBox();
            this.cantMaxDetTextBox = new System.Windows.Forms.TextBox();
            this.ultCompAutButton = new System.Windows.Forms.Button();
            this.cantMaxDetButton = new System.Windows.Forms.Button();
            this.ultNroRqstTextBox = new System.Windows.Forms.TextBox();
            this.ultNroButton = new System.Windows.Forms.Button();
            this.cuitLabel = new System.Windows.Forms.Label();
            this.cuitTextBox = new System.Windows.Forms.TextBox();
            this.signLabel = new System.Windows.Forms.Label();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.signTextBox = new System.Windows.Forms.TextBox();
            this.tokenTextBox = new System.Windows.Forms.TextBox();
            this.ticketButton = new System.Windows.Forms.Button();
            this.comprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.ComprobantesDataGridView)).BeginInit();
            this.PanelPruebas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoComprobanteButton
            // 
            this.nuevoComprobanteButton.Location = new System.Drawing.Point(14, 4);
            this.nuevoComprobanteButton.Name = "nuevoComprobanteButton";
            this.nuevoComprobanteButton.Size = new System.Drawing.Size(920, 44);
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
            this.ComprobantesDataGridView.Location = new System.Drawing.Point(14, 54);
            this.ComprobantesDataGridView.Name = "ComprobantesDataGridView";
            this.ComprobantesDataGridView.ReadOnly = true;
            this.ComprobantesDataGridView.Size = new System.Drawing.Size(920, 370);
            this.ComprobantesDataGridView.TabIndex = 22;
            this.ComprobantesDataGridView.DoubleClick += new System.EventHandler(this.ComprobantesDataGridView_DoubleClick);
            // 
            // PanelPruebas
            // 
            this.PanelPruebas.Controls.Add(this.verificarCaeTextBox);
            this.PanelPruebas.Controls.Add(this.verificarCaeButton);
            this.PanelPruebas.Controls.Add(this.ultCompAutTextBox);
            this.PanelPruebas.Controls.Add(this.cantMaxDetTextBox);
            this.PanelPruebas.Controls.Add(this.ultCompAutButton);
            this.PanelPruebas.Controls.Add(this.cantMaxDetButton);
            this.PanelPruebas.Controls.Add(this.ultNroRqstTextBox);
            this.PanelPruebas.Controls.Add(this.ultNroButton);
            this.PanelPruebas.Controls.Add(this.cuitLabel);
            this.PanelPruebas.Controls.Add(this.cuitTextBox);
            this.PanelPruebas.Controls.Add(this.signLabel);
            this.PanelPruebas.Controls.Add(this.tokenLabel);
            this.PanelPruebas.Controls.Add(this.signTextBox);
            this.PanelPruebas.Controls.Add(this.tokenTextBox);
            this.PanelPruebas.Controls.Add(this.ticketButton);
            this.PanelPruebas.Location = new System.Drawing.Point(14, 54);
            this.PanelPruebas.Name = "PanelPruebas";
            this.PanelPruebas.Size = new System.Drawing.Size(918, 134);
            this.PanelPruebas.TabIndex = 23;
            this.PanelPruebas.Visible = false;
            // 
            // verificarCaeTextBox
            // 
            this.verificarCaeTextBox.Location = new System.Drawing.Point(520, 98);
            this.verificarCaeTextBox.Name = "verificarCaeTextBox";
            this.verificarCaeTextBox.Size = new System.Drawing.Size(138, 20);
            this.verificarCaeTextBox.TabIndex = 35;
            this.verificarCaeTextBox.Visible = false;
            // 
            // verificarCaeButton
            // 
            this.verificarCaeButton.Location = new System.Drawing.Point(364, 98);
            this.verificarCaeButton.Name = "verificarCaeButton";
            this.verificarCaeButton.Size = new System.Drawing.Size(145, 30);
            this.verificarCaeButton.TabIndex = 34;
            this.verificarCaeButton.Text = "Verificar CAE";
            this.verificarCaeButton.UseVisualStyleBackColor = true;
            this.verificarCaeButton.Visible = false;
            // 
            // ultCompAutTextBox
            // 
            this.ultCompAutTextBox.Location = new System.Drawing.Point(164, 47);
            this.ultCompAutTextBox.Name = "ultCompAutTextBox";
            this.ultCompAutTextBox.Size = new System.Drawing.Size(145, 20);
            this.ultCompAutTextBox.TabIndex = 33;
            this.ultCompAutTextBox.Visible = false;
            // 
            // cantMaxDetTextBox
            // 
            this.cantMaxDetTextBox.Location = new System.Drawing.Point(164, 93);
            this.cantMaxDetTextBox.Name = "cantMaxDetTextBox";
            this.cantMaxDetTextBox.Size = new System.Drawing.Size(145, 20);
            this.cantMaxDetTextBox.TabIndex = 32;
            this.cantMaxDetTextBox.Visible = false;
            // 
            // ultCompAutButton
            // 
            this.ultCompAutButton.Location = new System.Drawing.Point(13, 47);
            this.ultCompAutButton.Name = "ultCompAutButton";
            this.ultCompAutButton.Size = new System.Drawing.Size(145, 40);
            this.ultCompAutButton.TabIndex = 31;
            this.ultCompAutButton.Text = "Obtener último comprobante autorizado";
            this.ultCompAutButton.UseVisualStyleBackColor = true;
            this.ultCompAutButton.Visible = false;
            // 
            // cantMaxDetButton
            // 
            this.cantMaxDetButton.Location = new System.Drawing.Point(13, 93);
            this.cantMaxDetButton.Name = "cantMaxDetButton";
            this.cantMaxDetButton.Size = new System.Drawing.Size(145, 40);
            this.cantMaxDetButton.TabIndex = 30;
            this.cantMaxDetButton.Text = "Obtener cantidad máxima de registros de detalle";
            this.cantMaxDetButton.UseVisualStyleBackColor = true;
            this.cantMaxDetButton.Visible = false;
            // 
            // ultNroRqstTextBox
            // 
            this.ultNroRqstTextBox.Location = new System.Drawing.Point(164, 1);
            this.ultNroRqstTextBox.Name = "ultNroRqstTextBox";
            this.ultNroRqstTextBox.Size = new System.Drawing.Size(145, 20);
            this.ultNroRqstTextBox.TabIndex = 29;
            this.ultNroRqstTextBox.Visible = false;
            // 
            // ultNroButton
            // 
            this.ultNroButton.Location = new System.Drawing.Point(13, 1);
            this.ultNroButton.Name = "ultNroButton";
            this.ultNroButton.Size = new System.Drawing.Size(145, 40);
            this.ultNroButton.TabIndex = 28;
            this.ultNroButton.Text = "Obtener último nro transacción";
            this.ultNroButton.UseVisualStyleBackColor = true;
            this.ultNroButton.Visible = false;
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
            // cuitTextBox
            // 
            this.cuitTextBox.Enabled = false;
            this.cuitTextBox.Location = new System.Drawing.Point(561, 53);
            this.cuitTextBox.Name = "cuitTextBox";
            this.cuitTextBox.Size = new System.Drawing.Size(345, 20);
            this.cuitTextBox.TabIndex = 26;
            this.cuitTextBox.Visible = false;
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
            // ticketButton
            // 
            this.ticketButton.Location = new System.Drawing.Point(364, 1);
            this.ticketButton.Name = "ticketButton";
            this.ticketButton.Size = new System.Drawing.Size(145, 76);
            this.ticketButton.TabIndex = 21;
            this.ticketButton.Text = "Obtener Ticket";
            this.ticketButton.UseVisualStyleBackColor = true;
            this.ticketButton.Visible = false;
            // 
            // comprobanteBindingSource
            // 
            this.comprobanteBindingSource.DataSource = typeof(FeaEntidades.Comprobante);
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
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 427);
            this.Controls.Add(this.ComprobantesDataGridView);
            this.Controls.Add(this.PanelPruebas);
            this.Controls.Add(this.nuevoComprobanteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CedFEA";
            ((System.ComponentModel.ISupportInitialize)(this.ComprobantesDataGridView)).EndInit();
            this.PanelPruebas.ResumeLayout(false);
            this.PanelPruebas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Button nuevoComprobanteButton;
		private System.Windows.Forms.DataGridView ComprobantesDataGridView;
		private System.Windows.Forms.BindingSource comprobanteBindingSource;
        private System.Windows.Forms.ToolTip PrincipalToolTip;
        private System.Windows.Forms.Panel PanelPruebas;
        private System.Windows.Forms.TextBox verificarCaeTextBox;
        private System.Windows.Forms.Button verificarCaeButton;
        private System.Windows.Forms.TextBox ultCompAutTextBox;
        private System.Windows.Forms.TextBox cantMaxDetTextBox;
        private System.Windows.Forms.Button ultCompAutButton;
        private System.Windows.Forms.Button cantMaxDetButton;
        private System.Windows.Forms.TextBox ultNroRqstTextBox;
        private System.Windows.Forms.Button ultNroButton;
        private System.Windows.Forms.Label cuitLabel;
        private System.Windows.Forms.TextBox cuitTextBox;
        private System.Windows.Forms.Label signLabel;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.TextBox signTextBox;
        private System.Windows.Forms.TextBox tokenTextBox;
        private System.Windows.Forms.Button ticketButton;
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
	}
}

