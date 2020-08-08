Assessment
----------

Highlight for me:
* Function invocation
* Boolean operator
* Comparison operator
* Iteration
* Variable declaration


Standard Library
----------------

_The_ source of truth. Everything else is second hand information.

Built in Functions
Built in Types

Standard library
https://docs.python.org/3/library/index.html
https://docs.python.org/3/library/stdtypes.html#string-methods
.strip()
.replace('cool', 'dumb')
.startswith('obo')
.lower()
https://docs.oracle.com/en/java/javase/14/docs/api/index.html
java.lang.string

```python
aa = 'Bob is cool!'
aa.replace('cool', 'awesome')
aa.split(' ')
aa.find('is')
aa.isdigit()

bb = [167, 12, 77]
bb.reverse()
bb.sort()
```

Data Structures
---------------


dicts
arrays in dicts

(see ks3 lesson in teacher training?)

```python
# list
aa = [
    'bob',
    'jane',
    'sally',
]
aa[1]
aa[1][2]

# dictionary
bb = {
    0: 'bob',
    1: 'jane',
    2: 'sally',
}
bb[1]

# dictionary +
cc = {
    'name': 'Allan',
    'age': 40,
    'languages': ['python', 'java', 'javascript'],
    'friends': aa,
}
cc['age']
cc['languages'][2]

# reveal - the entire python language is built on dicts

```


Engineering
-----------

* Debugger
    * python
        * debugger()
        * import pdb ; pdb.set_trace()
    * javascript
    * java? (needs a big IDE)
* Write tests (sometimes before starting a problem)
    * functions that return that can be asserted
        * `assert`



Summary
-------

You have about 1/4 of the normal contact time of an A-Level student.
Your futures sessions will have questions starting to be lead by you.

Case study on questioning:
Q: "How do you convert a string to an integer"
A: It's on the cheat sheet and you've done this before in previous programs
Dissatisfied with answer because the question was not articulated clearly
Actual Question: How do I convert a list of strings into a list of integers?

Your ability to ask precise questions will the bounding factor in your progress


Session 5
---------

Collaboration
* [Setting up SSH and Git on Windows 10](https://dev.to/bdbch/setting-up-ssh-and-git-on-windows-10-2khk) version control
* [LiveShare](https://visualstudio.microsoft.com/services/live-share/)


* Version control
    * `git`
* linter
    * ide feedback
* code formatter
    * `black` python
    * built into vb.net IDE
