using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Program
{
    internal class Calculos
    {
        static public int Acumulado = 0;
        static public int Cantidad = 0;

        static public void RegistrarNumero(int numero)
        {
            Console.WriteLine("Ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            Acumulado = Acumulado + numero;
            Cantidad++;
            Console.Clear();
        }
        static public int ObtenerAcumulado()
        {
            Console.Clear();
            Console.WriteLine("El acumulado es: " + Acumulado);
            return Acumulado;
        }
        static public double ObtenerPromedio()
        {
            return (double)Acumulado / Cantidad;
        }
        static public int PantallaMostrarMenu()
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
        static public void MostrarPantallaSolicitarNumero()
        {
            RegistrarNumero(0);

        }
        static public void MostrarPantallaAcumulado()
        {
            Acumulado = ObtenerAcumulado();
        }
        static public void MostrarPantallaCantidadIngresados()
        {
            Console.Clear();
            Console.WriteLine("La cantidad de numeros acumulados es: " + Cantidad);
        }
        static public void MostrarPantallaPromedio()
        {
            Console.Clear();
            Console.WriteLine("El promedio es: " + ObtenerPromedio());
        }
    }
}