Server Frameworks
-----------------

Objectives:
* Understand how to follow a tutorial to run "Hello World" for a range of server side frameworks
* Understand a range of server frameworks features
    1. To justify your choice of server framework (assignment 1)
    2. To critique the missing features of the `server_example` (assignment 1)

Tasks for next week:
1. Use a server framework
    * Find a server framework on your own
    * Run "Hello World" server
    * Return a JSON response (e.g. `GET /test --> {"foo": "bar"}`)
2. Research a server framework (for any language)
    * Come prepared to talk about it's features + show link to any example code (5min)

Next week:
* Client frameworks
    * Hello World


Assignment Marking Criteria
---------------------------


Further Reading
---------------

* [Representational state transfer](https://en.wikipedia.org/wiki/Representational_state_transfer)
    * > RESTful web APIs are typically loosely based on HTTP methods to access resources via URL-encoded parameters and the use of JSON or XML to transmit data.
* [Full Stack Python: Web Development - Overview](https://www.fullstackpython.com/web-development.html)
    * Lots of links to describe what the web is
* Finding the skills
    * When justifying your choice of language and framework
    * https://www.itjobswatch.co.uk/default.aspx?ql=&ll=&id=900&p=6&e=5&page=1&sortby=12&orderby=0



Middleware
Security/Authentication framework
Plugins

Flexability
Routing
Templates
Datamodel (ORM)
Streams
Websockets
Views


https://wiki.python.org/moin/StaticSiteGenerator



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


https://www.fullstackpython.com/sanic.html
https://github.com/itielshwartz/sanic-nginx-docker-example/blob/master/app/server.py



Django
------

* https://www.djangoproject.com/

https://docs.djangoproject.com/en/3.2/intro/tutorial01/
https://docs.djangoproject.com/en/3.2/intro/tutorial02/
https://docs.djangoproject.com/en/3.2/intro/tutorial03/


### Further Django Reading
* https://tutorial.djangogirls.org/en/
    * Wonderful tutorial from the basics up
* https://steelkiwi.com/blog/why-django-best-web-framework-your-project/





python manage.py createsuperuser

Turn off autosave in vscode - why does this feature exist!?

https://www.netguru.com/blog/django-pros-and-cons
https://code.tutsplus.com/tutorials/10-django-trouble-spots-for-beginners--net-12012
https://emacsway.github.io/en/django-framework/


Django REST Framework
---------------------


https://www.django-rest-framework.org/



Plugins

Middleware - like a decorator
Sessions - 
CSRF

Falcon Framework
----------------

http://falconframework.org/

* https://www.fullstackpython.com/falcon.html
    * > Falcon is a WSGI-compliant web framework designed to build RESTful APIs without requiring external code library dependencies.

* https://impythonist.wordpress.com/2015/09/12/build-massively-scalable-restful-api-with-falcon-and-pypy/
    * > Namaste everyone. If you build a RESTFul API for some purpose, what technology stack you use in python and why?. I may receive the following answers from you.
      > 1)  I use Flask with Flask-RESTFul
      > 2)  I use (Django + Tastypie) or (Django + REST Framework)
      > Both options are not suitable for me. Because there is a very good light-weight API framework available in python called Falcon. I always keep my project and REST API loosely coupled. It means my REST API knows little about the Django or Flask project that is being implemented. Creating cloud API’s with low-level web framework than a bulky wrapped one always speeds up my API.





http://falconframework.org/



* Thoughts for assignment
    * spin-uptime
    * developer familiarity
    * compatibility
    * complexity of design patterns
    * learn-ing curve

* deploy-ability

What requirements might you have in the future?
Hiring developers
Admin staff to manage items? (non developers?)
Speed/scale
Beyond one server? (one database - loads of app servers - load balanced)
Data persistence
Websockets (live updates/chat?)
Static storage (images/uploads)


Pyramid
-------

https://trypyramid.com/
https://docs.pylonsproject.org/projects/pyramid/en/2.0-branch/quick_tutorial/index.html
https://docs.pylonsproject.org/projects/pyramid/en/2.0-branch/quick_tutorial/json.html
Tests 

* [Hello Traversal World](https://docs.pylonsproject.org/projects/pyramid/en/2.0-branch/narr/hellotraversal.html)

No built in templating langaueg (you select one)
No built in database ORM - you select one SQLAlchemy is great


Django REST Framework
---------------------
A framework, build on another framework

https://www.fullstackpython.com/django-rest-framework-drf.html

Built on top of Django for API's
https://www.django-rest-framework.org/tutorial/quickstart/

Web visible interface - multiple dataformat serialzers
Generates openAPI spec from working program



https://rapidapi.com/blog/best-nodejs-frameworks/
Performacen community ease of use, best for


JWebToken - multiple servers




dotnet csproj
-------------

* https://github.com/calaldees/dotnet_docker_test
    * My demo for building and running Microsofts demo TodoApi app in docker containers
1. Start a new- gitpod workspace from the repo above
    * `https://gitpod.io/#https://github.com/USERNAME/REPONAME`
2. build and run the example application
    * `http://localhost:5000/WeatherForecast`
3. Inspect the `TodoApi` folder
    * Try to identify the components of the web app
    * Look at the `Dockerfile`. Try to understand the steps it might be doing

* Discuss: What is Microsoft trying to achieve?
    * How might this relate to our criteria for selecting a framework?


Snaic
-----

* https://sanicframework.org/

1. Follow "Getting Started" and run the basic app
    * https://sanicframework.org/en/guide/getting-started.html#getting-started
2. Add a response to the path `/test` to return the json `{"foo": "bar"}`
    * https://sanicframework.org/en/guide/basics/response.html#methods
3. Build a docker container to run this
    * `Dockerfile`
        * ```Dockerfile
            FROM python:slim
            WORKDIR /app/
            RUN  ???  ## Install dependencies/frameworks/libraries here ?? what did you install in Getting Started?
            COPY . .
            ENTRYPOINT ["???", "--host", "0.0.0.0", "server.app"]
            ```
        * (host/bind `0.0.0.0` is important for containers)
    * `Makefile`
        * ```Makefile
            DOCKER_IMAGE:=sanic_test
            build:
                docker build --tag {DOCKER_IMAGE} .
            run:
                docker run --rm -it --publish 8000:8000 ${DOCKER_IMAGE}
            ```

* https://www.fullstackpython.com/sanic.html
    * > Sanic is a Python web framework built on uvloop and designed for fast HTTP responses via asynchronous request handling. 
    * > Sanic cannot be developed or deployed on Windows due to its necessary uvloop dependency.
    * > There was an excellent discussion on the /r/python subreddit about using one of the newer async frameworks such as Sanic or Japronto compared with a traditional web framework like Django. 
      > One of the major tradeoff of adopting a newer framework is simply that the code library ecosystem has not, and may never, grow up around that framework. 
      > You have to accept the risk that you will need to build a significant amount of the plumbing yourself rather than pip installing existing, well-tested libraries.
* Thoughts for Assignment writeup
    * Throughput
        * https://sanicframework.org/en/guide/basics/handlers.html#a-word-about-async

Express.js
----------

https://expressjs.com/


Generator
Routes (not really explained router)
Static

http://localhost:3000/stylesheets/style.css


Guide
https://expressjs.com/en/guide/routing.html

res.json()
https://expressjs.com/en/4x/api.html#res.json




* Frameworks built on Frameworks
    * [Frameworks built on Express](https://expressjs.com/en/resources/frameworks.html)


[Difference between WSGI and ASGI?](https://medium.com/analytics-vidhya/difference-between-wsgi-and-asgi-807158ed1d4c)


Package Management
------------------

Popularity, addons/plugins/extensions, community

* [npmjs.com](https://www.npmjs.com)
    * [npmjs.com/package/express](https://www.npmjs.com/package/express)
        * Look at download statistics
* [pypi.org](https://pypi.org/)
    * https://pypistats.org/
        * https://pypistats.org/packages/django
        * https://pypistats.org/packages/falcon
        * https://pypistats.org/packages/sanic
        * https://pypistats.org/packages/pyramid
    * https://pepy.tech/





Google

Example of use cases
* `websites built with XXX`
Problems
* `problems with ...`

> Benefits and drawbacks are explored and drawbacks are clearly compared against business impact/risk.