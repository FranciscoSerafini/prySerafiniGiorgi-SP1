namespace prySerafiniGiorgi_SP1
{
    partial class frmLocalidades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.cmdCargarLoc = new System.Windows.Forms.Button();
            this.mskCodigoLocalidad = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de localidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Localidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificacion";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(89, 50);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(120, 20);
            this.txtLocalidad.TabIndex = 3;
            this.txtLocalidad.TextChanged += new System.EventHandler(this.txtLocalidad_TextChanged);
            // 
            // cmdCargarLoc
            // 
            this.cmdCargarLoc.Enabled = false;
            this.cmdCargarLoc.Location = new System.Drawing.Point(16, 132);
            this.cmdCargarLoc.Name = "cmdCargarLoc";
            this.cmdCargarLoc.Size = new System.Drawing.Size(75, 23);
            this.cmdCargarLoc.TabIndex = 5;
            this.cmdCargarLoc.Text = "Cargar";
            this.cmdCargarLoc.UseVisualStyleBackColor = true;
            this.cmdCargarLoc.Click += new System.EventHandler(this.cmdCargarLoc_Click);
            // 
            // mskCodigoLocalidad
            // 
            this.mskCodigoLocalidad.Enabled = false;
            this.mskCodigoLocalidad.Location = new System.Drawing.Point(89, 88);
            this.mskCodigoLocalidad.Mask = "99999";
            this.mskCodigoLocalidad.Name = "mskCodigoLocalidad";
            this.mskCodigoLocalidad.Size = new System.Drawing.Size(120, 20);
            this.mskCodigoLocalidad.TabIndex = 6;
            this.mskCodigoLocalidad.ValidatingType = typeof(int);
            this.mskCodigoLocalidad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCodigoLocalidad_MaskInputRejected);
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 181);
            this.Controls.Add(this.mskCodigoLocalidad);
            this.Controls.Add(this.cmdCargarLoc);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLocalidades";
            this.Text = "Localidades";
            this.Load += new System.EventHandler(this.frmLocalidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Button cmdCargarLoc;
        private System.Windows.Forms.MaskedTextBox mskCodigoLocalidad;
    }
}