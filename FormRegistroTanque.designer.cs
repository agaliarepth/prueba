namespace gasolinera
{
    partial class FormRegistroTanque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroTanque));
            this.label1 = new System.Windows.Forms.Label();
            this.codigo_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_nivel = new System.Windows.Forms.TextBox();
            this.cb_producto = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.capacidad_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unidad_cb = new System.Windows.Forms.ComboBox();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.productosTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.productosTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Tanque";
            // 
            // codigo_tb
            // 
            this.codigo_tb.Location = new System.Drawing.Point(129, 10);
            this.codigo_tb.MaxLength = 2;
            this.codigo_tb.Name = "codigo_tb";
            this.codigo_tb.Size = new System.Drawing.Size(61, 20);
            this.codigo_tb.TabIndex = 1;
            this.codigo_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_nivel);
            this.groupBox1.Controls.Add(this.cb_producto);
            this.groupBox1.Controls.Add(this.capacidad_tb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.unidad_cb);
            this.groupBox1.Location = new System.Drawing.Point(13, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Combustible";
            // 
            // tb_nivel
            // 
            this.tb_nivel.Location = new System.Drawing.Point(14, 86);
            this.tb_nivel.Name = "tb_nivel";
            this.tb_nivel.Size = new System.Drawing.Size(118, 20);
            this.tb_nivel.TabIndex = 29;
            this.tb_nivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nivel_KeyPress);
            // 
            // cb_producto
            // 
            this.cb_producto.DataSource = this.productosBindingSource;
            this.cb_producto.DisplayMember = "descripcion_producto";
            this.cb_producto.FormattingEnabled = true;
            this.cb_producto.Location = new System.Drawing.Point(14, 32);
            this.cb_producto.Name = "cb_producto";
            this.cb_producto.Size = new System.Drawing.Size(121, 21);
            this.cb_producto.TabIndex = 0;
            this.cb_producto.ValueMember = "id_producto";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // gasolineraDBDataSet
            // 
            this.gasolineraDBDataSet.DataSetName = "gasolineraDBDataSet";
            this.gasolineraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // capacidad_tb
            // 
            this.capacidad_tb.Location = new System.Drawing.Point(141, 86);
            this.capacidad_tb.Name = "capacidad_tb";
            this.capacidad_tb.Size = new System.Drawing.Size(118, 20);
            this.capacidad_tb.TabIndex = 7;
            this.capacidad_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capacidad_tb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nivel Critico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Capacidad";
            // 
            // unidad_cb
            // 
            this.unidad_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unidad_cb.FormattingEnabled = true;
            this.unidad_cb.IntegralHeight = false;
            this.unidad_cb.Items.AddRange(new object[] {
            "Lit",
            "Gal"});
            this.unidad_cb.Location = new System.Drawing.Point(151, 32);
            this.unidad_cb.Name = "unidad_cb";
            this.unidad_cb.Size = new System.Drawing.Size(102, 21);
            this.unidad_cb.TabIndex = 5;
            this.unidad_cb.TabStop = false;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Image = global::gasolinera.Properties.Resources.kcmx;
            this.cancelar_btn.Location = new System.Drawing.Point(154, 178);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(85, 48);
            this.cancelar_btn.TabIndex = 27;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // guardar_btn
            // 
            this.guardar_btn.Image = global::gasolinera.Properties.Resources.clean;
            this.guardar_btn.Location = new System.Drawing.Point(60, 178);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(85, 48);
            this.guardar_btn.TabIndex = 26;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormRegistroTanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(297, 273);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo_tb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistroTanque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro Tanque";
            this.Load += new System.EventHandler(this.FormRegistroTanque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigo_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox unidad_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capacidad_tb;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nivel;
        private System.Windows.Forms.ComboBox cb_producto;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private gasolineraDBDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider;
        
    }
}