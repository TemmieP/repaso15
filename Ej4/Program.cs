using System;
using System.Collections.Generic;

namespace RegistroProductosApp
{
    class Producto
    {
        public string nombre;
        public double precio;
        public int stock;

        public Producto(string n, double p, int s)
        {
            nombre = n;
            precio = p;
            stock = s;
        }
    }

    class RegistroProductos
    {
        List<Producto> productos = new List<Producto>();

        public void Registrar()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el stock del producto: ");
            int stock = int.Parse(Console.ReadLine());

            productos.Add(new Producto(nombre, precio, stock));
            Console.WriteLine("\nProducto registrado correctamente!");

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Mostrar()
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos registrados!");
            }
            else
            {
                Console.WriteLine("Lista de productos:");
                for (int i = 0; i < productos.Count; i++)
                {
                    Producto p = productos[i];
                    Console.WriteLine($"{i}. Nombre: {p.nombre}, Precio: {p.precio}, Stock: {p.stock}");
                }
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Modificar()
        {
            Mostrar();

            Console.Write("Ingrese el índice del producto a modificar: ");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < productos.Count)
            {
                Console.Write("Nuevo nombre: ");
                productos[indice].nombre = Console.ReadLine();

                Console.Write("Nuevo precio: ");
                productos[indice].precio = double.Parse(Console.ReadLine());

                Console.Write("Nuevo stock: ");
                productos[indice].stock = int.Parse(Console.ReadLine());

                Console.WriteLine("\nProducto modificado correctamente!");
            }
            else
            {
                Console.WriteLine("\nÍndice inválido.");
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RegistroProductos registro = new RegistroProductos();
            int opcion;

            do
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Bienvenido al sistema de registro de productos:");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("1. Registrar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Modificar producto");
                Console.WriteLine("0. Salir");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        registro.Registrar();
                        break;
                    case 2:
                        registro.Mostrar();
                        break;
                    case 3:
                        registro.Modificar();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion != 0);
        }
    }
}
