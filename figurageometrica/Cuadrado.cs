using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurageometrica
{
    // Definición de la clase Cuadrado que hereda de la clase Figura
    class Cuadrado : Figura
    {
        // Constructor de la clase Cuadrado que recibe un parámetro lado1
        public Cuadrado(float lado1)
        {
            // El valor del lado se asigna al atributo Lado1 de la clase Cuadrado
            this.Lado1 = lado1;
            // Aquí, this.Lado1 se refiere al atributo Lado1 de esta clase (Cuadrado),
            // no al de la clase Figura.
        }

        // Método que sobrescribe el método área de la clase base Figura
        public override float area()
        {
            // Retorna el área del cuadrado, que es el lado1 multiplicado por sí mismo
            return Lado1 * Lado1;
        }

        // Método que sobrescribe el método perímetro de la clase base Figura
        public override float perimetro()
        {
            // Retorna el perímetro del cuadrado, que es el lado1 multiplicado por 4
            return Lado1 * 4;
        }

        // Método que sobrescribe el método volumen de la clase base Figura
        public override float volumen()
        {
            // Aquí se lanza una excepción porque el volumen no es aplicable a un cuadrado
            throw new NotImplementedException();
            // La excepción NotImplementedException indica que este método no está implementado todavía.
        }
    }

}
