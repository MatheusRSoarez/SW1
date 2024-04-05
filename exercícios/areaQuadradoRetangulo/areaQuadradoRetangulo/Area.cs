using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace areaQuadradoRetangulo
{
    public class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int AreaCalculada { get; set; }
        public int Calcular()
        {
            AreaCalculada = Base * Altura;
            return AreaCalculada;
        }
        public string Calcular2()
        {
            string resultado = "";
            AreaCalculada = Base * Altura;
            if (Base == Altura)
            {
                 resultado = "Quadrado: "+AreaCalculada;
            }
            else
            {
                resultado = "Retângulo: "+AreaCalculada;
            }

            return resultado;
        }

        public void MostraDetalhes()
        {
            Console.WriteLine("Base: "+Base);
            Console.WriteLine("Altura: "+Altura);
            Console.WriteLine("Area: " + AreaCalculada);
        }
    }
}
