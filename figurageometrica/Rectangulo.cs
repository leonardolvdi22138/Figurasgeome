using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurageometrica
{
    // Definición de la clase Rectangulo que hereda de la clase Figura
    class Rectangulo : Figura
    {
        // Se define un atributo privado para el segundo lado del rectángulo
        private float lado2;

        // Propiedad pública para acceder y modificar el valor del lado2
        public float Lado2
        {
            set
            {
                // Verifica si el valor asignado al lado2 es menor que 0
                if (value < 0)
                {
                    lado2 = 0; // Si es menor que 0, se establece como 0
                }
                else
                {
                    lado2 = value; // Si es mayor o igual a 0, se asigna el valor normalmente
                }
            }
            get
            {
                return lado2; // Devuelve el valor actual de lado2
            }
        }

        // Constructor de la clase Rectangulo que toma dos lados como parámetros
        public Rectangulo(float lado1, float lado2)
        {
            // Asigna los valores de los lados al lado1 y al lado2 utilizando la propiedad Lado1 y el setter de Lado2
            this.Lado1 = lado1;
            this.Lado2 = lado2;
        }

        // Método que sobrescribe el método área de la clase base Figura
        public override float area()
        {
            // Retorna el área del rectángulo, que es el producto de sus dos lados
            return Lado1 * Lado2;
        }

        // Método que sobrescribe el método perímetro de la clase base Figura
        public override float perimetro()
        {
            // Retorna el perímetro del rectángulo, que es la suma de sus cuatro lados
            return (2 * Lado1) + (2 * Lado2);
        }

        // Método que sobrescribe el método volumen de la clase base Figura
        public override float volumen()
        {
            // Aquí se lanza una excepción porque el volumen no es aplicable a un rectángulo
            throw new NotImplementedException();
            // La excepción NotImplementedException indica que este método no está implementado todavía.
        }
    }
}
