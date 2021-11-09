KS3 Programming
===============

> How might you develop a university session to enable student teachers to plan and teach a lesson on programming at Key Stage 3?
> Outline the structure of your planned session including a short assessment task you would use during the session to monitor student teachers' understanding.

Prerequisites
-------------

* Observed a range of Computing lessons in school
* Have planned and deliver a starter/plenary with a class
* Have a lesson planning proforma used by your department
    * (or fallback to a stock Christ Church example)
* Be familiar with a class and has some indication of the class's background/skillset

_Estimated week 4?_


Competencies/Objectives
-----------------------

By the end of this session you should
* Be able to understand how to plan a KS3 lesson on programming
    * Objectives / Student Learning Outcomes
    * Distinct sections titles
        * a starer, demo, task, assessment, plenary
    * Consider pupil progression with
        * Explain -> Model -> Scaffold -> Practice
        * Predict -> Run -> Investigate -> Modify -> Make (PRIMM)
    * Consider using metaphors/analogies to convey abstract concepts (if relevant)
        * Clearly conveying to the learners they are 'metaphors'
    * Literacy + Technical Language
        * Explicitly define _technical domain language_


Core concepts
-------------

> Daidau, David (2018). What if everything we knew about teaching was wrong: 256-257

David Daidau - English Teacher - part of Ofsted inspection reform on lesson observations

* Young people find it difficult to engage with things outside of their world view

> Sentance Sue, Barendsen Erik, Schulte Carsten (2018). Computer Science Education: Perspectives on Teaching and Learning (2018)

* Computing can be very abstract subject
    * We can use Metaphors and Analogies
        * Physical tactile manifestation
* We are trying to build _Competency Model_ rather than _tickbox objectives_
    * _Comprehension oriented_ not _Creation oriented_
* To plan a lesson: start with _required competencies_ and work backwards from there
    * [Blending Content Areas Through Problem-Based Learning](https://www.csforallteachers.org/blog/blending-content-areas-through-problem-based-learning)
        * >  Understanding by Design by Grant Wiggins and Jay McTighe. 
            * describe three stages of curriculum planning through backward design

Example Lesson (Model) - Year 7 DataStructures (30min)
------------------------------------------------------

(Lesson will be written up in Christ Church Proforma) as exemplar for discussion

### Prerequisites

_Estimated week 10?_

* Skills
    * Can logon
    * Load code from network area into development environment
    * Execute a program
    * Save work
    * Post work to teacher
* Threshold concepts
    * If statement
    * Loop
    * String

### Starter

Show real data on screen.

What is this?

[data.police.uk Street-level crimes API](https://data.police.uk/docs/method/crime-street/)


### Competencies / Objectives

To be able to write complex programs,
we need to understand how computers structure data
Learn how to
* Read/Modify/Create complex data structures

* There is data all around you
* with these skills you can
    * ...

### Model

```python
data = {
    "User123": {
        "name": {
            "forename": "Allan",
            "surname": "Callaghan",
        },
        "skills": [
            "programming",
            "teaching",
            "piano",
        ],
        "age": 39,
        "avatar": "http://example.com/myimage.gif",
    },
}

print('What is the users first name?')
print(
    data["User123"]["name"]["forename"]
)
print('What is the users surname name?')
print(
    '???'
)
print('What is the users age?')
print(
    '???'
)
print('What is one of the users skills?')
print(
    '???'
)
```

### Technical Language

* Curly parenthesis || Curly brackets
* Data Structure || Structured Data || Nested Data
* Dictionary || HashMap || AssociativeArray || KeyValueStore
    * Key || Field
    * Value

### Tasks

Differentiation by outcome

(Scaffold)
* Task 1: Investigate
    * Complete the program
* Task 2: Modify
    * Update the data
* Task 3: Modify
    * add a new _field_
* Task 4: Modify
    * add a new user

### Assessment

* Progress submitted digitally to teacher
* Indication of performance
    * All, most, some
* Automated marking of code submissions (Cool area! ask me about this!)

### Plenary

[JSONPlaceholder](https://jsonplaceholder.typicode.com/)

Next lesson could be using real structured data to put data on a webpage


Task: Idea Generation: Physical Metaphors (1 hour)
--------------------------------------------------

Using the resources below, identify topics related to programming in the ks3/ks4 curriculum that could be conveyed by a physical metaphor.

### Resources (30min)
* [National curriculum in England: computing programmes of study - ks3](https://www.gov.uk/government/publications/national-curriculum-in-england-computing-programmes-of-study/national-curriculum-in-england-computing-programmes-of-study#key-stage-3)
* [AQA GCSE Computer Science: 8525](https://www.aqa.org.uk/subjects/computer-science-and-it/gcse/computer-science-8525)
* [Computing in the national curriculumA guide for secondary teachers](https://www.computingatschool.org.uk/data/uploads/cas_secondary.pdf)
* [CAS computational thinking - A Guide for teachers](https://community.computingatschool.org.uk/resources/2324/single)

### Bubble up (15min)
* On own
* pair up + share + remove duplicates
* combine pair + share + remove duplicates
* As class

### Additional Resources (15min)
* [Computer Science Unplugged](https://csunplugged.org/en/)
* [Cody-Roby](http://www.codeweek.it/cody-roby-en/ecw-edition/): [Race](https://youtu.be/D5hQ9UTDQ6s?t=230)
* Couple of my ideas
    * Postit note with a number on every screen
        * Ask class to sort the number by only passing the postit to either of the people next to them
            * Bubblesort
    * Caesar cypher wheel
    * Stack of chairs
        * You have to take the one from the top
        * You can only put one on the top


Task: Lesson Proforma (1 hour)
------------------------------

Complete a lesson proforma for a ks3 programming lesson

Include:
* Student Prerequisites (required/expected prior learning)
* Starter (focus task related to the lesson)
* Competencies/Objectives
    * Relate content to student worldview
* Literacy: Technical Terms/Keywords
* Differentiation
    * All, Most, Some
    * By task?
* Timing
    * Each lesson section to have an estimated time
* Consider
    * Physical metaphor/analogy (clearly conveyed AS a metaphor)
    * Explain -> Model -> Scaffold -> Practice
    * Predict -> Run -> Investigate -> Modify -> Make (PRIMM)
* Assessment
    * How collect evidence/check understanding?
* Plenary/Summary
    * Relate content to student worldview
    * Next steps


Demo / Discussion (30min)
-------------------------

Examples - Projector
Samples from class


Assessment
----------

* Group is small enough (10 students)
    * to overhear conversations
    * engage in small-group/individual discussions
* Two task points
    * Were they able to comprehend/extract information from the documents provided?
    * Did they contribute in idea generation?
        * How feasible where the ideas?
    * Did they complete lesson pro-forma?
        * I should be able to spot any missing sections or misunderstandings
        * I can keep a copy of there pro-forma digitally
* I can observe social interactions, attitude, problem solving, idea generation, comprehension and keep notes on student progress each session


Plenary
-------

### Teachers' Standards

Correlate learning with teachers' standards

* 2.f demonstrate knowledge and understanding of how pupils learn and how this impacts on teaching
* 3.c high standards of literacy, articulacy and the correct use of standard English, whatever the teacher’s specialist subject
* 4.d reflect systematically on the effectiveness of lessons and approaches to teaching
* 5.c demonstrate an awareness of the physical, social and intellectual development of children, and know how to adapt teaching to support pupils’ education at different stages of development


### References

> Daidau, David (2018). What if everything we knew about teaching was wrong


https://blogs.kcl.ac.uk/cser/2017/09/01/primm-a-structured-approach-to-teaching-programming/


> Sentance Sue, Barendsen Erik, Schulte Carsten (2018). Computer Science Education: Perspectives on Teaching and Learning (2018)
>
> Chapter 8: Teaching of Concepts .2: Teaching through analogy and storytelling
>   Curzon Paul, McOwen Peter, Donohue James, Wright Seymour, Marsh William. p92
>
> Chapter 15: Language and Computing .5: metaphor's:
>   Diethel Ira, Goschler Juliana, Lampe Timo. p211-212
>
> Chapter 16: Taxonomies and Competency Models
>   Hubwieser Peter, Sentance Sue. p229

