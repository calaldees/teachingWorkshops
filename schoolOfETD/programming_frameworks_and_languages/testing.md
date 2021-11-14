Automated Testing
=================

Objectives:
* Understand the purpose of a unit test framework
* Understand the purpose of a browser test framework
* Understand CORS headers
* Consider local environment tooling for development

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
    * Now just typing `pytest` will run automatically with those options


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


A Browser/End-to-End test Framework
------------------------

### End to End (Browser) Tests

* Terminology
    * Headless
        * Does not need to run the renderer - much lighter memory footprint and less processor time
        * Caution: this it NOT the same as an actual browser with a user. There are edge cases it can miss

#### Selenium

https://www.selenium.dev/

What are the problems with the architecture

#### puppeteer

https://developers.google.com/web/tools/puppeteer

Googles own headless browser test


CORS
----

* [Cross-Origin Resource Sharing (CORS)](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS)
    * HTTP Method: [OPTIONS](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods/OPTIONS)
        * `Access-Control-Allow-Origin`


Local Development on Windows
----------------------------

* [chocolatey.org](https://chocolatey.org/)
    * The Package Manager for Windows
    * WindowsKey + X -> Windows Powershell (Admin)
        * copy and paste the big shell line from - [Installing Chocolatey](https://chocolatey.org/install) -> "Now run the following command:"
    * ```powershell
        choco feature enable -n allowGlobalConfirmation
        choco install python3 node
        ```
    * ```cmd
        npm install cypress@8.7.0
            # `npm install` installs to `node_modules` in your current folder!
        set CYPRESS_BASE_URL=http://localhost:8001/?api=http://localhost:8000
            # set an environment variable for the duration of this terminal
        npx cypress open
            # or run headless
        npx cypress run --spec cypress/integration/freecycle/freecycle.spec.js
        ```
        * (I had issues with `9.0.0` on windows, some error about `plugins/index.js`?)
    * Docker on windows
        * [Install WSL](https://docs.microsoft.com/en-us/windows/wsl/install) (Windows Subsystem for Linux)
            * I think it's easier now - you used to have manually turn on HyperV
        * `choco install docker-desktop`
        * [windows-terminal-preview](https://www.microsoft.com/en-gb/p/windows-terminal-preview/9n8g5rfz9xk3#activetab=pivot:overviewtab)


Enabling Server tests as GitHub Actions
---------------------------------------



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
