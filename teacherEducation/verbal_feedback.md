Capturing Verbal Feedback
-------------------------

TODO: Rewrite

We are developers. We have the superpower of building solutions. Other teachers can't do this.
We can rapidly prototype ideas. These are sometimes refereed to as _hack projects_.

### Problem

In 2005 I wanted to build a teacher feedback capture system.

I observed that most teacher datasystems required me to sit at a desktop computer and enter data. I needed a mobile/portable data capture system.

### Idea

I wanted a handheld seating plan where I could tap a student and record information. The information was stored and available to the students. I had plans for making that data available as an _active desktop_ so that students logged in an immediately had their progress feedbacks and targets on the desktop.

Laptops were possible but bulky. PDA's were possible, but difficult to program. There were no smartphones. PDA's had VERY limited web ability. I did not have the time to code a system with the limited developer tooling of the era.

The interface would have been complex radio buttons and dialogues. I considered having an audio capture system. By just holding the stylus on a student name I could record audio/voice comments. At least I would have a record. When writing reports or parents evening I could go though all the audio snippets?


### Prototype? 2021

Superseded by Professional solution
* [Mote: voice notes & feedback](https://www.mote.com/)
    * Mote is the audio toolkit for educators and learners across the world - integrated into the products you know and love.

Mobile phones are now prevalent. Speech to text is a service available in HTML5 web browsers (currently only GoogleChrome, more are coming).

I spent 3 hours this holiday making a proof of concept mobile feedback capture system. (1.5 hours was pratting around with web layout ... I'm always on the back foot with web layout, I need to raise my skill-set with it)


* [feedbackLogger](https://calaldees.dreamhosters.com/teaching/teacherTools/feedbackLogger.html) 
    * proof of concept on my webserver
    * it's just a single html file that you can save locally
    * it saves comments in memory that can downloaded as json
    * the seating plan is currently hard coded
    * I've tested it with desktop chrome (It may need a few tweaks to be used on mobile?)
* [github.com/calaldees/teacherTools](https://github.com/calaldees/teacherTools)

TASK: Give it a try
Can we think of any other simple tools that could help us with data management for feedback?
(This leads on to a future session about _Data and Management_)

The important next step would be making this feedback visible to the student.


* Impact of feedback == Students Confidence in original answer
    * [School students’ confidence when answering diagnostic questions online](https://link.springer.com/article/10.1007/s10649-021-10084-7)
