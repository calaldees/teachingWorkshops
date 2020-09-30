Installing Development Tooling
==============================

1. Language(s)
2. Terminal
    * Use a good terminal (the default ones are awful)
    * Avoid using integrated IDE terminal
        * (want to build metal ethos that a terminal it NOT just related to coding)
3. IDE (Integrated Development Environment)
    * Line numbers
    * Syntax highlighting (colors)
    * Show white space


Windows
-------
```
    choco install vscode python3 java ojdkbuild visualstudio2019community
```
* Windows Store
    * Windows Terminal Preview


OSX
---

```bash
    brew install vscode python3 ?java? iterm2
```

Linux (Debian example)
----------------------

```bash
    sudo apt-get update && sudo apt-get install -y python3 vscode ?java?
```



* Position your windows so you can see terminal and code on screen at once (50% 50% vertical)
    * windows + left/right

* Play "Don't touch the mouse" - (unplug it?)
    * Compile and run cycle
        * Ctrl + s
        * Alt + Tab
        * Up -> Enter
            * `python filename.py`
            * `javac *.java && java -cp ../ $(basename "$PWD").Session1`



![Visual Studio 2019 - Module install](./images/visualstudio-install.gif)