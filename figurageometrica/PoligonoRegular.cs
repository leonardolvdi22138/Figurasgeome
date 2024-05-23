using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurageometrica
{
    class PoligonoRegular : Figura
    {
        //DECLARAR DOS VALORES FLOAT PARA GUARDAR NUMERO DE LADOS
        private float apo, n;
        
        public float Apo
        {
             set
            {
                //pregunta si el apotema (es el # del centro del poligono) <0
                if (value <= 0)
                {
                    apo = 0; //manda el valor a 0
                    //NO EXISTEN apotemas NEGATIVOS 
                }
                else
                {
                    apo = value;
                    //value es el valor del textbox 
                }
            }
            get //obtener el valor 
            {
                return apo; //regresa o cacha el valor de la variable apotema
            }
        } 
        public float N//validar el numero de lado >5
        {
            set
            {
                //pregunta si el # de los lados (n) >5 
                if (value < 5)
                {
                    n = 5;
                }
                else
                {
                    n = value;
                    //value es el valor del textbox 
                }
            }
            get //obtner valor
            {
                return n; //regresa o cacha el valor de la variable lado1
            }
        } 
        public PoligonoRegular (float lado,float apo, float n)
        { //radio se va a leer de la caja de texto con //usando el boton guardar 
            Lado1 = lado;
            Apo = apo;
            N = n;
        }
        //vamos a usar los metodos de la clase padre 
        //vamos a sobreescribir el comportamiento de estos
        public float area (float peri)
        {
            return (peri * apo) / 2;
        }
        public override float perimetro()
        {
            float peri;
            peri = n * Lado1;
            return peri;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXCEPCION DE USO DEFAULT DEL SISTEMA
        }
        public override float area()//calculo de area clase papa
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA 
        }
    }
}
