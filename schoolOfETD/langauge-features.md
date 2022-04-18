Language Features
=================

Objective
---------
* Understand a range of programming language features
* Be able to reason about the choice of a language for particular tasks

Overview
--------

* Lecture (1 hour)
* Pair Programming (30min)
* Coding Exercises (2.5 hours)

Next week
---------
* Professional developers are always talking informally about languages and tools
* Come prepared to give a mini verbal 5min example/explanation of language feature you have researched
    * Weblink + few sentences of what it is and why it might be useful
    * What problem is the language trying to solve? (why was it created?)
    * (brilliant if) Can you show/demo "hello world" + simple function running in the language?
    * I will pick 5 of you at random
* Some possible languages to research
    * [PureScript](https://www.purescript.org/)
    * [TypeScript](https://www.typescriptlang.org/)
    * [Elm](https://elm-lang.org/)
    * [Elixir](https://elixir-lang.org/)
    * [Kotlin](https://kotlinlang.org/)
    * other ...
* Level 6: Read and think for yourself


What do you know already?
-------------------------

TASK: Whiteboard
* TASK1: Name as many languages _features_ as you can
* TASK2: Can you categorise them? (!)


Every Language is good for something
------------------------------------

What should you learn?
> Lower level languages reveal a lot of things behind the scenes in other languages

* [The Most Popular Programming Languages & Their Uses (2020)](https://www.youtube.com/watch?v=rd6SgAIvGjw) Youtube 10min Tech with Tim
    1. JS
    2. Python
    3. Java
    4. Golang
    5. C++
    6. Typescript
    7. Ruby
    8. PHP
    9. C

Running Code this session
-------------------------

* [tutorialspoint.com/codingground](https://www.tutorialspoint.com/codingground.htm)
    * Good
        * Run code for MANY languages in the browser
        * No login required
    * Bad
        * Mostly synchronous (no interaction or sleep)
        * No live share
* [replit.com](https://replit.com/)
    * Good
        * Live share support
        * VERY fully featured
            * Interaction (actual repl)
            * Graphics (frame served)
            * Ports (externally visible)
    * Bad
        * Login with GitHub account
        * Must create a named workspace each time



Old(ish) Languages
------------------

### BASIC

* BASIC was on ROM and loaded on power on with most retro computers in the 80s.
* Most manufacturers had a slightly different dialects that created fragmentation

```basic
05 HOME : TEXT : REM Fibonacci numbers 
10 LET MAX = 5000
20 LET X = 1 : LET Y = 1
30 IF (X > MAX) GOTO 100
40 PRINT X
50 X = X + Y
60 IF (Y > MAX) GOTO 100
70 PRINT Y
80 Y = X + Y
90 GOTO 30
100 END
```
example from http://www.hoist-point.com/applesoft_basic_tutorial.htm

* Slow
* No named functions - just goto numbers
* Adding new intermediary lines was a pain
* Utterly unfathomable for anything other than the tiniest programmes

### PERL

* Practical Extraction and Report Language (text processing)
* As HTML was just text, it became the first widley adopted for server side scripting
    * templating
* PERL is considered a "write only" language
* Also used in early bioinfomatics tools because the data was just

```perl
# https://www.geeksforgeeks.org/perl-array-slices/
@array = ('Geeks', 'for', 'Geek');
@extracted_elements = @array[1, 2];
print"Extracted elements: "."@extracted_elements";
# What does this print?
```
https://www.tutorialspoint.com/execute_perl_online.php


An excerpt from one of my programs from years ago
```perl
sub print_control_buttons {
  if (defined $prev_id && $prev_id ne "") {print "<A TARGET=_top HREF='$script?file=$file&command=$command&search_field=id&search_string=$record->{prev_id}&id=$prev_id'>Previous</A>\n";}
                                           print " - <A TARGET=_top HREF='$script?file=$file&command=List'>Return to List</A> - \n";
  if (defined $next_id && $next_id ne "") {print "<A TARGET=_top HREF='$script?file=$file&command=$command&search_field=id&search_string=$record->{next_id}&id=$next_id'>Next</A>\n";}
  if (defined $Bibliography::UserManager::user{login}) {print " - <A TARGET=_top HREF='$script?file=$file&command=edit&id=$record->{id}'>Edit</A>\n";}
}
```

TASk: Take a peek at a few examples here
https://learn.perl.org/examples/
* Look how succinct the examples are? is perl good?
* Is the language good? or are the libraries good?

Good programmers can write good code in most languages

### PHP

* Was not designed. It was organically developed and gained popularity. As a result it has internal inconstancies.
* Easy to build and deploy. Runs on everything. Just copy a file in the right folder and it just works.




Language Cheat Sheet and Pair Programming
-----------------------------------------

* Task: 30min
    * With the _Visual Basic_ reference for a bubbelsort (below)
    * You are to use the _language_reference.html_ tool to attempt to convert this algorithm to another language
        * starting stub programs for a range of languages has been provided
        * Try to use a language that you are both unfamiliar with
    * You are to use an online collaborative tool to attempt to pair program a solution
        * Possible technologies
            * https://replit.com/ + _Create repl_ + share link
            * GitPod https://gitpod.io/workspaces + start any workspace + share invite (share is located bottom middle of the screen)
        * Remote pair programming is an important skill for any professional developer (post covid)

* [langauge_reference.html](https://computingteachers.uk/static/langauge_reference.html)
* Starting stubs [bubbelsort.md](https://github.com/calaldees/TeachProgramming/blob/master/teachprogramming/static/projects/data/bubbelsort.md)

### Reference Implementation
This can be copy/paste/run at
https://www.tutorialspoint.com/compile_vb.net_online.php
visual basic .net
```vb
Module VisualBasic

    Sub Main()
        Dim data() as String = {"b", "d", "c", "a"}
        data = bubbleSort(data)
        Console.WriteLine(Join(data, ","))
    End Sub

    Function bubbleSort(data as String()) As String()
        Console.WriteLine("bubbleSort")
        Dim has_changed as Boolean = True
        Do While has_changed
            Console.WriteLine(Join(data, ","))
            has_changed = False
            For i As Integer = 0 To data.Length - 2
                Dim a as String = data(i)
                Dim b as String = data(i+1)
                Console.WriteLine("comparing "+i.toString()+":"+a+" with "+(i+1).toString()+":"+b)
                If a > b Then
                    Console.WriteLine("swap")
                    data(i) = b
                    data(i+1) = a
                    has_changed = True
                End If
            Next
        Loop
        bubbleSort = data
    End Function

End Module
```
