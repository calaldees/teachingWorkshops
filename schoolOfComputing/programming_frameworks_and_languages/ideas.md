Frameworks and Languages
========================

50 hours instruction
150 hours independent

Frameworks for what?

AWS Lambda?
    SMTP in lambda
Crypto processing

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

Initial audit

1. What is this? (not including subsets)
  * ```json
      {"code": 200, "message": "something happened", "payload": ["a", "b", "c"]}
      ```
  1. python
  2. javascript
  3. json
  4. yml
  5. toml
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


