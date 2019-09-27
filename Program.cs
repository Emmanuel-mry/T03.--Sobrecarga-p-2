using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    class Program
    {
        static void Main(string[] args)


      
        {
           
            Datos dt = new Datos(); 
            dt.ObtenerDatos();
            Console.ReadLine();


            Operaciones OP = new Operaciones(); 
           //No se si esto era lo que queria que hiciera el programa porque aqui le estoy dando valores
            
            var res = OP.Multiplicar(2, 3);
            var res1 = OP.Multiplicar(5);
            var res2 = OP.Multiplicar();
            Console.WriteLine(res + "\t" + res1 + "\t" + res2);
            Console.ReadLine();

        }
        
        
    }
            
    }

