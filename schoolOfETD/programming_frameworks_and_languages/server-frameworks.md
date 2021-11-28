Server Frameworks
-----------------

### Objectives
* Understand how to follow a tutorial to run "Hello World" for a range of server side frameworks
* Understand a range of server frameworks features
    1. To justify your choice of server framework (assignment 1)
    2. To critique the missing features of the `server_example` (assignment 1)

### Tasks for next week
1. Use a server framework
    * Find a server framework on your own
    * Run "Hello World" server
    * Return a JSON response (e.g. `GET /test --> {"foo": "bar"}`)
2. Research a server framework (for any language)
    * Come prepared to talk about it's features + show link to any example code (3min)

### Next week
* Client frameworks
    * Hello World
    * [Cross-origin resource sharing](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing)
        * HTTP `OPTIONS` request with `Access-Control-Allow-Origin`
    * [Single-page application](https://en.wikipedia.org/wiki/Single-page_application)

Overview
--------

* Terminology + Tech (15min)
* Django (1 hour)
* Falcon (30 min)
* (Overview) Django REST Framework + Pyramid (30 min)
* dotnet csproj (15min)
* Sanic (30 min)
* express.js (30 min)
* Ruby on Rails, Gin, Laravel (30 min) - if we have time
* Assignment Assistance (30min)

History + Terms
---------------

* [Representational state transfer](https://en.wikipedia.org/wiki/Representational_state_transfer)
    * > RESTful web APIs are typically loosely based on HTTP methods to access resources via URL-encoded parameters and the use of JSON or XML to transmit data.
* [Common Gateway Interface (CGI)](https://en.wikipedia.org/wiki/Common_Gateway_Interface)
    * Just drop a script in an executable folder (new process on each request)
* [Web Server Gateway Interface (WSGI)](https://en.wikipedia.org/wiki/Web_Server_Gateway_Interface)
    * Connect web server (Apache, Nginx) to application logic (Python)
* [Asynchronous Server Gateway Interface (ASGI)](https://en.wikipedia.org/wiki/Asynchronous_Server_Gateway_Interface)
    * [Difference between WSGI and ASGI?](https://medium.com/analytics-vidhya/difference-between-wsgi-and-asgi-807158ed1d4c)
* [Middleware](https://en.wikipedia.org/wiki/Middleware)
    * Pre-request + Post-response hooks
    * Like _decorators_ (the language feature we looked at in the languages session)
* [Single-page application](https://en.wikipedia.org/wiki/Single-page_application)
    * A single-page application (SPA) is a web application or website that interacts with the user by dynamically rewriting the current web page with new data from the web server, instead of the default method of a web browser loading entire new pages. The goal is faster transitions that make the website feel more like a native app. 


Features of Server Frameworks
-----------------------------

* Middleware
* Security/Authentication framework
* Routing
* Views
* Model - Datamodel (ORM)
* Templates
* Serializers (output data)
    * Streams
* Websockets
* Plugin or expansion framework


Django
------

What is a server side framework?
Let's do a tutorial to find out what the components are.
(this is just to explore the further features - remember our goal for the assignment is to create a RESTApi to a spec)

* https://www.djangoproject.com/
* Tutorial (first 3 parts)
    * https://docs.djangoproject.com/en/3.2/intro/tutorial01/
    * https://docs.djangoproject.com/en/3.2/intro/tutorial02/
    * https://docs.djangoproject.com/en/3.2/intro/tutorial03/
* Let's live code!
    * https://gitpod.io/#https://github.com/gitpod-io/template-python-django

### Further Django Reading
* [Django Girls Tutorial](https://tutorial.djangogirls.org/en/)
    * Wonderful tutorial from the basics up
* [Why Django is the Best Web Framework for Your Project](https://steelkiwi.com/blog/why-django-best-web-framework-your-project/)
    * Not suited for small-scale projects
    * No default support for WebSockets
    * Monolithic
    * Django’s behavior is sometimes hard to tune
* [Django Framework Review - Pros and Cons](https://www.netguru.com/blog/django-pros-and-cons)
* [10 Django Trouble Spots for Beginners](https://code.tutsplus.com/tutorials/10-django-trouble-spots-for-beginners--net-12012)
* [About my experience of using Django Framework](https://emacsway.github.io/en/django-framework/)


Falcon Framework
----------------

http://falconframework.org/

Let's build it in gitpod - livecode - containerize
* bind/host to `0.0.0.0` + explain

* https://www.fullstackpython.com/falcon.html
    * > Falcon is a WSGI-compliant web framework designed to build RESTful APIs without requiring external code library dependencies.

* https://impythonist.wordpress.com/2015/09/12/build-massively-scalable-restful-api-with-falcon-and-pypy/
    * > Namaste everyone. If you build a RESTFul API for some purpose, what technology stack you use in python and why?. I may receive the following answers from you.
      > 1)  I use Flask with Flask-RESTFul
      > 2)  I use (Django + Tastypie) or (Django + REST Framework)
      > Both options are not suitable for me. Because there is a very good light-weight API framework available in python called Falcon. I always keep my project and REST API loosely coupled. It means my REST API knows little about the Django or Flask project that is being implemented. Creating cloud API’s with low-level web framework than a bulky wrapped one always speeds up my API.



Django REST Framework
---------------------

https://www.django-rest-framework.org/

A framework, built on another framework

https://www.fullstackpython.com/django-rest-framework-drf.html
https://www.django-rest-framework.org/tutorial/quickstart/

* Web visible interface for exploration
* Pagination
* Multiple dateformat serializers
* Generates openAPI spec from working program

Pyramid
-------

https://trypyramid.com/
https://docs.pylonsproject.org/projects/pyramid/en/2.0-branch/quick_tutorial/index.html
https://docs.pylonsproject.org/projects/pyramid/en/2.0-branch/quick_tutorial/json.html
Tests

* Decoupled views routed with decorators
* No built in templating language (you select one)
* No built in database ORM - you select one - SQLAlchemy is great
* Supports an alternate routing method called _traversal_ (dynamic)
    * [Hello Traversal World](https://docs.pylonsproject.org/projects/pyramid/en/2.0-branch/narr/hellotraversal.html)


dotnet csproj
-------------

* https://github.com/calaldees/dotnet_docker_test
    * My demo for building and running Microsofts demo TodoApi app in docker containers
1. Start a new gitpod workspace from the repo above (remember the way to do this)
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


* Generator
* Routes (not really explained router)
* Static
    * http://localhost:3000/stylesheets/style.css

Guide
https://expressjs.com/en/guide/routing.html

`res.json()`
https://expressjs.com/en/4x/api.html#res.json


* Frameworks built on Frameworks
    * [Frameworks built on Express](https://expressjs.com/en/resources/frameworks.html)


Ruby on Rails
-------------

* https://guides.rubyonrails.org/getting_started.html
* gem install rails
* rails new blog
    * crashed on gem .. had to cd in and `bundle install`
    * got stuck again .. took ages, could not get it to start
* cd blog
    * has some auto-magical virtual environment setup
* bin/rails server
    * did not start

* [Build a RESTful JSON API With Rails 5 - Part One](https://www.digitalocean.com/community/tutorials/build-a-restful-json-api-with-rails-5-part-one)
* Declining in popularity
* Sledgehammer to crack a nut

Laravel
-------

* https://laravel.com/
    * Look at the echo system
* https://laravel.com/docs/8.x#getting-started-on-linux
* curl -s https://laravel.build/example-app | bash
* cd example-app 
* ./vendor/bin/sail up
    * downloads mysql, redis, mailhog, selenium + chrome, ubuntu
* http://localhost
    * This didnt work - after downloading 4gb+ of dependencies
* docker-compose down
* https://laravel.com/docs/8.x#laravel-the-api-backend
    * looks like it can be used as an API backend ... but this seems like a sledgehammer to crack a nut
    * https://laravel.com/docs/8.x/responses#strings-arrays


Gin
---

* [Gin Web Framework](https://gin-gonic.com/)
* [Tutorial: Developing a RESTful API with Go and Gin](https://golang.org/doc/tutorial/web-service-gin)
* [TutorialEdge.net - Creating a RESTful API With Golang](https://tutorialedge.net/golang/creating-restful-api-with-golang/)

I may create a docker example of this for next session



Assignment 1 - Assistance
-------------------------

### Critique of prototype
* Excellent analysis and critique that identifies topics such as: 
    * technology limitations,
    * anti-patterns,
    * readability,
    * modality,
    * maintainability,
    * scale-ability,
    * limitations of unit testing,
    * adherence to standards,
    * security,
    * and wider business issues

* Use the inverse of all the 'good things' that the other frameworks provide
    * no support for standards
    * incomplete implementation
    * performance
    * stability
    * community
    * security
    * expandability

### Server framework justification
* Mark scheme
    * Justified  the  features  of  a  framework  in  comparison  to  other  frameworks  to provide a balanced and well researched justification.  
    * Factors such as:
        * spin-uptime,
        * developer familiarity,
        * compatibility,
        * complexity of design patterns,
        * learn-ing curve, 
        * theoretical throughput,
        * deploy-ability,
        * hire-ability,
        * cost, 
        * developer experience,
        * developer tools,
        * security,
        * developer community,
        * documentation 
        * and other business factors are discussed.
    * Examples of existing use-cases are used to strengthen the argument.
    * Benefits and drawbacks are explored, drawbacks are clearly compared against business impact/risk
* Golden rule for technical reports
    * Describe the technical issue/statement
    * Then describe what that means for your organisation



* What requirements might you have in the future?
    * Hiring developers
    * Admin staff to manage items? (non developers?)
    * Speed/scale
    * Beyond one server? (one database - loads of app servers - load balanced)
    * Data persistence
    * Websockets (live updates/chat?)
    * Static storage (images/uploads)
    * [JSON Web Token (JWT)](https://en.wikipedia.org/wiki/JSON_Web_Token) - multiple servers


### Hints
* General Reading
    * [Representational state transfer](https://en.wikipedia.org/wiki/Representational_state_transfer)
        * > RESTful web APIs are typically loosely based on HTTP methods to access resources via URL-encoded parameters and the use of JSON or XML to transmit data.
    * [Full Stack Python: Web Development - Overview](https://www.fullstackpython.com/web-development.html)
        * Lots of links to describe what the web is
* REST framework comparisons
    * [What are the best Microframeworks (Backend) Tools?](https://stackshare.io/microframeworks)
    * [10 popular REST frameworks For your MicroService](https://dev.to/vishnuchilamakuru/10-popular-rest-frameworks-for-your-microservice-39ao)
    * [What are the best web frameworks to create a web REST API?](https://www.slant.co/topics/1397/~best-web-frameworks-to-create-a-web-rest-api#23)
* Example web searches
    * `websites built with XXX`
    * `problems with ...`
    * `my experiences with ...`
* Popularity, addons/plugins/extensions, community
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
* Hiring the skills
    * When justifying your choice of language and framework
    * https://www.itjobswatch.co.uk/default.aspx?ql=&ll=&id=900&p=6&e=5&page=1&sortby=12&orderby=0


Unsorted
========


https://rapidapi.com/blog/best-nodejs-frameworks/
Performacen community ease of use, best for

https://github.com/pimbrouwers/Falco F# functional

* https://github.com/servicetitan/Stl.Fusion C# Super server+client mega solution
    * Key concept - "eventual consistency" - creating invalidation methods is key