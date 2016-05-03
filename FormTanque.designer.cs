namespace gasolinera
{
    partial class FormTanque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTanque));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tanquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.cb_ajuste = new System.Windows.Forms.CheckBox();
            this.tb_nivel = new System.Windows.Forms.TrackBar();
            this.lb_unidad = new System.Windows.Forms.Label();
            this.lb_porcentaje = new System.Windows.Forms.Label();
            this.pb_nivel = new System.Windows.Forms.ProgressBar();
            this.tanquesTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.tanquesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(640, 159);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // tanquesBindingSource
            // 
            this.tanquesBindingSource.DataMember = "tanques";
            this.tanquesBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // gasolineraDBDataSet
            // 
            this.gasolineraDBDataSet.DataSetName = "gasolineraDBDataSet";
            this.gasolineraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Image = global::gasolinera.Properties.Resources.exit1;
            this.button5.Location = new System.Drawing.Point(385, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 66);
            this.button5.TabIndex = 9;
            this.button5.Text = "Salir";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.Image = global::gasolinera.Properties.Resources.printer;
            this.button4.Location = new System.Drawing.Point(303, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 66);
            this.button4.TabIndex = 8;
            this.button4.Text = "Reportes";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::gasolinera.Properties.Resources.db;
            this.button3.Location = new System.Drawing.Point(222, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 66);
            this.button3.TabIndex = 7;
            this.button3.Text = "Actualizar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::gasolinera.Properties.Resources.dbmin;
            this.button2.Location = new System.Drawing.Point(144, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "Eliminar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::gasolinera.Properties.Resources.dbplus21;
            this.button1.Location = new System.Drawing.Point(63, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 177);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 191);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_stock);
            this.tabPage2.Controls.Add(this.cancelar_btn);
            this.tabPage2.Controls.Add(this.guardar_btn);
            this.tabPage2.Controls.Add(this.cb_ajuste);
            this.tabPage2.Controls.Add(this.tb_nivel);
            this.tabPage2.Controls.Add(this.lb_unidad);
            this.tabPage2.Controls.Add(this.lb_porcentaje);
            this.tabPage2.Controls.Add(this.pb_nivel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 165);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nivel de los Tanques";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_stock
            // 
            this.tb_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stock.Location = new System.Drawing.Point(436, 54);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.ReadOnly = true;
            this.tb_stock.Size = new System.Drawing.Size(148, 40);
            this.tb_stock.TabIndex = 31;
            this.tb_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_stock_KeyPress);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Enabled = false;
            this.cancelar_btn.Image = global::gasolinera.Properties.Resources.kcmx;
            this.cancelar_btn.Location = new System.Drawing.Point(233, 126);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(39, 33);
            this.cancelar_btn.TabIndex = 29;
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // guardar_btn
            // 
            this.guardar_btn.Enabled = false;
            this.guardar_btn.Image = global::gasolinera.Properties.Resources.clean;
            this.guardar_btn.Location = new System.Drawing.Point(191, 126);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(36, 33);
            this.guardar_btn.TabIndex = 28;
            this.guardar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // cb_ajuste
            // 
            this.cb_ajuste.AutoSize = true;
            this.cb_ajuste.Location = new System.Drawing.Point(449, 99);
            this.cb_ajuste.Name = "cb_ajuste";
            this.cb_ajuste.Size = new System.Drawing.Size(142, 17);
            this.cb_ajuste.TabIndex = 3;
            this.cb_ajuste.Text = "Ajustar Nivel del Tanque";
            this.cb_ajuste.UseVisualStyleBackColor = true;
            this.cb_ajuste.CheckedChanged += new System.EventHandler(this.cb_ajuste_CheckedChanged);
            // 
            // tb_nivel
            // 
            this.tb_nivel.BackColor = System.Drawing.SystemColors.Control;
            this.tb_nivel.Enabled = false;
            this.tb_nivel.LargeChange = 1;
            this.tb_nivel.Location = new System.Drawing.Point(-9, 97);
            this.tb_nivel.Maximum = 100;
            this.tb_nivel.Name = "tb_nivel";
            this.tb_nivel.Size = new System.Drawing.Size(452, 45);
            this.tb_nivel.TabIndex = 1;
            this.tb_nivel.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tb_nivel.Value = 50;
            this.tb_nivel.Scroll += new System.EventHandler(this.tb_nivel_Scroll);
            // 
            // lb_unidad
            // 
            this.lb_unidad.AutoSize = true;
            this.lb_unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_unidad.Location = new System.Drawing.Point(582, 76);
            this.lb_unidad.Name = "lb_unidad";
            this.lb_unidad.Size = new System.Drawing.Size(49, 18);
            this.lb_unidad.TabIndex = 1;
            this.lb_unidad.Text = " Litros";
            // 
            // lb_porcentaje
            // 
            this.lb_porcentaje.AutoSize = true;
            this.lb_porcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_porcentaje.Location = new System.Drawing.Point(430, 25);
            this.lb_porcentaje.Name = "lb_porcentaje";
            this.lb_porcentaje.Size = new System.Drawing.Size(121, 33);
            this.lb_porcentaje.TabIndex = 1;
            this.lb_porcentaje.Text = "00,00 %";
            // 
            // pb_nivel
            // 
            this.pb_nivel.Location = new System.Drawing.Point(3, 25);
            this.pb_nivel.Name = "pb_nivel";
            this.pb_nivel.Size = new System.Drawing.Size(428, 69);
            this.pb_nivel.Step = 1;
            this.pb_nivel.TabIndex = 0;
            // 
            // tanquesTableAdapter
            // 
            this.tanquesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(14, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 74);
            this.panel1.TabIndex = 12;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // FormTanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTanque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro Tanques";
            this.Load += new System.EventHandler(this.FormTanque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource tanquesBindingSource;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private gasolineraDBDataSetTableAdapters.tanquesTableAdapter tanquesTableAdapter;
        private System.Windows.Forms.ProgressBar pb_nivel;
        private System.Windows.Forms.Label lb_unidad;
        private System.Windows.Forms.Label lb_porcentaje;
        private System.Windows.Forms.TrackBar tb_nivel;
        private System.Windows.Forms.CheckBox cb_ajuste;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}