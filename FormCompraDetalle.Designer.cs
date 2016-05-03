namespace gasolinera
{
    partial class FormCompraDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompraDetalle));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cant = new System.Windows.Forms.NumericUpDown();
            this.vender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.prec = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lb2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lb1);
            this.panel2.Controls.Add(this.lb4);
            this.panel2.Controls.Add(this.lb3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.vender);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.prec);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cant);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 379);
            this.panel2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel Actual :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(14, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "CANTIDAD:";
            // 
            // cant
            // 
            this.cant.DecimalPlaces = 2;
            this.cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cant.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.cant.Location = new System.Drawing.Point(188, 170);
            this.cant.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(140, 44);
            this.cant.TabIndex = 10;
            // 
            // vender
            // 
            this.vender.AutoEllipsis = true;
            this.vender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vender.Image = ((System.Drawing.Image)(resources.GetObject("vender.Image")));
            this.vender.Location = new System.Drawing.Point(15, 291);
            this.vender.Name = "vender";
            this.vender.Size = new System.Drawing.Size(308, 72);
            this.vender.TabIndex = 9;
            this.vender.Text = "COMPRAR";
            this.vender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.vender.UseVisualStyleBackColor = true;
            this.vender.Click += new System.EventHandler(this.vender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "TANQUE :";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(170, 77);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(119, 24);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "Nivel Actual :";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(170, 5);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(119, 24);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Nivel Actual :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "COMBUSTIBLE :";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(170, 38);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(119, 24);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Nivel Actual :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Capacidad :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(170, 113);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(119, 24);
            this.lb4.TabIndex = 2;
            this.lb4.Text = "Nivel Actual :";
            // 
            // prec
            // 
            this.prec.DecimalPlaces = 2;
            this.prec.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prec.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.prec.Location = new System.Drawing.Point(188, 227);
            this.prec.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prec.Name = "prec";
            this.prec.Size = new System.Drawing.Size(140, 44);
            this.prec.TabIndex = 10;
            this.prec.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(14, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Precio u/m ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(170, 146);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(119, 24);
            this.lb5.TabIndex = 12;
            this.lb5.Text = "Nivel Actual :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unidad :";
            // 
            // FormCompraDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 386);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompraDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compra";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button vender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cant;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown prec;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label label7;

    }
}