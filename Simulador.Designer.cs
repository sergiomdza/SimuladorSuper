namespace SimuladorSuperMercado
{
    partial class formSuper
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
            this.ListViewClientes = new System.Windows.Forms.ListView();
            this.columnNumCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCantidadProductos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMaxDelay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDelayActual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ListViewCaja1 = new System.Windows.Forms.ListView();
            this.columnNumCliente1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumProd1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.ListViewCaja2 = new System.Windows.Forms.ListView();
            this.columnNumeroCliente2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumeroProd2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewCaja3 = new System.Windows.Forms.ListView();
            this.columnNumCliente3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumProd3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewCaja4 = new System.Windows.Forms.ListView();
            this.columnNumCliente4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumProd4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewCaja5 = new System.Windows.Forms.ListView();
            this.columnNumCliente5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumProd5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInteracion = new System.Windows.Forms.Label();
            this.btnSiguienteInt = new System.Windows.Forms.Button();
            this.btnSinCliente = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListViewClientes
            // 
            this.ListViewClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumCliente,
            this.columnCantidadProductos,
            this.columnMaxDelay,
            this.columnDelayActual});
            this.ListViewClientes.HideSelection = false;
            this.ListViewClientes.Location = new System.Drawing.Point(3, 377);
            this.ListViewClientes.Name = "ListViewClientes";
            this.ListViewClientes.Size = new System.Drawing.Size(658, 311);
            this.ListViewClientes.TabIndex = 0;
            this.ListViewClientes.UseCompatibleStateImageBehavior = false;
            this.ListViewClientes.View = System.Windows.Forms.View.Details;
            // 
            // columnNumCliente
            // 
            this.columnNumCliente.Text = "Numero de Cliente";
            this.columnNumCliente.Width = 158;
            // 
            // columnCantidadProductos
            // 
            this.columnCantidadProductos.Text = "Numero de productos";
            this.columnCantidadProductos.Width = 178;
            // 
            // columnMaxDelay
            // 
            this.columnMaxDelay.Text = "Max Delay";
            this.columnMaxDelay.Width = 103;
            // 
            // columnDelayActual
            // 
            this.columnDelayActual.Text = "Delay Actual";
            this.columnDelayActual.Width = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes en la tienda:";
            // 
            // ListViewCaja1
            // 
            this.ListViewCaja1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumCliente1,
            this.columnNumProd1});
            this.ListViewCaja1.HideSelection = false;
            this.ListViewCaja1.Location = new System.Drawing.Point(283, 47);
            this.ListViewCaja1.Name = "ListViewCaja1";
            this.ListViewCaja1.Size = new System.Drawing.Size(378, 282);
            this.ListViewCaja1.TabIndex = 2;
            this.ListViewCaja1.UseCompatibleStateImageBehavior = false;
            this.ListViewCaja1.View = System.Windows.Forms.View.Details;
            // 
            // columnNumCliente1
            // 
            this.columnNumCliente1.Text = "Numero de cliente";
            this.columnNumCliente1.Width = 125;
            // 
            // columnNumProd1
            // 
            this.columnNumProd1.Text = "Numero de Productos";
            this.columnNumProd1.Width = 155;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caja 1: (Express)";
            // 
            // ListViewCaja2
            // 
            this.ListViewCaja2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumeroCliente2,
            this.columnNumeroProd2});
            this.ListViewCaja2.HideSelection = false;
            this.ListViewCaja2.Location = new System.Drawing.Point(716, 47);
            this.ListViewCaja2.Name = "ListViewCaja2";
            this.ListViewCaja2.Size = new System.Drawing.Size(378, 282);
            this.ListViewCaja2.TabIndex = 4;
            this.ListViewCaja2.UseCompatibleStateImageBehavior = false;
            this.ListViewCaja2.View = System.Windows.Forms.View.Details;
            // 
            // columnNumeroCliente2
            // 
            this.columnNumeroCliente2.Text = "Numero de Cliente";
            this.columnNumeroCliente2.Width = 134;
            // 
            // columnNumeroProd2
            // 
            this.columnNumeroProd2.Text = "Numero de Productos";
            this.columnNumeroProd2.Width = 150;
            // 
            // ListViewCaja3
            // 
            this.ListViewCaja3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumCliente3,
            this.columnNumProd3});
            this.ListViewCaja3.HideSelection = false;
            this.ListViewCaja3.Location = new System.Drawing.Point(1115, 47);
            this.ListViewCaja3.Name = "ListViewCaja3";
            this.ListViewCaja3.Size = new System.Drawing.Size(378, 282);
            this.ListViewCaja3.TabIndex = 5;
            this.ListViewCaja3.UseCompatibleStateImageBehavior = false;
            this.ListViewCaja3.View = System.Windows.Forms.View.Details;
            // 
            // columnNumCliente3
            // 
            this.columnNumCliente3.Text = "Numero de Cliente";
            this.columnNumCliente3.Width = 134;
            // 
            // columnNumProd3
            // 
            this.columnNumProd3.Text = "Numero de productos";
            this.columnNumProd3.Width = 153;
            // 
            // ListViewCaja4
            // 
            this.ListViewCaja4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumCliente4,
            this.columnNumProd4});
            this.ListViewCaja4.HideSelection = false;
            this.ListViewCaja4.Location = new System.Drawing.Point(716, 396);
            this.ListViewCaja4.Name = "ListViewCaja4";
            this.ListViewCaja4.Size = new System.Drawing.Size(378, 282);
            this.ListViewCaja4.TabIndex = 6;
            this.ListViewCaja4.UseCompatibleStateImageBehavior = false;
            this.ListViewCaja4.View = System.Windows.Forms.View.Details;
            // 
            // columnNumCliente4
            // 
            this.columnNumCliente4.Text = "Numero de Cliente";
            this.columnNumCliente4.Width = 135;
            // 
            // columnNumProd4
            // 
            this.columnNumProd4.Text = "Numero de Producto";
            this.columnNumProd4.Width = 147;
            // 
            // ListViewCaja5
            // 
            this.ListViewCaja5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumCliente5,
            this.columnNumProd5});
            this.ListViewCaja5.HideSelection = false;
            this.ListViewCaja5.Location = new System.Drawing.Point(1115, 396);
            this.ListViewCaja5.Name = "ListViewCaja5";
            this.ListViewCaja5.Size = new System.Drawing.Size(378, 282);
            this.ListViewCaja5.TabIndex = 7;
            this.ListViewCaja5.UseCompatibleStateImageBehavior = false;
            this.ListViewCaja5.View = System.Windows.Forms.View.Details;
            // 
            // columnNumCliente5
            // 
            this.columnNumCliente5.Text = "Numero de Cliente";
            this.columnNumCliente5.Width = 133;
            // 
            // columnNumProd5
            // 
            this.columnNumProd5.Text = "Numero de Productos";
            this.columnNumProd5.Width = 173;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(711, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Caja 2: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1110, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Caja 3: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(721, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Caja 4: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1110, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Caja 5: ";
            // 
            // lblInteracion
            // 
            this.lblInteracion.AutoSize = true;
            this.lblInteracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteracion.Location = new System.Drawing.Point(12, 33);
            this.lblInteracion.Name = "lblInteracion";
            this.lblInteracion.Size = new System.Drawing.Size(199, 29);
            this.lblInteracion.TabIndex = 12;
            this.lblInteracion.Text = "Iteración actual: 0";
            // 
            // btnSiguienteInt
            // 
            this.btnSiguienteInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteInt.Location = new System.Drawing.Point(17, 89);
            this.btnSiguienteInt.Name = "btnSiguienteInt";
            this.btnSiguienteInt.Size = new System.Drawing.Size(145, 73);
            this.btnSiguienteInt.TabIndex = 14;
            this.btnSiguienteInt.Text = "Siguiente Iteración";
            this.btnSiguienteInt.UseVisualStyleBackColor = true;
            this.btnSiguienteInt.Click += new System.EventHandler(this.btnSiguienteIteracion_Click);
            // 
            // btnSinCliente
            // 
            this.btnSinCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinCliente.Location = new System.Drawing.Point(17, 168);
            this.btnSinCliente.Name = "btnSinCliente";
            this.btnSinCliente.Size = new System.Drawing.Size(145, 45);
            this.btnSinCliente.TabIndex = 15;
            this.btnSinCliente.Text = "Sin Cliente";
            this.btnSinCliente.UseVisualStyleBackColor = true;
            this.btnSinCliente.Click += new System.EventHandler(this.btnSinCliente_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Location = new System.Drawing.Point(12, 284);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(150, 45);
            this.btnConfig.TabIndex = 16;
            this.btnConfig.Text = "Configuracion";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // formSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 700);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnSinCliente);
            this.Controls.Add(this.btnSiguienteInt);
            this.Controls.Add(this.lblInteracion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListViewCaja5);
            this.Controls.Add(this.ListViewCaja4);
            this.Controls.Add(this.ListViewCaja3);
            this.Controls.Add(this.ListViewCaja2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListViewCaja1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListViewClientes);
            this.Name = "formSuper";
            this.Text = "Super";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListViewCaja1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ListViewCaja2;
        private System.Windows.Forms.ListView ListViewCaja3;
        private System.Windows.Forms.ListView ListViewCaja4;
        private System.Windows.Forms.ListView ListViewCaja5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInteracion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader ColumnNumCliente;
        private System.Windows.Forms.ColumnHeader columnNumCliente;
        private System.Windows.Forms.ColumnHeader columnCantidadProductos;
        private System.Windows.Forms.ColumnHeader columnMaxDelay;
        private System.Windows.Forms.ColumnHeader columnDelayActual;
        private System.Windows.Forms.Button btnSiguienteInt;
        private System.Windows.Forms.Button btnSinCliente;
        private System.Windows.Forms.ColumnHeader columnNumCliente1;
        private System.Windows.Forms.ColumnHeader columnNumProd1;
        private System.Windows.Forms.ColumnHeader columnNumeroCliente2;
        private System.Windows.Forms.ColumnHeader columnNumeroProd2;
        private System.Windows.Forms.ColumnHeader columnNumCliente3;
        private System.Windows.Forms.ColumnHeader columnNumProd3;
        private System.Windows.Forms.ColumnHeader columnNumCliente4;
        private System.Windows.Forms.ColumnHeader columnNumProd4;
        private System.Windows.Forms.ColumnHeader columnNumCliente5;
        private System.Windows.Forms.ColumnHeader columnNumProd5;
        private System.Windows.Forms.Button btnConfig;
    }
}

