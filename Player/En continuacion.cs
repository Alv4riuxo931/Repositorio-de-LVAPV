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
            velocidad = 10;
            rosa = new Personaje();
            
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            int velocidad = (int)nmrVelocidadPlayer.Value;
            pctPlayer.Location = new Point(pctPlayer.Location.X + velocidad, pctPlayer.Location.Y);
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            //int velocidad = int.Parse(nmrVelocidadPlayer.Value.ToString());
            //int velocidad = Convert.ToInt32(nmrVelocidadPlayer.Value.ToString());
            int velocidad = (int)nmrVelocidadPlayer.Value;
            pctPlayer.Location = new Point(pctPlayer.Location.X - velocidad, pctPlayer.Location.Y);
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            pctPlayer.Location = new Point(pctPlayer.Location.X, pctPlayer.Location.Y - (int)nmrVelocidadPlayer.Value);
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            pctPlayer.Location = new Point(pctPlayer.Location.X, pctPlayer.Location.Y + (int)nmrVelocidadPlayer.Value);
        }

        private void nmrVelocidadPlayer_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trcVelocidad_Scroll(object sender, EventArgs e)
        {

        }

        private void pctPlayer_Click(object sender, EventArgs e)
        {

        }
    }
}
