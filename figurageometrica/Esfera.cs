using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurageometrica
{
    // Definición de la clase Esfera que hereda de la clase Figura
    class Esfera : Figura
    {
        // Constructor de la clase Esfera que toma el radio como parámetro
        public Esfera(float rad)
        {
            this.Lado1 = rad; // Establece el radio de la esfera
        }

        // Método que sobrescribe el método para calcular el área de la figura
        public override float area()
        {
            // El área de una esfera es 4 * pi * radio^2
            return 4 * 3.1416F * (Lado1 * Lado1);
        }

        // Método que sobrescribe el método para calcular el perímetro de la figura
        public override float perimetro()
        {
            // En una esfera, el "perímetro" no se aplica directamente, 
            // pero aquí calculamos la "circunferencia", que es la distancia alrededor de la esfera
            // La circunferencia es 2 * pi * radio
            return 2 * 3.1416F * Lado1;
        }

        // Método que sobrescribe el método para calcular el volumen de la figura
        public override float volumen()
        {
            // El volumen de una esfera es (4/3) * pi * radio^3
            return (4 / 3) * 3.1416F * (Lado1 * Lado1 * Lado1);
        }
    }
}
