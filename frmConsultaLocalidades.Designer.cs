namespace prySerafiniGiorgi_SP1
{
    partial class frmConsultaLocalidades
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
            this.cmdListar = new System.Windows.Forms.Button();
            this.grillaLocalidad = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLocalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(11, 151);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(100, 23);
            this.cmdLimpiar.TabIndex = 8;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(166, 151);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(100, 23);
            this.cmdListar.TabIndex = 7;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // grillaLocalidad
            // 
            this.grillaLocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaLocalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grillaLocalidad.Location = new System.Drawing.Point(11, 11);
            this.grillaLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.grillaLocalidad.Name = "grillaLocalidad";
            this.grillaLocalidad.RowHeadersVisible = false;
            this.grillaLocalidad.RowHeadersWidth = 51;
            this.grillaLocalidad.RowTemplate.Height = 24;
            this.grillaLocalidad.Size = new System.Drawing.Size(255, 122);
            this.grillaLocalidad.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Localidad";
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
            // frmConsultaLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 178);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.grillaLocalidad);
            this.Name = "frmConsultaLocalidades";
            this.Text = "frmConsultaLocalidades";
            this.Load += new System.EventHandler(this.frmConsultaLocalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaLocalidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridView grillaLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}