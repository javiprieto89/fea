namespace FEA
{
    partial class ConsultaComprobante
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
            this.nrocomprobanteLbel = new System.Windows.Forms.Label();
            this.cuitemisorTextBox = new System.Windows.Forms.TextBox();
            this.nrocomprobanteTextBox = new System.Windows.Forms.TextBox();
            this.cuitemisorLabel = new System.Windows.Forms.Label();
            this.ptoVentaTextBox = new System.Windows.Forms.TextBox();
            this.ptoVentaLabel = new System.Windows.Forms.Label();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.ConsultarComprobanteButton = new System.Windows.Forms.Button();
            this.tipoComprobanteLabel = new System.Windows.Forms.Label();
            this.tipoComprobanteComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nrocomprobanteLbel
            // 
            this.nrocomprobanteLbel.AutoSize = true;
            this.nrocomprobanteLbel.Location = new System.Drawing.Point(104, 93);
            this.nrocomprobanteLbel.Name = "nrocomprobanteLbel";
            this.nrocomprobanteLbel.Size = new System.Drawing.Size(93, 13);
            this.nrocomprobanteLbel.TabIndex = 51;
            this.nrocomprobanteLbel.Text = "Nro. Comprobante";
            // 
            // cuitemisorTextBox
            // 
            this.cuitemisorTextBox.Location = new System.Drawing.Point(203, 10);
            this.cuitemisorTextBox.Name = "cuitemisorTextBox";
            this.cuitemisorTextBox.Size = new System.Drawing.Size(129, 20);
            this.cuitemisorTextBox.TabIndex = 50;
            // 
            // nrocomprobanteTextBox
            // 
            this.nrocomprobanteTextBox.Location = new System.Drawing.Point(203, 90);
            this.nrocomprobanteTextBox.Name = "nrocomprobanteTextBox";
            this.nrocomprobanteTextBox.Size = new System.Drawing.Size(129, 20);
            this.nrocomprobanteTextBox.TabIndex = 49;
            // 
            // cuitemisorLabel
            // 
            this.cuitemisorLabel.AutoSize = true;
            this.cuitemisorLabel.Location = new System.Drawing.Point(139, 13);
            this.cuitemisorLabel.Name = "cuitemisorLabel";
            this.cuitemisorLabel.Size = new System.Drawing.Size(58, 13);
            this.cuitemisorLabel.TabIndex = 48;
            this.cuitemisorLabel.Text = "Cuit emisor";
            // 
            // ptoVentaTextBox
            // 
            this.ptoVentaTextBox.Location = new System.Drawing.Point(203, 36);
            this.ptoVentaTextBox.Name = "ptoVentaTextBox";
            this.ptoVentaTextBox.Size = new System.Drawing.Size(129, 20);
            this.ptoVentaTextBox.TabIndex = 47;
            // 
            // ptoVentaLabel
            // 
            this.ptoVentaLabel.AutoSize = true;
            this.ptoVentaLabel.Location = new System.Drawing.Point(117, 39);
            this.ptoVentaLabel.Name = "ptoVentaLabel";
            this.ptoVentaLabel.Size = new System.Drawing.Size(80, 13);
            this.ptoVentaLabel.TabIndex = 46;
            this.ptoVentaLabel.Text = "Punto de venta";
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.Location = new System.Drawing.Point(77, 170);
            this.resultadoTextBox.Multiline = true;
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.ReadOnly = true;
            this.resultadoTextBox.Size = new System.Drawing.Size(366, 229);
            this.resultadoTextBox.TabIndex = 55;
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(15, 173);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(55, 13);
            this.resultadoLabel.TabIndex = 54;
            this.resultadoLabel.Text = "Resultado";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(30, 119);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(40, 13);
            this.estadoLabel.TabIndex = 53;
            this.estadoLabel.Text = "Estado";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.Location = new System.Drawing.Point(78, 116);
            this.estadoTextBox.Multiline = true;
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.ReadOnly = true;
            this.estadoTextBox.Size = new System.Drawing.Size(365, 48);
            this.estadoTextBox.TabIndex = 52;
            // 
            // ConsultarComprobanteButton
            // 
            this.ConsultarComprobanteButton.Location = new System.Drawing.Point(19, 405);
            this.ConsultarComprobanteButton.Name = "ConsultarComprobanteButton";
            this.ConsultarComprobanteButton.Size = new System.Drawing.Size(424, 46);
            this.ConsultarComprobanteButton.TabIndex = 56;
            this.ConsultarComprobanteButton.Text = "Consultar Comprobante";
            this.ConsultarComprobanteButton.UseVisualStyleBackColor = true;
            this.ConsultarComprobanteButton.Click += new System.EventHandler(this.ConsultarComprobanteButton_Click);
            // 
            // tipoComprobanteLabel
            // 
            this.tipoComprobanteLabel.AutoSize = true;
            this.tipoComprobanteLabel.Location = new System.Drawing.Point(89, 64);
            this.tipoComprobanteLabel.Name = "tipoComprobanteLabel";
            this.tipoComprobanteLabel.Size = new System.Drawing.Size(108, 13);
            this.tipoComprobanteLabel.TabIndex = 57;
            this.tipoComprobanteLabel.Text = "Tipo de comprobante";
            // 
            // tipoComprobanteComboBox
            // 
            this.tipoComprobanteComboBox.FormattingEnabled = true;
            this.tipoComprobanteComboBox.Location = new System.Drawing.Point(203, 62);
            this.tipoComprobanteComboBox.Name = "tipoComprobanteComboBox";
            this.tipoComprobanteComboBox.Size = new System.Drawing.Size(241, 21);
            this.tipoComprobanteComboBox.TabIndex = 58;
            // 
            // ConsultaComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 463);
            this.Controls.Add(this.tipoComprobanteComboBox);
            this.Controls.Add(this.tipoComprobanteLabel);
            this.Controls.Add(this.ConsultarComprobanteButton);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.nrocomprobanteLbel);
            this.Controls.Add(this.cuitemisorTextBox);
            this.Controls.Add(this.nrocomprobanteTextBox);
            this.Controls.Add(this.cuitemisorLabel);
            this.Controls.Add(this.ptoVentaTextBox);
            this.Controls.Add(this.ptoVentaLabel);
            this.Name = "ConsultaComprobante";
            this.Text = "Consultar Comprobante";
            this.Load += new System.EventHandler(this.ConsultaComprobante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nrocomprobanteLbel;
        private System.Windows.Forms.TextBox cuitemisorTextBox;
        private System.Windows.Forms.TextBox nrocomprobanteTextBox;
        private System.Windows.Forms.Label cuitemisorLabel;
        private System.Windows.Forms.TextBox ptoVentaTextBox;
        private System.Windows.Forms.Label ptoVentaLabel;
        private System.Windows.Forms.TextBox resultadoTextBox;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.Button ConsultarComprobanteButton;
        private System.Windows.Forms.Label tipoComprobanteLabel;
        private System.Windows.Forms.ComboBox tipoComprobanteComboBox;
    }
}