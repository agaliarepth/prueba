namespace gasolinera
{
    partial class FormRegistroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroCliente));
            this.label10 = new System.Windows.Forms.Label();
            this.tb_observaciones = new System.Windows.Forms.TextBox();
            this.cb_pais = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_numPlaca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_mujer = new System.Windows.Forms.RadioButton();
            this.rb_hombre = new System.Windows.Forms.RadioButton();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ci = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.guardarCliente_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Observaciones";
            // 
            // tb_observaciones
            // 
            this.tb_observaciones.Location = new System.Drawing.Point(10, 210);
            this.tb_observaciones.Multiline = true;
            this.tb_observaciones.Name = "tb_observaciones";
            this.tb_observaciones.Size = new System.Drawing.Size(534, 92);
            this.tb_observaciones.TabIndex = 48;
            // 
            // cb_pais
            // 
            this.cb_pais.FormattingEnabled = true;
            this.cb_pais.Items.AddRange(new object[] {
            "Bolivia",
            "Chile",
            "Peru",
            "Colombia",
            "Argentina",
            "Brasil",
            "Ecuador",
            "Paraguay",
            "Uruguay",
            "Venezuela",
            "Costa Rica",
            "Estados Unidos"});
            this.cb_pais.Location = new System.Drawing.Point(442, 151);
            this.cb_pais.Name = "cb_pais";
            this.cb_pais.Size = new System.Drawing.Size(102, 21);
            this.cb_pais.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Pais";
            // 
            // tb_numPlaca
            // 
            this.tb_numPlaca.Location = new System.Drawing.Point(282, 153);
            this.tb_numPlaca.Name = "tb_numPlaca";
            this.tb_numPlaca.Size = new System.Drawing.Size(145, 20);
            this.tb_numPlaca.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Numero Placa";
            // 
            // rb_mujer
            // 
            this.rb_mujer.AutoSize = true;
            this.rb_mujer.Location = new System.Drawing.Point(80, 153);
            this.rb_mujer.Name = "rb_mujer";
            this.rb_mujer.Size = new System.Drawing.Size(51, 17);
            this.rb_mujer.TabIndex = 39;
            this.rb_mujer.TabStop = true;
            this.rb_mujer.Text = "Mujer";
            this.rb_mujer.UseVisualStyleBackColor = true;
            // 
            // rb_hombre
            // 
            this.rb_hombre.AutoSize = true;
            this.rb_hombre.Location = new System.Drawing.Point(12, 153);
            this.rb_hombre.Name = "rb_hombre";
            this.rb_hombre.Size = new System.Drawing.Size(62, 17);
            this.rb_hombre.TabIndex = 38;
            this.rb_hombre.TabStop = true;
            this.rb_hombre.Text = "Hombre";
            this.rb_hombre.UseVisualStyleBackColor = true;
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(107, 110);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(169, 20);
            this.tb_telefono.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Sexo ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Telefono / Celular";
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(282, 110);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(260, 20);
            this.tb_direccion.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Direccion";
            // 
            // tb_ci
            // 
            this.tb_ci.Location = new System.Drawing.Point(12, 110);
            this.tb_ci.Name = "tb_ci";
            this.tb_ci.Size = new System.Drawing.Size(87, 20);
            this.tb_ci.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "CI /NIT";
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(282, 71);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(260, 20);
            this.tb_apellido.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Apellido";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(12, 71);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(264, 20);
            this.tb_nombre.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombres";
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Image = global::gasolinera.Properties.Resources.kcmx;
            this.cancelar_btn.Location = new System.Drawing.Point(284, 322);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(85, 48);
            this.cancelar_btn.TabIndex = 42;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // guardarCliente_btn
            // 
            this.guardarCliente_btn.Image = global::gasolinera.Properties.Resources.clean;
            this.guardarCliente_btn.Location = new System.Drawing.Point(193, 322);
            this.guardarCliente_btn.Name = "guardarCliente_btn";
            this.guardarCliente_btn.Size = new System.Drawing.Size(85, 48);
            this.guardarCliente_btn.TabIndex = 41;
            this.guardarCliente_btn.Text = "Guardar";
            this.guardarCliente_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarCliente_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardarCliente_btn.UseVisualStyleBackColor = true;
            this.guardarCliente_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 405);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_observaciones);
            this.Controls.Add(this.cb_pais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_numPlaca);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.guardarCliente_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rb_mujer);
            this.Controls.Add(this.rb_hombre);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistroCliente";
            this.Text = "Registro Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_observaciones;
        private System.Windows.Forms.ComboBox cb_pais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_numPlaca;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button guardarCliente_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_mujer;
        private System.Windows.Forms.RadioButton rb_hombre;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label1;
    }
}