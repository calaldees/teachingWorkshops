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
* Your solutions can use any programming language or framework as long as the tests pass

### Guidance

* It is not required for your server service to have a persistent data model
  * You can use a data persistence model if desired. There are no extra marks allocated to this
* There is no requirement for any user authentication
* There is no requirement for scale
  * The system will be operating with less than 100 items
* You will be allocated marks for partial solutions
* You are working towards being a professional software engineers. It is expected that you share and discuss your solutions with peers throughout this assignment


### Marks Breakdown

* 35% Server side implementation passing automated REST tests
* 35% Client side implementation passing automated browser tests
* 16% Visual usability (use of visual framework)
* 14% Comments/Markdown-Documentation/Readability/Readable-Git-Log
  * Documentation for a developer to run and debug each container
  * 7% for server
  * 7% for client



| Assignment | Section | Marks (Total 60) |
|---|--------------------------------|---:|
| 1 | Server tests                   | 21 |
| 1 | Server documentation           |  4 |
| 1 | Client tests                   | 21 |
| 1 | Client documentation           |  4 |
| 1 | Visual framework               | 10 |


| 2 | Critique of prototype          |  7 |
| 2 | Server framework justification | 15 |
| 2 | Client framework justification | 15 |
| 2 | Roadmap                        |  3 |
|   |                                | 40 |

Server Tests
------------


Port open
serves html on root
POST
 returns json
 complete 201
POST
 incomplete 405
GET item
 json
 fields
 404
GET items
 json
 fields
 filter username
DELETE
 200
 404
CORS
  OPTIONS
  items
NEAR
 bonus

16 marks

5 marks for
Use of framework
File/folder structure (sensible names)
Use of language features (list comprehensions, async etc)
Conciseness (verbose? unneed intermediaries? readable)

README sufficent to launch + test
Commits strutured
Comments in code describe
Reference snippets/tutorial urls inline


Client Tests
------------

200
has Freecycle
has Text input * 4
submit + see item (8 marks)
has delete
delete + remove (2marks)
displays real image

15 Marks (1 mark short)

