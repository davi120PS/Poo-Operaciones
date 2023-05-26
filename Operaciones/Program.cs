using System;
using Operaciones.Class;

namespace Operaciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Request();
            person.Print();
        }
    }
}