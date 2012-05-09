namespace FEA
{
    partial class ConsultaUltNroComprobante
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
            this.cuitemisorTextBox = new System.Windows.Forms.TextBox();
            this.cuitemisorLabel = new System.Windows.Forms.Label();
            this.tipoComprobanteLabel = new System.Windows.Forms.Label();
            this.ptoVentaLabel = new System.Windows.Forms.Label();
            this.ConsultaUltNroComprobanteButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.tipoCompComboBox = new System.Windows.Forms.ComboBox();
            this.ptoVtaTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cuitemisorTextBox
            // 
            this.cuitemisorTextBox.Location = new System.Drawing.Point(167, 65);
            this.cuitemisorTextBox.Name = "cuitemisorTextBox";
            this.cuitemisorTextBox.Size = new System.Drawing.Size(129, 20);
            this.cuitemisorTextBox.TabIndex = 50;
            // 
            // cuitemisorLabel
            // 
            this.cuitemisorLabel.AutoSize = true;
            this.cuitemisorLabel.Location = new System.Drawing.Point(102, 68);
            this.cuitemisorLabel.Name = "cuitemisorLabel";
            this.cuitemisorLabel.Size = new System.Drawing.Size(58, 13);
            this.cuitemisorLabel.TabIndex = 49;
            this.cuitemisorLabel.Text = "Cuit emisor";
            // 
            // tipoComprobanteLabel
            // 
            this.tipoComprobanteLabel.AutoSize = true;
            this.tipoComprobanteLabel.Location = new System.Drawing.Point(55, 41);
            this.tipoComprobanteLabel.Name = "tipoComprobanteLabel";
            this.tipoComprobanteLabel.Size = new System.Drawing.Size(108, 13);
            this.tipoComprobanteLabel.TabIndex = 46;
            this.tipoComprobanteLabel.Text = "Tipo de comprobante";
            // 
            // ptoVentaLabel
            // 
            this.ptoVentaLabel.AutoSize = true;
            this.ptoVentaLabel.Location = new System.Drawing.Point(81, 15);
            this.ptoVentaLabel.Name = "ptoVentaLabel";
            this.ptoVentaLabel.Size = new System.Drawing.Size(80, 13);
            this.ptoVentaLabel.TabIndex = 45;
            this.ptoVentaLabel.Text = "Punto de venta";
            // 
            // ConsultaUltNroComprobanteButton
            // 
            this.ConsultaUltNroComprobanteButton.Location = new System.Drawing.Point(12, 175);
            this.ConsultaUltNroComprobanteButton.Name = "ConsultaUltNroComprobanteButton";
            this.ConsultaUltNroComprobanteButton.Size = new System.Drawing.Size(424, 46);
            this.ConsultaUltNroComprobanteButton.TabIndex = 55;
            this.ConsultaUltNroComprobanteButton.Text = "Consultar Ultimo Nro. Comprobante Emitido";
            this.ConsultaUltNroComprobanteButton.UseVisualStyleBackColor = true;
            this.ConsultaUltNroComprobanteButton.Click += new System.EventHandler(this.ConsultaUltNroComprobanteButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(9, 152);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(55, 13);
            this.resultadoLabel.TabIndex = 53;
            this.resultadoLabel.Text = "Resultado";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(23, 98);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(40, 13);
            this.estadoLabel.TabIndex = 52;
            this.estadoLabel.Text = "Estado";
            // 
            // tipoCompComboBox
            // 
            this.tipoCompComboBox.FormattingEnabled = true;
            this.tipoCompComboBox.Location = new System.Drawing.Point(167, 38);
            this.tipoCompComboBox.Name = "tipoCompComboBox";
            this.tipoCompComboBox.Size = new System.Drawing.Size(268, 21);
            this.tipoCompComboBox.TabIndex = 56;
            // 
            // ptoVtaTextBox
            // 
            this.ptoVtaTextBox.Location = new System.Drawing.Point(168, 12);
            this.ptoVtaTextBox.Name = "ptoVtaTextBox";
            this.ptoVtaTextBox.Size = new System.Drawing.Size(128, 20);
            this.ptoVtaTextBox.TabIndex = 57;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.Location = new System.Drawing.Point(70, 91);
            this.estadoTextBox.Multiline = true;
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.ReadOnly = true;
            this.estadoTextBox.Size = new System.Drawing.Size(366, 52);
            this.estadoTextBox.TabIndex = 58;
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.Location = new System.Drawing.Point(69, 149);
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.ReadOnly = true;
            this.resultadoTextBox.Size = new System.Drawing.Size(366, 20);
            this.resultadoTextBox.TabIndex = 59;
            // 
            // ConsultaUltNroComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 231);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.ptoVtaTextBox);
            this.Controls.Add(this.tipoCompComboBox);
            this.Controls.Add(this.ConsultaUltNroComprobanteButton);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.estadoLabel);
            this.Controls.Add(this.cuitemisorTextBox);
            this.Controls.Add(this.cuitemisorLabel);
            this.Controls.Add(this.tipoComprobanteLabel);
            this.Controls.Add(this.ptoVentaLabel);
            this.Name = "ConsultaUltNroComprobante";
            this.Text = "Consulta del Ultimo Nro. Comprobante Emitido";
            this.Load += new System.EventHandler(this.ConsultaUltNroComprobante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cuitemisorTextBox;
        private System.Windows.Forms.Label cuitemisorLabel;
        private System.Windows.Forms.Label tipoComprobanteLabel;
        private System.Windows.Forms.Label ptoVentaLabel;
        private System.Windows.Forms.Button ConsultaUltNroComprobanteButton;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.ComboBox tipoCompComboBox;
        private System.Windows.Forms.TextBox ptoVtaTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox resultadoTextBox;
    }
}