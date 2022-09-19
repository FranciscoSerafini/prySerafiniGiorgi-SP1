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
            this.cmdCargarCult = new System.Windows.Forms.Button();
            this.txtCultivos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCodigoCultivo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cmdCargarCult
            // 
            this.cmdCargarCult.Enabled = false;
            this.cmdCargarCult.Location = new System.Drawing.Point(12, 131);
            this.cmdCargarCult.Name = "cmdCargarCult";
            this.cmdCargarCult.Size = new System.Drawing.Size(75, 23);
            this.cmdCargarCult.TabIndex = 11;
            this.cmdCargarCult.Text = "Cargar";
            this.cmdCargarCult.UseVisualStyleBackColor = true;
            this.cmdCargarCult.Click += new System.EventHandler(this.cmdCargarLoc_Click);
            // 
            // txtCultivos
            // 
            this.txtCultivos.Location = new System.Drawing.Point(71, 50);
            this.txtCultivos.Name = "txtCultivos";
            this.txtCultivos.Size = new System.Drawing.Size(134, 20);
            this.txtCultivos.TabIndex = 9;
            this.txtCultivos.TextChanged += new System.EventHandler(this.txtCultivos_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cultivos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingreso de cultivos";
            // 
            // mskCodigoCultivo
            // 
            this.mskCodigoCultivo.Enabled = false;
            this.mskCodigoCultivo.Location = new System.Drawing.Point(85, 88);
            this.mskCodigoCultivo.Mask = "99999";
            this.mskCodigoCultivo.Name = "mskCodigoCultivo";
            this.mskCodigoCultivo.Size = new System.Drawing.Size(119, 20);
            this.mskCodigoCultivo.TabIndex = 12;
            this.mskCodigoCultivo.ValidatingType = typeof(int);
            this.mskCodigoCultivo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCodigoCultivo_MaskInputRejected);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 183);
            this.Controls.Add(this.mskCodigoCultivo);
            this.Controls.Add(this.cmdCargarCult);
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

        private System.Windows.Forms.Button cmdCargarCult;
        private System.Windows.Forms.TextBox txtCultivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCodigoCultivo;
    }
}