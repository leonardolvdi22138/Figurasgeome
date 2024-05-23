using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurageometrica
{
    class Triangulo:Figura
    {
       
        private float lado2;
        
        public float Lado2
        {
            set
            {
               
                if (value < 0)
                {
                    lado2 = 0; 
                }
                else
                {
                    lado2 = value;
                }
            }
            get 
            {
                return lado2;
            }
        }

        
        private float baseTriangulo;
        
        public float Base
        {
            set
            {
                
                if (value < 0)
                {
                    baseTriangulo = 0;
                }
                else
                {
                    baseTriangulo = value;
                }
            }
            get
            {
                return baseTriangulo;
            }
            
        }

        // Creación
        private float altura;
        // Propiedad para la altura
        public float Altura
        {
            set
            {
                // Pregunta si el valor < 0
                if (value < 0)
                {
                    altura = 0; // Asigna el valor a 0
                }
                else
                {
                    altura = value;
                }
            }
            get // Obtener el valor
            {
                return altura; // Retorna el valor de la variable altura
            }
        }

        // Constructor del triángulo
        public Triangulo(float lado1, float lado2, float baseTriangulo, float altura)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Base = baseTriangulo;
            this.Altura = altura;
        }

        // Sobrescribir los métodos de la clase padre
        public override float area()
        {
            return Base * Altura / 2;
        }

        public override float perimetro()
        {
            // El perímetro de un triángulo es la suma de sus tres lados
            return Lado1 + Lado2 + Base;
        }

        public override float volumen()
        {
            throw new NotImplementedException("El volumen no está definido para un triángulo.");
        }
    }
}

