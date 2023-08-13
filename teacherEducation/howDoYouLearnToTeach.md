How do you learn to teach
=========================

Targets: talk through - (already done in induction, double )


* Aims and purposes of our teaching and learning
* Meta-pedagogy (not _tips for teaching_)
* Tacit knowledge transfer - e.g. Riding Bike, Learning to read
* Reflection

Aims of Subject Pedagogy
------------------------

* What is Subject Pedagogy?
* You already have foundation subject knowledge
* We are learning HOW to teach someone about Computing
* I will not be showing you tips for teaching
* I will not give you resources
* I don't know the 'right' way to teach. Nobody does. It's contextual.
* Training _you_ as teachers to _reinvent the profession_ (and not be cones of us teacher trainers)
* Preparing students for a future we are unsure of
    * spellcheck story



Tacit Knowledge
---------------

* [TEACHING A BACKFLIP IN A HOUR! 😱 Location: Motive School Of Movement in Greenville, South Carolina](https://www.youtube.com/watch?v=E8f-giFxN8Q)
    * scaffold
    * worked examples (more effective for novices)

* [Tacit Knowledge](https://en.wikipedia.org/wiki/Tacit_knowledge)
    * Tacit knowledge is knowledge that cannot be captured through words alone.
    * tacit knowledge feel like _a hunch_ - feels right. it enabled creative problem solving
    * Some people argue that tacit knowledge does not exist - everything can be quantified and deliberately taught
    * Further Reeding
        * [Scaling tacit knowledge](https://nintil.com/scaling-tacit-knowledge/)



* Tacit knowledge transfer - e.g. Riding Bike, Learning to read
    * Can you write down the steps to ride a bike?
    * [Learning How to Ride a Bike](https://notebook.wesleyac.com/learning-to-bike/)

TASK: How would you teach someone to ride a bike?
120 seconds - Write down - the phases/notes
Describe verbally to group


* We don't get better by just doing a task for 10,000 hours
    * How long have you spent driving? Why are you not a world class driver?
    * You're operating without reflection/feedback mechanisms
* we get better by observation, analysis, feedback, mentoring

* [Why Tacit Knowledge is More Important Than Deliberate Practice](https://commoncog.com/blog/tacit-knowledge-is-a-real-thing/)
* [Knowledge Illusion: People think they know more than they do - draw a bike](http://www.gianlucagimini.it/prototypes/velocipedia.html)


Building Computing Knowledge
----------------------------

> No one get's into coding for the loops and if statements, they do it for the superpowers it gives them.
<sub>Amjad Masda</sub>

https://docs.replit.com/teaching-curriculum/intro-python
https://www.tes.com/teaching-resource/introduction-to-python-fully-resourced-sow-12392327
https://replit.com/curriculum/Intro-to-Python
https://replit.com/curriculum/Intermediate-Python
https://replit.com/@MrAColley

### Types of learners

* Hobbyist
    * Motivated
    * invests own time
    * own choice
* Employees
    * paid by experts
    * trained by experts
    * have end goal
    * allocated CPD time
* Students
    * One lesson a week for 8 weeks
    * large class
    * teacher still on learning curve
    * one subject among many
    * goal is far in the future
    * Might not want to be there
* from [Education Workshop: Using PRIMM to teach Programming with Andy Colley](https://youtu.be/H0t2eBXazF0?t=632) at 10min

Because a consumer of digital services does not make you a creator of digital services

### Novices and experts
`myAge = int(input("Please type in your age: "))`
How many concepts are there here? High cognitive load and this is one line .. and there are 5 or 6 concepts
(bigger example)
Many tutorials start with this complex line
1. what is the problem (do we understand it)
2. what are the parts of the problem?
3. how to translate that into computer instructions/syntax (people seem to obsess about this!?)

### Task example:
* Task: Find the highest number in the list
    * how to unpick it?
    * how do they actually solve this?
* Worked examples (backwards fading)

### Gradual taking ownership
Not my code (not my responsibility) -> partially my code -> all my code 
(Up to GCSE)
Example code | My prediction | screenshot of code running | differences from my prediction

Academic wording - giving things a name
https://qualifications.pearson.com/en/qualifications/edexcel-gcses/computer-science-2020.html on screen GCSE exam

### Misconceptions
(what misconceptions) (show code from before)

If they are learning - shut up! stop talking

### More able? More Support?
Not the lockstep march
Concept: Advanced ones - cheat sheet - another language?

### Teach the long way
* don't use `in` (just use a loop)
* don't use `input("this string is output!")`


The Block Model
---------------

plan your (I)nvestigate questions

* [Block Model: an educational model of program comprehension as a tool for a scholarly approach to teaching](https://doi.org/10.1145/1404520.1404535) Schulte 2008
    * [The I in PRIMM](https://helloworld.raspberrypi.org/articles/hw14-the-i-in-primm) Sue Sentence 2020
        * https://helloworld.raspberrypi.org/issues/14 Page 50

| | (T) Text Surface | (P) Program execution | (F) Function (relevance/intention) |
|-|-|-|-|
| (M) Macro structure | Understand the overall strcuture of the program text | Understand the algorithum underleying a program | Understand the goal/purpose the program in the current context |
| (R) Relationships | Relationships between blocks | Sequence of function calls, object sequence diagrams | Understand how subgoals are related to goals |
| (B) Blocks | Regions of interst that build a unit (systematically or sematically) | Operation of a block or function | Understanding of the function of a block of code |
| (A) Atoms | Language elements | Operation of a statement | function of a statement |

Example
* (MF) "What would happen if the input to the program was ___"
* (RT) "Ask students to identify the scope of a variable"
* (RP) "Draw the flow of control on the program"
* (BT) "Ask students to draw on the program to identify blocks of code or types of construct"
* (BP) Ask: "What would happen if those two lines were the other way around?"
* (BP) Draw the flow of control
* (AF) Identify the purpose of a single statement

```python
answer = input("What is the best subject?")

if answer == "Computing":
    print("Correct! Well done!")
else:
    print("I'm afraid you must be mistaken.")
```
* (MF) What input would produce the output "Correct"
* (BT) What line does selection start on?
* (BP) Which line runs after line 3 when the input is "Music"?
* (AT) What is the condition in the code?
* (AF) What is the purpose of line 1 in the code

```python
print("Hi What's your name?")

name = "Turnip"

print("Hi " + name + "! How are you today?")
```
You do

### Modify
Pure focus (at first) (working memory)
Swap a `for` loop for a `while` loop

repl.it `.draw` file

### Make
From scratch? Parson?
Level of detail of instruction
* SUPER DETAILED
    * enter a name and say Hello name
* or more vague (plain english - top level)
    * name and special message

>> I taught my dog to sing
> what can he sing?
>> I said I taught him, I didn't say he's learnt it

----


Maynard and Furlong - development
-------------------

* Early Idealism
* Personal Survival
* Dealing with Difficulties
* Hitting a Platu
* Moving on


We don't really know much about education
-----------------------------------------

* [The Biggest Myth In Education](https://www.youtube.com/watch?v=rhgwIhB58PA) veretasium 2021 - learning styles YouYube 15min
    * you are not a visual learner
    * be critical

* [What are we doing? Are we all doing it?](https://bennewmark.wordpress.com/2021/06/22/what-are-we-doing-are-we-all-doing-it/) 5min
    * Lesson observations are not sufficient for knowing is teaching is effective
    * Observers look for a focused environment where student know what they are doing
    * This is a poor proxy for "learning", but it is an effective proxy
    * Necessary but _not sufficient_, but very necessary.

* So much of what we know about education is incomplete and possibly wrong
* Education is a new thing; We've only been sitting at desks for 100 years. Before that EVERYTHING was apprenticeships



Reflective practice
===================

* Up until now, (level 6 and below) you have been _taught at_. You've been told what to learn and how to learn it.
* At postgraduate level - there are 'no answers'.
* We have take information from a range of sources and structure our thinking in a particular way that allows us to critically inspect and challenges our beliefs/assumptions

"I'm just going to think lots and get better" - not that simple

Rolf
* What
* So What
* Now What

Kolb
* Experience
* Reflection
* Theorising
* Experimenting

Brockfield's 4 lenses
* Autobiographical lens
* Learners lens
* Colleague lens
* Scholarship lens


Criticality and learning to think
---------------------------------

* Metaphor "routing around in the grass"
    * Snake in the grass?
    * evolution makes us not hang around to find out
    * We know!! The risk/cost of investigating is too high
    * When we are certain - we don't think
    * "routing around in the grass" to find out is dangerous
    * Modern society (mostly) is not instant death.
    * If we even see people routing around in the grass we tut and sigh and roll our eye's. We feel like we know the answer.
    * Don't stop others for routing around in the grass. Start digging yourself.

* Duck or rabbit?
    * ![Duck or Rabbit](https://www.researchgate.net/profile/Shane-Oneill-5/publication/232927441/figure/fig1/AS:669948519120911@1536739582541/Duck-rabbit-drawing.png)
        * Which is it?



* We are debating over interpretation. It is not either, it's just some lines

> If we cant agree what education is for, then we will be unable to agree on how to improve it.
David Daiau 


* [All of science gets a general index (permalink)](https://pluralistic.net/2021/10/28/clintons-ghost/#cornucopia-concordance)
    * > It's hard to overstate what a scam academic and scientific publishing is.

TODO:
* [Ofsted alarm at teacher trainers 'selling' one pedagogy](https://www.tes.com/news/ofsted-alarm-teacher-trainers-selling-one-pedagogy)


Pedagogy and Practice
---------------------

[Are We Preparing or Training Teachers? Developing Professional Judgement in and Beyond Teacher Preparation Programs](https://journals.sagepub.com/doi/10.1177/0022487117702584) [padlet](https://padlet-uploads.storage.googleapis.com/620776567/c1f78b95d4d4ba6b8911b4ea271a0184/Are_we_preparing_or_training_teachers.pdf) Scales 2018

> "Pedagogy does not often survive contact with the classroom" (Lynch, 2013, p. xv).
> Lynch suggests learning to teach must be a combination of views about teaching that candidates bring to programs along with experience.
> Lynch calls this the Tuesday morning question:
> What will teachers do after they have had the experience of Monday?
> He asserts that
> learning from experience is possible through theories of pedagogy,
> but pedagogy without experience is meaningless

> How can programs prepare candidates for complex teaching situations that may not match coursework exactly? 
> Learning to teach literacy is not simply learning content, skills, and strategies, 
> but a way to think about teaching as a flexible, adaptive process 
> that takes into account district requirements, school culture, teacher expertise, curricular demands, and students’ needs.
> Teachers need to make professional judgements during teaching, 
> and perhaps even become subversive in adaptations, depending on their teaching contexts.
>
> This begins in coursework where teacher educators should help candidates understand when, where, and how to be advocates for a different stance.
> Indeed, we are not advocates of replicating program instructors or a “Clone Army” (McCallum & Lucas, 2002) of teachers who compliantly do as they are told.


Research informed Practice
--------------------------

Even if you've taught full time for 3 years.
How many young people have you taught? Maybe 1000? for a few hours each ... maybe some of them 60 hours in a year.
How many young people are in the country? the world? how many other techniques do you think there are?
Even with 3 years of battle experience, without research and scholarship you have no idea how your ideals compare to the planet.


Stop working on hunches and things that feel right.
Remember "poor proxies for learning", just because they are quiet, does not mean that leaning is happening.
So we combine "Practice with Scholarship"


* [Teaching and Learning Toolkit](https://educationendowmentfoundation.org.uk/education-evidence/teaching-learning-toolkit) - An accessible summary of education evidence

DISCUSSION: Is the EEF the final word on this? Is there more to the story? Criticality (more on this tuesday)?


Public Blog Concept?
-------------------

* To enhance your reflections this year you could have them publicly visible and blog about your experiences and growth.
* This could be too much for some

* [Blogging while on professional placement: explaining the diversity in student attitudes and engagement](https://www.tandfonline.com/doi/abs/10.1080/1475939X.2013.847481?journalCode=rtpe20) Dalgarno (2013)
    * > The use of journals by students while on placement is a well-accepted strategy for encouraging reflection on practice, with the use of online blogs for this purpose potentially providing additional benefits through shared reflection and peer support. The aim of this study was to explore the effectiveness of an online blogging activity by teacher education students while on professional placement in schools.
* [Blogs in pre-service teacher education: exploring the participation issue](https://www.tandfonline.com/doi/abs/10.1080/1475939X.2013.802990) Deng 2012
    * > conceptualise the participation issue central to blogs through examining the factors that hinder student teachers from writing academic blogs and exchanging comments


My technique/approach to Student teacher reflections
----------------------------------------------------

* Students have limited time. The activity has to feel worthwhile.
* Students don't want to show others their "incorrect and floundering" inner monologue and scribbles
    * But without an audience/viewer they see little point in doing it
* Student feel threatened when big scary tutor demands to see their reflections. It's too much like marking and judgment.

So!

* At the beginning of every subject session. We will spend 15min to 30min showing another member of the group your weekly mentor sheet and talking about the targets and reflections.
    * Pair up with different people each week (I hopefully don't need to define a rota)
    * I may circulate and pop into some of the discussions
* Your reflections/action points from subject sessions will also go on the weekly mentor meeting sheet.
* Your targets on your weekly mentor meeting sheet are your _leavers_
    * [Leverage observations](https://improvingteaching.co.uk/2014/12/15/archimedean-leadership-2-what-are-leverage-observations-or-how-would-yo-yo-ma-feed-back/) 2014 Harry Fletcher-Wood
* One document. One place. Consistent "judgment free" low stakes discussion.



















Unsorted
========



* Actions (leaver)
    * Immediate actions
    * Future points (How will you come back to these?)
        * Behaviours? Cumulative?

* []() TODO Jimerson, Camps and Grief 2003 - engagement is multifaceted - affective behavioural and cognative
    * Volentary interactions with content and teachers
    * Samuelson 2012 measurements of engagement constructs
    * Subtype should be specifed to deepen understanding and to avoid vague classifications (Christerson, Reshly, ylie, 2012)
    * Finn and Zimmer (2012) behavioural components as academic and social

* [An Error Feedback Method to Enhance Teaching Ability of Young Teachers for Classroom Teaching Process](https://ieeexplore.ieee.org/document/9150284/references#references)
    * Pretty weird - talks about feedback and testing? Unsure of what this journal was actually getting at?


TODO

* CCCU Student [free-software](https://www.canterbury.ac.uk/our-students/ug-current/it-services/software-and-online-services/free-software)
    * Student desktop

* [Teacher professional learning and development](https://www.iaoed.org/downloads/EdPractices_18.pdf) Helen Timperley - INTERNATIONAL ACADEMY OF EDUCATION



Other?
-----


* [Quality teacher educators = quality teachers? Conceptualizing essential domains of knowledge for those who teach teachers](https://www.tandfonline.com/doi/full/10.1080/13664530.2013.813766?src=recsys)
    * > (teacher education is) preparing teachers to remake the profession,
    * > Teaching has always been about changing the world; it has never been about changing the world alone
    * Do we need teacher educators?
* [Teach Teachers how to create magic](https://www.ted.com/talks/christopher_emdin_teach_teachers_how_to_create_magic) 6min TED Talk 2013
    * Engage students like rappers and pastors do


### Be open?

* [They are not the baddies](https://teachreal.wordpress.com/2021/09/11/they-are-not-the-baddies/)
    * A youthful perception of school is not always accurate (even adults remembering)
    * Don't jump to conclusions about rules being setup
    * schools (and their employees) are the baddies



* Twitter [Finland: Charging fees for tuition is illegal - private money makes public system better](https://twitter.com/RexChapman/status/1566258979004727299)