using Operaciones.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Functions
{
    public class Menu
    {
        public void Menus()
        {
            int opcion;
            float num1,num2,num3,num4,num5;
            Console.Clear();
            Console.WriteLine("Menu de operaciones");
            Console.WriteLine("| 1 suma |2 resta | 3 producto | 4 division | 5 Dolar a peso |");
            opcion = int.Parse(Console.ReadLine());

            Operaciones operacion = new Operaciones();

            if ( opcion == 5 )
            {
                operacion.Convertion();
                return;
            }

            Console.Clear();
            Console.Write("Ingresa un numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Ingresa un numero: ");
            num2 = float.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    #region Suma
                    Console.Write("Ingresa un numero: ");
                    num3 = float.Parse(Console.ReadLine());
                    Console.Write("Ingresa un numero: ");
                    num4 = float.Parse(Console.ReadLine());
                    Console.Write("Ingresa un numero: ");
                    num5 = float.Parse(Console.ReadLine());
                    #endregion
                    Console.WriteLine("La suma es: " + operacion.Suma(num1, num2, num3,num4,num5));
                    break;
                case 2:
                    Console.WriteLine("La suma es: " + operacion.Resta(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("La suma es: " + operacion.Producto(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("La suma es: " + operacion.Div(num1, num2));
                    break;
                default : 
                    Console.WriteLine("No existe esa opcion");
                    break;
            }
        }
    }
}
