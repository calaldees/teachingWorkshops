Automated Tests (1 hour)
---------------

* A super power for our subject disaplin with code.

* https://replit.com/@calaldees/DoctestMarkdownTest
    * An example of using different types of automated test in python.
        * Doctests
        * Doctest in separate MarkDown file
            * `python -m doctest --fail-fast -v main.md`
        * Doctests inline with code
            * `python -m doctest --fail-fast -v example_doctest_inline.py`
        * Tests via Main method and assertions
            * (no real test framework)
    * TASKS
        1. Complete the tests that fail when you hit the run button
        2. Add a repl.it unit test for subtract (the _tick_ icon on the left)
        3. Using the shell command-line run the (total of) 3 other methods for writing/running tests in python
            * see `.replit` for the commands for each type of test
        4. Attempt to use replit's built in unit-tests
            * I don't like the idea of vendor lock-in, but let's investigate what these tools do
* https://github.com/calaldees/TeachProgramming/blob/master/teachprogramming/static/projects/data/crypto.md
* An example of use semi-professionally - inline doctest
    * https://github.com/calaldees/libs/blob/71a86ada8d641b49215893c53b92c31190254e13/python3/calaldees/music.py#L27


### Professional systems

There are integrated all-in-one auto-mark solutions for Computer Science problems.

* [mimirhq.com](https://www.mimirhq.com/classroom/demo_video) mimir classroom
    * Video
        * Coding assignment - see animation of how student solved problem
* (Isac Computer science has one?)
* [Moss](http://theory.stanford.edu/~aiken/moss/) - A System for Detecting Software Similarity
    * Plagiarism detection of code
* [gradescope.com](https://www.gradescope.com/) by turnitin
    * Auto marking and plagiarism detection
* [codequiry.com](https://codequiry.com/) - api for code similarity


### Pedagogy

* What are the advantages of automated tests?
* What are the problems with automated tests?

<details>

* Fast feedback on performance
* Specification (know what you're aiming for)
* If students build tests - You are more likely to understand what you want the task is, if you construct tests before starting a task.
    * How can you get somewhere if you don't know where you are going?

* Students are bad at writing tests ... so they will be even worse at writing code ...
* [The Peanut Butter and Jelly Sandwich Challenge as an Approach to Improve Students Abilities in Test Case Writing](https://dl.acm.org/doi/10.1145/3304221.3325582) 2019
    * > Test cases are a set of test inputs, execution conditions, and expected results developed for a particular objective, such as to exercise a particular program path or to verify compliance with a specific requirement. Test cases that are written by students typically have recurring errors that make difficult to find hidden bugs or lack essential details about the data to be used and the instructions that must be followed. As an attempt to improve the quality of students test cases, we used a "Peanut butter and jelly sandwich challenge", typically used to teach algorithmic thinking, to show students the difficulties one may have repeating a simple set of instructions when they are not precisely described. That activity was adapted to cover contents focused on test case writing.
* Concept: Spend a lesson beforehand writing the tests!

</details>