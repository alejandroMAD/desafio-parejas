Juego de parejas
===============
[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![en](https://img.shields.io/badge/lang-en-red.svg)](https://github.com/alejandroMAD/desafio-parejas/blob/master/README.md)
[![es](https://img.shields.io/badge/lang-es-yellow.svg)](https://github.com/alejandroMAD/desafio-parejas/blob/master/README.es.md)

Interfaz de usuario
----------
![Interfaz de usuario](/screenshot.png)

Una juego de parejas escrito en Windows Forms-VB.Net para encontrar parejas de cartas barajadas aleatoriamente, que emplea un temporizador, una interfaz de usuario de diseño plano y paneles de cartas generados de forma dinámica en tiempo de ejecución, utilizando un código bien estructurado y escalable.

Características
-------------------
* El juego ofrece dos niveles de dificultad, Fácil y Difícil, asociados a tableros de cartas de diferente tamaño (4x4 y 6x6) y diferentes límites de tiempo (1 y 2 minutos).
* El temporizador permite mostrar el tiempo que resta de juego actualizado cada segundo y determina el estado de fin de juego cuando el tiempo se acaba.
* Los tableros de cartas se generan dinámicamente en tiempo de ejecución, no en la fase de diseño, proporcionando un código escalable y reutilizable para diversas configuraciones de juego.
* Las cartas son barajadas mediante una función aleatoria y comparadas para determinar las parejas de iguales durante el juego mediante etiquetas o tags.
* Los aciertos y fallos son contados y almacenados en variables para diferentes propósitos, mientras que la puntuación de una partida se calcula en potencias de 2 como homenaje al lenguaje de los ordenadores.
* Se utilizan diversas pistas visuales en la interfaz para guiar a través de las fases del juego al usuario, tales como una versión más oscura del reverso de las cartas que están deshabilitadas y el color rojo del reloj cuando quedan 20 segundos o menos.
* Una breve pausa de 900 milisegundos suspende el hilo de ejecución cuando se seleccionan dos cartas que no son pareja, antes de volverlas boca abajo de nuevo, para que el usuario tenga tiempo de memorizar su posición.
* Al final de una partida se muestran al usuario mensajes diferentes dependiendo del resultado del juego.

Reconocimiento
-------------------

* Fotografía del reverso de las cartas: [Laberinto del Parque Juan Carlos I en Madrid de Victor - Unsplash](https://unsplash.com/es/fotos/_qXjdWm8YEo)
* Iconos de tecnología y programación: [Iconos de IconMafia y IconScout](https://iconscout.com/contributors/icon-mafia) 
* Ilustración de victoria de un oso: [Imagen de catalyststuff - Freepik](https://www.freepik.es/vector-gratis/lindo-oso-corriendo-maraton-dibujos-animados-vector-icono-ilustracion-concepto-icono-deporte-animal-plano-aislado_32432390.htm)
* Ilustración de derrota de un caracol: [Imagen de brgfx - Freepik](https://www.freepik.es/vector-gratis/reloj-plantilla-caracol_3840486.htm)

Licencia
--------
    Copyright (C) 2022  Alejandro M. González
    
    MIT License: http://opensource.org/licenses/MIT
