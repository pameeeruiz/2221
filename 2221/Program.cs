using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2221
{
    //Gutierrez Ruiz Evelyn Pamela
    internal class Program
    {
        static void Main(string[] args)
        {
            acciones acciones = new acciones();
            int opcion;
            do
            {
                 opcion = menu();
                switch (opcion)
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
                        int c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + acciones.resta(c, d));
                        break;
                    case 3:
                        Console.WriteLine("Multiplicacion");
                        Console.WriteLine("Ingrese el primer numero");
                        int e = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int f = int.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + acciones.multiplicacion(e, f));
                        break;
                    case 4:
                        Console.WriteLine("Division");
                        Console.WriteLine("Ingrese el numero a dividir");
                        double p = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el numero divisor");
                        double m = double.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + acciones.division(p,m));
                        break;
                    case 5:
                        salir();
                   
                        break;
                }
            }
            while (opcion != 5 );

        }
        static int menu()
        {
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Salir");
            Console.WriteLine();
            return int.Parse(Console.ReadLine());
            
        }

        static void salir()
        {
            Console.WriteLine("Gracias por usar el programa");
            
        }
    }
}