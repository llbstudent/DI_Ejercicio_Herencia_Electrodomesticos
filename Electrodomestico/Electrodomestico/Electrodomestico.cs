using System;
using System.Collections.Generic;
using System.Text;

namespace Electrodomestico
{
    //Clase padre de las que heredaran 'Television' y Lavadora'
    class Electrodomestico
    {
        //Variables constantes
        private const Double PRECIO_POR_DEFECTO = 100;
        private const Enums.Colores COLOR_POR_DEFECTO = Enums.Colores.blanco;
        private const Enums.consumoEnergetico CONSUMO_POR_DEFECTO = Enums.consumoEnergetico.F;
        private const Double PESO_POR_DEFECTO = 5.00;

        //Atributos
        protected Double precioBase;
        protected Enums.Colores color;
        protected Enums.consumoEnergetico consumo;
        protected Double peso;


        //Setter y Getter (Aquí estarán los métodos 'get' de todos los atributos )
        public Double PrecioBase { get => precioBase; set => precioBase = value; }
        public Enums.Colores Color { get => color; set => color = value; }
        public Enums.consumoEnergetico Consumo { get => consumo; set => consumo = value; }
        public Double Peso { get => peso; set => peso = value; }


        //Constructores
        //Vacío
        public Electrodomestico() {
            this.precioBase = PRECIO_POR_DEFECTO;
            this.color = COLOR_POR_DEFECTO;
            this.consumo = CONSUMO_POR_DEFECTO;
            this.peso = PESO_POR_DEFECTO;
        }
        
        //Con el precio y el peso
        public Electrodomestico(Double precio, Double peso) {
            this.precioBase = precio;
            this.peso = peso;
            this.color = COLOR_POR_DEFECTO;
            this.consumo = CONSUMO_POR_DEFECTO;
        }

        //Constructor con todos los atributos pasados por parámetros
        public Electrodomestico(Double precioBase, Enums.Colores color, Enums.consumoEnergetico consumo, Double peso) {
            this.precioBase = precioBase;
            this.color = color;
            this.consumo = consumo;
            this.peso = peso;
        }


        //----------------------------------
        //  MÉTODOS
        //----------------------------------
        //Nos comprueba si el tipo de consumo energético es apto/de los predeterminados
        public static Boolean comprobarConsumoEnergetico(char letra)
        {
            Boolean consumoApto = false;

            if (letra == 'A' || letra == 'B' ||
                letra == 'C' || letra == 'D' ||
                letra == 'E' || letra == 'F')
            {
                consumoApto = true;
            }
            else
            {
                Console.WriteLine("El consumo no es apto");
            }
            return consumoApto;
        }

        
        //Pasada una letra nos devuelve un tipo de consumo
        public static Enums.consumoEnergetico obtenerConsumoEnergetico(char letra)
        {
            switch (letra)
            {
                case 'A':
                    return Enums.consumoEnergetico.A;
                case 'B':
                    return Enums.consumoEnergetico.B;
                case 'C':
                    return Enums.consumoEnergetico.C;
                case 'D':
                    return Enums.consumoEnergetico.D;
                case 'E':
                    return Enums.consumoEnergetico.E;
                case 'F':
                    return Enums.consumoEnergetico.F;
                default:
                    return Enums.consumoEnergetico.ERROR;
            }
        }

        //Nos comprueba el color del electrodoméstico
        public static Boolean comprobarColor(String color)
        {
            color = color.ToLower().Trim();
            Boolean colorApto = false;

            if (color == "blanco" || color == "rojo" || color == "azul" ||
                color == "negro" || color == "gris")
            {
                colorApto = true;
            }
            else
            {
                Console.WriteLine("El color no es apto");
            }
            return colorApto;
        }

        public static Enums.Colores obtenerColor(String color)
        {
            switch (color)
            {
                case "rojo":
                    return Enums.Colores.rojo;
                case "blanco":
                    return Enums.Colores.blanco;
                case "azul":
                    return Enums.Colores.azul;
                case "negro":
                    return Enums.Colores.negro;
                case "gris":
                    return Enums.Colores.gris;
                default:
                    return Enums.Colores.ERROR;
            }
        }


        //Calculará el precio final
        public Double precioFinal()
        {
            //Primero cogemos el precioBase
            Double precioFinal = this.precioBase;

            //Luego le sumamos cantidad según el consumo
            switch (this.consumo)
            {
                case Enums.consumoEnergetico.A:
                    precioFinal += 100;
                    break;

                case Enums.consumoEnergetico.B:
                    precioFinal += 80;
                    break;

                case Enums.consumoEnergetico.C:
                    precioFinal += 60;
                    break;

                case Enums.consumoEnergetico.D:
                    precioFinal += 50;
                    break;

                case Enums.consumoEnergetico.E:
                    precioFinal += 30;
                    break;

                case Enums.consumoEnergetico.F:
                    precioFinal += 10;
                    break;
            }

            //Al final el peso
            if(this.peso < 20)
            {
                precioFinal += 10;

            }else if (this.peso >= 20 && this.peso < 50)
            {
                precioFinal += 50;

            }
            else if (this.peso >= 50 && this.peso < 80)
            {
                precioFinal += 80;
            }
            else
            {
                precioFinal += 100;
            }

            return precioFinal;
        }


        //Método auxiliar
        public String toString()
        {
            String data = "Electrodomestico - Precio: " + precioFinal();
            return data;
        }
    }
}
