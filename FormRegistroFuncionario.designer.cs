namespace gasolinera
{
    partial class FormRegistroFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroFuncionario));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cb_tipo = new System.Windows.Forms.TabPage();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_sueldo = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_obs = new System.Windows.Forms.TextBox();
            this.tb_dir = new System.Windows.Forms.TextBox();
            this.tb_cinit = new System.Windows.Forms.TextBox();
            this.tb_telf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.cb_tipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cb_tipo
            // 
            this.cb_tipo.BackColor = System.Drawing.Color.Transparent;
            this.cb_tipo.Controls.Add(this.tb_tipo);
            this.cb_tipo.Controls.Add(this.tb_pass);
            this.cb_tipo.Controls.Add(this.tb_username);
            this.cb_tipo.Controls.Add(this.tb_sueldo);
            this.cb_tipo.Controls.Add(this.tb_id);
            this.cb_tipo.Controls.Add(this.tb_nombre);
            this.cb_tipo.Controls.Add(this.tb_obs);
            this.cb_tipo.Controls.Add(this.tb_dir);
            this.cb_tipo.Controls.Add(this.tb_cinit);
            this.cb_tipo.Controls.Add(this.tb_telf);
            this.cb_tipo.Controls.Add(this.label11);
            this.cb_tipo.Controls.Add(this.label10);
            this.cb_tipo.Controls.Add(this.label7);
            this.cb_tipo.Controls.Add(this.label5);
            this.cb_tipo.Controls.Add(this.button3);
            this.cb_tipo.Controls.Add(this.label1);
            this.cb_tipo.Controls.Add(this.button4);
            this.cb_tipo.Controls.Add(this.button5);
            this.cb_tipo.Controls.Add(this.label2);
            this.cb_tipo.Controls.Add(this.label9);
            this.cb_tipo.Controls.Add(this.pb_foto);
            this.cb_tipo.Controls.Add(this.label4);
            this.cb_tipo.Controls.Add(this.label8);
            this.cb_tipo.Controls.Add(this.label6);
            this.cb_tipo.Location = new System.Drawing.Point(4, 22);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Padding = new System.Windows.Forms.Padding(3);
            this.cb_tipo.Size = new System.Drawing.Size(468, 441);
            this.cb_tipo.TabIndex = 0;
            this.cb_tipo.Text = "Datos Personales";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(256, 227);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(199, 20);
            this.tb_pass.TabIndex = 32;
            this.tb_pass.Validating += new System.ComponentModel.CancelEventHandler(this.tb_pass_Validating);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 228);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(211, 20);
            this.tb_username.TabIndex = 30;
            this.tb_username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_username_Validating);
            // 
            // tb_sueldo
            // 
            this.tb_sueldo.Location = new System.Drawing.Point(123, 183);
            this.tb_sueldo.Name = "tb_sueldo";
            this.tb_sueldo.Size = new System.Drawing.Size(100, 20);
            this.tb_sueldo.TabIndex = 28;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(58, 11);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 1;
            this.tb_id.Validating += new System.ComponentModel.CancelEventHandler(this.tb_id_Validating);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(6, 69);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(449, 20);
            this.tb_nombre.TabIndex = 3;
            this.tb_nombre.Validating += new System.ComponentModel.CancelEventHandler(this.tb_nombre_Validating);
            // 
            // tb_obs
            // 
            this.tb_obs.Location = new System.Drawing.Point(9, 268);
            this.tb_obs.Multiline = true;
            this.tb_obs.Name = "tb_obs";
            this.tb_obs.Size = new System.Drawing.Size(345, 116);
            this.tb_obs.TabIndex = 20;
            // 
            // tb_dir
            // 
            this.tb_dir.Location = new System.Drawing.Point(6, 125);
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.Size = new System.Drawing.Size(217, 20);
            this.tb_dir.TabIndex = 7;
            // 
            // tb_cinit
            // 
            this.tb_cinit.Location = new System.Drawing.Point(256, 124);
            this.tb_cinit.Name = "tb_cinit";
            this.tb_cinit.Size = new System.Drawing.Size(199, 20);
            this.tb_cinit.TabIndex = 9;
            // 
            // tb_telf
            // 
            this.tb_telf.Location = new System.Drawing.Point(6, 184);
            this.tb_telf.Name = "tb_telf";
            this.tb_telf.Size = new System.Drawing.Size(100, 20);
            this.tb_telf.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Contraseña";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Nombre de Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Sueldo Basico (Bs)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ci o Nit";
            // 
            // button3
            // 
            this.button3.Image = global::gasolinera.Properties.Resources.search;
            this.button3.Location = new System.Drawing.Point(357, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 27);
            this.button3.TabIndex = 26;
            this.button3.Text = "Explorar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // button4
            // 
            this.button4.Image = global::gasolinera.Properties.Resources.kcmx;
            this.button4.Location = new System.Drawing.Point(222, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 48);
            this.button4.TabIndex = 25;
            this.button4.Text = "Cancelar";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = global::gasolinera.Properties.Resources.clean;
            this.button5.Location = new System.Drawing.Point(131, 388);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 48);
            this.button5.TabIndex = 24;
            this.button5.Text = "Guardar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Completo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Obsevaciones";
            // 
            // pb_foto
            // 
            this.pb_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Image = global::gasolinera.Properties.Resources.empty_user;
            this.pb_foto.Location = new System.Drawing.Point(357, 268);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(98, 98);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_foto.TabIndex = 18;
            this.pb_foto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Puesto que desempeña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cb_tipo);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 467);
            this.tabControl1.TabIndex = 27;
            // 
            // tb_tipo
            // 
            this.tb_tipo.Location = new System.Drawing.Point(259, 183);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(196, 20);
            this.tb_tipo.TabIndex = 33;
            // 
            // FormRegistroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 477);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.cb_tipo.ResumeLayout(false);
            this.cb_tipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cb_tipo;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_sueldo;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_obs;
        private System.Windows.Forms.TextBox tb_dir;
        private System.Windows.Forms.TextBox tb_cinit;
        private System.Windows.Forms.TextBox tb_telf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tipo;
    }
}