namespace gasolinera
{
    partial class FormRegistroCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroCombustible));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_codigoComb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_descrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.cb_moneda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_unidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.guardarCombustible_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // tb_codigoComb
            // 
            this.tb_codigoComb.Location = new System.Drawing.Point(55, 13);
            this.tb_codigoComb.Name = "tb_codigoComb";
            this.tb_codigoComb.Size = new System.Drawing.Size(100, 20);
            this.tb_codigoComb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // tb_descrip
            // 
            this.tb_descrip.Location = new System.Drawing.Point(19, 60);
            this.tb_descrip.Name = "tb_descrip";
            this.tb_descrip.Size = new System.Drawing.Size(285, 20);
            this.tb_descrip.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(19, 104);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(121, 20);
            this.tb_precio.TabIndex = 5;
            // 
            // cb_moneda
            // 
            this.cb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_moneda.FormattingEnabled = true;
            this.cb_moneda.Items.AddRange(new object[] {
            "Bolivianos",
            "Dolares"});
            this.cb_moneda.Location = new System.Drawing.Point(183, 104);
            this.cb_moneda.Name = "cb_moneda";
            this.cb_moneda.Size = new System.Drawing.Size(121, 21);
            this.cb_moneda.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Moneda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unidad";
            // 
            // cb_unidad
            // 
            this.cb_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_unidad.FormattingEnabled = true;
            this.cb_unidad.Items.AddRange(new object[] {
            "Lit",
            "Gal"});
            this.cb_unidad.Location = new System.Drawing.Point(19, 147);
            this.cb_unidad.Name = "cb_unidad";
            this.cb_unidad.Size = new System.Drawing.Size(121, 21);
            this.cb_unidad.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Observaciones";
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(19, 191);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(285, 60);
            this.tb_obs.TabIndex = 13;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Image = global::gasolinera.Properties.Resources.kcmx;
            this.cancelar_btn.Location = new System.Drawing.Point(173, 257);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(85, 48);
            this.cancelar_btn.TabIndex = 46;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // guardarCombustible_btn
            // 
            this.guardarCombustible_btn.Image = global::gasolinera.Properties.Resources.clean;
            this.guardarCombustible_btn.Location = new System.Drawing.Point(82, 257);
            this.guardarCombustible_btn.Name = "guardarCombustible_btn";
            this.guardarCombustible_btn.Size = new System.Drawing.Size(85, 48);
            this.guardarCombustible_btn.TabIndex = 45;
            this.guardarCombustible_btn.Text = "Guardar";
            this.guardarCombustible_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarCombustible_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardarCombustible_btn.UseVisualStyleBackColor = true;
            this.guardarCombustible_btn.Click += new System.EventHandler(this.guardarCombustible_btn_Click);
            // 
            // FormRegistroCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 305);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.guardarCombustible_btn);
            this.Controls.Add(this.tb_obs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_unidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_moneda);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_descrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_codigoComb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistroCombustible";
            this.Text = "Registro Combustible";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_codigoComb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_descrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.ComboBox cb_moneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_unidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button guardarCombustible_btn;
    }
}