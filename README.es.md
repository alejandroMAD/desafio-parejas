Juego de parejas
===============
[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![en](https://img.shields.io/badge/lang-en-red.svg)](https://github.com/alejandroMAD/desafio-parejas/blob/master/README.md)
[![es](https://img.shields.io/badge/lang-es-yellow.svg)](https://github.com/alejandroMAD/desafio-parejas/blob/master/README.es.md)

Interfaz de usuario
----------
![Interfaz de usuario](/screenshot.png)

Una juego de parejas escrito en Windows Forms-VB.Net para encontrar parejas de cartas barajadas aleatoriamente, que emplea un temporizador, una interfaz de usuario moderna de diseño plano y paneles de cartas generados de forma dinámica en tiempo de ejecución, utilizando un código bien estructurado y escalable.

Características
-------------------
* The game provides two difficulty levels, Easy and Hard, connected with different card grid sizes (4x4 and 6x6) and different time limits (1 and 2 minutes).
* The timer allows to display the time left on second intervals and determines the game over state when it runs out.
* The grids of cards are dinamically generated at runtime, not at design time, allowing for a scalable and reusable code for different game configurations.
* Cards are shuffled with a random function and compared to find matches during the game by tags, whereas game score points are counted on a powers-of-two basis as a tribute to the language of computers.
* Correct card picks and mistakes are counted and stored in variables for several purposes.
* Several visual cues are used on the UI to guide the user through game stages, such as a darker shade for disabled cards and a red font color for the timer when there are less than 20 seconds left.
* A brief delay of 900 ms pauses the thread when two unpaired cards are picked before turning them upside-down so the user has time to memorize their position.
* Custom different messages are displayed at the end of the game depending on the outcome.


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
