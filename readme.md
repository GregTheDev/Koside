This is a proof of concept that I started working on to see how viable/easy it would be to create a Kodi skin editor/IDE.

It tests a few ideas, but that is all... it doesn't even support saving :-)

So what does it do:
* Parses skin files and displays the controls in a tree
* Displays properties and values in a property editor (grouped by category)
* Sample editor for "value" property on controls
* The beginnings of a c# library to manipulate skin projects (seperate from the IDE)

What doesn't it do:
* A lot
* Can't save any changes
* No visual designer, only displays code

Maybe someone finds the code useful.

Screenshot of the IDE (showing home.xml from skin.persona)

![Image of IDE](https://raw.githubusercontent.com/GregTheDev/Koside/master/images/overview.png)
