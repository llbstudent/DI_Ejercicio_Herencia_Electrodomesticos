
using System;

namespace Electrodomestico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un array de Electrodomesticos de 10 posiciones.
            Electrodomestico[] misElectrodomesticos = new Electrodomestico[10];

            //Asignamos a cada posición un objeto de las clases anteriores con los valores que deseemos.
            //Podemos rellenarlo con valores predeterminados o manualmente
            Console.WriteLine("*******************" +
                "[1]-Predeterminado" +
                "[2]-Manual" +
                "*******************");
            Console.Write("Seleccione cómo desea rellenar el vector de electrodomésticos (inserte número): ");
            int opcionRellenoArray = Convert.ToInt32(Console.ReadLine());

            if(opcionRellenoArray == 1)
            {

            }else if(opcionRellenoArray == 2)
            {
                rellenarArrayElectrodomesticos(misElectrodomesticos);
            }
            

            //recorremos el array y ejecutamos el método precioFinal()
            ejecutarPrecioFinal(misElectrodomesticos);

            //Mostramos el precio de cada clase
            Console.ReadLine();
        }

        //---------------------------
        //  MÉTODOS
        //---------------------------
        private static void ejecutarPrecioFinal(Electrodomestico[] elec)
        {
            Console.Clear();
            Console.WriteLine("**************.:. LISTADO DE PRECIOS .:.**************");
            for (int i = 0; i < elec.Length; i++)
            {
                Console.WriteLine((1 + i) + "-Electrodoméstico " + elec[i].precioFinal());
            }
        }

        /// <summary>
        /// Método en el que rellenaremos el array de electrodomésticos al gusto
        /// </summary>
        /// <param name="misElectrodomesticos"></param>
        private static void rellenarArrayElectrodomesticos(Electrodomestico[] elect)
        {
            Console.WriteLine("\n*******************  EJERCICIO ELECTRODPOMÉSTICOS - HERENCIA *******************" +
                    "\n[1]-Electrodoméstico normal" +
                    "\n[2]-Lavadora" +
                    "\n[3]-Televisor" +
                    "\n*********************************************************************************");

            for (int i=0; i < elect.Length; i++)
            {
                //Booleano que nos ayudará para que sólo nos deje introudcir estos 3 números
                Boolean formatoCorrecto = true;
                int opcionElec = 0;
                //Bucle que nos ayudará a controlar las excepciones y rellenar el array
                do
                {
                    formatoCorrecto = true;
                    try
                    {
                        Console.Write("\nSeleccione que quiere que sea el electrodoméstico núm[" + (1 + i) + "]: ");
                        opcionElec = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Inserte un formato correcto por favor");
                        formatoCorrecto = false;
                    }
                    catch (Exception e) // Para que nos capture otra excepción, por si acaso ocurriese
                    {
                        Console.WriteLine(e.Message);
                        formatoCorrecto = false;
                    }

                    //Switch: según el número que hayamos introducido nos creará un tipo de electrodoméstico u otro
                    switch (opcionElec)
                    {
                        // Electrodoméstico
                        case 1:
                            Console.Clear();
                            Console.WriteLine("HA ELEGIDO ELECTRODOMÉSTICO NORMAL");
                            Console.WriteLine("[1]-Por defecto" +
                                "\n[2]-Con Precio y Peso" +
                                "\n[3]-Con todos sus atributos");

                            Console.Write("Seleccione cómo desea crear su Electrodoméstico: ");

                            //Variable que nos ayudará a crear el electrodomésticos usando los diferentes constructores
                            int opcionCreacionElectrodomestico = Convert.ToInt32(Console.ReadLine());

                            switch (opcionCreacionElectrodomestico)
                            {
                                case 1:
                                    elect[i] = new Electrodomestico();
                                    break;

                                case 2:
                                    elect[i] = creacionConPrecio_Y_Peso("electrodomestico");
                                    break;

                                case 3:
                                    elect[i] = creacionConTodosLosAtributos("electrodomestico");
                                    break;

                                //Sino especificamos se creará por defecto
                                default:
                                    elect[i] = new Electrodomestico();
                                    Console.WriteLine("Debido a un error, se ha creado por defecto");
                                    break;
                            }         
                            break;
                        
                        // Lavadora
                        case 2:
                            Console.Clear();
                            Console.WriteLine("HA ELEGIDO LAVADORA");
                            Console.WriteLine("[1]-Por defecto" +
                                "\n[2]-Con Precio y Peso" +
                                "\n[3]-Con todos sus atributos");

                            Console.Write("Seleccione cómo desea crear su Lavadora: ");
                            elect[i] = new Lavadora();
                            //Variable que nos ayudará a crear la instancia de 'Lavadora' usando los diferentes constructores
                            int opcionCreacionLavadora = Convert.ToInt32(Console.ReadLine());

                            switch (opcionCreacionLavadora)
                            {
                                case 1:
                                    elect[i] = new Lavadora();
                                    break;

                                case 2:
                                    elect[i] = creacionConPrecio_Y_Peso("lavadora");
                                    break;

                                case 3:
                                    elect[i] = creacionConTodosLosAtributos("lavadora");
                                    break;

                                //Sino especificamos se creará por defecto
                                default:
                                    elect[i] = new Lavadora();
                                    Console.WriteLine("Debido a un error, se ha creado por defecto");
                                    break;
                            }
                            break;

                        // Televisor
                        case 3:
                            Console.Clear();
                            Console.WriteLine("HA ELEGIDO TELEVISOR");
                            Console.WriteLine("[1]-Por defecto" +
                                "\n[2]-Con Precio y Peso" +
                                "\n[3]-Con todos sus atributos");

                            Console.Write("Seleccione cómo desea crear su Televisor: ");
                            elect[i] = new Television();
                            //Variable que nos ayudará a crear la instancia de 'Television' usando los diferentes constructores
                            int opcionCreacionTelev = Convert.ToInt32(Console.ReadLine());

                            switch (opcionCreacionTelev)
                            {
                                case 1:
                                    elect[i] = new Television();
                                    break;

                                case 2:
                                    elect[i] = creacionConPrecio_Y_Peso("televisor");
                                    break;

                                case 3:
                                    elect[i] = creacionConTodosLosAtributos("televisor");
                                    break;

                                //Sino especificamos se creará por defecto
                                default:
                                    elect[i] = new Television();
                                    Console.WriteLine("Debido a un error, se ha creado por defecto");
                                    break;
                            }
                            break;

                        //Para que nos controle que no se haya introducido otro número que no sean esos 3
                        default:
                            Console.WriteLine("Inserte un número correcto por favor");
                            formatoCorrecto = false;
                            break;
                    }


                } while (!formatoCorrecto);

                
            }
        }

        /// <summary>
        /// Nos creará una instancia del electrodoméstico dependiendo de cual le hayamos especificado previamente
        /// Usaremos el constructor que solo posee los atributos de 'peso' y precio
        /// </summary>
        /// <param name="tipoElec"></param>
        /// <returns></returns>
        private static Electrodomestico creacionConPrecio_Y_Peso(string tipoElec)
        {
            Console.Clear();
            Console.WriteLine("Ha elegido {0}", tipoElec);
            Console.Write("Inserte el precio-Base del producto: ");
            Double precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inserte el peso del producto: ");
            Double peso = Convert.ToDouble(Console.ReadLine());

            switch (tipoElec)
            {
                case "electrodomestico":
                    Electrodomestico e = new Electrodomestico(precio, peso);
                    return e;

                case "lavadora":
                    Lavadora l = new Lavadora(precio, peso);
                    return l;

                case "televisor":
                    Television t = new Television(precio, peso);
                    return t;

                default:
                    Electrodomestico e2 = new Electrodomestico(precio, peso);
                    return e2;
                    
            }
        }

        /// <summary>
        /// Nos creará una instancia de los diferentes electrodomesticos, según el tipo que le pasemos
        /// Usaremos el constructor que posee a todos los atributos
        /// </summary>
        /// <param name="tipoElec"></param>
        /// <returns></returns>
        private static Electrodomestico creacionConTodosLosAtributos(string tipoElec)
        {
            //Obtenemos primero todos los datos/atributos de l clase padre 'Electrodomestico'
            Console.Clear();
            Console.WriteLine("Ha elegido {0}", tipoElec);
            Console.Write("Inserte el precio-Base del producto: ");
            Double precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inserte el peso del producto: ");
            Double peso = Convert.ToDouble(Console.ReadLine());

            //Bucle que nos ayudará a introducir correctamente los valores del color y del consumo energético
            do
            {
                Console.Write("Inserte el color del producto: ");
                String color = Console.ReadLine();
                Console.Write("Inserte el consumo del producto: ");
                char consumo = Console.ReadLine()[0];

                //Nos aseguramos que el color y el consumo son valores correctos
                // Sino se les asignará uno por defecto
                Boolean consumoOK = Electrodomestico.comprobarConsumoEnergetico(consumo);
                Boolean colorOK = Electrodomestico.comprobarColor(color);

                if (consumoOK && colorOK)
                {
                    switch (tipoElec)
                    {
                        case "electrodomestico":
                            Electrodomestico e = new Electrodomestico(precio, Electrodomestico.obtenerColor(color), Electrodomestico.obtenerConsumoEnergetico(consumo), peso);
                            return e;

                        case "lavadora":
                            Console.Write("Inserte los kilos de la carga de la lavadora: ");
                            Double carga = Convert.ToDouble(Console.ReadLine());
                            Lavadora l = new Lavadora(precio, Electrodomestico.obtenerColor(color), Electrodomestico.obtenerConsumoEnergetico(consumo), peso, carga);
                            return l;

                        case "televisor":
                            Console.Write("Inserte el número de pulgadas: ");
                            int pulgadas = Convert.ToInt32(Console.ReadLine());
                            Console.Write("¿Tiene 'TDT' integrado? (Si/No)");
                            Boolean tdt;
                            String respuestaTDT = Console.ReadLine();

                            if (respuestaTDT.ToLower().Trim() == "si")
                                tdt = true;
                            else
                                tdt = false;
                            
                            Television t = new Television(precio, Electrodomestico.obtenerColor(color), Electrodomestico.obtenerConsumoEnergetico(consumo), peso, pulgadas, tdt);
                            return t;

                        default:
                            Electrodomestico e2 = new Electrodomestico(precio, Electrodomestico.obtenerColor(color), Electrodomestico.obtenerConsumoEnergetico(consumo), peso);
                            return e2;
                    }
                }
                else
                {
                    Console.WriteLine("Debe introducir un valor apto para el color y para el consumo");
                }
            } while (true);//Fin do-while   

        }
    }
}
