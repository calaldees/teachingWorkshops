* Introduction (2 hours) 10:00 to 12:00
* IDE + Containers (2 hours) 13:00 to 15:00

Introduction (2 hours)
============

* Learning Objectives
  * Understand the module content and assessment content

Who am I?
---------

* 7 Years teaching Computing in secondary schools
    * A-level, Linux, networking, game programming. Part of transition from ICT to Computing.
* 10 years Software engineering
    * 2 years - Lead developer of a Citizen Journalism startup
    * 6 years - Global Radio (full stack web content management developer, android dev, Lead test and internal tooling engineer)
    * 6 months - financial investment platform CI infrastructure
    * 1.5 years NHS Genome processing pipeline for cancer and rare disease analysis
* 3 years Lecturer in Education (teacher training)
* Now - Lecturer in Computing

* Side projects
  * DMX Stage lighting and projectior sys (with 3d stage visualiser)
  * Karaoke System for mobile phones
  * Lots of other rubbish


New Module
----------

* Not been run before
    * Marks for whole cohort can be scaled
* Your feedback is important


Module Overview
---------------

<sub>Hint: Take notes .... seriously! ... get a notepad, or open a text document. Get ready!</sub>

TASK: (10min) 
* Find - the module handbook - read
* Whiteboard - What do you think is in this module?

## Module Aims
To develop the student’s understanding of the fundamental concepts of Programming Frameworks and Languages. 
This module supports the Implement and Operate elements of the CDIO model.

### Intended Learning Outcomes 
By the end of the module students should be able to:
1. Demonstrate an understanding of the concept of a Framework in general, a Framework used for Programming, and a Framework used for software Testing
2. Critically evaluate the effectiveness of a particular framework for an application and platform
3. Synthesise a small digital artefact using a well-formed programming framework

Whiteboard in half: words to describe
* What is a [programming language](https://en.wikipedia.org/wiki/Programming_language)?
* What is a [software framework](https://en.wikipedia.org/wiki/Software_framework)?

The sign of an armature:
> _TECH_XYZ_ is rubbish
This module will help develop an important part of your professional skill-set: 
> The ability to discuss and reason about technology choices

* Language
  * A formal structure to describe machine behaviour
* Framework
  * Inversion of control
    * It calls you, rather than you call it

### How will we learn

1. Focus on a business engineering problem with real industry tools
    * Hand on each week with a range of tools
2. Discussion
    * Real researchers and engineers can discuss/reason about technology
    * (Hack time, coffee-area chat)

#### Level 6
* Level 4 - You are told what to do
* Level 5 - Supported developing competency in a range of problem domains
* Level 6 - You are able to self direct

* My role is NOT to have all the answers. 
* My role is to facilitate your transition towards a skilled professional.

#### Session Overview - Online/Campus

Task: Look on blackboard at session list

* 2 weeks online
    * Blackboard
* 2 weeks on campus
    * 09:00 - 13:00 Lab (if we can fit in one room)
    * 14:00 - 18:00 (optional lab support)


Assessment Demo
----------------

* Demo: The simple app

* Implement Web App
  * Server Framework (data api service)
  * Client Framework (browser app logic)
  * Client Layout Framework (styles + visuals)


* Set 27/09/2021
* Assignment 1 01/11/2021
* Assignment 2 10/01/2022

* GitPod + containers
* OpenAPI Spec

| Assignment | Section | Marks (Total 100) |
|---|--------------------------------|---:|
| 1 | Critique of prototype          |  7 |
| 1 | Server framework justification | 15 |
| 1 | Client framework justification | 15 |
| 1 | Roadmap                        |  3 |
| 2 | Server implementation          | 21 |
| 2 | Server documentation           |  4 |
| 2 | Client implementation          | 21 |
| 2 | Client documentation           |  4 |
| 2 | Visual usability               | 10 |



### Run it yourself (1 hour)

* Demo: (15min)
* Task: (30min)
* QA

<sub>Seriously ... make notes ... </sub>

Demo:
* Fork
* The IDE
* The Interaction (public port)
* The tests


1. Fork and run the project on GitPod
2. Add an item with the web interface
3. Run the tests


### Public Repo?
* Will confer with course directors




Starting point Quiz (15min)
-------------------

How much do you as a class know already?
(They are deliberately challenging questions)

https://b.socrative.com/login/student/
CALLAGHAN1818



Development Environment + Containers (2 hours)
====================================

<sub>Seriously ... take notes ... </sub>

* Learning Objective
  * Build Fundamental Skills
    * Setup new GitPod environment bound to new repo
    * Understand how to Build a container
      * Starting layer
      * Layers and Cache
      * Entrypoint
    * Understand how to Run a container
      * Ports
      * Volume mounts
      * Clean container state
    * Commit via commandline
    * Orchestrate multiple containers






---



  1. Module overview
    1. Assignments
      1. Writeup justification
      2. OpenAPI + Tests + Containers
    2. What level 6 means
    3. How do you analyse a framework (explicit)
    4. Languages
    5. Frameworks
    6. Tests
  2. Practical
    7. Clone and commit
    8. gitpod
    9. Containers
      1. build/run
      2. compose
    10. Make HTTP Server
      3. python/java
  3. Homework: 




Initial audit

---

Updated

2. Which languages have you used
  1. C#
  2. Java
  3. Python
  4. Php
  5. Golang
  6. C
  7. C++
  8. Javascript
  9. Ruby

1. What is this? (not including subsets)
  * ```json
      {"code": 200, "message": "something happened", "payload": ["a", "b", "c"]}
      ```
  1. python
  2. javascript
  3. json
  4. yml
  5. xml
3. What are these?
  * GET, POST, DELETE, PUT
  1. Database operations
  2. Common language commands
  3. HTTP request methods
  4. Part of the OpenAPI spec
4. What is the difference between virtualisation and containerisation?
  * Virtualisation is simulating an entire machine, Containerisation is an isolated environment managed by the kernel
  * Virtualisation is the emulation of an operating system, Containerisation is a virtual system
  * Virtualisation runs inside another process, Containerisation is running on the host
  * Virtualisation runs on your local machine, Containerisation runs remotely
5. What is an event loop?
  1. A `while` loop
  2. A core game/ui loop that process's each frame in realtime
  3. A technique for handling user input efficiently at a low level
  4. A way for single threaded languages to mimic/utilise concurrency
6. Which of these are _functional_ languages
  1. PureScript
  2. TypeScript
  3. C#
  4. Haskell
  5. Elm
  6. Prolog
  7. Java



Notional machine of how twitter works?
