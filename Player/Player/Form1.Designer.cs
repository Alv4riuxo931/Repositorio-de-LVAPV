namespace Player
{
    partial class frmJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJuego));
            this.pctPlayer = new System.Windows.Forms.PictureBox();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.nmrVelocidadPlayer = new System.Windows.Forms.NumericUpDown();
            this.trcVelocidad = new System.Windows.Forms.TrackBar();
            this.pctEnemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrVelocidadPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPlayer
            // 
            this.pctPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pctPlayer.Image")));
            this.pctPlayer.Location = new System.Drawing.Point(100, 150);
            this.pctPlayer.Name = "pctPlayer";
            this.pctPlayer.Size = new System.Drawing.Size(129, 143);
            this.pctPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPlayer.TabIndex = 0;
            this.pctPlayer.TabStop = false;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(684, 391);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 1;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(522, 391);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 2;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(603, 362);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(75, 23);
            this.btnArriba.TabIndex = 3;
            this.btnArriba.Text = "Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(603, 391);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnAbajo.TabIndex = 4;
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // nmrVelocidadPlayer
            // 
            this.nmrVelocidadPlayer.Location = new System.Drawing.Point(639, 273);
            this.nmrVelocidadPlayer.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrVelocidadPlayer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrVelocidadPlayer.Name = "nmrVelocidadPlayer";
            this.nmrVelocidadPlayer.Size = new System.Drawing.Size(120, 20);
            this.nmrVelocidadPlayer.TabIndex = 5;
            this.nmrVelocidadPlayer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrVelocidadPlayer.ValueChanged += new System.EventHandler(this.nmrVelocidadPlayer_ValueChanged);
            // 
            // trcVelocidad
            // 
            this.trcVelocidad.Location = new System.Drawing.Point(252, 369);
            this.trcVelocidad.Minimum = 1;
            this.trcVelocidad.Name = "trcVelocidad";
            this.trcVelocidad.Size = new System.Drawing.Size(213, 45);
            this.trcVelocidad.TabIndex = 6;
            this.trcVelocidad.Value = 1;
            this.trcVelocidad.Scroll += new System.EventHandler(this.trcVelocidad_Scroll);
            // 
            // pctEnemy
            // 
            this.pctEnemy.Image = ((System.Drawing.Image)(resources.GetObject("pctEnemy.Image")));
            this.pctEnemy.Location = new System.Drawing.Point(365, 192);
            this.pctEnemy.Name = "pctEnemy";
            this.pctEnemy.Size = new System.Drawing.Size(100, 101);
            this.pctEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEnemy.TabIndex = 7;
            this.pctEnemy.TabStop = false;
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctEnemy);
            this.Controls.Add(this.trcVelocidad);
            this.Controls.Add(this.nmrVelocidadPlayer);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.pctPlayer);
            this.Name = "frmJuego";
            this.Text = "Juego";
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrVelocidadPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPlayer;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.NumericUpDown nmrVelocidadPlayer;
        private System.Windows.Forms.TrackBar trcVelocidad;
        private System.Windows.Forms.PictureBox pctEnemy;
    }
}

