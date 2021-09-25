Frameworks and Languages
========================


MCOMD3PFL Programming Frameworks and Languages

50 hours instruction
150 hours independent

* [GitHub List - Project Based Learning](https://github.com/practical-tutorials/project-based-learning)
* [mapOfComputing](https://github.com/ComputingTeachers/mapOfComputing/)
* [computingteachers.uk/langauge_reference](https://computingteachers.uk/static/langauge_reference.html)


* [twitter - professional developers conversation](https://twitter.com/b0rk/status/1436703520560910337)
    * > when you learn an abstraction first (like Rails), it can be hard to go learn about what's underneath (like TCP) and understand how it relates to the abstraction
      * @b0rk
    * > I really like that you jumped from Rails all the way to TCP in this tweet. People sometimes only think about a single layer of abstraction when the whole technology stack is important 
      * @garethadams

* [View Components, Storybook and Tailwind: The Holy Trinity? Learn how to setup View Components and Storybook for Ruby on Rails.](https://finnian.io/blog/view-components-storybook-tailwind-the-holy-trinity/)
* [Pagnination in openapi](https://github.com/OAI/OpenAPI-Specification/issues/1835)
* [replace-jquery](https://github.com/sachinchoolur/replace-jquery)
  * Automatically finds jQuery methods from existing projects and generates vanilla js alternatives. 
* [High-Performance-Organizations-Reading-List](https://github.com/pdfernhout/High-Performance-Organizations-Reading-List#decreasing-cognitive-load)
  * Paragraph summarising the books/articles - AMAZING!
  * Programmers hit walls of complexity 3,000 30,000 and 300,000
* [FORTRAN.io](https://fortran.io/) - finally, a Fortran Web Framework
* [TI4 Map Generator](https://github.com/DerekPPeterson/ti4-map-generator) - Generate balanced ti4 maps
  * cgi-bin python wrapper to c++ commandline
* [Structural pattern matching in Python 3.10](https://benhoyt.com/writings/python-pattern-matching/)
* [Improve Your Life with Long Error Messages](https://blog.appsignal.com/2021/09/22/improve-your-life-with-long-error-messages.html)
  * Plugin for Ruby to collect error report data from users

one reason I love debugging is that bugs often break through abstraction layers! they help you learn what's underneath

    Generic functionality
    Built-in solutions to a number of common programming problems
    Structure for organizing code
    A development philosophy or an architectural paradigm

    URL routing
    Templating / views
    Database interaction
    Form controls
    DOM manipulation
    Asynchronous requests
    Input validation
    User management
    Session management

Organisation
  MVC
  Model–View–ViewModel 
        Prism
    MCCM Light
    Caliburn Micro

  Model-View-Presenter
        Atom
    Ionic
    React-Native

plugins




Frameworks for what?

AWS Lambda?
    SMTP in lambda
Crypto processing

* [Building apps in minutes, not months](https://alexanderobenauer.com/labnotes/001/) - Conductor Framework Demo
* Django 4 [Fixed #33012 -- Added Redis cache backend. #14437](https://github.com/django/django/pull/14437)

Define vocab + terms - draw the scope

Software framework as a theory
Framework or ecosystem?
AWS is not a framework - serverless? blurly? An operating system is not a framework


Static, dynamic, typed, compiled
Vocab
Strength and weaknesss of langauges

Types of framework
Laguage libs
SDK - libs - compose (pyramid)
Framework Plugins - extendability


Research other courses



Containers for trialling technologies
Kubenettes?

Docker would be difficult to run at a user level on campus

Ian's link
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio-code



Languages
---------

* Assembler
  * Not a language, it is the machine
* BASIC
  * goto
* Fortran
* C
* C++
* Perl
  * Write only language
* PHP
* Python
  * async
* Javascript
  * ES2018
  * async
  * event driven callback chaos
  * Tangentially: web assembly?
* Golang
  * Very clean base library
  * _is in array_ complaint. It's a systems level language.
* Ocaml
* Prolog
* Erlang
  * Live updates
  * [Why Erlang?](https://www.fredrikholmqvist.com/posts/why-erlang/)
* Elixir
* Haskell
* PureScript
* Elm
* Typescript
* Java
  * JVM
* Ruby
* C#
  * .NET Core - bindings
* Visual Basic
* Scala
  * JVM
  * Kitchen sink
* ReasonML
* Kotlin

Event loop
Immutability
Dynamic data structures
Channels
Static/Compiled


You can use all these tools poorly or well.
When you do something for the second time (in another language), it's not the language that is batter, it is your understanding of the problem that is better.

Java programers are typically weaker programmers - because that is what they have been taught. The _good_ programmers have self learnt a language. That's why esoteric languages attract better programmers.

Mainstream languages (support existing business tools)
Find programmers that have the esoteric skill (less of them)
Companies training their emploees from scratch.
Norte Networks had their own language/tools for telephone switches.

Fads

CoPilot - scandle of open source

Andorid App lifecycle

Operator overloading
side-effects
C++ get operation modifys the dictionary


Server Side
-----------

### DIY HTTP Server

Java + Python

### DIY Message Board

Python + PHP

### Dynamic Server Frameworks

Static site generation

DB, Templates, Routing

CGI-BIN - write a script in any labnagueg as long as it printed html response
PHP lowered barrier to entry to server - get people started

Wordpress - Framework? Lots of plugs
No other frameworks at the time

CodIgnitor PHP - Laravell (new) PHP
Node.js
Rails (Ruby)
Falcon

Shimmi - own framework - 
v1 hardcoded for one use - image board - could not do anything else with it
v2 others interested but wanted differnt features - started plugings - made a minimum engine. Everything was a plugin that spoke to each other. Event system page event kicks it off - login plugin 

#### Django

#### Pyramid

### Static site generation

https://wiki.python.org/moin/StaticSiteGenerator

#### Jekyll 

#### Nikola

#### Static SQLLite

https://phiresky.netlify.app/blog/2021/hosting-sqlite-databases-on-github-pages/
http://static.wiki/
https://github.com/segfall/static-wiki


Client Side
-----------

### DIY JS/HTML5/CSS

### Frontend UI Frameworks

Historical JQuery

#### React

Reuseable components 
  calendar (like any other html tag)

#### Angular

Elm
Vue.js
   wikipedia redo frontend with vue

HyperApp



### Style

#### Bootstrap

#### Tailwind


Testing
-------

### DIY Testing

### Selenium

### Cypress


Mobile
------

Native Android

HTML5 iOS and Andorid generators


Assessment
----------

Create a prototype of one of the following web services
buggy and held together with sticky-tape
Do not need to implement any user security

I strongly advise you to use different frameworks, languages and projects.

* SocialMedia (Twitter/Facebook)
* eCommerce (Amazon) - list products, add to basket
* Video Streaming (Netflix, iPlayer, Youtube) - browse thumbnails/search, player video
* Blog with multiple authors (Medium) - list articles, rss, images in content
* Chat/Messenger (WhatsApp) - multiple users
* Mail?
* Messageboard?
* Collection tracker - valuation
* Other - welcome to discuss

Justify your choice of frameworks - server client
github project
Runnable in containers - kubenetees?
Must have automated tests to prove it's functionality - see test results/progress - instuctions for viewing tests
pofetionaly deplyable - externally hosted
useable on both desktop and mobile device

30% fragments
40% something works
50% frameworks used
60% tests range of framework features used
70% deployable substantial framework features used
80% works on range of devices
90% can function with 50+ users, externally visible
Lambda


https://expressjs.com/

Python
* [Sanic Framework](https://sanic.readthedocs.io/en/stable/)
    * https://github.com/MagicStack/uvloop

 uptime sclaine request 
 session - user state

 Graph QL
 https://graphql.org/

 Separation of concerns

 React "context" replacement for redux
 https://reactjs.org/docs/context.html

 Preact vs react
 https://preactjs.com/guide/v8/differences-to-react/
 Some limiatations


 https://mithril.js.org/
 Small - drop in
 Not intended to be enterprise
Principles of react

vue.js
https://vuejs.org/
More compatable with html js mindset - old people - 

ANgular
https://angularjs.org/



RX java?

Mobile?

Ionic?
React native


Hyperapp - Shish - <1k js


https://www.gitpod.io/
https://codetasty.com/

https://codesandbox.io/

https://betterprogramming.pub/my-favorite-cloud-ides-e6afaa94d96b

https://www.codeply.com/
All the frameworks!! live in browser 

https://glitch.com/
Node, React, Eleventy (static)


https://runkit.com/home
instant api - workbook


Some aforementioned links:

Client side:
https://preactjs.com/
https://mithril.js.org/  <- pretty fringe
https://vuejs.org/        <- pretty popular

Server side:
https://sanicframework.org/en/
https://fastapi.tiangolo.com/

I haven't used Fast API in production, but it looks well thought out and brings together some previously disparate tooling.
Sanic is essentially like Flask in that it's up to you to decide a lot of things.

Rollback in fighting games:
https://arstechnica.com/gaming/2019/10/explaining-how-fighting-games-use-delay-based-and-rollback-netcode/


gitpod docker support
https://github.com/gitpod-io/gitpod/issues/52#issuecomment-738629624
https://community.gitpod.io/t/running-docker-within-gitpod/538/8
https://github.com/shaal/ddev-gitpod






---

https://github.com/rcbxd
 Anthony Skorupskyy rcbxd
Node microservices developer, Vue/Angular hater, and Docker lover.


---



Other courses
=============

https://www.kent.ac.uk/courses/modules/module/CO894
https://digital.com/web-hosting/languages-and-frameworks/
https://developer.mozilla.org/en-US/docs/Learn/Server-side/First_steps/Web_frameworks
https://www.thoughtworks.com/radar/languages-and-frameworks
https://www.softermii.com/blog/top-programming-languages-and-frameworks-for-software-development-for-2020
https://medium.com/swlh/the-7-programming-languages-frameworks-to-learn-in-2020-6f9ac923ec5d

https://en.wikipedia.org/wiki/Software_framework

https://stackoverflow.com/questions/4099975/difference-between-a-module-library-and-a-framework
framework is inversion of control


Structure
=========

## Intended Learning Outcomes 
By the end of the module students should be able to:
1. Demonstrate an understanding of the concept of a Framework in general, a Framework used for Programming, and a Framework used for software 
Testing.
2. Critically evaluate the effectiveness of a particular framework for an application and platform.
3. Synthesise a small digital artefact using a well-formed programming framework.


* Week 1 (Online) 27/09/2021: Introduction
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
* Week 2 (Online) 2	04/10/2021: Languages
  1. Historical
  2. Static/Dynamic/Functional / Visual
    1. meta (can write/alter itself), garbage collection, interpreted, embeddable, hybryd (partially compiled), concurrentcy, macro (text subsitution), multiparadime, reflection, repl, c-bindings, large number abstraction, Error handling
    2. https://en.wikipedia.org/wiki/List_of_programming_languages_by_type
    3. see mapOfComputing for evluation critera link
  3. Event loop, deployment, channels/concurrency
  4. Decorators, pattern matching
  5. Employment, fads
  6. Use containers to run language code
  7. Homework: Investigate a language to present next time
* Week 3 (Campus) 11/10/2021: Server Frameworks
  7.  History
    1. cgi-bin
    2. templates server side
    3. request/response (no realtime)
  8.  Modern
    4. scale, realtime
  9.  Django/Pyramid/Sanic
  10. Node.js
  11. Homework: Investigate a server framework to present next time
* Week 4 (Campus) 18/10/2021: Client Frameworks
  * note: CORS headers
  12. web
    1.  Structure
    2.  Layout
  13. History
    3. jQuery
  14. HyperApp
  15. React
    4.  Context (live reload with state)
  16. Homework: Investigate a client framework to present next time
* Week 5 ACW
  * !!!
* Week 6 (Online) 01/11/2021: Web Layout
  * Assignment 1 due
  1.  Bootstrap
  2.  Tailwind
  3.  Homework: Assignment justify the frameworks you will use
* Week 7 (Online) 08/11/2021: Testing
  * Tests in CI
    * Github actions
    * Pre commit hooks?
  20. Unit
    1. xunit reports
  21. Server
    2. pytest
      1. Fixtures
      2. Plugins
    3. Karma/Jasmine
  22. Client/Browser (End-to-End)
    4.  selenium
    5.  cypress
  * Homework: Investigate a client framework to present next time
* Week 8 (Campus) 15/11/2021: Frameworks in other domains
  1.  serverless
  2.  GraphQL
  3.  Crypto frameworks
  4.  mobile
    1. Android app lifecycle
  5.  game
* Week 9 (Campus) 22/11/2021
  * Assignment workshop
* Week 10 (Online) 29/11/2021
  * Engineering war stories
* Week 11 (Online) 06/12/2021
* Week 12 (Campus) 13/12/2021
  * Module review


Assignments
===========

* Set 27/09/2021
* Assignment 1 01/11/2021
* Assignment 2 10/01/2022

Assignment 1 - Technical Report
------------

### Overview
Create a 1600 word technical report. This will be 40% of this module.

* A repository has been setup with an existing prototype implementation with working test suites.
* [github.com/calaldees/frameworks_and_languages_module](https://github.com/calaldees/frameworks_and_languages_module)
* Clone this repository and inspect it's functionally.
* In assignment 1 (this assignment) you will be asked to justify a choice of tooling
* In assignment 2 (next assignment) you will be using the tools you have chosen in assignment 1 to implement a new server and client


### Scenario
* You have been employed by FreeCycle-Inc as a Lead Engineer
* Your role is to technically advise and implement FreeCycle's digital products on web and mobile platforms
* Freecycle-Inc have an existing working prototype for their FreeCycle platform with tests. (see assessment 2 - example)
* The business requires you to implement a deployable/working version of the system within 3 months (see assessment 2 - deadline)

### Task
Produce a summary technical report to the business directors (1600 words total)
The report should contain:
* A description of why the existing prototype implementation is not fit for business use (300 words)
* A recommendation about the proposed technical direction:
  * Server Implementation (600 words)
    * Language justification
    * Framework justification
  * Client Implementation (600 words)
    * Language justification
    * Framework justification
* Consider a 2 year technical roadmap for this implementation (timeframes) (100 words)
* Provide a set of references for your justification (references do not count towards word count)

### Guidance
* Level of Expectation:
  * This task is intended to mimics a genuine task that might be required of you as a software engineer. This is a scenario for a learning exercise and lacks some of nuance of a real problem.
  * Realistically; You are not a lead developer. You are not expected to write this to a true industry standard. You are trying to demonstrate to an external examiner your knowledge and understanding.
* You are being assessed on your justification/critique of the technical implementation and technology. You are not marked on critique of the user functionality that has been proposed.
* It is perfectly acceptable to consider interim solutions/technology
  * example:
    * > We will use XYZ for the next 3 months as this will allow us to bring the product to market quickly. We will automatically have an admin panel for data and will easily be able to hire/contact this skill-set cheaply at short notice.
    * > We will then focus on a scaleable THINGY solution to replace the XYZ implementation for version 2 of the API in 9 months time.
* Technical reports heavily used bullet points. You do not need to write in full english paragraphs all the time.
  * Consider 'Lean documentation'
* Your justifications need to be supported with references. Show links to blog articles and case studies that support your technical assessment/recommendations. It is an institutional policy to use Harvard style referencing.


#### Marking Criteria
TODO?
* Quality of justification
  * Wide range of technical and business factors are considered (skills marketplace, lead time, scale, maintainability, deployment)
* Referencing/Supporting Evidence
* Quality of written communication


Assignment 2 - Digital Artifact
------------

Freecycle-Inc have a working prototype implementation of their proposed service.

https://github.com/calaldees/frameworks_and_languages_module

The repository provides:
* An OpenAPI3 Specification for the server service
* A reference server implementation that runs in a container (you will replace this implementation)
* An automated test container that tests the server implementation's conformance to the OpenAPI3 spec. These test run as GitHub actions as part of CI
* A reference client implementation (that uses the OpenAPI3 service server container)
* A set of browser tests (cypress), to document the expected client/user flows

### Task
* You are to replace the example server and client implementations with new implementations that pass the server and client automated test suites
* Your solutions must run in containers on CI
* Your solutions must use the frameworks you researched and justified in assignment 1

### Mark Breakdown

* 35% Server side implementation passing automated REST tests
* 35% Client side implementation passing automated browser tests
* 16% Visual usability (use of visual framework)
* 14% Comments/Markdown-Documentation/Readability/Readable-Git-Log
  * Documentation for a developer to run and debug each container
  * 7% for server
  * 7% for client


### Guidance

* It is not required for your server service to have a persistent data model
  * You can use a data persistence model if desired. There are no extra marks allocated to this.
* There is no requirement for any user authentication
* There is no requirement for scale
  * The system will be operating with less than 100 items
* You do not need a complete working server and client to pass this module. You should be able to pass this module with a good write-up (assignment 1) and one good working implementation (server or client).


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
