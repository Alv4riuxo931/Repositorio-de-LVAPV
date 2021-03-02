using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Personaje
    {
        #region atributos
        public Point posicion;
        public Size tamanio;
        private int velocidad;
        private string nombre;
        private int vida;
        #endregion
        #region propiedades
        public int Vida 
        { 
            get { return this.vida; }
            set { this.vida = (0<=value && value <= 100)?value: this.vida; }
            //set
            //{
            //    if (0 <= value && value <= 100)
            //    {
            //        this.vida = value;
            //    }
            //    else
            //    {
            //        this.vida = this.vida;
            //    }
            //}
        }
        public string Nombre 
        { 
            get { return this.nombre; }
            set { this.nombre = value; } 
        }
        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = value; }
        }
        public Size Tamanio
        {
            get { return this.tamanio; }
            set { this.tamanio = value; }
        }
        public Point Posicion
        {
            get { return this.posicion; }
            set { this.posicion = value; }
        }
        #endregion
        #region métodos
        public Personaje() 
        {
            this.nombre = "Rosa";
            this.vida = 100;
            this.velocidad = 10;
            this.posicion = new Point(0, 0);
            this.tamanio = new Size(100, 100);
        }
        #endregion
    }
}
