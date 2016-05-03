namespace gasolinera
{
    partial class FormFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.usernameempledoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.empleadosTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.empleadosTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 49;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempleadoDataGridViewTextBoxColumn,
            this.nombreempleadoDataGridViewTextBoxColumn,
            this.telefonoempleadoDataGridViewTextBoxColumn,
            this.sueldoempleadoDataGridViewTextBoxColumn,
            this.direccionempleadoDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.usernameempledoDataGridViewTextBoxColumn,
            this.passwordempleadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empleadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(724, 298);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idempleadoDataGridViewTextBoxColumn
            // 
            this.idempleadoDataGridViewTextBoxColumn.DataPropertyName = "id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.HeaderText = "id_empleado";
            this.idempleadoDataGridViewTextBoxColumn.Name = "idempleadoDataGridViewTextBoxColumn";
            this.idempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idempleadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreempleadoDataGridViewTextBoxColumn
            // 
            this.nombreempleadoDataGridViewTextBoxColumn.DataPropertyName = "nombre_empleado";
            this.nombreempleadoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreempleadoDataGridViewTextBoxColumn.Name = "nombreempleadoDataGridViewTextBoxColumn";
            this.nombreempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreempleadoDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonoempleadoDataGridViewTextBoxColumn
            // 
            this.telefonoempleadoDataGridViewTextBoxColumn.DataPropertyName = "telefono_empleado";
            this.telefonoempleadoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoempleadoDataGridViewTextBoxColumn.Name = "telefonoempleadoDataGridViewTextBoxColumn";
            this.telefonoempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoempleadoDataGridViewTextBoxColumn.Width = 70;
            // 
            // sueldoempleadoDataGridViewTextBoxColumn
            // 
            this.sueldoempleadoDataGridViewTextBoxColumn.DataPropertyName = "sueldo_empleado";
            this.sueldoempleadoDataGridViewTextBoxColumn.HeaderText = "Sueldo ";
            this.sueldoempleadoDataGridViewTextBoxColumn.Name = "sueldoempleadoDataGridViewTextBoxColumn";
            this.sueldoempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sueldoempleadoDataGridViewTextBoxColumn.Width = 50;
            // 
            // direccionempleadoDataGridViewTextBoxColumn
            // 
            this.direccionempleadoDataGridViewTextBoxColumn.DataPropertyName = "direccion_empleado";
            this.direccionempleadoDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionempleadoDataGridViewTextBoxColumn.Name = "direccionempleadoDataGridViewTextBoxColumn";
            this.direccionempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // usernameempledoDataGridViewTextBoxColumn
            // 
            this.usernameempledoDataGridViewTextBoxColumn.DataPropertyName = "username_empledo";
            this.usernameempledoDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameempledoDataGridViewTextBoxColumn.Name = "usernameempledoDataGridViewTextBoxColumn";
            this.usernameempledoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordempleadoDataGridViewTextBoxColumn
            // 
            this.passwordempleadoDataGridViewTextBoxColumn.DataPropertyName = "password_empleado";
            this.passwordempleadoDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordempleadoDataGridViewTextBoxColumn.Name = "passwordempleadoDataGridViewTextBoxColumn";
            this.passwordempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // gasolineraDBDataSet
            // 
            this.gasolineraDBDataSet.DataSetName = "gasolineraDBDataSet";
            this.gasolineraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Image = global::gasolinera.Properties.Resources.exit1;
            this.button5.Location = new System.Drawing.Point(464, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 66);
            this.button5.TabIndex = 9;
            this.button5.Text = "Salir";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Image = global::gasolinera.Properties.Resources.db;
            this.button3.Location = new System.Drawing.Point(302, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 66);
            this.button3.TabIndex = 7;
            this.button3.Text = "Actualizar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::gasolinera.Properties.Resources.dbmin;
            this.button2.Location = new System.Drawing.Point(224, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "Eliminar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::gasolinera.Properties.Resources.dbplus21;
            this.button1.Location = new System.Drawing.Point(143, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Image = global::gasolinera.Properties.Resources.Clock;
            this.button6.Location = new System.Drawing.Point(383, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 66);
            this.button6.TabIndex = 8;
            this.button6.Text = "Turnos";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 375);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Empleados";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private gasolineraDBDataSetTableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameempledoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
    }
}