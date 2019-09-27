using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    class Operaciones
    {
        public double Multiplicar()
        {
            var resultado = 0;
            return resultado;
        }

        public double Multiplicar(double x )
        {
            var resultado = x * x;
            return resultado;
            
        }

        public double Multiplicar(double y, double x)
        {
            var resultado = y * x;
            return resultado;

        }

    }

}
