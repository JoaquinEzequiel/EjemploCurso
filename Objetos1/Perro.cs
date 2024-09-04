using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos1
{
    internal class Perro
    {
        private string Nombre;
        private int tipo;
        private string color;

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public void setColor(string c) { color = c; }
        public void setNombre(string n) {  Nombre = n; }
        public string getNombre() { return Nombre; }
        public string getColor() {  return color; }

    }
}
