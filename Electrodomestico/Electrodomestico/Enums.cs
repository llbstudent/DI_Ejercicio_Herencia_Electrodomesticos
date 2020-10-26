using System;
using System.Collections.Generic;
using System.Text;

namespace Electrodomestico
{
    /// <summary>
    /// Usaremos 'enums' en vez de tipos rpimitivos para que no podamos introducir una de las opciones que no sean estas
    /// </summary>
    class Enums
    {
        
        //Enum para los colores disponibles para los electromesticos
        public enum Colores
        {
            blanco, negro, rojo, azul, gris, ERROR
        }

        public enum consumoEnergetico
        {
            A, B, C, D , E , F, ERROR
        }
    }
}
