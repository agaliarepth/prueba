using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gasolinera.Reportes;

namespace gasolinera
{

    public partial class FormMovimientoCompras : Form
    {
        private gasolineraDBDataSetTableAdapters.Vista_comprasDistribuidorTableAdapter compras_da = new gasolineraDBDataSetTableAdapters.Vista_comprasDistribuidorTableAdapter();
        private gasolineraDBDataSetTableAdapters.Vista_detalleComprasTableAdapter detalle = new gasolineraDBDataSetTableAdapters.Vista_detalleComprasTableAdapter();
        gasolineraDBDataSet.Vista_comprasDistribuidorDataTable table = new gasolineraDBDataSet.Vista_comprasDistribuidorDataTable();
        private string tipo;
        public FormMovimientoCompras()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = compras_da.GetData();
            this.table = compras_da.GetData();
            tipo = "TODAS LAS COMPRAS HASTA LA FECHA";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = compras_da.GetBy_fechas(dt_f1.Text, dt_f2.Text);
            this.table = compras_da.GetBy_fechas(dt_f1.Text, dt_f2.Text);
            this.tipo = "COMPRAS DE " + dt_f1.Text + " A " + dt_f2.Text;
        }
        private void configuracionesIniciales()
        {

            dataGridView2.Columns["id_detalle_compras"].Visible = false;
            dataGridView2.Columns["descripcion_producto"].Width = 250;

            dataGridView2.Columns["id_compra"].Visible = false;


        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ClassNumeroLetra nl = new ClassNumeroLetra();
            tb_tipo.Text = dataGridView1.CurrentRow.Cells["tipo_documento"].Value.ToString();
            tb_fecha.Text = dataGridView1.CurrentRow.Cells["fecha_compra"].Value.ToString();
            numDoc.Text = dataGridView1.CurrentRow.Cells["numero_documento"].Value.ToString();
            distri.Text = dataGridView1.CurrentRow.Cells["nombre_distri"].Value.ToString() + dataGridView1.CurrentRow.Cells["apellido_distri"].Value.ToString();
            label6.Text = dataGridView1.CurrentRow.Cells["monto_total"].Value.ToString();
            label3.Text = nl.Convertir(label6.Text, true);

            dataGridView2.DataSource = detalle.GetDataBy_idCompra(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_compra"].Value));
            configuracionesIniciales();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            CoprasReport com = new CoprasReport(this.table, this.tipo);
            com.ShowDialog();


        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dt_f2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_f1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gb_panel = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cinit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.tb_fecha = new System.Windows.Forms.TextBox();
            this.tb_placa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.distri = new System.Windows.Forms.TextBox();
            this.numDoc = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(26, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 45);
            this.panel4.TabIndex = 42;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(444, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 37);
            this.button6.TabIndex = 36;
            this.button6.Text = "Por Funcionario";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(338, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 37);
            this.button5.TabIndex = 35;
            this.button5.Text = "Por Turnos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 37);
            this.button2.TabIndex = 34;
            this.button2.Text = "Por Bomba";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 33;
            this.button1.Text = "Ventas del Dia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 37);
            this.button3.TabIndex = 32;
            this.button3.Text = "Mostrar Todos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
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
            this.panel3.Location = new System.Drawing.Point(163, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 54);
            this.panel3.TabIndex = 41;
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
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "De";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 21);
            this.button4.TabIndex = 32;
            this.button4.Text = "Filtrar Por Fechas";
            this.button4.UseVisualStyleBackColor = true;
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
            // dt_f1
            // 
            this.dt_f1.CustomFormat = "yyyy/MM/dd";
            this.dt_f1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_f1.Location = new System.Drawing.Point(24, 28);
            this.dt_f1.Name = "dt_f1";
            this.dt_f1.Size = new System.Drawing.Size(89, 20);
            this.dt_f1.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gb_panel);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(552, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 607);
            this.panel1.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Cyan;
            this.label10.Location = new System.Drawing.Point(140, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 24);
            this.label10.TabIndex = 35;
            this.label10.Text = "DETALLE FACTURA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 514);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 90);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel2.Location = new System.Drawing.Point(49, 55);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(255, 18);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Imprimir Facturas Seleccionadas";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(60, 37);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(182, 18);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Imprimir Factura Actual";
            // 
            // gb_panel
            // 
            this.gb_panel.BackColor = System.Drawing.Color.DarkGray;
            this.gb_panel.Controls.Add(this.label3);
            this.gb_panel.Controls.Add(this.lb_total);
            this.gb_panel.Controls.Add(this.label7);
            this.gb_panel.Controls.Add(this.label6);
            this.gb_panel.Location = new System.Drawing.Point(5, 373);
            this.gb_panel.Name = "gb_panel";
            this.gb_panel.Size = new System.Drawing.Size(440, 84);
            this.gb_panel.TabIndex = 19;
            this.gb_panel.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_total.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_total.Location = new System.Drawing.Point(484, 22);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(0, 16);
            this.lb_total.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(274, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(303, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(0, 233);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(449, 139);
            this.dataGridView2.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.numDoc);
            this.panel2.Controls.Add(this.distri);
            this.panel2.Controls.Add(this.tb_nombre);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tb_cinit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tb_tipo);
            this.panel2.Controls.Add(this.tb_fecha);
            this.panel2.Controls.Add(this.tb_placa);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Cliente);
            this.panel2.Location = new System.Drawing.Point(3, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 178);
            this.panel2.TabIndex = 17;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(92, 114);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.ReadOnly = true;
            this.tb_nombre.Size = new System.Drawing.Size(343, 20);
            this.tb_nombre.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(6, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "SR(A)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(225, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero de Placa";
            // 
            // tb_cinit
            // 
            this.tb_cinit.Location = new System.Drawing.Point(92, 144);
            this.tb_cinit.Name = "tb_cinit";
            this.tb_cinit.ReadOnly = true;
            this.tb_cinit.Size = new System.Drawing.Size(100, 20);
            this.tb_cinit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha";
            // 
            // tb_tipo
            // 
            this.tb_tipo.Location = new System.Drawing.Point(92, 31);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.ReadOnly = true;
            this.tb_tipo.Size = new System.Drawing.Size(149, 20);
            this.tb_tipo.TabIndex = 11;
            // 
            // tb_fecha
            // 
            this.tb_fecha.Location = new System.Drawing.Point(92, 68);
            this.tb_fecha.Name = "tb_fecha";
            this.tb_fecha.ReadOnly = true;
            this.tb_fecha.Size = new System.Drawing.Size(101, 20);
            this.tb_fecha.TabIndex = 11;
            // 
            // tb_placa
            // 
            this.tb_placa.Location = new System.Drawing.Point(340, 146);
            this.tb_placa.Name = "tb_placa";
            this.tb_placa.ReadOnly = true;
            this.tb_placa.Size = new System.Drawing.Size(95, 20);
            this.tb_placa.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(240, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Codigo Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Autorizacion";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Cliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cliente.Location = new System.Drawing.Point(208, 71);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(120, 15);
            this.Cliente.TabIndex = 1;
            this.Cliente.Text = "Clientes Registrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(1, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 498);
            this.dataGridView1.TabIndex = 39;
            // 
            // distri
            // 
            this.distri.Location = new System.Drawing.Point(335, 25);
            this.distri.Name = "distri";
            this.distri.Size = new System.Drawing.Size(100, 20);
            this.distri.TabIndex = 20;
            // 
            // numDoc
            // 
            this.numDoc.Location = new System.Drawing.Point(335, 66);
            this.numDoc.Name = "numDoc";
            this.numDoc.Size = new System.Drawing.Size(100, 20);
            this.numDoc.TabIndex = 20;
            // 
            // FormMovimientoCompras
            // 
            this.ClientSize = new System.Drawing.Size(1029, 631);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMovimientoCompras";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_panel.ResumeLayout(false);
            this.gb_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel panel4;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panel3;
        private DateTimePicker dt_f2;
        private Label label8;
        private Button button4;
        private Label label2;
        private DateTimePicker dt_f1;
        private Panel panel1;
        private Label label10;
        private GroupBox groupBox1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private GroupBox gb_panel;
        private Label label3;
        private Label lb_total;
        private Label label7;
        private Label label6;
        private DataGridView dataGridView2;
        private Panel panel2;
        private TextBox tb_nombre;
        private Label label11;
        private Label label1;
        private TextBox tb_cinit;
        private Label label4;
        private TextBox tb_tipo;
        private TextBox tb_fecha;
        private TextBox tb_placa;
        private Label label9;
        private Label label5;
        private Label Cliente;
        private DataGridView dataGridView1;
        private TextBox distri;
        private TextBox numDoc;

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
