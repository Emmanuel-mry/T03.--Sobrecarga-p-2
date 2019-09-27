using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    class Datos
    {
        public void ObtenerDatos() //En este metodo se le piden datos a los usuarios
        {
            Console.WriteLine("    BIENVENIDO");
            Console.WriteLine("INGRESE 2 DATOS");
            Console.WriteLine();
            Console.WriteLine("DATO 1");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("DATO 2");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Operaciones OP = new Operaciones();
            double res = OP.Multiplicar(x, y), res1 = OP.Multiplicar(x), res2 = OP.Multiplicar(); //Llamando a la sobre carga
                
            Console.WriteLine("EL RESULTADO ES:"+" "+res);
            Console.WriteLine("EL RESULTADO ES:" + " " + res1);
            Console.WriteLine("EL RESULTADO ES:" + " " + res2);
        }
    }
}
