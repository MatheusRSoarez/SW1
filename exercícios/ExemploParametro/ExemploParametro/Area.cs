using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploParametro
{
    internal class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public float AreaCalculada { get; set; }  

        public float calculaQuadrado()
        {
            if (Base == Altura)
            {
                AreaCalculada = Base * Altura;
            }
            else
            {
                Console.Write("Não é um quadrado. ");
            }
            return AreaCalculada;
        }

        public float calculaRetangulo()
        {
            AreaCalculada = Base * Altura;
            return AreaCalculada;
        }

        public float calculaTriangulo()
        {
            float areaTriangulo = AreaCalculada = (Base * Altura)/2;
            return areaTriangulo;
        }

        public void escolha(int opcao)
        {
           if(opcao == 1)
            {
                float quadrado = calculaQuadrado();
                Console.WriteLine("Área do quadrado é: " + quadrado);
            }else if(opcao == 2)
            {
                float retangulo = calculaRetangulo();
                Console.WriteLine("Área do Retangulo é: " + retangulo);
            }else if (opcao == 3)
            {
                float triangulo = calculaTriangulo();
                Console.WriteLine("Área do triangulo é: " + triangulo);
            }
        }
    }
}
