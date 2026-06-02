using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_servicio_y_Vectores
{
    internal class NumericServices
    {
        public int[] Numeros = new int [100];
        public int Cantidad;

        public void RegistrarNumero(int Numero)
        {
            Numeros[Cantidad] = Numero;
            Cantidad++;
        }
        public int ObtenerAcumulado()
        {
            int suma = 0;
            for (int i = 0; i < Cantidad; i++)
            {
                suma += Numeros[i];
            }
            return suma;
        }
        public double ObtenerPromedio()
        {
            double promedio = 0;
            if (Cantidad > 0) 
            {
                promedio = (double) ObtenerAcumulado() / Cantidad;
            }
            return promedio;
        }
        public void ObtenerNumeros(int indiceDesde, int indiceHasta)
        {
            for (int i = indiceDesde; i <= indiceHasta; i++)
            {
                Console.WriteLine(Numeros[i]);
            }
        }
    }
}
