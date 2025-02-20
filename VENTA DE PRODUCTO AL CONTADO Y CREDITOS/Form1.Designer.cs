namespace VENTA_DE_PRODUCTO_AL_CONTADO_Y_CREDITOS
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
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnContado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTA DE PRODUCTO";
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(45, 95);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(154, 23);
            this.btnCredito.TabIndex = 1;
            this.btnCredito.Text = "VENTA AL CREDITO";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnContado
            // 
            this.btnContado.Location = new System.Drawing.Point(290, 95);
            this.btnContado.Name = "btnContado";
            this.btnContado.Size = new System.Drawing.Size(164, 23);
            this.btnContado.TabIndex = 2;
            this.btnContado.Text = "VENTA AL CONTADO";
            this.btnContado.UseVisualStyleBackColor = true;
            this.btnContado.Click += new System.EventHandler(this.btnContado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 271);
            this.Controls.Add(this.btnContado);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnContado;
    }
}

