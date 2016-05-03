namespace gasolinera
{
    partial class FormConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_llave = new System.Windows.Forms.TextBox();
            this.tb_auto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_fechaLimite = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_nit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.guardarConfig_btn = new System.Windows.Forms.Button();
            this.tb_en1 = new System.Windows.Forms.TextBox();
            this.tb_en2 = new System.Windows.Forms.TextBox();
            this.tb_en3 = new System.Windows.Forms.TextBox();
            this.tb_en4 = new System.Windows.Forms.TextBox();
            this.tb_pie1 = new System.Windows.Forms.TextBox();
            this.tb_pie2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Llave de Dosificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de Autorizacion";
            // 
            // tb_llave
            // 
            this.tb_llave.Location = new System.Drawing.Point(6, 76);
            this.tb_llave.Name = "tb_llave";
            this.tb_llave.Size = new System.Drawing.Size(449, 20);
            this.tb_llave.TabIndex = 4;
            // 
            // tb_auto
            // 
            this.tb_auto.Location = new System.Drawing.Point(6, 116);
            this.tb_auto.Name = "tb_auto";
            this.tb_auto.Size = new System.Drawing.Size(449, 20);
            this.tb_auto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Limite de Facturacion";
            // 
            // dt_fechaLimite
            // 
            this.dt_fechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechaLimite.Location = new System.Drawing.Point(180, 135);
            this.dt_fechaLimite.Name = "dt_fechaLimite";
            this.dt_fechaLimite.Size = new System.Drawing.Size(83, 20);
            this.dt_fechaLimite.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_pie2);
            this.groupBox1.Controls.Add(this.tb_pie1);
            this.groupBox1.Controls.Add(this.tb_en4);
            this.groupBox1.Controls.Add(this.tb_en3);
            this.groupBox1.Controls.Add(this.tb_en2);
            this.groupBox1.Controls.Add(this.tb_en1);
            this.groupBox1.Controls.Add(this.tb_nit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dt_fechaLimite);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_llave);
            this.groupBox1.Controls.Add(this.tb_auto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 414);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Para Facturar";
            // 
            // tb_nit
            // 
            this.tb_nit.Location = new System.Drawing.Point(9, 37);
            this.tb_nit.Name = "tb_nit";
            this.tb_nit.Size = new System.Drawing.Size(138, 20);
            this.tb_nit.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(11, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "NIT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(11, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pie de Factura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(8, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Encabezado de Factura";
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Image = global::gasolinera.Properties.Resources.kcmx;
            this.cancelar_btn.Location = new System.Drawing.Point(230, 469);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(85, 48);
            this.cancelar_btn.TabIndex = 44;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // guardarConfig_btn
            // 
            this.guardarConfig_btn.Image = global::gasolinera.Properties.Resources.clean;
            this.guardarConfig_btn.Location = new System.Drawing.Point(139, 469);
            this.guardarConfig_btn.Name = "guardarConfig_btn";
            this.guardarConfig_btn.Size = new System.Drawing.Size(85, 48);
            this.guardarConfig_btn.TabIndex = 43;
            this.guardarConfig_btn.Text = "Guardar";
            this.guardarConfig_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarConfig_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardarConfig_btn.UseVisualStyleBackColor = true;
            this.guardarConfig_btn.Click += new System.EventHandler(this.guardar);
            // 
            // tb_en1
            // 
            this.tb_en1.Location = new System.Drawing.Point(11, 183);
            this.tb_en1.MaxLength = 49;
            this.tb_en1.Name = "tb_en1";
            this.tb_en1.Size = new System.Drawing.Size(444, 20);
            this.tb_en1.TabIndex = 14;
            // 
            // tb_en2
            // 
            this.tb_en2.Location = new System.Drawing.Point(42, 210);
            this.tb_en2.MaxLength = 49;
            this.tb_en2.Name = "tb_en2";
            this.tb_en2.Size = new System.Drawing.Size(396, 20);
            this.tb_en2.TabIndex = 15;
            // 
            // tb_en3
            // 
            this.tb_en3.Location = new System.Drawing.Point(53, 237);
            this.tb_en3.MaxLength = 49;
            this.tb_en3.Name = "tb_en3";
            this.tb_en3.Size = new System.Drawing.Size(373, 20);
            this.tb_en3.TabIndex = 16;
            // 
            // tb_en4
            // 
            this.tb_en4.Location = new System.Drawing.Point(110, 264);
            this.tb_en4.MaxLength = 49;
            this.tb_en4.Name = "tb_en4";
            this.tb_en4.Size = new System.Drawing.Size(176, 20);
            this.tb_en4.TabIndex = 17;
            // 
            // tb_pie1
            // 
            this.tb_pie1.Location = new System.Drawing.Point(11, 344);
            this.tb_pie1.MaxLength = 49;
            this.tb_pie1.Name = "tb_pie1";
            this.tb_pie1.Size = new System.Drawing.Size(415, 20);
            this.tb_pie1.TabIndex = 18;
            // 
            // tb_pie2
            // 
            this.tb_pie2.Location = new System.Drawing.Point(33, 371);
            this.tb_pie2.MaxLength = 49;
            this.tb_pie2.Name = "tb_pie2";
            this.tb_pie2.Size = new System.Drawing.Size(362, 20);
            this.tb_pie2.TabIndex = 19;
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 592);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.guardarConfig_btn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfiguracion";
            this.Text = "Configuracion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_llave;
        private System.Windows.Forms.TextBox tb_auto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_fechaLimite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button guardarConfig_btn;
        private System.Windows.Forms.TextBox tb_nit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_pie2;
        private System.Windows.Forms.TextBox tb_pie1;
        private System.Windows.Forms.TextBox tb_en4;
        private System.Windows.Forms.TextBox tb_en3;
        private System.Windows.Forms.TextBox tb_en2;
        private System.Windows.Forms.TextBox tb_en1;

    }
}