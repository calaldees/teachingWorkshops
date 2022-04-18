Containerisation
================

What is the difference between virtualisation (virtual machines) and containerisation (virtual environments)?


Hash
----

hash - what is it?



40 hexidecimal character
>>> pow(16,40)
1461501637330902918203684832716283019655932542976

len(str(pow(16,40)))
10^49

[How Many Atoms Are There In The World?](https://headsup.scoutlife.org/many-atoms-world/)
10^51



OverlayFS

https://earthly.dev/blog/lxc-vs-docker/

* > Docker used LXC, prior to version 1.0, to create isolation from the host system. Later, Docker developed its own replacement for LXC called libcaontainer. 
* > Docker containers are made to run a single process per container.

podman

Docker root user
docker info
create independently on own machines
Layer cache - ci
activity?


Singularity


https://hub.docker.com/_/mysql

Architectures
https://hub.docker.com/search?architecture=arm64&q=&source=verified&type=image
ARM
ARM64
x86
x86-64
PowerPC

https://hub.docker.com/_/nginx

Wont work with ARM
https://hub.docker.com/r/mwader/static-ffmpeg/tags



* [moby/buildkit: always display image hashes #1053](https://github.com/moby/buildkit/issues/1053)
    * > Yeah, setting DOCKER_BUILDKIT=1 disimproves debug experience a lot. Without DOCKER_BUILDKIT, it was possible to run a container with a layer right before the failed step, and with DOCKER_BUILDKIT it's not possible anymore since it just doesn't show image cached IDs.
        > This looks like a clear regression...



x86/ARM Magic
-------------



Use
---

shell == full evaluation - array is not shell

Entrypoint vs cmd

Exec + run



Input/Output of files
---------------------

Mount + cp


Multistage builds
-----------------

 install pillow
 tests
 scratch -> thttpd


docker run --rm -it python:alpine /bin/sh


```Dockerfile
FROM python:alpine as base

WORKDIR /app/

FROM base as download
    # This could install `gcc` or other large compiler tools
    RUN apk add --no-cache \
        curl \
    && true
    # Use the tools to create datafiles
    RUN curl -A "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:59.0) Gecko/20100101 Firefox/59.0" -O "https://shadedrelief.com/natural3/ne3_data/8192/elev_bump_8k.jpg"
    # These derived files can be copied independently of the tools that built them (curl is not installed in other targets)


FROM base as production
    COPY --from=download /app/ /app/
    CMD ["python3", "-m", "http.server"]
    # Future: Add HEALTHCHECK only for production

# Extension: extra targets
#   this installs some extra dev tools 
FROM base as shell
    COPY --from=download /app/ /app/
    RUN apk add --no-cache \
        bash \
    && true
    CMD ["/bin/bash"]


# docker build --file multistage_example.Dockerfile --target production --tag multistage_example .
# docker run --rm --publish 8000:8000 multistage_example
# visit http://localhost:8000/

# docker build --tag multistage_example --file multistage.Dockerfile --target shell .
    # `curl` is not installed
```

* [The smallest Docker image to serve static websites](https://lipanski.com/posts/smallest-docker-image-static-website)
    * `thttpd` 187kb - built with alpine but uses the `scratch` image with no OS installed



Healthcheck
-----------

```Dockerfile
FROM python:alpine as base

WORKDIR /app/

RUN apk add --no-cache \
    curl \
&& true

CMD ["python3", "-m", "http.server"]
HEALTHCHECK --interval=5s --timeout=3s CMD curl --fail http://localhost:8000/ || exit 1

# nc -z localhost 8000


# docker build --tag heathcheck_example --file heathcheck_example.Dockerfile .
# docker run --rm --publish 8000:8000 heathcheck_example

# docker run --rm -it --publish 8000:8000 heathcheck_example /bin/sh
# docker ps -a
# look at `health`


# docker exec -it fdc52dae38a2 /bin/sh

```

Multi Container Systems
-----------------------

docker-compose
 sql? redis? mongodb?
multiple containers mount log

`database.py`
```python
import mysql.connector

mydb = mysql.connector.connect(
    host="mysql",
    user="test",
    password="test",
    database="test",
)

print(mydb)

# Continue at
# https://www.w3schools.com/python/python_mysql_create_table.asp
# or
# https://realpython.com/python-mysql/
```

`python-mysql.Dockerfile`
```Dockerfile
FROM python:alpine

WORKDIR /app/

RUN apk add --nocache \
    mysql-client \
    mariadb-connector-c \
&& pip install --no-cache-dir \
    mysql-connector-python \
&& true

COPY database.py .
```

`docker-compose.yml`
```yaml
# https://docs.docker.com/compose/compose-file/

services:
    mysql:
        image: mysql
        environment:
            # https://hub.docker.com/_/mysql See Environment Variables
            MYSQL_ROOT_PASSWORD: root
            MYSQL_DATABASE: test
            MYSQL_USER: test
            MYSQL_PASSWORD: test
    python:
        build:
            context: ./
            dockerfile: python-mysql.Dockerfile
        links:
            - mysql
        command: /bin/sh
```

```bash
docker-compose build
docker-compose run --rm -i python
    mysql --host=mysql --user=test --database=test --password=test
    python database.py
```

```
# volumes:
#    mysql_data:
        # volumes:
        #    - mysql_data:/var/lib/mysql
```

Try a different language or database or both
* [hub.docker.com/_/mysql](https://hub.docker.com/_/mysql)
    * [python_mysql_getstarted](https://www.w3schools.com/python/python_mysql_getstarted.asp)
    * [nodejs_mysql](https://www.w3schools.com/nodejs/nodejs_mysql.asp)
* [hub.docker.com/_/mongo](https://hub.docker.com/_/mongo)
    * [python_mongodb_getstarted](https://www.w3schools.com/python/python_mongodb_getstarted.asp)
    * [nodejs_mongodb](https://www.w3schools.com/nodejs/nodejs_mongodb.asp)
    * [some ideas](https://github.com/calaldees/TeachProgramming/tree/master/teachprogramming/static/projects/data/mongo)


Command Vs Entrypoint (and overriding)
---------------------

`ENTRYPOINT` is another way to launch a container

`entrypoint_example.Dockerfile`
```Dockerfile
FROM alpine
ENTRYPOINT ["ls"]
CMD ["--help"]
```

```bash
docker build --tag entrypoint_example --file entrypoint_example.Dockerfile .
docker run --rm entrypoint_example
docker run --rm entrypoint_example .
docker run --rm entrypoint_example -la

# I want to shell into this container ...
docker run --rm -it entrypoint_example /bin/bash
# Why does this not work? What has happened?
```

```bash
# When an `ENTRYPOINT` is set, all arguments are APPENDED to the entrypoint
# The entrypoint must be overridden explicitly (and MUST be BEFORE the image name `entrypoint_example`)
docker run --rm -it --entrypoint /bin/sh entrypoint_example

# `ENTRYPOINT` can be inspected with
docker inspect entrypoint_example
```


Unsorted
========


```bash
docker run --rm -it alpine /bin/sh
    ls
    vi test.txt
    # a for append
    test
    # esc then :wq
```

```bash
docker run -it alpine /bin/sh
    vi test.txt

docker ps -a
    # find CONTAINER ID
docker cp 151a6554d794:/test.txt ./
```


```bash
docker run --rm -it --volume ${PWD}:/test_mnt/ alpine /bin/sh
    vi /test_mnt/test.txt
    exit

cat test.txt
```



```
FROM alpine
RUN echo "hello" > test.txt
```

DOCKER_BUILDKIT=0 docker build --tag test .

```
FROM alpine
RUN echo "hello" > test.txt
RUN exit 1
RUN echo "hello2" > test.txt
```
```
$ DOCKER_BUILDKIT=0 docker build --tag test .
Sending build context to Docker daemon  2.048kB
Step 1/4 : FROM alpine
 ---> 0ac33e5f5afa
Step 2/4 : RUN echo "hello" > test.txt
 ---> Using cache
 ---> bf3d23693958
Step 3/4 : RUN exit 1
 ---> Running in 9dcbf78c1870
The command '/bin/sh -c exit 1' returned a non-zero code: 1
```

docker run --rm -it bf3d23693958 /bin/sh

docker inspect test

 "Parent": "sha256:bf3d23

"RootFS": {
    "Type": "layers",
    "Layers": [
        "sha256:4fc242d58285699eca05db3cc7c7122a2b8e014d9481f323bd9277baacfa0628",
        "sha256:a044af2aefbc7f80dd3f1482b8374a79c61dbc643b26aa5788da19ff7635adbb",
        "sha256:e435616c917b74469cfd4b3715f300235fca3aa297c2d8c9816b2f11fd8774de"
    ]
},

        "Size": 5574977,
        "VirtualSize": 5574977,
                "Architecture": "amd64",

docker history --no-trunc test




### Docker Commandline Helpers

```bash
alias docker_clean='docker volume rm $(docker volume ls -qf dangling=true) ; docker rm $(docker ps -q -f status=exited) ; docker rmi $(docker images -q -f dangling=true)'
alias docker_nuke='docker_rm_all ; docker rmi --force $(docker images -q -a) ; docker volume rm $(docker volume ls -qf dangling=true) ; docker network rm $(docker network ls -q)'
alias docker_ps='docker ps -a --format "{{.ID}}\t{{.Names}}"'
alias docker_rm_all='docker_stop_all ; docker rm $(docker ps -a -q) --force'
alias docker_rm_exited='docker ps -a | grep Exit | cut -d " " -f 1 | xargs docker rm'
alias docker_stop_all='docker stop $(docker ps -a -q)'
```

Why Docker is problematic
----------------

* Docker only allows for composing images by inheriting from a single layer
* All containers run as `root` by default


Other Container Solutions
-------------------------

* [Podman](https://podman.io/)
    * Simply put: `alias docker=podman`
    * Secure by default
    * No Root level daemon
    * [Migrating from Docker to Podman](https://marcusnoble.co.uk/2021-09-01-migrating-from-docker-to-podman/)
* [Singularity](https://sylabs.io/guides/3.5/user-guide/introduction.html)
    * Easily make use of GPUs, high speed networks, parallel filesystems on a cluster or server by default.
    * A simple, effective security model
* [NixOS](https://nixos.org/)
    * > Nix is a tool that takes a unique approach to package management and system configuration. Learn how to make reproducible, declarative and reliable systems. 
    * [Will Nix Overtake Docker?](https://blog.replit.com/nix-vs-docker)
        * repl.it is moving from a single 30gb mega- container to a `nix` package pick and mix approach
        * > Nix takes a first-principles approach to reproducible builds and package management. Nix provides a whole build system that allows for building packages in an isolated way.


Further Reading
---------------

* [Layers between docker builds can't be shared](https://stackoverflow.com/a/60603650/3356840)
    * Sharing docker layers from pulled images is a manual override

Building on CI
* [Docker build cache sharing on multi-hosts with BuildKit and buildx](https://medium.com/titansoft-engineering/docker-build-cache-sharing-on-multi-hosts-with-buildkit-and-buildx-eb8f7005918e)
    * [docker/buildx](https://github.com/docker/buildx)
