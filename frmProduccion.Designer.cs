namespace prySerafiniGiorgi_SP1
{
    partial class frmProduccion
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
            this.cmdCargarProduccion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.lstCultivos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmdCargarProduccion
            // 
            this.cmdCargarProduccion.Enabled = false;
            this.cmdCargarProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarProduccion.Location = new System.Drawing.Point(216, 213);
            this.cmdCargarProduccion.Name = "cmdCargarProduccion";
            this.cmdCargarProduccion.Size = new System.Drawing.Size(73, 28);
            this.cmdCargarProduccion.TabIndex = 11;
            this.cmdCargarProduccion.Text = "Cargar";
            this.cmdCargarProduccion.UseVisualStyleBackColor = true;
            this.cmdCargarProduccion.Click += new System.EventHandler(this.cmdCargarLoc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cultivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = " Localidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingreso de Toneladas";
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(89, 91);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(200, 21);
            this.lstLocalidad.TabIndex = 12;
            this.lstLocalidad.SelectedIndexChanged += new System.EventHandler(this.lstLocalidad_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Toneladas";
            // 
            // txtToneladas
            // 
            this.txtToneladas.Enabled = false;
            this.txtToneladas.Location = new System.Drawing.Point(89, 170);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(200, 20);
            this.txtToneladas.TabIndex = 15;
            this.txtToneladas.TextChanged += new System.EventHandler(this.txtToneladas_TextChanged);
            // 
            // lstCultivos
            // 
            this.lstCultivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivos.Enabled = false;
            this.lstCultivos.FormattingEnabled = true;
            this.lstCultivos.Location = new System.Drawing.Point(89, 134);
            this.lstCultivos.Name = "lstCultivos";
            this.lstCultivos.Size = new System.Drawing.Size(200, 21);
            this.lstCultivos.TabIndex = 16;
            this.lstCultivos.SelectedIndexChanged += new System.EventHandler(this.lstCultivos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 270);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstCultivos);
            this.Controls.Add(this.txtToneladas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.cmdCargarProduccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProduccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCargarProduccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.ComboBox lstCultivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}