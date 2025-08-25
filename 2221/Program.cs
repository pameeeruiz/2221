using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2221
{
    internal class Program
    {
        static void Main(string[] args)
        {
            acciones acciones = new acciones();
            while (true)
            {
                switch (menu())
                {
                    case 1:
                        Console.WriteLine("Suma");
                        Console.WriteLine("Ingrese el primer numero");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + acciones.suma(a, b));
                        break;
                    case 2:
                        Console.WriteLine("Resta");
                        Console.WriteLine("Ingrese el primer numero");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + acciones.resta(a, b));
                        break;
                    case 3:
                        Console.WriteLine("Multiplicacion");
                        Console.WriteLine("Ingrese el primer numero");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + acciones.multiplicacion(a, b));
                        break;
                    case 4:
                        Console.WriteLine("Division");
                        Console.WriteLine("Ingrese el primer numero");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + acciones.division(a, b));
                        break;
                    case 5:
                        salir();
                        break;
                }

            }



        }
        static int menu()
        {
            int opcion;
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Salir");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        static void salir()
        {
            Console.WriteLine("Gracias por usar el programa");
            Environment.Exit(0);
        }
    }
}