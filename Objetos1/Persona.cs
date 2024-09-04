using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos1
{
    internal class Persona
    {
       private int edad;
       private float sueldo;
       private string nombre;


        public Persona (string nombre)
        {
            this.nombre = nombre;
        }
       public void setEdad(int e) { edad = e; }
       public int getEdad() { return edad; }
        public void setNombre(string n)
        {
            nombre = n;
        }

      public string saludar() { return "hola soy..." + nombre; }
    public string saludar(string nombre)
        {
            return "hola! " + nombre + "soy.." + this.nombre;
        }

    }
}
