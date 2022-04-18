Session 2: Languages
====================

Recap
-----
QUESTION: Whiteboard?
* What did we cover last week?
* Why are we doing this?

Announcements
-------------
* Attempting to book campus rooms
    * Next week on campus VH.1.26 (morning), VH.1.02 (afternoon)
* Extending Assignment 1 by one week to 08/11/2021
    * Results of quiz showed weakness in understanding of anatomy of a web service - extra session


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
        * Must create a named workspace



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


### PHP

* Was not designed. It was organically developed and gained popularity. As a result it has internal inconstancies.
* Easy to build and deploy. Runs on everything. Just copy a file in the right folder and it just works.


New(ish) Languages
------------------

### [GoLang](https://golang.org/)

* Google's static typed, compiled performant systems level, concurrency primitives.
* Compiling C was too slow. They wanted something that compiles FAST.
* Modern language features
* Readability
* Very well designed standard library - fewer external libraries (including few gui)
* builtin formatter
* Not OO


> Java has explicit class: the Rectangle class declares it implements Shape. 
> Go’s approach is implicit. A structure that implements all functions of an interface implicitly implements this interface.

* From [How WhatsApp scaled to 1 billion users with only 50 engineers](https://www.quastor.org/p/how-whatsapp-scaled-to-1-billion)
    * [Why you can have millions of Goroutines but only thousands of Java Threads](https://rcoh.me/posts/why-you-can-have-a-million-go-routines-but-only-1000-java-threads/)
        * If you’ve been working with JVM based languages for a while, you’ve probably come across a situation where you’ve reached the limit of the number of concurrent threads you can have.
        * On your personal computer, this limit is usually around ~10,000 threads.
        * On the other hand, you can have more than a hundred million goroutines on a laptop with Go.
        * This article explores why you can have so many more Goroutines than threads.
        * There’s two main reasons why
            * The JVM delegates threading to operating system threads. Go implements its own scheduler that allows many Goroutines to run on the same OS thread.
            * The JVM defaults to a 1 MB stack per thread. Go’s stacks are dynamically sized and a new goroutine will have a stack of about 4 KB.

### [Erlang](https://www.erlang.org/)

* > Erlang is a programming language used to build massively scalable soft real-time systems with requirements on high availability. Some of its uses are in telecoms, banking, e-commerce, computer telephony and instant messaging. Erlang's runtime system has built-in support for concurrency, distribution and fault tolerance.
* Rolling live deployment
    * Used for upgrading system while they are running
        * Used for Final Fantasy Online
    * Each distributed module can restart/clear/fix itself
    * Data can run though converters/channels
* Unlike anything you have ever used before


Language Features
-----------------

* Common features
    * Type checking
    * data structures
    * abstraction
    * error handling
    * concurrency

### Meta Programming

* [Metaprogramming](https://en.wikipedia.org/wiki/Metaprogramming) Wikipedia
    * > a program can be designed to read, generate, analyze or transform other programs, and even modify itself while running

* Reflection - program inspecting itself while running
    * Some say this is unneeded as the language could support this itself
* Changing the structure of the program while running (is this a good thing?)

* [Macro](https://en.wikipedia.org/wiki/Macro_(computer_science)#Parameterized_macro)
    * Static languages

### Garbage Collection

Manual memory management or Automatic memory management

```python
aa = {'a':[1,2,3], 'b':[4,5,6]}
bb = {'c':[7,8,9], 'd':[10,11,12]}
aa = {'e':[13,14,15], 'f':[16,17,18]}
# Question: Where is the data from the first `aa`? Where did it go?
```

```python
import sys
a = []
b = a
sys.getrefcount(a)
# The reference count for the empty list object [] was 3. 
# The list object was referenced by a, b and the argument passed to sys.getrefcount().
```

Whiteboard/Visualiser: Demo?

Memory management is dangerous to get wrong. 
Most programmers mess this up because we are only human. 
So most languages prefer automattic memory management.

* Reference counting
* You don't have control over the garbage collection thread
    * This is an issue for hard realtime systems (one of the biggest complaints of java)
    * (I think) Java has 30 different garbage collection methods/strategies
* C, C++, Rust have manual memory management model
    * Memory leaks
    * Rust has excellent primitives for this

### Internationalisation

* Some older languages only support `bytes` and don't handle `unicode` as part of the language.
* This was THE major issue in moving from python2 to python3 and caused lots of compatibility issues.

### Less is more?

* [Less is more: language features](https://blog.ploeh.dk/2015/04/13/less-is-more-language-features/) Mark Seemann 2015
    * Venn diagrams visualising languages features compared to possible errors and valid code

### Language Evaluation Criteria

* [Evaluating Programming Languages](https://cs.lmu.edu/~ray/notes/evaluatingprogramminglanguages/)
    * > So, if you ever get into an argument about programming languages, what should you say?
    * Criteria for Evaluation • Popularity • Understanding Evaluation Tradeoffs
* [Language Evaluation Criteria](https://progr-harrykar.blogspot.com/2018/11/language-evaluation-criteria.html) 2018
* [Design Criteria for Programming Languages](http://jcsites.juniata.edu/faculty/rhodes/lt/plcriteria.htm) 2015

Some criteria
* Read-ability
* Writ-ability
* Reliability
* Cost
* Generality
* Extensibility
* Standard-ability
* Support for internationalization


### Complexity?

```c
for (i = 0; i < 100; i++) printf("hello"); /* How many lines of code is this? */
```
https://en.wikipedia.org/wiki/Source_lines_of_code

Measures of complexity
* [Halstead_complexity_measures](https://en.wikipedia.org/wiki/Halstead_complexity_measures) Wikipedia
* [Cyclomatic_complexity](https://en.wikipedia.org/wiki/Cyclomatic_complexity) Wikipedia



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

Number Handling
---------------

Static/Compiled seem to be different to Dynamic/Interpreted. Let's look.

Run all of these

java
```java
int a = Integer.MAX_VALUE;
System.out.println(a);
System.out.println(a+1);
```
csharp
```csharp
int a = Int32.MaxValue;
Console.WriteLine(a);
Console.WriteLine(a+1);
```
python
```python
import sys
a = sys.maxsize
print(a)
print(a+1)
```
javascript
```javascript
let a = Number.MAX_SAFE_INTEGER;
console.log(a);
console.log(a+1);
Number.MAX_SAFE_INTEGER+1 === Number.MAX_SAFE_INTEGER+2
```
https://en.wikipedia.org/wiki/Nuclear_Gandhi


### Typing
Static languages it's explicit
python
```python
ll = [4,5,6,7]
type(ll)
```
javascript
```javascript
const ll = [4,5,6,7];
typeof(ll);
```


Missing basic language features - IndexOf item in array
-------------------------------------------------------

* Run these examples
* Briefly scan the stackoverflow pages

javascript
```javascript
const ll = [4,5,6,7];
ll.indexOf(6);
```
python
```python
ll = [4,5,6,7]
ll.index(6)
```
java
```java
int[] ll = new int[]{4,5,6,7};
// ???
// https://stackoverflow.com/questions/1522108/how-to-find-the-index-of-an-element-in-an-array-in-java
```
golang
```golang
ll := []int{4,5,6,7}
// ???
// https://stackoverflow.com/questions/8307478/how-to-find-out-element-position-in-slice
```

* Why is this basic feature missing from arrays in java and golang?
    * This is a pretty important aspect of language design


Implementation Abstraction
--------------------------

java
```java
// Predict what this program should print (preferably discuss your idea with another person)
// then run it
// Can you describe why this has happened?
// Is this good? or bad?

// https://docs.oracle.com/javase/8/docs/technotes/guides/collections/overview.html
// https://docs.oracle.com/en/java/javase/17/docs/api/java.base/java/util/Collection.html
import java.util.Arrays;
import java.util.Collection;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.TreeSet;

class Main {
  public static void main(String[] args) {
    System.out.println("Hello world!");

    Collection<Integer> a = new ArrayList<>();
    Collection<Integer> b = new LinkedList<>();
    Collection<Integer> c = new TreeSet<>();

    a.add(1);
    a.add(1);

    b.add(2);
    b.add(2);

    c.add(3);
    c.add(3);

    Collection<Integer> d = new ArrayList<>();
    d.addAll(a);
    d.addAll(b);
    d.addAll(c);

    System.out.println(
        String.join(",", Arrays.toString(d.toArray()))
    );
  }
}
```

* [Java Collections Framework](https://docs.oracle.com/javase/8/docs/technotes/guides/collections/overview.html)
    * Ability to abstract the implementation from the interface
    * [java.util.Collection](https://docs.oracle.com/en/java/javase/17/docs/api/java.base/java/util/Collection.html)
        * List, Set, Map

Whiteboard/Visualiser?

* Arrays
    * Performant random access
    * Performant sequential access (cacheing)
    * Memory efficient
    * Difficult to add/remove/splice
        * Entire array needs copying to another location
* LinkedList
    * Sequential only access
        * not cacheable
    * Memory
        * Every element stores an additional next-reference
        * Can be distributed across memory 
    * Easy to add/remove/splice

This example shows us first hand the difference between high level and low level languages.
In high level languages, we don't know what the system is doing. We use whatever abstraction we are provided.


Mutability
----------

javascript
```javascript
// Predict what this program should print (preferably discuss your idea with another person)
// then run it
// Can you describe why this has happened?
// Is this good? or bad?

function sum_numbers(numbers) {
    let total = 0;
    for (i of numbers) {
        total += i;
    }
    numbers.push(8);
    return total;
}

const ll = [1,2,3];
console.log(sum_numbers(ll));
console.log(sum_numbers(ll));
console.log(ll);
```

* Why is `const` not working?
* We can't inspect every method that could ever be run to check it does not modify our data
* In `get` operation modify the dictionary to include the key. WARNING.
* Mutability by default is dangerous. It is difficult to protect yourself.
* Solution _Immutability_. Library's?
    * [immutable-js](https://immutable-js.com/)


Reference Equality by default
-----------------------------

java
```java
// Predict what this program should print (preferably discuss your idea with another person)
// then run it
// Can you describe why this has happened?
// Is this good? or bad?

import java.awt.Point;
class Main {
  public static void main(String[] args) {
    Point p1 = new Point(1,1);
    Point p2 = new Point(1,1);
    System.out.println(p1 == p2);
  }
}
```


Prototypical Inheritance
------------------------

javascript
```javascript
// from https://blog.frankel.ch/six-interesting-features-programming-languages/

// Part 1: ----
class Person {
  constructor(name, birthdate) {
    this.name = name;
    this.birthdate = birthdate;
  }
}
const person1 = new Person("John Doe", Date.now());
const person2 = new Person("Jane Doe", Date.now());

// Try (before running each line, predict what it will do)
// person1.name
// person2.name
// person1.debug()

// Part 2: ----
person1.debug = function() {
  console.debug("I added this dynamically to a single object", this);
}
person1.debug();

// Try (before running each line, predict what it will do)
// person1.debug()
// person2.debug()

// Part 3: ----
Person.prototype.debug = function() {
  console.debug("I added this to everyone", this);
}
const person3 = new Person("Nicolas", Date.now());

// Try (before running each line, predict what it will do)
// person1.debug();
// person2.debug();
// person3.debug();


// Part 4: ---
// Question: What has just happened?
// What is _prototypical inheritance_?
// Is this good? or bad?
```


Decorators
----------

python
```python
# TASK:
# Attempt to modify this decorator to:
#   1. print to the screen the arguments that the decorated function was called with
#   2. modify the returned result by adding 10
# e.g. When run the output should be
#   called with (1, 2) {}
#   13

from functools import wraps

def example_decorator(original_function=None, add_your_args=None):
    """
    This pattern works for defining decorators with and without params.
        (Positional arguments to the decorator are not supported by this pattern)
    Use with 
        @example_decorator
        def my_func(a, b):
            return a + b
    or
        def my_func(a, b):
            return a + b
        my_func = example_decorator(my_func)
    """
    def _decorate(function):
        @wraps(function)
        def wrapped_function(*args, **kwargs):
            pass  # replace this line with - pre function code
            _return = function(*args, **kwargs)
            pass  # replace this line with - post function code
            return _return
        return wrapped_function
    return _decorate(original_function) if callable(original_function) else _decorate


@example_decorator
def my_func(a, b):
    return a + b


if __name__ == "__main__":
    print(my_func(1,2))
```

* What is the point of this technique?
* When/Why would you ever use it?
* Is this good? or bad?


Operator Overloading
--------------------


python
```python
# Predict what this program should print (preferably discuss your idea with another person)
# then run it
# Can you describe why this has happened?
# Is this good? or bad?

class Circle():
    def __init__(self, x, y, radius):
        self.x = x
        self.y = y
        self.radius = radius
    def __repr__(self):
        return f"Circle({self.x=}, {self.y=}, {self.radius=})"
    def __str__(self):
        return repr(self)
    def __add__(self, other):
        if isinstance(other, Circle):
            return Circle(
                x = (self.x + other.x)/2,
                y = (self.y + other.y)/2,
                radius = self.radius + other.radius,
            )
        if isinstance(other, (int, float)):
            return Circle(
                x = self.x,
                y = self.y,
                radius = self.radius + other
            )
        raise NotImplementedError(f"Unable to add '{other}'")

if __name__ == "__main__":
    print(Circle(5,5,5) + Circle(2,2,5))
    print(Circle(1,2,3) + 5)
```

csharp
```csharp
class Circle {
    double x;
    double y;
    double radius;

    public Circle(double x, double y, double radius) {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    override
    public String ToString() {
        return $@"Circle(x={x}, y={y}, radius={radius})";
    }

    public static Circle operator +(Circle a, Circle b) {
        return new Circle(x: (a.x + b.x)/2, y: (a.y + b.y)/2, radius: a.radius + b.radius);
    }

    public static Circle operator +(Circle a, int r) {
        return new Circle(x: a.x, y: a.y, radius: a.radius + r);
    }
}

Console.WriteLine(new Circle(5,5,5) + new Circle(2,2,5));
Console.WriteLine(new Circle(1,2,3) + 5);
```

python
```python
class Rectangle():
    def __init__(self, x1, y1, x2, y2):
        self.x1 = x1
        self.y1 = y1
        self.x2 = x2
        self.y2 = y2
    def __repr__(self):
        return f"Rectangle({self.x1=}, {self.y1=}, {self.x2=}, {self.y2=})"
    def __str__(self):
        return repr(self)
    def __add__(self, other):
        """
        This is a doctest - you can run this from the command line with
        python3 -m doctest -v -o ELLIPSIS NAME_OF_FILE.py

        >>> r1 = Rectangle(0,0,10,10)
        >>> r2 = Rectangle(5,5,20,20)

        >>> r1 + "bob"
        Traceback (most recent call last):
        NotImplementedError: Unable to add ...

        >>> r1 + r2
        Rectangle(self.x1=0, self.y1=0, self.x2=20, self.y2=20)

        >>> r2 + r1
        Rectangle(self.x1=0, self.y1=0, self.x2=20, self.y2=20)

        >>> r1 + 1
        Rectangle(self.x1=0, self.y1=0, self.x2=11, self.y2=11)
        """
        # Part 1: Implement the `+` operator
        # hint use the circle example above for ideas
        # hint there are two built in functions that may help - one of them is `max()` - https://docs.python.org/3/library/functions.html#max
        raise NotImplementedError(f"Unable to add '{other}'")

    # Part 2: Implement another operator
    # def __???__(self, other):
        # Can you implement another operator? can you make 'subtract' remove from the width/height of the rectangle?
        # https://docs.python.org/3/library/operator.html
    
    # Part 3: Identify other operators that can be overloaded
    # https://docs.python.org/3/library/operator.html
    # Is operator overloading good? or bad? why?
```

csharp
```csharp
class Rectangle {
    int x1;
    int y1;
    int x2;
    int y2;

    public Rectangle(int x1, int y1, int x2, int y2) {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public override String ToString() => $"Rectangle(x1:{x1}, y1:{y1}, x2:{x2}, y2:{y2})";
    public override int GetHashCode() => x1 ^ y1 ^ x2 ^ y2;
    public override bool Equals(object obj) => GetHashCode()==obj.GetHashCode();  // Quick Hack

    public static Rectangle operator +(Rectangle a, Rectangle b) {
        throw new NotImplementedException("Complete this + operator");
    }
    public static Rectangle operator +(Rectangle a, int b) {
        throw new NotImplementedException("Complete this + operator");
    }
}


var r1 = new Rectangle(0,0,10,10);
var r2 = new Rectangle(5,5,20,20);

AssertIsEqual(r1 + r2, new Rectangle(0, 0, 20, 20));
AssertIsEqual(r1 + 1, new Rectangle(0, 0, 11, 11));
```

### Documentation
* https://docs.python.org/3/reference/datamodel.html#emulating-numeric-types
* https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading


I've used this for TimeLine objects
https://github.com/calaldees/libs/blob/eeddc0f8fdad48f7595c56a2ed1b4ae23ab14b96/python3/calaldees/animation/timeline.py#L211



* [4 Reasons Why Java doesn't support Operator Overloading](https://javarevisited.blogspot.com/2011/08/why-java-does-not-support-operator.html)


Async + await and the Event Loop
--------------------------------

javascript
```javascript
// Part 1: ---
// Predict what this program should print (preferably discuss your idea with another person)
// then run it
// Can you describe why this has happened?
// Is this good? or bad?
console.log("1");
const _ = setTimeout(()=>{
    console.log("2");
}, 1000);
console.log("3");

// Part 2: ---
// Alter the program above to ensure the program
// prints `1`
// _waits for 1 second_
// prints `2`
// _waits for 1 second_
// prints `3`
```

```javascript
// Run this code
// try and work out what the hell is going on ...
const promise = new Promise((resolve, reject) => {
    // do a chunk of work here
    // this work will be done in the background
    // (that's not the whole story, but close enough)
    // when we are finished this chunk call `resolve()`
    resolve("some work has been done");
    // or call reject() if it's broken
}).then((data)=>{
    // another chunk of work in the background
    return data + " and even more work";
}).then((data)=>{
    console.log(data);
}).catch((error)=>{
    console.error(error);
});
// we can query the `promise` object to check if our background work has finished
```

Javascript in single threaded. Without breaking work in to chunks it would lock the whole system.

```javascript
function sleep(milliseconds) {
    return new Promise((resolve, reject) => setTimeout(()=>resolve(Date.now()), milliseconds));
}
async function do_steps() {
    console.log("1");
    const _a = await sleep(1000);
    console.log("2", _a);
    const _b = await sleep(1000);
    console.log("3", _b);
    const _c = await sleep(1000);
    console.log("4", _c);
}
const promise = do_steps();
// Now imagine if `sleep(1000)` was replaced with `fetch("http://my.service.com/api/v1/do_stuff?name=me")`
```

* Python and Javascript are "single process" technologies. They simply cannot support concurrency (without spawning more process's)
* [What Is the Python Global Interpreter Lock (GIL)?](https://realpython.com/python-gil/)
* We can augment these single process languages to be utilising that single process as much as possible by using an event loop. This helps with blocking IO.
    * The languages have new features `async` and `await` to support this


Reflection and MetaProgramming (TODO)
----------


```python
dir()
getattr()
```

Pattern Matching (TODO)
----------------



Recommended Reading
-------------------

These will help you with your research task and serve as a refresher from some of today's workshops

* [6 interesting features in programming languages](https://blog.frankel.ch/six-interesting-features-programming-languages/)
    * JavaScript: prototypes
        * JavaScript dynamic’s nature, it’s possible do add properties and functions to an existing instance.
    * Kotlin: extension functions/properties
    * Go: implicit interface implementation
    * Clojure: "dependent types"
    * Elixir: pattern matching
    * Python: for-comprehensions
* [The Coolest Programming Language Features](https://therenegadecoder.com/code/the-coolest-programming-language-features/) Jeremy Grifski 2021
    * Extension Methods
    * Macros
    * Automatic Properties
    * Optional Chaining
    * Lambda Expressions
    * Immutability
    * Multiple Dispatch
    * Destructuring
    * Inline Testing
    * Inline Assemblers
    * Library Naming Conventions
* [Programming languages ranked by expressiveness](https://redmonk.com/dberkholz/2013/03/25/programming-languages-ranked-by-expressiveness/)
    * Some data analysis of the expressiveness of languages
    * Interesting to see categorisation of languages
* Video [4 Programming Paradigms In 40 Minutes](https://www.youtube.com/watch?v=cgVVZMfLjEI) Coding Tech 40min RubyConf 2017 Aja Hammerly
    * Object oriented (example in Ruby)
    * Functional (example in Racket)
        * Pure == never store state, never modify inputs
        * Data and procedures are separate - oo data and procedures are intertwined
        * Prefix notation (rather than infix) - allow single operator to operate on a list
        * Easy to test, reuse components and concurrency
    * Logical (example in Prolog)
        * Describe _what_ not _how_
        * Variables/Constants, Facts, Rules (specify relationships between facts)
        * _ancestors_ example
        * programs can run backwards and forwards finding missing value
    * Procedural (example in Assembler)
        * two register A and D
        * no multiplication, division
        * constants go to A
        * Jump if eq, lt, gt
* Books
    * [Seven Languages in Seven Weeks - A Pragmatic Guide to Learning Programming Languages](https://pragprog.com/titles/btlang/seven-languages-in-seven-weeks/) 2010 by Bruce A. Tate
        * ISBN 9781934356593
        * Ruby, IO, Prolog, Scala, Clojure, Haskell
    * [Exercises in Programming Style](https://www.routledge.com/Exercises-in-Programming-Style/Lopes/p/book/9780367350208) 2020 Cristina (Crista) Lopes
        * ISBN 9780367350208
        * Part 1 Historical
        * Part 2 Basic Styles
        * Part 3 Function Composition
        * Part 4 Objects and Object Interaction
        * Part 5 Reflection and Metaprogramming
        * Part 6 Adversity
        * Part 7 Data-Centric
        * Part 8 Concurrency
        * Part 9 Interactivity
        * Part 10 Neural Networks
    * [Concepts of Programming Languages: International Edition](https://www.amazon.co.uk/Concepts-Programming-Languages-Robert-Sebesta/dp/0321509684/)
        * ISBN-13 978-0321509680


Final Thoughts
--------------

Many language features seem like good ideas, after years of use and scrutiny people begin to know the impact of the feature. Once it's part of a language features can rarely ever be removed as so much code is written to use them.
Languages fall out of favour and new ones are always trying new ideas.

> ... your scientists were so preoccupied with whether or not they could that they didn’t stop to think if they should.
<sub>Jeff Goldblum - Jurassic Park</sub>



TODO
====

* [asciinema blog - 4x smaller, 50x faster](https://blog.asciinema.org/post/smaller-faster/)
    * WebASM + Rust + Solid.js migrated from Clojurescript
* [Advanced programming languages](https://matt.might.net/articles/best-programming-languages/)
    * >  In academic research and in entrepreneurship, you need to multiply your effectiveness as a programmer, and since you (probably) won't be working with an entrenched code base, you are free to use whatever language best suits the task at hand.
    * Languages
        * Haskell.
        * Scala.
        * Standard ML and OCaml.
        * Scheme.
