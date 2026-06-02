using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_servicio
{
    internal class NumericService
    {
        public int Acumulado = 0;
        public int Cantidad = 0;

        public void RegistrarNumero(int numero)
        {

            Acumulado = Acumulado + numero;
            Cantidad++;

        }
        public int ObtenerAcumulado()
        { 
            return Acumulado;
        }
        public double ObtenerPromedio()
        {
            double Promedio = 0;
            if (Cantidad > 0)
            {
                Promedio = 1.0 * Acumulado / Cantidad;
            }
            return (double)Acumulado / Cantidad;
        }
    }
}