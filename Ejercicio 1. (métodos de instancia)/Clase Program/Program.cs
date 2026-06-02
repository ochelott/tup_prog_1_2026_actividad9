using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do 
            {
                opcion = Calculos.PantallaMostrarMenu();
                switch (opcion)
                {
                    case 1:
                        Calculos.MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        Calculos.MostrarPantallaAcumulado();
                        break;
                    case 3:
                        Calculos.MostrarPantallaCantidadIngresados();
                        break;
                    case 4:
                        Calculos.MostrarPantallaPromedio();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Intente nuevamente.");
                        break;
                }
            } while (opcion != 5) ;
            Console.ReadKey();
            Console.WriteLine("Presione cualquier tecla para salir...");

        }
    }
}
