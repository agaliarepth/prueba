namespace gasolinera
{
    partial class FormCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salir_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newCliente_btn = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.clientesTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.clientesTableAdapter();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numplacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisplacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreclienteDataGridViewTextBoxColumn,
            this.Column1,
            this.apellidoclienteDataGridViewTextBoxColumn,
            this.telefonoclienteDataGridViewTextBoxColumn,
            this.direccionclienteDataGridViewTextBoxColumn,
            this.numplacaDataGridViewTextBoxColumn,
            this.paisplacaDataGridViewTextBoxColumn,
            this.cinitDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(914, 318);
            this.dataGridView1.TabIndex = 2;
            // 
            // salir_btn
            // 
            this.salir_btn.Image = global::gasolinera.Properties.Resources.exit1;
            this.salir_btn.Location = new System.Drawing.Point(502, 327);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(75, 66);
            this.salir_btn.TabIndex = 14;
            this.salir_btn.Text = "Salir";
            this.salir_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salir_btn.UseVisualStyleBackColor = true;
            this.salir_btn.Click += new System.EventHandler(this.salir_btn_Click);
            // 
            // button3
            // 
            this.button3.Image = global::gasolinera.Properties.Resources.db;
            this.button3.Location = new System.Drawing.Point(421, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 66);
            this.button3.TabIndex = 12;
            this.button3.Text = "Actualizar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::gasolinera.Properties.Resources.dbmin;
            this.button2.Location = new System.Drawing.Point(343, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 66);
            this.button2.TabIndex = 11;
            this.button2.Text = "Eliminar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newCliente_btn
            // 
            this.newCliente_btn.Image = global::gasolinera.Properties.Resources.dbplus21;
            this.newCliente_btn.Location = new System.Drawing.Point(262, 327);
            this.newCliente_btn.Name = "newCliente_btn";
            this.newCliente_btn.Size = new System.Drawing.Size(75, 66);
            this.newCliente_btn.TabIndex = 10;
            this.newCliente_btn.Text = "Adicionar";
            this.newCliente_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newCliente_btn.UseVisualStyleBackColor = true;
            this.newCliente_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // gasolineraDBDataSet
            // 
            this.gasolineraDBDataSet.DataSetName = "gasolineraDBDataSet";
            this.gasolineraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreclienteDataGridViewTextBoxColumn.Width = 120;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_cliente";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // apellidoclienteDataGridViewTextBoxColumn
            // 
            this.apellidoclienteDataGridViewTextBoxColumn.DataPropertyName = "apellido_cliente";
            this.apellidoclienteDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidoclienteDataGridViewTextBoxColumn.Name = "apellidoclienteDataGridViewTextBoxColumn";
            this.apellidoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoclienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonoclienteDataGridViewTextBoxColumn
            // 
            this.telefonoclienteDataGridViewTextBoxColumn.DataPropertyName = "telefono_cliente";
            this.telefonoclienteDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoclienteDataGridViewTextBoxColumn.Name = "telefonoclienteDataGridViewTextBoxColumn";
            this.telefonoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoclienteDataGridViewTextBoxColumn.Width = 75;
            // 
            // direccionclienteDataGridViewTextBoxColumn
            // 
            this.direccionclienteDataGridViewTextBoxColumn.DataPropertyName = "direccion_cliente";
            this.direccionclienteDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionclienteDataGridViewTextBoxColumn.Name = "direccionclienteDataGridViewTextBoxColumn";
            this.direccionclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numplacaDataGridViewTextBoxColumn
            // 
            this.numplacaDataGridViewTextBoxColumn.DataPropertyName = "num_placa";
            this.numplacaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.numplacaDataGridViewTextBoxColumn.Name = "numplacaDataGridViewTextBoxColumn";
            this.numplacaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numplacaDataGridViewTextBoxColumn.Width = 75;
            // 
            // paisplacaDataGridViewTextBoxColumn
            // 
            this.paisplacaDataGridViewTextBoxColumn.DataPropertyName = "pais_placa";
            this.paisplacaDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisplacaDataGridViewTextBoxColumn.Name = "paisplacaDataGridViewTextBoxColumn";
            this.paisplacaDataGridViewTextBoxColumn.ReadOnly = true;
            this.paisplacaDataGridViewTextBoxColumn.Width = 75;
            // 
            // cinitDataGridViewTextBoxColumn
            // 
            this.cinitDataGridViewTextBoxColumn.DataPropertyName = "ci_nit";
            this.cinitDataGridViewTextBoxColumn.HeaderText = "CI/NIT";
            this.cinitDataGridViewTextBoxColumn.Name = "cinitDataGridViewTextBoxColumn";
            this.cinitDataGridViewTextBoxColumn.ReadOnly = true;
            this.cinitDataGridViewTextBoxColumn.Width = 75;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 40;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacionesDataGridViewTextBoxColumn.Width = 155;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 396);
            this.Controls.Add(this.salir_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newCliente_btn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCliente";
            this.Text = "Registro Clientes";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button salir_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button newCliente_btn;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private gasolineraDBDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numplacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisplacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
    }
}