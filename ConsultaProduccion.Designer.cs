namespace prySerafiniGiorgi_SP1
{
    partial class frmConsultaProduccion
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
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdListarProduciones = new System.Windows.Forms.Button();
            this.grillaProduccion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(12, 138);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(154, 23);
            this.cmdLimpiar.TabIndex = 8;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            // 
            // cmdListarProduciones
            // 
            this.cmdListarProduciones.Location = new System.Drawing.Point(355, 141);
            this.cmdListarProduciones.Name = "cmdListarProduciones";
            this.cmdListarProduciones.Size = new System.Drawing.Size(154, 23);
            this.cmdListarProduciones.TabIndex = 7;
            this.cmdListarProduciones.Text = "Listar";
            this.cmdListarProduciones.UseVisualStyleBackColor = true;
            this.cmdListarProduciones.Click += new System.EventHandler(this.cmdListarProduciones_Click);
            // 
            // grillaProduccion
            // 
            this.grillaProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grillaProduccion.Location = new System.Drawing.Point(11, 11);
            this.grillaProduccion.Margin = new System.Windows.Forms.Padding(2);
            this.grillaProduccion.Name = "grillaProduccion";
            this.grillaProduccion.RowHeadersVisible = false;
            this.grillaProduccion.RowHeadersWidth = 51;
            this.grillaProduccion.RowTemplate.Height = 24;
            this.grillaProduccion.Size = new System.Drawing.Size(505, 122);
            this.grillaProduccion.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Localidad";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cultivo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // frmConsultaProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 176);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdListarProduciones);
            this.Controls.Add(this.grillaProduccion);
            this.Name = "frmConsultaProduccion";
            this.Text = "Consulta produccion";
            ((System.ComponentModel.ISupportInitialize)(this.grillaProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdListarProduciones;
        private System.Windows.Forms.DataGridView grillaProduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}