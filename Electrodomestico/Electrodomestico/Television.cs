using System;
using System.Collections.Generic;
using System.Text;

namespace Electrodomestico
{
    class Television: Electrodomestico
    {
        //Constantes
        private const int PULGADAS_POR_DEFECTO = 20;
        private const Boolean TDT_POR_DEFECTO = false;

        //atributos
        private int pulgadas;
        private Boolean TDT;

        //Constructores
        //Constructor por defecto
        public Television(): base() { }

        //Constructor con precio y peso
        public Television(Double precio, Double peso) : base(precio, peso) {
            this.pulgadas = PULGADAS_POR_DEFECTO;
            this.TDT = TDT_POR_DEFECTO;
        }


        //Constructor con la resolucion y TDT y el resto de los atributos heredados
        public Television(Double precioBase, Enums.Colores color, Enums.consumoEnergetico consumo, Double peso, int pulgadas, Boolean tdt): 
            base(precioBase, color, consumo, peso) {
            this.TDT = tdt;
            this.pulgadas = pulgadas;
        }


        //Setter y Getter
        public int Pulgadas { get => pulgadas; set => pulgadas = value; }
        public bool TDT1 { get => TDT; set => TDT = value; }


        //--------------------
        //  MÉTODOS
        //--------------------
        /// <summary>
        /// Se llamará al método del padre y se incrementará si tiene más de 40 pulgadas y TDT
        /// </summary>
        /// <returns></returns>
        public Double precioFinal()
        {
            Double precioFinal = base.precioFinal();

            //Incrementamos si la resolución es mayor de 40 pulgadas
            if (this.pulgadas > 40)
                precioFinal += ((precioFinal * 30)/100);

            //Incrementamos 50€ si tiene TDT
            if (this.TDT)
                precioFinal += 50;

            return precioFinal;
        }

        //Método auxiliar
        public String toString()
        {
            String data = "Television - Precio: " + precioFinal();
            return data;
        }
    }
}
