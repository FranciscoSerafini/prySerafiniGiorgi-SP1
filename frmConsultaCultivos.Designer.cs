namespace prySerafiniGiorgi_SP1
{
    partial class frmConsultaCultivos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdLimpiarCultivos = new System.Windows.Forms.Button();
            this.cmdListarCultivos = new System.Windows.Forms.Button();
            this.grillaCultivos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCultivos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLimpiarCultivos
            // 
            this.cmdLimpiarCultivos.Location = new System.Drawing.Point(11, 151);
            this.cmdLimpiarCultivos.Name = "cmdLimpiarCultivos";
            this.cmdLimpiarCultivos.Size = new System.Drawing.Size(100, 23);
            this.cmdLimpiarCultivos.TabIndex = 11;
            this.cmdLimpiarCultivos.Text = "Limpiar";
            this.cmdLimpiarCultivos.UseVisualStyleBackColor = true;
            this.cmdLimpiarCultivos.Click += new System.EventHandler(this.cmdLimpiarCultivos_Click);
            // 
            // cmdListarCultivos
            // 
            this.cmdListarCultivos.Location = new System.Drawing.Point(166, 151);
            this.cmdListarCultivos.Name = "cmdListarCultivos";
            this.cmdListarCultivos.Size = new System.Drawing.Size(100, 23);
            this.cmdListarCultivos.TabIndex = 10;
            this.cmdListarCultivos.Text = "Listar";
            this.cmdListarCultivos.UseVisualStyleBackColor = true;
            this.cmdListarCultivos.Click += new System.EventHandler(this.cmdListarCultivos_Click);
            // 
            // grillaCultivos
            // 
            this.grillaCultivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCultivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grillaCultivos.Location = new System.Drawing.Point(11, 11);
            this.grillaCultivos.Margin = new System.Windows.Forms.Padding(2);
            this.grillaCultivos.Name = "grillaCultivos";
            this.grillaCultivos.RowHeadersVisible = false;
            this.grillaCultivos.RowHeadersWidth = 51;
            this.grillaCultivos.RowTemplate.Height = 24;
            this.grillaCultivos.Size = new System.Drawing.Size(255, 122);
            this.grillaCultivos.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Cultivo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cultivo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // frmConsultaCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 183);
            this.Controls.Add(this.cmdLimpiarCultivos);
            this.Controls.Add(this.cmdListarCultivos);
            this.Controls.Add(this.grillaCultivos);
            this.Name = "frmConsultaCultivos";
            this.Text = "Consulta cultivos";
            ((System.ComponentModel.ISupportInitialize)(this.grillaCultivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLimpiarCultivos;
        private System.Windows.Forms.Button cmdListarCultivos;
        private System.Windows.Forms.DataGridView grillaCultivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}