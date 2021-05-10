using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Program
    {
        static void Main(string[] args)
        {
           
            Triangulo triangulo = new Triangulo(3, 4, 5);//chamando clase e add valores

            Console.WriteLine(triangulo.TipoTriangulo());

            Console.ReadLine();
                      
         }
    }
}
