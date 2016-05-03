namespace gasolinera
{
    partial class FormCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_doc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tanque = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tanquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lb_total = new System.Windows.Forms.Label();
            this.productosTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.productosTableAdapter();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.clientesTableAdapter();
            this.bombasTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.bombasTableAdapter();
            this.tanquesTableAdapter1 = new gasolinera.gasolineraDBDataSetTableAdapters.tanquesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribuidor";
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Image = global::gasolinera.Properties.Resources.kcmx;
            this.cancelar_btn.Location = new System.Drawing.Point(192, 344);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(85, 48);
            this.cancelar_btn.TabIndex = 29;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // guardar_btn
            // 
            this.guardar_btn.Image = global::gasolinera.Properties.Resources.clean;
            this.guardar_btn.Location = new System.Drawing.Point(98, 344);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(85, 48);
            this.guardar_btn.TabIndex = 28;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(6, 42);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.ReadOnly = true;
            this.tb_nom.Size = new System.Drawing.Size(252, 20);
            this.tb_nom.TabIndex = 30;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha.Location = new System.Drawing.Point(321, 42);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(146, 20);
            this.dt_fecha.TabIndex = 31;
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
            // panel2
            // 
            this.panel2.BackgroundImage = global::gasolinera.Properties.Resources.bg;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.lb_total);
            this.panel2.Controls.Add(this.cancelar_btn);
            this.panel2.Controls.Add(this.guardar_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 395);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(521, 52);
            this.label5.TabIndex = 40;
            this.label5.Text = "COMPRA DE COMBUSTIBLE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_tipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_doc);
            this.groupBox1.Controls.Add(this.tb_nom);
            this.groupBox1.Controls.Add(this.dt_fecha);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 121);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(264, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 42;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tipo Documento";
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Factura",
            "Recibo",
            "Nota de entrega",
            "Not de Venta",
            "Pagare",
            "Papel"});
            this.cb_tipo.Location = new System.Drawing.Point(9, 79);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Numero Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha";
            // 
            // tb_doc
            // 
            this.tb_doc.Location = new System.Drawing.Point(177, 80);
            this.tb_doc.Name = "tb_doc";
            this.tb_doc.Size = new System.Drawing.Size(114, 20);
            this.tb_doc.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tanque,
            this.descripcion,
            this.stock,
            this.precio_producto,
            this.cantidad_prod,
            this.monto_total});
            this.dataGridView1.Location = new System.Drawing.Point(15, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(561, 150);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit_1);
            // 
            // tanque
            // 
            this.tanque.AutoComplete = false;
            this.tanque.DataSource = this.tanquesBindingSource;
            this.tanque.DisplayMember = "num_tanque";
            this.tanque.HeaderText = "Tanque";
            this.tanque.Name = "tanque";
            this.tanque.ReadOnly = true;
            this.tanque.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tanque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tanque.ValueMember = "id_tanque";
            // 
            // tanquesBindingSource
            // 
            this.tanquesBindingSource.DataMember = "tanques";
            this.tanquesBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Nivel Actual";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // precio_producto
            // 
            this.precio_producto.HeaderText = "Precio";
            this.precio_producto.Name = "precio_producto";
            this.precio_producto.ReadOnly = true;
            this.precio_producto.Width = 70;
            // 
            // cantidad_prod
            // 
            this.cantidad_prod.HeaderText = "Cantidad";
            this.cantidad_prod.Name = "cantidad_prod";
            this.cantidad_prod.ReadOnly = true;
            this.cantidad_prod.Width = 70;
            // 
            // monto_total
            // 
            this.monto_total.HeaderText = "total";
            this.monto_total.Name = "monto_total";
            this.monto_total.ReadOnly = true;
            this.monto_total.Width = 70;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(582, 256);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 74);
            this.button6.TabIndex = 36;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(324, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Bs";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(582, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 73);
            this.button4.TabIndex = 35;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lb_total.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_total.Location = new System.Drawing.Point(358, 338);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(56, 24);
            this.lb_total.TabIndex = 35;
            this.lb_total.Text = "Total";
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // bombasTableAdapter
            // 
            this.bombasTableAdapter.ClearBeforeFill = true;
            // 
            // tanquesTableAdapter1
            // 
            this.tanquesTableAdapter1.ClearBeforeFill = true;
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 395);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompras";
            this.Text = "Registro Compras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Panel panel2;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private gasolineraDBDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_doc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private gasolineraDBDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private gasolineraDBDataSetTableAdapters.bombasTableAdapter bombasTableAdapter;
        private System.Windows.Forms.BindingSource tanquesBindingSource;
        private gasolineraDBDataSetTableAdapters.tanquesTableAdapter tanquesTableAdapter1;
        private System.Windows.Forms.DataGridViewComboBoxColumn tanque;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_total;
    }
}