using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurageometrica
{
    class Circulo:Figura //es una clase hija de figura 
    {
        //usamos el constructor de la clase padre

        public Circulo(float radio)
        {
            //radio se va a leer de la caja de texto con 
            //usando el boton guardar 
            Lado1 = radio;
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobresalir el comportamiento d estos

        public override float area()
        {
            return 3.1416F * Lado1 * Lado1;
            //agregamos f al final de un numero cuando
            //es una constante no definida en una variable 
            //previamente
        }
        public override float perimetro()
        {
            return 3.1416F * 2 * Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //esto es una excepcion de uso default del SISTEMA 
        }
    }
}
