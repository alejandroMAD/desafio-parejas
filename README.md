Memory matching game
===============
[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![en](https://img.shields.io/badge/lang-en-red.svg)](https://github.com/alejandroMAD/desafio-parejas/blob/master/README.md)
[![es](https://img.shields.io/badge/lang-es-yellow.svg)](https://github.com/alejandroMAD/desafio-parejas/blob/master/README.es.md)

User interface
----------
![User interface](/screenshot.png)

A VB.Net Windows Forms memory matching game to find pairs among shuffled cards, using a Timer, a custom flat UI design and dynamic runtime-generated grids of cards at runtime, in structured scalable code.

Features
-------------------
* The game provides two difficulty levels, Easy and Hard, connected with different card grid sizes (4x4 and 6x6) and different time limits (1 and 2 minutes).
* The timer allows to display the time left on second intervals and determines the game over state when it runs out.
* The grids of cards are dinamically generated at runtime, not at design time, allowing for a scalable and reusable code for different game configurations.
* Cards are shuffled with a random function and compared to find matches during the game by tags, whereas game score points are counted on a powers-of-two basis as a tribute to the language of computers.
* Correct card picks and mistakes are counted and stored in variables for several purposes.
* Several visual cues are used on the UI to guide the user through game stages, such as a darker shade for disabled cards and a red font color for the timer when there are less than 20 seconds left.
* A brief delay of 900 ms pauses the thread when two unpaired cards are picked before turning them upside-down so the user has time to memorize their position.
* Custom different messages are displayed at the end of the game depending on the outcome.


Credits
-------------------

* Cards backside photo: [Picture created by Mohamed Hassan - Pixabay](https://pixabay.com/images/id-2988137)
* Programming languages and frameworks icons: [Hospital icons created by Freepik - Flaticon](https://www.flaticon.com/free-icons/hospital)
* Victory bear picture
* Defeat snail picture

License
--------
    Copyright (C) 2022  Alejandro M. González
    
    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:
    
    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.
    
    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
    
    MIT License: http://opensource.org/licenses/MIT
