Test Frameworks
===============

Objectives:
* Understand the purpose of a unit test framework
* Understand the purpose of a browser test framework


PyTest (A unittest framework)
------

* [pytest.org](https://pytest.org/)
    * pytest: helps you write better programs
    * The pytest framework makes it easy to write small tests, yet scales to support complex functional testing for applications and libraries.

### TASK: run the basic PyTest example

```bash
# Create `pytest` folder
# Create `test_sample.py` file
pip install pytest  # (only once)
pytest
```

### TASK: Extend the base example

* Add the following functions
    * `add(a, b)`
    * `multiply(a, b)`
* Create tests for the functions
    * Think about possible values to test with 
        * (positive? negative? BIG numbers?)
        * add(2, "thing")
* Advanced (optional)
    * Test for exceptions
    * `div(a, b)` -> `div(100, 0)`
    * https://docs.pytest.org/en/6.2.x/assert.html#assertions-about-expected-exceptions


### Task: Testing `jsonplaceholder`

* [jsonplaceholder.typicode.com](https://jsonplaceholder.typicode.com/)
    * [guide](https://jsonplaceholder.typicode.com/guide/)
        * ```bash
            curl https://jsonplaceholder.typicode.com/posts/1
            # Important: resource will not be really updated on the server but it will be faked as if.
            curl -X POST -d '{"title": "foo", "body": "bar", "userId": "1"}' https://jsonplaceholder.typicode.com/posts
            curl -X DELETE https://jsonplaceholder.typicode.com/posts/1
            ```

```bash
pip install pytest requests
```

`test_jsonplaceholder.py` (pytest files must start with `test_`)
```python
"""
Complete the pytest tests below for https://jsonplaceholder.typicode.com/guide/
Test the endpoints by:
1.) making a request using the `requests library`
2.) Assert/Check/Verify some aspect of the data you get back is correct to the spec/examples

Hints:

    ITEM={"title": "foo", "body": "bar", "userId": "1"}
    response = requests.post(ENDPOINT + '/posts', json=ITEM)

    response = requests.get(???)

    data = response.json()
    assert data['id'] > 100
"""
import requests

ENDPOINT="https://jsonplaceholder.typicode.com/"

def test_get_post_1():
    pass  # remove me

def test_create_post():
    pass  # remove me

def test_delete_post_1():
    pass  # remove me
```

### Task: install plugin

* [pytest-html](https://pytest-html.readthedocs.io/)
    * `pip install pytest-html`
    * `pytest --html=report.html --self-contained-html`
* view generated report
    * `python3 -m http.server`
* Advanced (Optional)
    * Create a `pytest.ini` file
    * ```ini
        [pytest]
        addopts = --html=report.html --self-contained-html
        ```
    * Typing `pytest` will run automatically with those options

### Task: Debugger

* Change one of your tests so that it fails
* run pytest with the command below
* ```bash
    pytest --pdb
    ```
* Inspect the `response` object
    * `dir(???)` repl


### Task: Run individual tests for this project
```bash
# Run server on :8000
cd server_example
make run_local

# -- separate terminal

# Run tests
cd server_test
pytest test_api.py::test_items_has_posted_item
```

### Framework Features
* Fixtures
    * ```python
        @pytest.fixture
        def new_item(ENDPOINT):
            # create it before the test
            yield "???"
            # tidy up after test
        ```
* Plugins
    * https://docs.pytest.org/en/latest/reference/plugin_list.html
    * Task: look at this list ... why is this important?

### Caution: Cache files

* Cache files make me sad ... (I personally refer to them a 'file cancer')
* PyTest by default creates hidden cache files.
    * `__pycache__`, `.pytest_cache`
    * DO NOT COMMIT THESE TO YOUR REPO!
        * use `.gitignore`
    * Don't copy them when building containers (this can conflict with the container execution environment)
        * use `.dockerignore`

Other UnitTest Frameworks
-------------------------

* C#
    * [Get started with unit testing](https://docs.microsoft.com/en-us/visualstudio/test/getting-started-with-unit-testing) in Visual Studio
* Java
    * [JUnit](https://junit.org/)
        * [User Guide - example](https://junit.org/junit5/docs/current/user-guide/#writing-tests)
* Javascript
    * [JavaScript unit testing frameworks in 2020: A comparison](https://raygun.com/blog/javascript-unit-testing-frameworks/)
        * https://jasmine.github.io/
        * https://mochajs.org/
        * https://github.com/avajs/ava
            * Async tests
        * https://jestjs.io/


Cypress (A Browser/End-to-End test Framework)
-------

* Demo full local cypress environment
* Terminology: Headless
    * Does not need to run the renderer - much lighter memory footprint and less processor time
    * Caution: this it NOT the same as an actual browser with a user. There are edge cases it can miss


### Task: Create a Cypress test to search with Google

* Save as `cypress/integration/example.spec.js`
```javascript
describe('Google', () => {
    it('Search for university webpage and check university logo is present', () => {
        cy.visit("https://www.google.com");
        // * Perform a google search for canterbury christ church university (with a spelling mistake)
        // * Check that `canterbury.ac.uk` is somewhere in the returned list of searches
        // * Follow the google search link to the main university webpage and check the logo is visible

        // * Hint: "Accept Cookie" buttons will block your way. Your test should deal with these
    });
});
/*
* Run with
    * Local Headless: `npx cypress run --spec cypress/integration/google.spec.js`
    * Container Headless: `make cypress_cmd CYPRESS_CMD="run --spec cypress/integration/example.spec.js"`
* https://docs.cypress.io/api/commands/
    * `.visit("https://site")`
    * `.contains("text on webpage")`
    * `.click()`
    * `.type("the text you want to type{enter}")`
    * `.get('???')`
        * `.get('input[title="???"]')`
        * `.get('#id_of_element')`
        * `.get('img[alt="???"')`
    * `.should('be.visible')`
    * `.scrollIntoView()`
*/
```


Other Browser/End-to-End test Frameworks
----------------------------------------

### Selenium

https://www.selenium.dev/
* Very established
* What are the problems with the architecture

### puppeteer

https://developers.google.com/web/tools/puppeteer

Googles own headless browser test




Quiz
----

* https://b.socrative.com/login/student/
    * callaghan1818
* for teacher https://b.socrative.com/teacher/


Solutions
=========

<details>
<summary>Cypress Solution</summary>

    cy.visit("https://www.google.com");
    cy.contains("I agree").click();
    cy.get('input[title="Search"]').type("canterbury christ chuch{enter}");
    cy.contains("canterbury.ac.uk").click();
    cy.get('#onetrust-accept-btn-handler').should('be.visible').click();
    cy.get('img[alt="Canterbury Christ Church University Logo"]').should('be.visible');

</details>

<details>
<summary>backup of questions</summary>
1.

Why don't we do all our web application testing with Browser test frameworks

They are difficult to construct

They are slow

They require lots of system resources to run

They do not detail where the precise issue/line may be
2.

Assertions:

Are a language feature

Can only be used in tests

Allow us to succinctly check for truthy-ness with a concise syntax

Can give more detail to failing tests

Assertions can typically be used anywhere in code. They are sometimes used to detect problematic runtime conditions.

"More detail" is a trap and a vague term - they do not give us more detail in themselfs, however they may point us to error cases 'sooner rather than later' and this may help debugging
3.

Headless

Is a framework

browser tests do not need to produce any user interact-able visuals

browsers use less system resources than normal browsers

Requires less code

"Requires less code" than what? This is vague.

A headless browser does not need to waste time rendering the screen for a real user and can save on resourse
4.

Which is better

Unit Tests

Browser Tests

Unit and Browser tests are both good

Unit and Browser tests are optional

Try telling a business that "Unit and Browser tests are optional".

You need both for all projects. Don't start a project without them!
5.

CORS is

A server framework

A server technique

A client framework

A security feature of modern browsers

Implemented with HTTP headers

Implemented with HTTP status codes
6.

A test report

Is a legal requirement

is useful for measuring developer performance

Is useful for developers when generated by CI

Is useful when generated by developers for managers

Managers dont use test-reports - Developers use them to identify where problems in the code are

"Developer Performance" who would anyone measure this?

"Legal requirement"? Have we ever mentioned the law in these lectures?
7.

Testing

It is possible to just write browser tests as your main job

Every developer must be able to write tests

Testing is normally done by another department

Tests can be added later in a projects lifecycle

This is bit of a trick question - Tests CAN be added later in a project lifecycle. This is often hard and as the code was not written with testability in mind and may need refactoring.

It is possible be employed specifically as a browser test expert. These testers are highly valued by organisations!

Developers that can't write tests don't get very far in their profession
8.

What should always be in .gitignore AND .dockerignore files

Makefile

node_modules

__pycache__ (if a python project)

*.js

README.md

Dockerfile

Test report folder

node_modules should never be comitted to a repo under any circumstance. this is megabytes of binary files!

Cache files should be ignored (why would we ever store these? they are temporary guff)

Test reports should never be commited, these are transient and can be regenerated. They are normally 1000's of lines long and this will contaminate your repo

The other files are legitmate files Makefile, Dockerfile, README.md and *.js are all possibly legitimate files.

The question was ALWAYS be in .gitignore AND .dockerignore some of those files could be in one of them



</details>