using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class PersonaTuning
    {
        private int edad;
        private float sueldo;
        private string nombre;

        public void setEdad(int e) {

            Console.WriteLine("diga su edad..");
            e = int.Parse(Console.ReadLine());
            edad = e; 
        }
        public int getEdad() { return edad; }
        public string setNombre (string n) {
            Console.WriteLine("indique su nombre...");
            Console.ReadLine(n);
            
            nombre = n; 
        }
        public string saludar() { return "Hola mi nombre es.." + nombre; }


    }




}

