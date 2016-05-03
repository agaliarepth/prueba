namespace gasolinera
{
    partial class FormPorTanque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPorTanque));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.horainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diassemanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dt_f2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_f1 = new System.Windows.Forms.DateTimePicker();
            this.turnosTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.turnosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horainicioDataGridViewTextBoxColumn,
            this.Column1,
            this.horafinDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.diassemanaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.turnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(407, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // horainicioDataGridViewTextBoxColumn
            // 
            this.horainicioDataGridViewTextBoxColumn.DataPropertyName = "hora_inicio";
            this.horainicioDataGridViewTextBoxColumn.HeaderText = "hora_inicio";
            this.horainicioDataGridViewTextBoxColumn.Name = "horainicioDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_turno";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // horafinDataGridViewTextBoxColumn
            // 
            this.horafinDataGridViewTextBoxColumn.DataPropertyName = "hora_fin";
            this.horafinDataGridViewTextBoxColumn.HeaderText = "hora_fin";
            this.horafinDataGridViewTextBoxColumn.Name = "horafinDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // diassemanaDataGridViewTextBoxColumn
            // 
            this.diassemanaDataGridViewTextBoxColumn.DataPropertyName = "dias_semana";
            this.diassemanaDataGridViewTextBoxColumn.HeaderText = "dias_semana";
            this.diassemanaDataGridViewTextBoxColumn.Name = "diassemanaDataGridViewTextBoxColumn";
            // 
            // turnosBindingSource
            // 
            this.turnosBindingSource.DataMember = "turnos";
            this.turnosBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // gasolineraDBDataSet
            // 
            this.gasolineraDBDataSet.DataSetName = "gasolineraDBDataSet";
            this.gasolineraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doble Click para Seleccionar";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(155, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Filtro por Fecha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dt_f2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dt_f1);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(86, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 54);
            this.panel3.TabIndex = 40;
            // 
            // dt_f2
            // 
            this.dt_f2.CustomFormat = "yyyy/MM/dd";
            this.dt_f2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_f2.Location = new System.Drawing.Point(150, 28);
            this.dt_f2.Name = "dt_f2";
            this.dt_f2.Size = new System.Drawing.Size(84, 20);
            this.dt_f2.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(2, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "De";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 21);
            this.button4.TabIndex = 32;
            this.button4.Text = "Filtrar Por Fechas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "A";
            // 
            // dt_f1
            // 
            this.dt_f1.CustomFormat = "yyyy/MM/dd";
            this.dt_f1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_f1.Location = new System.Drawing.Point(24, 28);
            this.dt_f1.Name = "dt_f1";
            this.dt_f1.Size = new System.Drawing.Size(89, 20);
            this.dt_f1.TabIndex = 28;
            // 
            // turnosTableAdapter
            // 
            this.turnosTableAdapter.ClearBeforeFill = true;
            // 
            // FormPorTanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 256);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPorTanque";
            this.Text = "Filtro por Turnos";
            this.Load += new System.EventHandler(this.FormPorTanque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dt_f2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_f1;
        private System.Windows.Forms.BindingSource turnosBindingSource;
        private gasolineraDBDataSetTableAdapters.turnosTableAdapter turnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diassemanaDataGridViewTextBoxColumn;
    }
}