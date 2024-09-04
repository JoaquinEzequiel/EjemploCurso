using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos1
{
    internal class Botella
    {
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
        }
        public Botella() { }    

        private int capacidad;
        private string color;
        private string material;

        public int Capacidad { 
            
            get { return capacidad; } 
            set { capacidad = value; } 
    
        }
        public string getColor() { return color; }
        public string getMaterial() { return material; }




    }
}
