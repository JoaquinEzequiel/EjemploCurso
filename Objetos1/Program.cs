using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            float sueldo;
            string nombre;
            int[] edades = new int[10];


            Persona persona1 = new Persona(" joaquin");
            persona1.setEdad(20);
            Console.WriteLine(persona1.saludar());
            persona1.ge



           /** Botella b1 = new Botella("Violeta", "Plastico");
            b1.Capacidad = 200;
            Botella b2 = new Botella();


            Console.WriteLine("la capacidad de la botella es de: " + b1.Capacidad);
            Console.WriteLine("El color de la botella es: " + b1.getColor() + "y su material es de: " + b1.getMaterial());
            Console.WriteLine("la edad de la persona es: " + persona1.getEdad());

            Perro Perro1 = new Perro();
            Perro Perro2 = new Perro();
            Perro Perro3 = new Perro();

            Perro1.Tipo = 1;
            Perro2.Tipo = 2;
            

            Perro1.setNombre("rufus");
            Perro2.setNombre("Willi");
            Perro3.setNombre("Alfred");
            Perro1.setColor("Negro");
            Perro2.setColor("Negro");
            

            if (Perro1.getColor() == Perro2.getColor())
            {
                Console.WriteLine("Ingrese un 3er perro..");
                Console.WriteLine("Ingrese el tipo..");
                Perro3.Tipo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre");



            }**/

            Console.ReadKey();



        }


    }
}
