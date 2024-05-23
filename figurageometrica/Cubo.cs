using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurageometrica
{

    // Definición de la clase Cubo que hereda de la clase Figura
    class Cubo : Figura
    {
        // Constructor de la clase Cubo que toma la longitud del lado como parámetro
        public Cubo(float Ladoc)
        {
            this.Lado1 = Ladoc; // Establece la longitud del lado del cubo
        }

        // Método que sobrescribe el método para calcular el área de la figura
        public override float area()
        {
            // El área de un cubo es 6 veces el cuadrado de la longitud del lado
            return 6 * Lado1 * Lado1;
        }

        // Método que sobrescribe el método para calcular el volumen de la figura
        public override float volumen()
        {
            // El volumen de un cubo es el cubo de la longitud del lado
            return Lado1 * Lado1 * Lado1;
        }

        // Método que sobrescribe el método para calcular el perímetro de la figura
        public override float perimetro()
        {
            // Se lanza una excepción NotImplementedException
            // Esto indica que el cálculo del perímetro aún no ha sido implementado
            throw new NotImplementedException();
        }
    }

}
