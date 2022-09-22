namespace prySerafiniGiorgi_SP1
{
    partial class frmCultivos
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
            this.cmdCargarCultivo = new System.Windows.Forms.Button();
            this.txtCultivos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCodigoCultivo = new System.Windows.Forms.MaskedTextBox();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCargarCultivo
            // 
            this.cmdCargarCultivo.Enabled = false;
            this.cmdCargarCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarCultivo.Location = new System.Drawing.Point(174, 135);
            this.cmdCargarCultivo.Name = "cmdCargarCultivo";
            this.cmdCargarCultivo.Size = new System.Drawing.Size(75, 37);
            this.cmdCargarCultivo.TabIndex = 11;
            this.cmdCargarCultivo.Text = "Cargar";
            this.cmdCargarCultivo.UseVisualStyleBackColor = true;
            this.cmdCargarCultivo.Click += new System.EventHandler(this.cmdCargarLoc_Click);
            // 
            // txtCultivos
            // 
            this.txtCultivos.Location = new System.Drawing.Point(105, 52);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(144, 20);
            this.txtCultivos.TabIndex = 9;
            this.txtCultivos.TextChanged += new System.EventHandler(this.txtCultivos_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cultivos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingreso de cultivos";
            // 
            // mskCodigoCultivo
            // 
            this.mskCodigoCultivo.Enabled = false;
            this.mskCodigoCultivo.Location = new System.Drawing.Point(105, 88);
            this.mskCodigoCultivo.Mask = "99999";
            this.mskCodigoCultivo.Name = "mskCodigoCultivo";
            this.mskCodigoCultivo.Size = new System.Drawing.Size(144, 20);
            this.mskCodigoCultivo.TabIndex = 12;
            this.mskCodigoCultivo.ValidatingType = typeof(int);
            this.mskCodigoCultivo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCodigoCultivo_MaskInputRejected);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdLimpiar.Location = new System.Drawing.Point(11, 135);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 37);
            this.cmdLimpiar.TabIndex = 13;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 183);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.mskCodigoCultivo);
            this.Controls.Add(this.cmdCargarCultivo);
            this.Controls.Add(this.txtCultivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCultivos";
            this.Text = "Cultivos";
            this.Load += new System.EventHandler(this.frmCultivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCargarCultivo;
        private System.Windows.Forms.TextBox txtCultivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCodigoCultivo;
        private System.Windows.Forms.Button cmdLimpiar;
    }
}