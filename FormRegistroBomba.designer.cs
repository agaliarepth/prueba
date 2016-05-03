namespace gasolinera
{
    partial class FormRegistroBomba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroBomba));
            this.label1 = new System.Windows.Forms.Label();
            this.codigo_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combustible_cb = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.mangueras = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabque_cb = new System.Windows.Forms.ComboBox();
            this.tanquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tanquesTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.tanquesTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.productosTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.productosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangueras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Bomba";
            // 
            // codigo_tb
            // 
            this.codigo_tb.Location = new System.Drawing.Point(15, 24);
            this.codigo_tb.MaxLength = 3;
            this.codigo_tb.Name = "codigo_tb";
            this.codigo_tb.Size = new System.Drawing.Size(121, 20);
            this.codigo_tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Combustible";
            // 
            // combustible_cb
            // 
            this.combustible_cb.DataSource = this.productosBindingSource;
            this.combustible_cb.DisplayMember = "descripcion_producto";
            this.combustible_cb.FormattingEnabled = true;
            this.combustible_cb.Location = new System.Drawing.Point(171, 23);
            this.combustible_cb.Name = "combustible_cb";
            this.combustible_cb.Size = new System.Drawing.Size(121, 21);
            this.combustible_cb.TabIndex = 3;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de Mangueras";
            // 
            // mangueras
            // 
            this.mangueras.Location = new System.Drawing.Point(166, 74);
            this.mangueras.Name = "mangueras";
            this.mangueras.Size = new System.Drawing.Size(124, 20);
            this.mangueras.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Asignar a Tanque #";
            // 
            // tabque_cb
            // 
            this.tabque_cb.DataSource = this.tanquesBindingSource;
            this.tabque_cb.DisplayMember = "num_tanque";
            this.tabque_cb.FormattingEnabled = true;
            this.tabque_cb.Location = new System.Drawing.Point(15, 73);
            this.tabque_cb.Name = "tabque_cb";
            this.tabque_cb.Size = new System.Drawing.Size(121, 21);
            this.tabque_cb.TabIndex = 10;
            this.tabque_cb.ValueMember = "id_tanque";
            // 
            // tanquesBindingSource
            // 
            this.tanquesBindingSource.DataMember = "tanques";
            this.tanquesBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Image = global::gasolinera.Properties.Resources.kcmx;
            this.cancelar_btn.Location = new System.Drawing.Point(149, 115);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(85, 48);
            this.cancelar_btn.TabIndex = 44;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelar_btn.UseVisualStyleBackColor = true;
            this.cancelar_btn.Click += new System.EventHandler(this.cancelar_btn_Click);
            // 
            // button1
            // 
            this.button1.Image = global::gasolinera.Properties.Resources.clean;
            this.button1.Location = new System.Drawing.Point(58, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 48);
            this.button1.TabIndex = 43;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tanquesTableAdapter
            // 
            this.tanquesTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // FormRegistroBomba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 181);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabque_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mangueras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combustible_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigo_tb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistroBomba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro Bombas";
            this.Load += new System.EventHandler(this.FormRegistroBomba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangueras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigo_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combustible_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown mangueras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tabque_cb;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button button1;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private System.Windows.Forms.BindingSource tanquesBindingSource;
        private gasolineraDBDataSetTableAdapters.tanquesTableAdapter tanquesTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private gasolineraDBDataSetTableAdapters.productosTableAdapter productosTableAdapter;
    }
}