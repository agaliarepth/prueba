namespace gasolinera
{
    partial class FormPorBomba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPorBomba));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbombaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nummanguerasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocombustibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bombasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bombasTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.bombasTableAdapter();
            this.dt_f1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_f2 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbombaDataGridViewTextBoxColumn,
            this.nummanguerasDataGridViewTextBoxColumn,
            this.tipocombustibleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bombasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(286, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idbombaDataGridViewTextBoxColumn
            // 
            this.idbombaDataGridViewTextBoxColumn.DataPropertyName = "id_bomba";
            this.idbombaDataGridViewTextBoxColumn.HeaderText = "NºBomba";
            this.idbombaDataGridViewTextBoxColumn.Name = "idbombaDataGridViewTextBoxColumn";
            this.idbombaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idbombaDataGridViewTextBoxColumn.Width = 70;
            // 
            // nummanguerasDataGridViewTextBoxColumn
            // 
            this.nummanguerasDataGridViewTextBoxColumn.DataPropertyName = "num_mangueras";
            this.nummanguerasDataGridViewTextBoxColumn.HeaderText = "Mangueras";
            this.nummanguerasDataGridViewTextBoxColumn.Name = "nummanguerasDataGridViewTextBoxColumn";
            this.nummanguerasDataGridViewTextBoxColumn.ReadOnly = true;
            this.nummanguerasDataGridViewTextBoxColumn.Width = 70;
            // 
            // tipocombustibleDataGridViewTextBoxColumn
            // 
            this.tipocombustibleDataGridViewTextBoxColumn.DataPropertyName = "tipo_combustible";
            this.tipocombustibleDataGridViewTextBoxColumn.HeaderText = "Ccombustible";
            this.tipocombustibleDataGridViewTextBoxColumn.Name = "tipocombustibleDataGridViewTextBoxColumn";
            this.tipocombustibleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bombasBindingSource
            // 
            this.bombasBindingSource.DataMember = "bombas";
            this.bombasBindingSource.DataSource = this.gasolineraDBDataSet;
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
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doble Click para Seleccionar";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(102, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Filtro por Fecha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bombasTableAdapter
            // 
            this.bombasTableAdapter.ClearBeforeFill = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "A";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "De";
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
            this.panel3.Location = new System.Drawing.Point(36, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 54);
            this.panel3.TabIndex = 38;
            // 
            // FormPorBomba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPorBomba";
            this.Text = "Filtro Bombas";
            this.Load += new System.EventHandler(this.FormPorBomba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private System.Windows.Forms.BindingSource bombasBindingSource;
        private gasolineraDBDataSetTableAdapters.bombasTableAdapter bombasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbombaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nummanguerasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocombustibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dt_f1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_f2;
        private System.Windows.Forms.Panel panel3;
    }
}