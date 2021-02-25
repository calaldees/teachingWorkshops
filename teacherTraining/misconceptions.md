Misconceptions
==============

* [computer science: student myths and misconceptions](https://www.researchgate.net/publication/234832735_Computer_science_student_myths_and_misconceptions) of the field in general (Beaubouef, McDowell 2008)
    * > common myths and misconceptions about the field of computer science. It addresses and attempts to dispel these notions in an effort to provide prospective computer science students and the general public with a more realistic view of the field
* [Misconceptions About Computer Science](https://cacm.acm.org/magazines/2017/3/213837-misconceptions-about-computer-science/fulltext) - The profession of IT
    * Computing occupations are projected to grow at a higher rate than all other STEM areas combined.
    * Regardless of their career, many professionals will be using computer science at work.
    * most "human executable recipes" cannot be implemented by a machine. This misconception actually leads people to misunderstand algorithms and therefore overestimate what a machine can do.
    *  "transfer hypothesis." a thinking skill automatically transfers into other domains simply by being present in the brain. This is not true
    * Misconceptions
        * CS = programming
        * Programming is concerned with expressing a solution to a problem as notation in a language. 
        * Once you master a core knowledge base including variables, sequencing, conditionals, loops, abstraction, modularization, and decomposition, you will be a computing professional.
        * Programming is easy to learn.
        * Computational thinking is the driver of programming skill.
        * When we engage in everyday step-by-step procedures we are thinking computationally
        * Computational thinking improves problem-solving skills in other fields.
        * CS is basically science and math. The engineering needed to produce the technology is all based on the science and math.
        * Old CS is obsolete. The important developments in CS such as AI and big data analysis are all recent.
* [Top 5 Misconceptions About Computer Science](http://blog.sparkfuneducation.com/top-5-misconceptions-about-computer-science)
    * It’s only for boys
    * It’s going to be required for every job in the future
    * It’s all about programming
    * It’s too complicated for younger students
    * Computer science is hard to integrate into core subjects
* [3 Misconceptions about ICT In Schools](https://www.netcom92.com/2013/09/3-misconceptions-ict-schools) Megan Hemmings 2017
    * Pupils will just surf the web all day
    * Children spend enough time in front of screens already
    * Computers are making my child less, not more, clever
* [Identifying student misconceptions of programming](https://dl.acm.org/doi/10.1145/1734263.1734299) Kaczmarczyk 2010
    * investigation of student misconceptions in a series of core CS1 topics previously identified as both important and difficult. 
* [Computing Misconceptions - Any Key Stage](https://community.computingatschool.org.uk/resources/4725/single)
    * This is just a first attempt at trying to categorise the misconceptions we see in our classrooms.
    * [Exploring Programming Misconceptions: An Analysis of Student Mistakes in Visual Program Simulation Exercises](https://dl.acm.org/doi/10.1145/2401796.2401799) [dropbox](https://www.dropbox.com/s/bar756coeuyn3b2/p19-sirkia.pdf?dl=0)  
        * Teemu SirkiäAalto Universityteemu.sirkia@aalto.fiJuha SorvaAalto Universityjuha.sorva@aalto.fi

Copy&Paste from article above - the list is amazing!

Variables

    writing code for statements like ‘x is equal to 3 or 4’ literally as ‘x == 3 or 4’ which causes headaches if using a language where the expression to the right of the Boolean operator has a Boolean interpretation.
    Value and variable are often swapped too eg 7 = x.
    the perennial problem of confusing assignment (=) with a test for equality (==). x=x+1 is utterly confusing in the mathematical terms children are familiar with.
    foo="A"
    bar="B"
    foo=bar
    //gives foo="B" and bar="B"
    Slicing a string removes characters from the original string.
    Lists and arrays are the same thing.
    Variables remain linked after assignment. a := 7; b := a; a := 13; What’s the value of b? Students with this misconception would answer 13. (This might be worse in languages that use an equals sign for assignment. After all, b = a seems to suggest these semantics…)
    Inverted assignment (first = second) - wrong way round

Logic

    thinking the inverse of x < y is x > y.
    Loops, functions, variables, classes don’t really exist. CPUs have no clue about any of these things, they exist only in the language translator and debuging.

Flow Control
Sequence

    ‘sequence’ in Maths meaning a pattern and ‘sequence’ in Computing meaning an order
    Every line in Java / C / C# / C++ must have a semi colon at the end of it.
    if x == y: (execute then part even if false)

Selection

    ELSE in selection needs a Boolean test of its own
    ELSE is always needed in a selection statement
    1=="1" is True (not helped by the fact in some languages it is!)
    IF(A > 6 AND < 8) instead of IF(A > 6 AND A < 8)
    Language dependent IF (A = B) is the same as IF (A == B)
    Students insist on using: If test=True Then, rather than: If test Then

Repetition

    where the student thinks that the loop break when ever the condition stops being true, rather than at the boundary where it is checked.
    loops always exit from the bottom of the loop instead of where the loop control condition is evaluated.

Subprograms

    Confusing a function call with a GOTO (this is terrible because it often kind of works with a few weird side effects)
    Returning False from function even though condition does not hold
    All subprograms must have a return statement
    not storing return value of function
    mixing up the direction in which data flows between subprograms that ask for user input or carry out some output. Data from the user should go out from the subprogram to the rest of the program not in. Data to the user should go in to the subprogram not out of it.
    Lots of my students (despite careful teaching to the contrary…) confuse a function returning a value with a procedure that outputs (i.e. prints) a value.

Data Representation

    The length of a string is the number of chars in it, but string indexing is zero based. The length of CAT is 3, but the T is at index 2. (Some languages have settable origin 0 or 1)
    Assuming that all two’s complement numbers are going to be negative.
    assuming all hexadecimal numbers MUST have letters

Technology

    That the best way to type a capital letter is the Caps Lock key :/
    Clock speed More cycles per second doesn’t automatically mean faster. Some CPUs do more in each clock cycle, or memory may not be able to keep up.
    USB == Memory Stick
    Input devices being something you put into the computer (i.e. anything that you can plug in, especially power).

Networking

    pupils learn about a logical star network topology and assume this is how it is physically configured (i.e. a server sits in the middle and all nodes are directly connected to it).
    Peer-to-peer networks are believed to be a network topology, rather than a virtual network implemented at software layers
    WiFi connects you directly to the Internet…
    …and this connection is available anywhere you go.
    The class of an IP address dictates the subnet mask that must be used.
    servers are big computers
    Absolute misunderstanding of what Wifi is altogether, using it as a general term for their router at home.

Web

    The title tag in HTML produces a title on the webpage itself.
    The HTML head element describes what appears at the top of a webpage.
    Conflating the Internet and World Wide Web.
    Confusing Web browser and search engine. Google being a browser
    Referring to HTML as a programming language/writing a program.

Spreadsheet

    SUM in a spreadsheet means ‘add’ (as in maths) not ‘do a calculation’ [also =SUM(A1+A2) is a pet hate!]
    =SUM() being needed for any calculation in Excel.

Computer Systems

    Processor cores execute multiple instructions at the same time (multitasking).
    Having more processor cores directly improves the runtime of a (single threaded) application
    Logic gates are discrete components not made of anything else (no knowledge of transistors)

Other

    Compilers produce assembly code which is then converted to machine code.
    Detecting errors is the same as correcting errors.
