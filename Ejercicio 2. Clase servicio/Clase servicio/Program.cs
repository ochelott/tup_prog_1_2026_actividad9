using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_servicio
{
    internal class Program
    {
        static NumericService servicio = new NumericService();

        static int PantallaMostrarMenu()
        {
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("1. Registrar numero");
            Console.WriteLine("2. Mostrar acumulado");
            Console.WriteLine("3. Mostrar cantidad de acumulados");
            Console.WriteLine("4. Mostrar promedio");
            Console.WriteLine("5. Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaSolicitarNumero()
        {
            
            Console.WriteLine("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarNumero(numero);
            Console.Clear();
        }
        static void MostrarPantallaAcumulado()
        {
            Console.Clear();
            Console.WriteLine("El acumulado es: " + servicio.ObtenerAcumulado());
        }
        static  void MostrarPantallaCantidadIngresados()
        {
            Console.Clear();
            Console.WriteLine("La cantidad de numeros acumulados es: " + servicio.Cantidad);
        }
        static void MostrarPantallaPromedio()
        {
            Console.Clear();
            Console.WriteLine("El promedio es: " + servicio.ObtenerPromedio());
        }
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                opcion = PantallaMostrarMenu();
           
            switch (opcion)
            {
                case 1:
                    MostrarPantallaSolicitarNumero();
                    break;
                case 2:
                    MostrarPantallaAcumulado();
                    break;
                case 3:
                    MostrarPantallaCantidadIngresados();
                    break;
                case 4:
                    MostrarPantallaPromedio();
                    break;
                default:
                    Console.WriteLine("Saliendo del programa...");
                        break;
            }
            } while (opcion != 5);
            Console.ReadKey();
            Console.WriteLine("Ingrese cualquier tecla para salir...");
        }
    }
}
