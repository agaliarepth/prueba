namespace gasolinera
{
    partial class FormPorDistri
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iddistribuidorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredistriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidodistriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcciondistriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentabancariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distribuidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.distribuidoresTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.distribuidoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Doble Click para Seleccionar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddistribuidorDataGridViewTextBoxColumn,
            this.nombredistriDataGridViewTextBoxColumn,
            this.apellidodistriDataGridViewTextBoxColumn,
            this.direcciondistriDataGridViewTextBoxColumn,
            this.razonsocialDataGridViewTextBoxColumn,
            this.cinitDataGridViewTextBoxColumn,
            this.cuentabancariaDataGridViewTextBoxColumn,
            this.bancoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.distribuidoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(458, 277);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // iddistribuidorDataGridViewTextBoxColumn
            // 
            this.iddistribuidorDataGridViewTextBoxColumn.DataPropertyName = "id_distribuidor";
            this.iddistribuidorDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.iddistribuidorDataGridViewTextBoxColumn.Name = "iddistribuidorDataGridViewTextBoxColumn";
            this.iddistribuidorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddistribuidorDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombredistriDataGridViewTextBoxColumn
            // 
            this.nombredistriDataGridViewTextBoxColumn.DataPropertyName = "nombre_distri";
            this.nombredistriDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombredistriDataGridViewTextBoxColumn.Name = "nombredistriDataGridViewTextBoxColumn";
            this.nombredistriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidodistriDataGridViewTextBoxColumn
            // 
            this.apellidodistriDataGridViewTextBoxColumn.DataPropertyName = "apellido_distri";
            this.apellidodistriDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidodistriDataGridViewTextBoxColumn.Name = "apellidodistriDataGridViewTextBoxColumn";
            this.apellidodistriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direcciondistriDataGridViewTextBoxColumn
            // 
            this.direcciondistriDataGridViewTextBoxColumn.DataPropertyName = "direccion_distri";
            this.direcciondistriDataGridViewTextBoxColumn.HeaderText = "direccion_distri";
            this.direcciondistriDataGridViewTextBoxColumn.Name = "direcciondistriDataGridViewTextBoxColumn";
            this.direcciondistriDataGridViewTextBoxColumn.ReadOnly = true;
            this.direcciondistriDataGridViewTextBoxColumn.Visible = false;
            // 
            // razonsocialDataGridViewTextBoxColumn
            // 
            this.razonsocialDataGridViewTextBoxColumn.DataPropertyName = "razon_social";
            this.razonsocialDataGridViewTextBoxColumn.HeaderText = "Razon social";
            this.razonsocialDataGridViewTextBoxColumn.Name = "razonsocialDataGridViewTextBoxColumn";
            this.razonsocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cinitDataGridViewTextBoxColumn
            // 
            this.cinitDataGridViewTextBoxColumn.DataPropertyName = "ci_nit";
            this.cinitDataGridViewTextBoxColumn.HeaderText = "ci_nit";
            this.cinitDataGridViewTextBoxColumn.Name = "cinitDataGridViewTextBoxColumn";
            this.cinitDataGridViewTextBoxColumn.ReadOnly = true;
            this.cinitDataGridViewTextBoxColumn.Visible = false;
            // 
            // cuentabancariaDataGridViewTextBoxColumn
            // 
            this.cuentabancariaDataGridViewTextBoxColumn.DataPropertyName = "cuenta_bancaria";
            this.cuentabancariaDataGridViewTextBoxColumn.HeaderText = "cuenta_bancaria";
            this.cuentabancariaDataGridViewTextBoxColumn.Name = "cuentabancariaDataGridViewTextBoxColumn";
            this.cuentabancariaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuentabancariaDataGridViewTextBoxColumn.Visible = false;
            // 
            // bancoDataGridViewTextBoxColumn
            // 
            this.bancoDataGridViewTextBoxColumn.DataPropertyName = "banco";
            this.bancoDataGridViewTextBoxColumn.HeaderText = "banco";
            this.bancoDataGridViewTextBoxColumn.Name = "bancoDataGridViewTextBoxColumn";
            this.bancoDataGridViewTextBoxColumn.ReadOnly = true;
            this.bancoDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacionesDataGridViewTextBoxColumn.Visible = false;
            // 
            // distribuidoresBindingSource
            // 
            this.distribuidoresBindingSource.DataMember = "distribuidores";
            this.distribuidoresBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // gasolineraDBDataSet
            // 
            this.gasolineraDBDataSet.DataSetName = "gasolineraDBDataSet";
            this.gasolineraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // distribuidoresTableAdapter
            // 
            this.distribuidoresTableAdapter.ClearBeforeFill = true;
            // 
            // FormPorDistri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPorDistri";
            this.Text = "FormPorDistri";
            this.Load += new System.EventHandler(this.FormPorDistri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private System.Windows.Forms.BindingSource distribuidoresBindingSource;
        private gasolineraDBDataSetTableAdapters.distribuidoresTableAdapter distribuidoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddistribuidorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredistriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidodistriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcciondistriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentabancariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
    }
}