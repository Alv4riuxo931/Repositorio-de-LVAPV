namespace LVAPV07
{
    partial class frmTres
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
            this.lblFormaTres = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormaTres
            // 
            this.lblFormaTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaTres.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblFormaTres.Location = new System.Drawing.Point(288, 156);
            this.lblFormaTres.Name = "lblFormaTres";
            this.lblFormaTres.Size = new System.Drawing.Size(194, 34);
            this.lblFormaTres.TabIndex = 0;
            this.lblFormaTres.Text = "Forma Tres";
            this.lblFormaTres.Click += new System.EventHandler(this.lblFormaTres_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 415);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblFormaTres);
            this.Name = "frmTres";
            this.Text = "Forma 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormaTres;
        private System.Windows.Forms.Button btnCerrar;
    }
}