namespace Caso01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DgPedidos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTotalPedidos = new System.Windows.Forms.Label();
            this.CboEmpleado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido y Nombre del Empleado";
            // 
            // DgPedidos
            // 
            this.DgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPedidos.Location = new System.Drawing.Point(41, 72);
            this.DgPedidos.Name = "DgPedidos";
            this.DgPedidos.Size = new System.Drawing.Size(747, 298);
            this.DgPedidos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total de Pedidos";
            // 
            // LblTotalPedidos
            // 
            this.LblTotalPedidos.AutoSize = true;
            this.LblTotalPedidos.Location = new System.Drawing.Point(735, 390);
            this.LblTotalPedidos.Name = "LblTotalPedidos";
            this.LblTotalPedidos.Size = new System.Drawing.Size(46, 13);
            this.LblTotalPedidos.TabIndex = 6;
            this.LblTotalPedidos.Text = "             ";
            // 
            // CboEmpleado
            // 
            this.CboEmpleado.FormattingEnabled = true;
            this.CboEmpleado.Location = new System.Drawing.Point(218, 26);
            this.CboEmpleado.Name = "CboEmpleado";
            this.CboEmpleado.Size = new System.Drawing.Size(236, 21);
            this.CboEmpleado.TabIndex = 7;
            this.CboEmpleado.SelectionChangeCommitted += new System.EventHandler(this.CboEmpleado_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CboEmpleado);
            this.Controls.Add(this.LblTotalPedidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgPedidos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTotalPedidos;
        private System.Windows.Forms.ComboBox CboEmpleado;
    }
}

