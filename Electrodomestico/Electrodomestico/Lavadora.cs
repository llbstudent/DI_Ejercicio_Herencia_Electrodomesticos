using System;
using System.Collections.Generic;
using System.Text;

namespace Electrodomestico
{
    class Lavadora: Electrodomestico
    {
        //Constantes
        private const Double CARGA_POR_DEFECTO = 5.00;

        //Atributos
        private Double carga;

        //Constructores

        // Constructor por defecto
        public Lavadora() : base() {
            this.carga = CARGA_POR_DEFECTO;
        }

        // Constructor precio y pero por defecto
        public Lavadora(Double precio, Double peso): base(precio, peso) {
            this.carga = CARGA_POR_DEFECTO;
        }

        // Constructor con carga y resto de atributos heredados
        public Lavadora(Double precioBase, Enums.Colores color, Enums.consumoEnergetico consumo, Double peso , Double carga)
            : base(precioBase, color, consumo, peso) {
            this.carga = carga;
        }

        //Setter y Getter
        public double Carga { get => carga; set => carga = value; }


        //----------------------------------
        //  MÉTODOS
        //----------------------------------
        /// <summary>
        /// Se llamará al método del padre y se incrementará el precio si tiene una carga mayor a '30'
        /// </summary>
        /// <returns></returns>
        public Double precioFinal()
        {
            Double precioFinal = base.precioFinal();

            if (this.carga > 30)
                precioFinal += 50;

            return precioFinal;
        }

        //Método auxiliar
        public String toString()
        {
            String data = "Lavadora - Precio: " + precioFinal();
            return data;
        }
    }
}
