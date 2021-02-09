namespace LVAPV07
{
    partial class frmUno
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
            this.btnLlevar = new System.Windows.Forms.Button();
            this.lblFormaUno = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlevar
            // 
            this.btnLlevar.Location = new System.Drawing.Point(640, 403);
            this.btnLlevar.Name = "btnLlevar";
            this.btnLlevar.Size = new System.Drawing.Size(148, 23);
            this.btnLlevar.TabIndex = 0;
            this.btnLlevar.Text = "Llevame a la Forma 2";
            this.btnLlevar.UseVisualStyleBackColor = true;
            this.btnLlevar.Click += new System.EventHandler(this.btnLlevar_Click);
            // 
            // lblFormaUno
            // 
            this.lblFormaUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaUno.ForeColor = System.Drawing.Color.Red;
            this.lblFormaUno.Location = new System.Drawing.Point(306, 163);
            this.lblFormaUno.Name = "lblFormaUno";
            this.lblFormaUno.Size = new System.Drawing.Size(182, 50);
            this.lblFormaUno.TabIndex = 1;
            this.lblFormaUno.Text = "Forma Uno";
            this.lblFormaUno.Click += new System.EventHandler(this.lblForma1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 403);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblFormaUno);
            this.Controls.Add(this.btnLlevar);
            this.Name = "frmUno";
            this.Text = "Forma1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlevar;
        private System.Windows.Forms.Label lblFormaUno;
        private System.Windows.Forms.Button btnCerrar;
    }
}

