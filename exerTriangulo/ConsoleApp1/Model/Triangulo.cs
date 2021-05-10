using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangulo
    {

        private double a, b, c;


        public Triangulo(double ladoA, double ladoB, double ladoC)
        {

            a = ladoA;
            b = ladoB;
            c = ladoC;
        }
            
        private string EhValido()
        
        {
            string validacao = "";
            

            if ( a < b + c  && b < a + c && c < a + b)//validação
            {

               return validacao = "Triangulo OK";

            }

            return validacao = "Triangulo com algum erro";
        }

        public string TipoTriangulo()
        {
            string validacao = "";


            if (EhValido() != "Triangulo com algum erro")
            {
                                            
                 if (a == b && a == c)//equi
                {
                    return validacao = "Triangulo Equilatero";

                }
                else if (a != b && b != c && a != c)//esca
                {
                    return validacao = "Triangulo Escaleno";

                }
                else if (a == b || a == c || b == a || b == c || c == a || c == b)//isó
                {
                    return validacao = "Triangulo isósceles";
                }

            }
            return EhValido();
        }
    }
}
