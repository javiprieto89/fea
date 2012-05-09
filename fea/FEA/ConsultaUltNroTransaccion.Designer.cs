namespace FEA
{
    partial class ConsultaUltNroTransaccion
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
            this.ConsultaUltNroTransaccionButton = new System.Windows.Forms.Button();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.cuitemisorTextBox = new System.Windows.Forms.TextBox();
            this.cuitemisorLabel = new System.Windows.Forms.Label();
            this.CantMaxRenglonesButton = new System.Windows.Forms.Button();
            this.DummyAppServerButton = new System.Windows.Forms.Button();
            this.DummyAuthServerButton = new System.Windows.Forms.Button();
            this.DummyDbServerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConsultaUltNroTransaccionButton
            // 
            this.ConsultaUltNroTransaccionButton.Location = new System.Drawing.Point(12, 117);
            this.ConsultaUltNroTransaccionButton.Name = "ConsultaUltNroTransaccionButton";
            this.ConsultaUltNroTransaccionButton.Size = new System.Drawing.Size(210, 46);
            this.ConsultaUltNroTransaccionButton.TabIndex = 62;
            this.ConsultaUltNroTransaccionButton.Text = "Consultar Ultimo Nro. Transacción";
            this.ConsultaUltNroTransaccionButton.UseVisualStyleBackColor = true;
            this.ConsultaUltNroTransaccionButton.Click += new System.EventHandler(this.ConsultaUltNroTransaccionButton_Click);
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.Location = new System.Drawing.Point(70, 91);
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.ReadOnly = true;
            this.resultadoTextBox.Size = new System.Drawing.Size(366, 20);
            this.resultadoTextBox.TabIndex = 61;
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(9, 94);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(55, 13);
            this.resultadoLabel.TabIndex = 60;
            this.resultadoLabel.Text = "Resultado";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(23, 40);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(40, 13);
            this.estadoLabel.TabIndex = 59;
            this.estadoLabel.Text = "Estado";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.Location = new System.Drawing.Point(70, 37);
            this.estadoTextBox.Multiline = true;
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.ReadOnly = true;
            this.estadoTextBox.Size = new System.Drawing.Size(365, 48);
            this.estadoTextBox.TabIndex = 58;
            // 
            // cuitemisorTextBox
            // 
            this.cuitemisorTextBox.Location = new System.Drawing.Point(70, 7);
            this.cuitemisorTextBox.Name = "cuitemisorTextBox";
            this.cuitemisorTextBox.Size = new System.Drawing.Size(129, 20);
            this.cuitemisorTextBox.TabIndex = 57;
            // 
            // cuitemisorLabel
            // 
            this.cuitemisorLabel.AutoSize = true;
            this.cuitemisorLabel.Location = new System.Drawing.Point(6, 10);
            this.cuitemisorLabel.Name = "cuitemisorLabel";
            this.cuitemisorLabel.Size = new System.Drawing.Size(58, 13);
            this.cuitemisorLabel.TabIndex = 56;
            this.cuitemisorLabel.Text = "Cuit emisor";
            // 
            // CantMaxRenglonesButton
            // 
            this.CantMaxRenglonesButton.Location = new System.Drawing.Point(226, 117);
            this.CantMaxRenglonesButton.Name = "CantMaxRenglonesButton";
            this.CantMaxRenglonesButton.Size = new System.Drawing.Size(210, 46);
            this.CantMaxRenglonesButton.TabIndex = 63;
            this.CantMaxRenglonesButton.Text = "Consultar Cant. Max. Renglones";
            this.CantMaxRenglonesButton.UseVisualStyleBackColor = true;
            this.CantMaxRenglonesButton.Click += new System.EventHandler(this.CantMaxRenglonesButton_Click);
            // 
            // DummyAppServerButton
            // 
            this.DummyAppServerButton.Location = new System.Drawing.Point(12, 169);
            this.DummyAppServerButton.Name = "DummyAppServerButton";
            this.DummyAppServerButton.Size = new System.Drawing.Size(130, 46);
            this.DummyAppServerButton.TabIndex = 64;
            this.DummyAppServerButton.Text = "Consultar App Server";
            this.DummyAppServerButton.UseVisualStyleBackColor = true;
            this.DummyAppServerButton.Click += new System.EventHandler(this.DummyAppServerButton_Click);
            // 
            // DummyAuthServerButton
            // 
            this.DummyAuthServerButton.Location = new System.Drawing.Point(159, 170);
            this.DummyAuthServerButton.Name = "DummyAuthServerButton";
            this.DummyAuthServerButton.Size = new System.Drawing.Size(130, 46);
            this.DummyAuthServerButton.TabIndex = 65;
            this.DummyAuthServerButton.Text = "Consultar Auth Server";
            this.DummyAuthServerButton.UseVisualStyleBackColor = true;
            this.DummyAuthServerButton.Click += new System.EventHandler(this.DummyAuthServerButton_Click);
            // 
            // DummyDbServerButton
            // 
            this.DummyDbServerButton.Location = new System.Drawing.Point(305, 170);
            this.DummyDbServerButton.Name = "DummyDbServerButton";
            this.DummyDbServerButton.Size = new System.Drawing.Size(130, 46);
            this.DummyDbServerButton.TabIndex = 66;
            this.DummyDbServerButton.Text = "Consultar Db Server";
            this.DummyDbServerButton.UseVisualStyleBackColor = true;
            this.DummyDbServerButton.Click += new System.EventHandler(this.DummyDbServerButton_Click);
            // 
            // ConsultaUltNroTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 221);
            this.Controls.Add(this.DummyDbServerButton);
            this.Controls.Add(this.DummyAuthServerButton);
            this.Controls.Add(this.DummyAppServerButton);
            this.Controls.Add(this.CantMaxRenglonesButton);
            this.Controls.Add(this.ConsultaUltNroTransaccionButton);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.cuitemisorTextBox);
            this.Controls.Add(this.cuitemisorLabel);
            this.Name = "ConsultaUltNroTransaccion";
            this.Text = "Consulta Ultimo Nro. Transacción";
            this.Load += new System.EventHandler(this.ConsultaUltNroTransaccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConsultaUltNroTransaccionButton;
        private System.Windows.Forms.TextBox resultadoTextBox;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox cuitemisorTextBox;
        private System.Windows.Forms.Label cuitemisorLabel;
        private System.Windows.Forms.Button CantMaxRenglonesButton;
        private System.Windows.Forms.Button DummyAppServerButton;
        private System.Windows.Forms.Button DummyAuthServerButton;
        private System.Windows.Forms.Button DummyDbServerButton;
    }
}