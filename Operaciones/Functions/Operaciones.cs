using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Functions
{
    public class Operaciones
    {

        public int opcion;
        public float num, rest, prod = 0, div = 0, total = 0;
        public float Suma(float num1, float num2, float num3, float num4, float num5)
        {
            float resultado = num1 + num2 + num3 + num4 + num5;
            return resultado;
        }
        public float Resta(float num1, float num2)
        {
            float resultado = num1 - num2;
            return resultado;
        }
        public float Producto(float num1, float num2)
        {
            float resultado = num1 * num2;
            return resultado;
        }
        public float Div(float num1, float num2)
        {
            float resultado = num1 / num2;
            return resultado;
        }
        public void Convertion()
        {
            double dolar,peso;
            Console.WriteLine("¿Cuantos dolares tienes?");
            dolar = float.Parse(Console.ReadLine());
            peso = dolar * 17.5;
            Console.WriteLine($"Tienes {peso} pesos");
        }
    }
}