namespace gasolinera
{
    partial class FormAsignarHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignarHorarios));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diassemanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.turnosTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.turnosTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias_semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainicioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horafinDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diassemanaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaturnosEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_turnosEmpleadosTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.Vista_turnosEmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaturnosEmpleadosBindingSource)).BeginInit();
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
            this.idturnoDataGridViewTextBoxColumn,
            this.horainicioDataGridViewTextBoxColumn,
            this.horafinDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.diassemanaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.turnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(455, 132);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idturnoDataGridViewTextBoxColumn
            // 
            this.idturnoDataGridViewTextBoxColumn.DataPropertyName = "id_turno";
            this.idturnoDataGridViewTextBoxColumn.HeaderText = "id_turno";
            this.idturnoDataGridViewTextBoxColumn.Name = "idturnoDataGridViewTextBoxColumn";
            this.idturnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idturnoDataGridViewTextBoxColumn.Visible = false;
            // 
            // horainicioDataGridViewTextBoxColumn
            // 
            this.horainicioDataGridViewTextBoxColumn.DataPropertyName = "hora_inicio";
            this.horainicioDataGridViewTextBoxColumn.HeaderText = "hora_inicio";
            this.horainicioDataGridViewTextBoxColumn.Name = "horainicioDataGridViewTextBoxColumn";
            this.horainicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horafinDataGridViewTextBoxColumn
            // 
            this.horafinDataGridViewTextBoxColumn.DataPropertyName = "hora_fin";
            this.horafinDataGridViewTextBoxColumn.HeaderText = "hora_fin";
            this.horafinDataGridViewTextBoxColumn.Name = "horafinDataGridViewTextBoxColumn";
            this.horafinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diassemanaDataGridViewTextBoxColumn
            // 
            this.diassemanaDataGridViewTextBoxColumn.DataPropertyName = "dias_semana";
            this.diassemanaDataGridViewTextBoxColumn.HeaderText = "dias_semana";
            this.diassemanaDataGridViewTextBoxColumn.Name = "diassemanaDataGridViewTextBoxColumn";
            this.diassemanaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // turnosTableAdapter
            // 
            this.turnosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_turno,
            this.hora_inicio,
            this.hora_fin,
            this.descripcion,
            this.dias_semana});
            this.dataGridView2.Location = new System.Drawing.Point(6, 173);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(455, 112);
            this.dataGridView2.TabIndex = 1;
            // 
            // id_turno
            // 
            this.id_turno.HeaderText = "id";
            this.id_turno.Name = "id_turno";
            this.id_turno.ReadOnly = true;
            this.id_turno.Visible = false;
            // 
            // hora_inicio
            // 
            this.hora_inicio.HeaderText = "Hora Inicio";
            this.hora_inicio.Name = "hora_inicio";
            this.hora_inicio.ReadOnly = true;
            // 
            // hora_fin
            // 
            this.hora_fin.HeaderText = "Hora Fin";
            this.hora_fin.Name = "hora_fin";
            this.hora_fin.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // dias_semana
            // 
            this.dias_semana.HeaderText = "Dias";
            this.dias_semana.Name = "dias_semana";
            this.dias_semana.ReadOnly = true;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Image = global::gasolinera.Properties.Resources.kcmx;
            this.cancelar_btn.Location = new System.Drawing.Point(222, 295);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(85, 48);
            this.cancelar_btn.TabIndex = 29;
            this.cancelar_btn.Text = "Salir";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // guardar_btn
            // 
            this.guardar_btn.Image = global::gasolinera.Properties.Resources.clean;
            this.guardar_btn.Location = new System.Drawing.Point(122, 297);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(85, 48);
            this.guardar_btn.TabIndex = 28;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(222, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 34);
            this.button6.TabIndex = 31;
            this.button6.Text = "-";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(174, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 34);
            this.button4.TabIndex = 30;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_foto);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 99);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Location = new System.Drawing.Point(7, 11);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(80, 80);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_foto.TabIndex = 0;
            this.pb_foto.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 377);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.guardar_btn);
            this.tabPage1.Controls.Add(this.cancelar_btn);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asignar Horarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_quitar);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(471, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Turnos Asignados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(185, 297);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(89, 48);
            this.btn_quitar.TabIndex = 31;
            this.btn_quitar.Text = "Quitar Turnos ";
            this.btn_quitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeight = 40;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.horainicioDataGridViewTextBoxColumn1,
            this.horafinDataGridViewTextBoxColumn1,
            this.diassemanaDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.vistaturnosEmpleadosBindingSource;
            this.dataGridView3.GridColor = System.Drawing.Color.White;
            this.dataGridView3.Location = new System.Drawing.Point(6, 18);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(463, 273);
            this.dataGridView3.TabIndex = 0;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            this.descripcionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_turno";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_turno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // horainicioDataGridViewTextBoxColumn1
            // 
            this.horainicioDataGridViewTextBoxColumn1.DataPropertyName = "hora_inicio";
            this.horainicioDataGridViewTextBoxColumn1.HeaderText = "Inicio";
            this.horainicioDataGridViewTextBoxColumn1.Name = "horainicioDataGridViewTextBoxColumn1";
            this.horainicioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.horainicioDataGridViewTextBoxColumn1.Width = 50;
            // 
            // horafinDataGridViewTextBoxColumn1
            // 
            this.horafinDataGridViewTextBoxColumn1.DataPropertyName = "hora_fin";
            this.horafinDataGridViewTextBoxColumn1.HeaderText = "Fin";
            this.horafinDataGridViewTextBoxColumn1.Name = "horafinDataGridViewTextBoxColumn1";
            this.horafinDataGridViewTextBoxColumn1.ReadOnly = true;
            this.horafinDataGridViewTextBoxColumn1.Width = 50;
            // 
            // diassemanaDataGridViewTextBoxColumn1
            // 
            this.diassemanaDataGridViewTextBoxColumn1.DataPropertyName = "dias_semana";
            this.diassemanaDataGridViewTextBoxColumn1.HeaderText = "Dias";
            this.diassemanaDataGridViewTextBoxColumn1.Name = "diassemanaDataGridViewTextBoxColumn1";
            this.diassemanaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.diassemanaDataGridViewTextBoxColumn1.Width = 120;
            // 
            // vistaturnosEmpleadosBindingSource
            // 
            this.vistaturnosEmpleadosBindingSource.DataMember = "Vista_turnosEmpleados";
            this.vistaturnosEmpleadosBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // vista_turnosEmpleadosTableAdapter
            // 
            this.vista_turnosEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // FormAsignarHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 506);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAsignarHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asignar Horarios";
            this.Load += new System.EventHandler(this.FormAsignarHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaturnosEmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private System.Windows.Forms.BindingSource turnosBindingSource;
        private gasolineraDBDataSetTableAdapters.turnosTableAdapter turnosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diassemanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias_semana;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource vistaturnosEmpleadosBindingSource;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horafinDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diassemanaDataGridViewTextBoxColumn1;
        private gasolineraDBDataSetTableAdapters.Vista_turnosEmpleadosTableAdapter vista_turnosEmpleadosTableAdapter;
    }
}