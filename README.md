PROFESSOR _ ÁLVARO LÓPEZ JURADO

AUTHOR _ LAURA LUCENA BUENDIA
<<<<<<< HEAD

Crearemos una Clase llamada Electrodomestico con las siguientes características: Sus atributos son:
=======
_____________
Crearemos una Clase llamada Electrodomestico con las siguientes características:
Sus atributos son:
>>>>>>> 7cea4e07e83960693cac70cb5ce4f032897bbcd9

-precio base

-color

-consumo energético (letras entre A y F)
<<<<<<< HEAD

-peso.

//Indica que se podrán heredar.

• Por defecto, el color será blanco, el consumo energético será F, el precioBase es de 100 € y el peso de 5 kg. Usa constantes para ello.

• Los colores disponibles son blanco, negro, rojo, azul y gris. No importa si el nombre está en mayúsculas o en minúsculas.

Los constructores que se implementaran serán:

• Un constructor por defecto.

• Un constructor con el precio y peso. El resto por defecto.

• Un constructor con todos los atributos.
=======

-peso. 

//Indica que se podrán heredar.

•	Por defecto, el color será blanco, el consumo energético será F,
	el precioBase es de 100 € y el peso de 5 kg. 
	Usa constantes para ello.
	
	
•	Los colores disponibles son blanco, negro, rojo, azul y gris.
	No importa si el nombre está en mayúsculas o en minúsculas.

Los constructores que se implementaran serán:

•	Un constructor por defecto.

•	Un constructor con el precio y peso. El resto por defecto.

•	Un constructor con todos los atributos.
>>>>>>> 7cea4e07e83960693cac70cb5ce4f032897bbcd9


Los métodos que implementara serán:

• Métodos get de todos los atributos.

<<<<<<< HEAD
• comprobarConsumoEnergetico(char letra): comprueba que la letra es correcta, sino es correcta usara la letra por defecto. Se invocara al crear el objeto y no sera visible.

• comprobarColor(String color): comprueba que el color es correcto, sino lo es usa el color por defecto. Se invocara al crear el objeto y no sera visible.

• precioFinal(): según el consumo energético, aumentara su precio, y según su tamaño, también. Esta es la lista de precios:

LETRA PRECIO

A 100 €

B 80 €

C 60 €

D 50 €

E 30 €

F 10 €

TAMAÑO PRECIO

Entre 0 y 19 kg 10 €

Entre 20 y 49 kg 50 €

Entre 50 y 79 kg 80 €

Mayor que 80 kg 100 €

CLASES QUE HEREDARAN

CLASE LAVADORA

Crearemos una clase llamada Lavadora (hererada de la anterior) con las siguientes características:

Su atributo es carga, ademas de los atributos heredados.

Por defecto, la carga es de 5 kg. Usa una constante para ello.
=======
• comprobarConsumoEnergetico(char letra): comprueba que la letra es correcta, sino es correcta usara la letra por defecto. 
	Se invocara al crear el objeto y no sera visible.

• comprobarColor(String color): comprueba que el color es correcto, sino lo es usa el color por defecto. 
	Se invocara al crear el objeto y no sera visible.

• precioFinal(): según el consumo energético, aumentara su precio, y según su tamaño, también. 
	Esta es la lista de precios:


LETRA		PRECIO

A		100 €

B		80 €

C		60 €

D		50 €

E		30 €

F		10 €

_______________________________
TAMAÑO			PRECIO

Entre 0 y 19 kg		10 €

Entre 20 y 49 kg	50 €

Entre 50 y 79 kg	80 €

Mayor que 80 kg		100 €


_______________________________
CLASES QUE HEREDARAN
_______________________________
CLASE LAVADORA
_______________________________
Crearemos una clase llamada Lavadora  (hererada de la anterior) con las siguientes características:

*	Su atributo es carga, ademas de los atributos heredados.

*	Por defecto, la carga es de 5 kg. Usa una constante para ello.
>>>>>>> 7cea4e07e83960693cac70cb5ce4f032897bbcd9


Los constructores que se implementaran serán:

<<<<<<< HEAD
Un constructor por defecto.

Un constructor con el precio y peso. El resto por defecto.

Un constructor con la carga y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clase padre.
=======
*	Un constructor por defecto.

*	Un constructor con el precio y peso. El resto por defecto.

*	Un constructor con la carga y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clase padre.
>>>>>>> 7cea4e07e83960693cac70cb5ce4f032897bbcd9


Los métodos que se implementara serán:

<<<<<<< HEAD
Método get de carga.

precioFinal():, si tiene una carga mayor de 30 kg, aumentara el precio 50 €, sino es así no se incrementara el precio. Llama al método padre y añade el código necesario. Recuerda que las condiciones que hemos visto en la clase Electrodomestico también deben afectar al precio.

CLASE TELEVISION
=======
*	Método get de carga.

*	precioFinal():, si tiene una carga mayor de 30 kg, aumentara el precio 50 €, sino es así no se incrementara el precio. Llama al método padre y añade el código necesario. 
	Recuerda que las condiciones que hemos visto en la clase Electrodomestico también deben afectar al precio.
>>>>>>> 7cea4e07e83960693cac70cb5ce4f032897bbcd9

_______________________________
CLASE TELEVISION
_______________________________
Crearemos una clase llamada Television (heredada de la clase electrodomestico) con las siguientes características:

<<<<<<< HEAD
Sus atributos son resolución (en pulgadas) y sintonizador TDT (booleano), ademas de los atributos heredados.

Por defecto, la resolución sera de 20 pulgadas y el sintonizador sera false.

Los constructores que se implementaran serán:

Un constructor por defecto.

Un constructor con el precio y peso. El resto por defecto.

Un constructor con la resolución, sintonizador TDT y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clase padre.
=======
*	Sus atributos son resolución (en pulgadas) y sintonizador TDT (booleano), ademas de los atributos heredados.

*	Por defecto, la resolución sera de 20 pulgadas y el sintonizador sera false.

*	Los constructores que se implementaran serán:

*	Un constructor por defecto.

*	Un constructor con el precio y peso. El resto por defecto.

*	Un constructor con la resolución, sintonizador TDT y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clase padre.
>>>>>>> 7cea4e07e83960693cac70cb5ce4f032897bbcd9



Los métodos que se implementara serán:

<<<<<<< HEAD
Método get de resolución y sintonizador TDT.

precioFinal(): si tiene una resolución mayor de 40 pulgadas, se incrementara el precio un 30% y si tiene un sintonizador TDT incorporado, aumentara 50 €. Recuerda que las condiciones que hemos visto en la clase Electrodomestico también deben afectar al precio.
=======
*	Método get de resolución y sintonizador TDT.

*	precioFinal(): si tiene una resolución mayor de 40 pulgadas, se incrementara el precio un 30% y si tiene un sintonizador TDT incorporado, aumentara 50 €.
	Recuerda que las condiciones que hemos visto en la clase Electrodomestico también deben afectar al precio.
>>>>>>> 7cea4e07e83960693cac70cb5ce4f032897bbcd9

______________________________________________________________
El programa hará lo siguiente:
<<<<<<< HEAD

Crea un array de Electrodomesticos de 10 posiciones.

Asigna a cada posición un objeto de las clases anteriores con los valores que desees.

Ahora, recorre este array y ejecuta el método precioFinal().

Deberás mostrar el precio de cada clase, es decir, el precio de todas las televisiones por un lado, el de las lavadoras por otro y la suma de los Electrodomesticos (puedes crear objetos Electrodomestico, pero recuerda que Television y Lavadora también son electrodomésticos).

Por ejemplo, si tenemos un Electrodomestico con un precio final de 300, una lavadora de 200 y una televisión de 500, el resultado final sera de 1000 (300+200+500) para electrodomésticos, 200 para lavadora y 500 para televisión.
=======
______________________________________________________________

*	Crea un array de Electrodomesticos de 10 posiciones.

*	Asigna a cada posición un objeto de las clases anteriores con los valores que desees.

*	Ahora, recorre este array y ejecuta el método precioFinal().

*	Deberás mostrar el precio de cada clase, es decir, el precio de todas las televisiones por un lado, el de las lavadoras por otro y la suma de los Electrodomesticos
	(puedes crear objetos Electrodomestico, pero recuerda que Television y Lavadora también son electrodomésticos). 


Por ejemplo, si tenemos un Electrodomestico con un precio final de 300, una lavadora de 200 y una televisión de 500, el resultado final sera de 1000 (300+200+500) para electrodomésticos, 200 para lavadora y 500 para televisión.
>>>>>>> 7cea4e07e83960693cac70cb5ce4f032897bbcd9
