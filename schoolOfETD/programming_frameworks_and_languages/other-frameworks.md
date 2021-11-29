Other Stuff
===========

We've covered REST apis's and Single-Page-Webapps .. the world is a LOT bigger.

Objectives
* Understand a range of other tangentially related technologies (and frameworks)
    * why this is important ..
        * Interviews ..?
        * Future self learning ..?
    * What problem are these technologies trying to solve

Overview
* 2 Hour Lecture + Writing Workshop Experiment (whiteboard.fi)
* 2 Hour Tutorial with project - formatively assessing progress


Serverless Architecture
-----------------------

* Not a framework - more of a methodology
* You don't run your own http server - the provider does
* lxc to lxd
    * aws lambda

* https://www.twilio.com/docs/glossary/what-is-serverless-architecture

Question: What problem is serverless trying to solve?


GraphQL
-------

* Not a framework - query language for api's
* https://www.howtographql.com/basics/1-graphql-is-the-better-rest/ page + (12min video)

Question: When would you use GraphQL over REST? Is there a point in ever using REST?
What problems is REST tring to solve?

NoSQL
-----

https://www.guru99.com/nosql-tutorial.html
https://www.freecodecamp.org/news/nosql-databases-5f6639ed9574/
eventual consistency

Question: What problems is NoSQL trying to solve?


IPFS + Blockchain hosting
----

* [HTTP is obsolete. It's time for the distributed, permanent web](https://ipfs.io/ipfs/QmNhFJjGcMPqpuYfxL62VVB9528NXqDNMFXiqN5bgFYiZ1/its-time-for-the-permanent-web.html)
    * [[http]] has problems - this beautifully describes why
    * HTTP servers need to be kept on all the time. When they go, all their data is inaccessible. The Web is centralised because of http/
    * Could you host pages on Mars?
* [Host your Website on the Blockchain, Permanently](https://medium.com/fullstacked/i-saved-60-per-year-forever-by-hosting-my-website-on-the-blockchain-6f7bf07d35d9) - How to host a simple website on Arweave’s perma-web
* [Decentralizing your Website](https://towardsdatascience.com/decentralizing-your-website-f5bca765f9ed) - IPFS + ENS

Question: What is the problem IPFS is trying to solve?


BlockChain Applications
-----------------------

### Hyperledger
* [introduction](https://hyperledger.github.io/composer/v0.19/introduction/introduction.html)
    * Hyperledger Composer is an extensive, open development toolset and framework to make developing blockchain applications easier.
    * [key-concepts]https://hyperledger.github.io/composer/v0.19/introduction/key-concepts.html


Omni? Frameworks
----------------

### Fusion
* [Stl.Fusion](https://github.com/servicetitan/Stl.Fusion)
    * [How Similar Is Fusion to SignalR?](https://medium.com/swlh/how-similar-is-stl-fusion-to-signalr-e751c14b70c3)
        * Modelling an application based on state changes that propagate to client
        * > the only end result of your actions is that the client-side state (of every client) becomes consistent with the server-side state!


Static Site Generation
----------------------

Other approach: Static Site Generation

* [What is a Static Site Generator? And 3 ways to find the best one](https://www.netlify.com/blog/2020/04/14/what-is-a-static-site-generator-and-3-ways-to-find-the-best-one/)
* Really scalable and performant (cacheable, use of existing simple performant systems, distributable)
* Frameworks
    * [hugo](https://gohugo.io/) Golang
    * [jekyll](https://jekyllrb.com/) Ruby
    * [hyde](https://hyde.github.io/) Python
    * [nikola](https://getnikola.com/) Python
    * [next.js](https://nextjs.org/) Typescript
        * hybrid static & server rendering

Question: When would you use static site generation?


Mobile Frameworks
-----------------

Applications in other domains or ecosystems

### Android Activity Lifecycle
Not really a framework, but your app sites within a bigger ecosystem
* https://developer.android.com/guide/components/activities/activity-lifecycle


Game Frameworks
---------------

* if you are writing the `main` method and calling it - its a library
* if you are writing code that is called by other code - that is using a framework
* engines are bigger suites of tools

* [what-is-the-difference-between-a-game-framework-and-a-game-engine](https://gamedev.stackexchange.com/questions/31772/what-is-the-difference-between-a-game-framework-and-a-game-engine)
* Example
    * [LittleJS](https://killedbyapixel.github.io/LittleJS/docs/) - The Tiny JavaScript Game Engine That Can
        * notice how you place your code with a known object structure
    * [PyGame](https://en.wikipedia.org/wiki/Pygame)
        * https://realpython.com/pygame-a-primer/#basic-pygame-program
        * A library not a framework - if you implement the game loop - its not a framework
