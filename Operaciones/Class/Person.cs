using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_1.Functions;
using Operaciones.Class;

namespace Operaciones.Class
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Career { get; set; }
        public int Age { get; set; }

        public void Request()
        {
            Console.Write("Ingresa tu nombre: ");
            this.Name = Console.ReadLine();
            Console.Write("Ingresa tu Apellido: ");
            this.LastName = Console.ReadLine();
            Console.Write("Ingresa tu carrera: ");
            this.Career = Console.ReadLine();
            Console.Write("Ingresa tu Edad: ");
            this.Age = int.Parse(Console.ReadLine());

            if (Age >= 18)
            {
                Menu menu = new Menu();
                /*Console.WriteLine("Eres mayor de edad");
                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();*/
                menu.Menus();
            }
            else
            {
                Console.WriteLine("Eres menor de edad, ingresa de nuevo");
                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                Request();
            }
        }
        public void Print()
        {
            Console.WriteLine("Tu numbre es: " + Name);
            Console.WriteLine("Tu apellido es: " + LastName);
            Console.WriteLine("Tu carrera es: " + Career);
            Console.WriteLine("Tu edad es: " + Age);
        }
    }
}
