namespace SimuladorSuperMercado
{
    partial class Configuracion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numMaxClient = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMaxProduct = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numMaxDelay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numMaxProductsExpressLane = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numCheckoutCaja1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numCheckoutCaja2 = new System.Windows.Forms.NumericUpDown();
            this.numCheckoutCaja3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numCheckoutCaja4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numCheckoutCaja5 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxProductsExpressLane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutCaja1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutCaja2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutCaja3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutCaja4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutCaja5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numMaxDelay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numMaxProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numMaxClient);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 577);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración General:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.numCheckoutCaja5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numCheckoutCaja4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numCheckoutCaja3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numCheckoutCaja2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numCheckoutCaja1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numMaxProductsExpressLane);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(521, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 576);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuraciones Caja";
            // 
            // numMaxClient
            // 
            this.numMaxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxClient.Location = new System.Drawing.Point(296, 68);
            this.numMaxClient.Name = "numMaxClient";
            this.numMaxClient.Size = new System.Drawing.Size(120, 34);
            this.numMaxClient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero máximo de clientes por iteración:";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 68);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número máximo de articulos por cliente:";
            // 
            // numMaxProduct
            // 
            this.numMaxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxProduct.Location = new System.Drawing.Point(296, 158);
            this.numMaxProduct.Name = "numMaxProduct";
            this.numMaxProduct.Size = new System.Drawing.Size(120, 34);
            this.numMaxProduct.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 68);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número máximo de iteraciones de retardo por cliente:";
            // 
            // numMaxDelay
            // 
            this.numMaxDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxDelay.Location = new System.Drawing.Point(296, 267);
            this.numMaxDelay.Name = "numMaxDelay";
            this.numMaxDelay.Size = new System.Drawing.Size(120, 34);
            this.numMaxDelay.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Máximo de productos de la caja rápida:";
            // 
            // numMaxProductsExpressLane
            // 
            this.numMaxProductsExpressLane.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxProductsExpressLane.Location = new System.Drawing.Point(366, 70);
            this.numMaxProductsExpressLane.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMaxProductsExpressLane.Name = "numMaxProductsExpressLane";
            this.numMaxProductsExpressLane.Size = new System.Drawing.Size(120, 34);
            this.numMaxProductsExpressLane.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Caja 1:";
            // 
            // numCheckoutCaja1
            // 
            this.numCheckoutCaja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckoutCaja1.Location = new System.Drawing.Point(130, 159);
            this.numCheckoutCaja1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCheckoutCaja1.Name = "numCheckoutCaja1";
            this.numCheckoutCaja1.Size = new System.Drawing.Size(120, 34);
            this.numCheckoutCaja1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Caja 2:";
            // 
            // numCheckoutCaja2
            // 
            this.numCheckoutCaja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckoutCaja2.Location = new System.Drawing.Point(130, 209);
            this.numCheckoutCaja2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCheckoutCaja2.Name = "numCheckoutCaja2";
            this.numCheckoutCaja2.Size = new System.Drawing.Size(120, 34);
            this.numCheckoutCaja2.TabIndex = 10;
            // 
            // numCheckoutCaja3
            // 
            this.numCheckoutCaja3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckoutCaja3.Location = new System.Drawing.Point(130, 256);
            this.numCheckoutCaja3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCheckoutCaja3.Name = "numCheckoutCaja3";
            this.numCheckoutCaja3.Size = new System.Drawing.Size(120, 34);
            this.numCheckoutCaja3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Caja 3:";
            // 
            // numCheckoutCaja4
            // 
            this.numCheckoutCaja4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckoutCaja4.Location = new System.Drawing.Point(130, 305);
            this.numCheckoutCaja4.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCheckoutCaja4.Name = "numCheckoutCaja4";
            this.numCheckoutCaja4.Size = new System.Drawing.Size(120, 34);
            this.numCheckoutCaja4.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Caja 4:";
            // 
            // numCheckoutCaja5
            // 
            this.numCheckoutCaja5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheckoutCaja5.Location = new System.Drawing.Point(130, 355);
            this.numCheckoutCaja5.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCheckoutCaja5.Name = "numCheckoutCaja5";
            this.numCheckoutCaja5.Size = new System.Drawing.Size(120, 34);
            this.numCheckoutCaja5.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Caja 5:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(304, 443);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(182, 66);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar todos los cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(365, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "Checkout products por iteración: ";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxProductsExpressLane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutCaja1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutCaja2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutCaja3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutCaja4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckoutCaja5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numMaxClient;
        public System.Windows.Forms.NumericUpDown numMaxProduct;
        public System.Windows.Forms.NumericUpDown numMaxDelay;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numMaxProductsExpressLane;
        public System.Windows.Forms.NumericUpDown numCheckoutCaja1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown numCheckoutCaja5;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.NumericUpDown numCheckoutCaja4;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown numCheckoutCaja3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown numCheckoutCaja2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label10;
    }
}