Web Services
============

Present languages (30min)


Objectives
----------

* Understand the fundamentals of HTTP as protocol
* Understand basic tooling to create HTTP requests
* Understand JSON data encoding of structured data
* Understand OpenAPI specifications and how these can be used to describe web services
* Understand the purpose of automated tests and CI (github actions)


Workshop 1: HTTP (1 hour)
----------------

Objectives
* Understand the fundamentals of HTTP as protocol
* Understand basic tooling to create HTTP requests

### Workshop

* ![Chrome Devtools HTTP Example](./images/chrome_devtools_http.gif)
    * Press `F12`
    * Navigate to `bbc.co.uk`
    * Inspect request/response
        * Headers and content
    * Look at
        * Status: 200 in green
        * Method: GET
        * File: ...
        * Type: html, jpeg, js, json
* [telnet](https://en.wikipedia.org/wiki/Telnet) demo (gotta be quick, timeout is a few seconds)
    ```
    telnet
    o barcampcanterbury.com 80
    ```
    ```
    GET / HTTP/1.1
    Host: barcampcanterbury.com
    ```
* [curl](https://en.wikipedia.org/wiki/CURL)
    * bash tool
    * stands for 'Client'URL
    * command-line tool for making web requests
    * supports https (SSL encryption + certificate checking)
    * `curl https://barcampcanterbury.com/`
        * By default cURL performs a GET request and displays BODY content only
        * `-I` headers only
        * `-vvv` debug
    * `curl barcampcanterbury.com`
        * Servers will normally all redirect to `https`
        * `-L` follow redirects
    * `>` and `<` are direction `*` is additional information about network layer
    * ```
        > GET / HTTP/2
        > Host: barcampcanterbury.com
        > user-agent: curl/7.68.0
        > accept: */*
        ...
        < HTTP/2 200
        < date: Sun, 10 Oct 2021 13:23:13 GMT
        < server: Apache
        < last-modified: Mon, 11 May 2020 18:17:45 GMT
        < etag: "4463-5a5635d0ee376"
        < accept-ranges: bytes
        < content-length: 17507
        < cache-control: max-age=600
        < expires: Sun, 10 Oct 2021 13:33:13 GMT
        < vary: Accept-Encoding,User-Agent
        < content-type: text/html
        <
        <!DOCTYPE html>
        <html lang="en">
        <head>
        ```
    * from BBC website, try to curl jpeg data
        * Chrome - right click - 
            * Copy - Copy URL
                * `curl PASTE_URL`
                    * Binary data (cant show in terminal)
                    * `--output -` garbage in text
                    * `-O` to output to file
                    * try to open image - then delete it
            * (Advanced) Copy - cURL (POSIX)
                * See the additional command-line headers to simulate the Chrome request

### HTTP Request/Response
* [HTTP Messages](https://developer.mozilla.org/en-US/docs/Web/HTTP/Messages)
    * Headers + Body (sometimes called Content or Payload)
    * [HTTP request methods](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods)
        * GET, POST, PUT, DELETE, OPTIONS
    * [HTTP response status codes](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status)
        * 200, 302, 4xx, 5xx
    * [Common MIME types](https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types/Common_types)
* Key points
    * Requests+Responses have Headers+Body
    * As well as GET, we can send requests to upload/edit/modify data the webserver controls with POST, PUT, DELETE requests
    * Servers can respond with a range of errors/messages (your fault 4xx, server fault 5xx)
    * HTTP can be used to return different types of data


Workshop 2: JSON data (30min)
---------------------

JavaScript Object Notation (JSON)

* Using the code snippets below. Perform these tasks
    * Pick a language python or javascript
    * Setup the data variable (in the snippets below)
    * What is (you can trial this in the console)
        * data['a']
        * data[0]['b']
        * data[2]['e'][1]
        * data[2]['f']['h']
    * Change the following in memory
        * data[1]['c'] = 100
        * data[2]['f']['z'] = "addition"
    * Serialize the data to a string
    * Load up in language2, copy and paste the string, decode the data in language2
    * Modify the data in language2
    * Serialize the data to a string in language2
    * decode the data the string in language1

python
```python
import json

data = [
    {'a': 1, 'b': 2},
    {'c': 3, 'd': 4},
    {'e': [5,6,7], 'f': {'g': 10, 'h': "something"}},
]
string_data = json.dumps(data)
print(string_data)
data2 = json.loads(string_data)
```

javascript
```javascript
const data = [
    {'a': 1, 'b': 2},
    {'c': 3, 'd': 4},
    {'e': [5,6,7], 'f': {'g': 10, 'h': "something"}},
];
const string_data = JSON.stringify(data);
console.log(string_data);
const data2 = JSON.parse(string_data);
```

### JSON in static languages
* Using JSON in static languages is MUCH harder. 
* They need to bound to Class's. (in some cases there are general object wrappers)
* Representing strings with out having to escape `\"` is a pain. 
* The `{'e': [...` line, because it is a different structure to the other elements, creates massive problems for static languages.
* In most cases JSON handling is not built into the base language and needs and external library.


### Other data formats
* XML (legacy 2005)
* Protobuff
* GraphQL
* YAML (superset)
* TOML

### JSON Schema
* [json-schema](https://json-schema.org/)


OpenAPI
-------

[redocly - FreeCycle](https://redocly.github.io/redoc/?url=https://raw.githubusercontent.com/calaldees/frameworks_and_languages_module/main/openapi.yml)


Understanding the Assignment lab
--------------------------------

* `POST` example (with JSON data)
    * ```bash
        curl -d '{"key1":"value1", "key2":"value2"}' -H "Content-Type: application/json" -X POST http://localhost:3000/data
        ```



Language Features (cont)
=================

Operator overloading + doctests
--------------------


Async/await
-----------


Assignment Dissection
=====================

