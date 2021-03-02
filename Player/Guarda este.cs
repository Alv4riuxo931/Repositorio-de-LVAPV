using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class frmJuego : Form
    {
        int velocidad;
        Personaje rosa;

        public frmJuego()
        {
            InitializeComponent();
            velocidad = (int)nmrVelocidadPlayer.Value;  
            rosa = new Personaje();
            
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.X + velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X + velocidad, pctPlayer.Location.Y);
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.X - velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X - velocidad, pctPlayer.Location.Y);
            }
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.Y -10 -velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X, pctPlayer.Location.Y - velocidad);
            }
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.Y - 10 + velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X, pctPlayer.Location.Y + velocidad);
            }
        }

        private void nmrVelocidadPlayer_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void trcVelocidad_Scroll(object sender, EventArgs e)
        {
            velocidad = (int)trcVelocidad.Value;
        }
    }
}
