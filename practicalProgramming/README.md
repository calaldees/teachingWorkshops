Practical Programing
====================

_Computer Science_ vs/different_from _Software Engineering_
_Training in gym_ vs _Running the marathon_


Course Structure
----------------

* 52 Weeks (208 guided learning hours) (roughly an AS)
    * per week
        * 1 Hour tuition (documented/videoed)
        * 3 Hours of directed tasks
    * Out of tutorial contact/help can happen, but I would like to summarize what was covered on video

* [cheat sheet](https://github.com/calaldees/TeachProgramming/blob/master/teachprogramming/static/docs/LanguageCheetSheet.odt)
* [projects](https://github.com/calaldees/TeachProgramming/blob/master/teachprogramming/static/docs/unit1-projects.md)
    * Whole year in advance
* To be complemented by _theory_ sessions and _engineering example_ sessions

* First 5 sessions (10% of course) will be very directed
    * Foundation skills
* Later sessions will become much more two way

Every session will be _ridiculously_ hard: The edge of what you are capable of. (If it's easy then you are not growing).
95% of the time you are interacting with programs they will be in a broken state.


Setup
-----

Windows
```
    choco install vscode python3 java ojdkbuild visualstudio2019community
```
OSX
```
    brew install vscode python3 ?java?
```
Linux (Ubuntu example)
```bash
    apt-get update && apt-get install -y python3 vscode ?java?
```

* Install language(s)
* IDE (Integrated Development Environment)
    * Line numbers
    * Show white space
    * Syntax highlighting (colors)
* Terminal
    * Use a good terminal (the default ones are awful)
    * Avoid using integrated IDE terminal
        * (want to build metal ethos that a terminal it NOT just related to coding)

* Position your windows so you can see terminal and code on screen at once (50% 50% vertical)
* Play "Don't touch the mouse" - (unplug it?)
    * Compile and run cycle
        * Ctrl + S
        * Alt + Tab
        * Up -> Enter
            * `python filename.py`
            * `javac *.java && java -cp ../ $(basename "$PWD").Session1`


Session1
--------

* function
    * params
* variables
    * type
* if

* Project
    * login
    * image size calculator

Session2
--------

May be worth repeating session1 with dynamic/static language

* project
    * 3rd language? Visual Basic?

Session3
--------

* arrays/lists
* loops
* files

* projects
    * trainings tasks +

Session4
--------

* dictionarys/maps/associative arrays
* data structures

* debugger
* linter

* tests first!

Session 5
---------

* Version control
* Collaboration (live Share)

Session 6
---------

You drive

Session 7
---------

Copter (in JS)
(finished base) + suggested level and parallax


Session 8
---------

You drive

Spec bingo
Prepare progress assessment
I will inspect your entire GitHub repo to date and offer feedback on progress
Submitting a project - whats required
Doctest with pytest
```python
 # pytest test.py --doctest-modules --pdb

def add(a, b):
    """
    My function to add stuff

    >>> add(1, 1)
    2
    >>> add(2, 2)
    4
    >>> add(-1, 5)
    100
    """
    return a + b


answer = add(10, 2)
print(answer)

```


Session 9
---------




Session 10
----------


Self directed talk about
AND, OR, NOT, NAND, XOR
Stacks, Queues (theory)

Pair progressming of humanise


---

[#1 Thing to Learn to Become a Self-Taught Programmer](https://youtu.be/sYjEzOIa5JI?t=83) - Your knowlege of the syntax wont get you the job. The ability to produce a desired outcome will.
