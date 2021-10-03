Languages
=========

Objective:
* Understand a range of programming language features

* Next week:
    * 5min example language feature - Weblink + talk


https://www.tutorialspoint.com/codingground.htm

“Yeah, but your scientists were so preoccupied with whether or not they could that they didn’t stop to think if they should.” Jeff Goldblum - Jurassic Park


History
-------

### Basic

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
http://www.hoist-point.com/applesoft_basic_tutorial.htm

### PERL

```perl
@array = ('Geeks', 'for', 'Geek');
@extracted_elements = @array[1, 2];
print"Extracted elements: "."@extracted_elements";
```
https://www.tutorialspoint.com/execute_perl_online.php
https://www.geeksforgeeks.org/perl-array-slices/

Perl is considered a "write only" langauge

```perl
sub print_control_buttons {
  if (defined $prev_id && $prev_id ne "") {print "<A TARGET=_top HREF='$script?file=$file&command=$command&search_field=id&search_string=$record->{prev_id}&id=$prev_id'>Previous</A>\n";}
                                           print " - <A TARGET=_top HREF='$script?file=$file&command=List'>Return to List</A> - \n";
  if (defined $next_id && $next_id ne "") {print "<A TARGET=_top HREF='$script?file=$file&command=$command&search_field=id&search_string=$record->{next_id}&id=$next_id'>Next</A>\n";}
  if (defined $Bibliography::UserManager::user{login}) {print " - <A TARGET=_top HREF='$script?file=$file&command=edit&id=$record->{id}'>Edit</A>\n";}
}
```

It was good for text templateing. When generating html ment manipulating text perl was king. It was also used in early bioinfomatics tools because the data was just

https://learn.perl.org/examples/
Look how succinct the examples are? is perl good?


Librarys are good

### PHP

Was not designed. It was organicly developed and gained opularity. As a result it has internal inconstancies.
Easy to build and deploy. Runs on everything. Just copy a file in the right folder and it just works.



### GoLang

Google's static typed, compiled performant systems level, concurrency primitives.
Compiling C was too slow. They wanted something that compiles FAST.
Modern language features
Readability
Very well designed standard library - fewer external librarys (including few gui)
builtin formatter
Not OO

Java has explicit class: the Rectangle class declares it implements Shape. 
Go’s approach is implicit. A structure that implements all functions of an interface implicitly implements this interface.



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


MetaProgaramming
 reflection - programm inspecting itself while running
 some say this is unneeded as the language could support this itself
 changing the structure of the programm while running (is this a good thing?)


garbage collection

TASK: Whiteboard
Name as many languages as you can

Can you categorise them?

Type checking
data structures
abstraction
error handling
concurrency

Lower level languages reveal a lot of things behind the sceens in other langauges


* [Less is more: language features](https://blog.ploeh.dk/2015/04/13/less-is-more-language-features/) Mark Seemann 2015
    * Venn diagrams visualising languages features compared to possible errors and valid code


* [The Most Popular Programming Languages & Their Uses (2020)](https://www.youtube.com/watch?v=rd6SgAIvGjw) Youtube 10min Tech with Tim
    * JS
    * Python
    * Java
    * Golang
    * C++
    * Typescript
    * Ruby
    * PHP
    * C

Low Level
High Level

* [4 Programming Paradigms In 40 Minutes](https://www.youtube.com/watch?v=cgVVZMfLjEI) Coding Tech 40min RubyConf 2017 Aja Hammerly
    * Object oriented (example in Ruby)
    * Functional (example in Racket)
    * Logical (example in Prolog)
        * Describe _what_ not _how_
        * Variables/Constants, Facts, Rules (specify relationships between facts)
        * _ancestors_ example
        * programs can run backwards and forwards finding missing value
    * Procedural (example in Assembler)
        * two register A and D
        * no multiplication, devision
        * constants go to A
        * Jump if eq, lt, gt
    

Functional
Pure == never store state, never modify inputs
Data and procedures are separate - oo data and procedures are intertwined
Prefix notiation - allow sinlge operator to operate on a list
Concurrency!
Easy to test
Reuseabliliy

https://www.amazon.co.uk/Concepts-Programming-Languages-Robert-Sebesta/dp/0321509684/

[Design Criteria for Programming Languages](http://jcsites.juniata.edu/faculty/rhodes/lt/plcriteria.htm) 2015
https://progr-harrykar.blogspot.com/2018/11/language-evaluation-criteria.html

Some criteria

    Readability
    Writability
    Reliability
    Cost
    Generality
    Extensibility
    Standardability
    Support for internationalization


https://redmonk.com/dberkholz/2013/03/25/programming-languages-ranked-by-expressiveness/


Number Handling
---------------

```java
int a = Integer.MAX_VALUE;
System.out.println(a);
System.out.println(a+1);
```
```csharp
int a = Int32.MaxValue;
Console.WriteLine(a);
Console.WriteLine(a+1);
```
```python
import sys
a = sys.maxsize
print(a)
print(a+1)
```
```javascript
let a = Number.MAX_SAFE_INTEGER;
console.log(a);
console.log(a+1);
Number.MAX_SAFE_INTEGER+1 === Number.MAX_SAFE_INTEGER+2
```
https://en.wikipedia.org/wiki/Nuclear_Gandhi


Dynamic/Static
```python
ll = [4,5,6,7]
type(ll)
```
```javascript
const ll = [4,5,6,7];
typeof(ll);
```

Missing basic language features - IndexOf item in array
-------------------------------------------------------

* Run these examples
* Briefly scan the stackoverflow pages

```javascript
const ll = [4,5,6,7];
ll.indexOf(6);
```
```python
ll = [4,5,6,7]
ll.index(6)
```
```java
int[] ll = new int[]{4,5,6,7};
// ???
// https://stackoverflow.com/questions/1522108/how-to-find-the-index-of-an-element-in-an-array-in-java
```
```golang
ll := []int{4,5,6,7}
// ???
// https://stackoverflow.com/questions/8307478/how-to-find-out-element-position-in-slice
```

* Why is this basic feature missing from arrays in java and golang?
    * This is a pretty important aspect of language design


Implementation Abstraction
--------------------------

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
    * https://docs.oracle.com/en/java/javase/17/docs/api/java.base/java/util/Collection.html


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


Operator Overloading
--------------------

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
        if (isinstance(other, Circle)):
            return Circle(
                x = (self.x + other.x)/2,
                y = (self.y + other.y)/2,
                radius = self.radius + other.radius,
            )
        if (isinstance(other, (int, float))):
            return Circle(
                x = self.x,
                y = self.y,
                radius = self.radius + other
            )
        raise NotImplementedError(f"Unable to add '{other}'")

if __name__ == "__main__":
    print(
        Circle(5,5,5) + Circle(2,2,5)
    )
    print(
        Circle(1,2,3) + 5
    )
```

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
        python3 -m doctest -o ELLIPSIS NAME_OF_FILE.py

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
        # hint there are two built in functions that may help - one of them is min - https://docs.python.org/3/library/functions.html
        raise NotImplementedError(f"Unable to add '{other}'")

    # Part 2: Implement another operator
    # def __???__(self, other):
        # Can you implement another operator? can you make 'subtract' remove from the width/height of the rectangle?
        # https://docs.python.org/3/library/operator.html
    
    # Part 3: Identify other operators that can be overloaded
    # https://docs.python.org/3/library/operator.html
    # Is operator overloading good? or bad? why?
```

Async + await
-------------

