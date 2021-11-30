Client Frameworks
=================

Objectives
1. Understand the requirements for the client component of the assessment
2. Understand how we can manipulate dynamic webpages with the javascript DOM
3. Understand how we can perform HTTP requests in javascript
4. Understand the basic features of client side frameworks
    * vue.js
    * hyperapp
    * react


Server Frameworks (15min)
-----------------

* Tell me about Sever side frameworks


Demo Client Example (15min)
-------------------

Simplified requirements

And cypress tests



Types of Web Applications (10min)
-------------------------

(A simplified and not entirely accurate overview)

* Server Rendered 
    * (majority of sites before 2014)
    * Older model - invented when browsers were less capable and had less features
    * Loads/Requests entire new page every link/click/action
    * Server template rendering
* Single Page Webapp 
    * (majority of webapps after 2014)
    * Client Application supported with Server API
    * Loads js app once on first visit - uses server api on some click/action
    * Client/Browser template rendering (shadow-dom)
    * Can support realtime bi-direction communication with web-sockets
* Static Site Generation 
    * (grew significantly in popularity form 2014)
    * Generate entire (static) site (efficiently) on data change


Document Object Model (DOM) (15min)
---------------------------

```javascript
// Open a blank browser tab and bring up devtools (F12)
// Type the following a line at a time

text = document.createElement("p")
text.textContent = "Hello World"
document.body.appendChild(text)
text.textContent = "Hello World 2"
text.style = "color: red;"
// Notice how updating the `text` object updates the page

// Inspect the DOM in devtools
document.body.children
document.body.children[0]

// Set data attributes and query them
text.dataset['test'] = 3
text2 = document.querySelector(`[data-test='3']`)
text2.remove()
document.body.appendChild(text)  // you still have a variable `text` and can re-add it

// TASK:
// 1.) using the techniques above create the following html structure with javascript code
/*
<ul>
    <li data-id="a">Bread</li>
    <li data-id="b">Milk</li>
    <li data-id="c">Eggs</li>
</ul>
*/
// 2.) use querySelector to find id="b" and remove it
```
Further Reading
* MDN [Document.querySelector()](https://developer.mozilla.org/en-US/docs/Web/API/Document/querySelector)


Client Frameworks (5min)
-----------------

Why?

> every time we change our application’s state, we need to update the UI to match.

* Separate out:
    * State
    * Template/Visuals/Look
    * Logic/Actions
* Considering
    * Async/multithreading (things happen at different times and take indeterminate time)


Client/Browser communication with ServerAPI (15min)
-------------------------------------------

Interacting with our API from client browser javascript

```javascript
// Open a blank browser tab and bring up devtools (F12)
// Copy and paste the code below
//   These are javascript equivalent of `curl` statesmen's from previous session
// Start server_example api
// Set `urlAPI` to your server address. It MUST not end with a `/`
// TASK: using the devtools console
//   - add 3 items
//   - get the item list (explore in devtools)
//   - delete the middle item

urlAPI = 'http://localhost:8000'
testItem = {
    user_id: "bob",
    lat: 1,
    lon: 1,
    image: "http://placekitten.com/100/100",
    keywords: "a, b, c",
    description: "a test item that is great",
}

let items = []

function getItems() {
    fetch(`${urlAPI}/items`, {
        method: 'GET',
    })
        .then(response => response.json())
        .then(json => {
            console.log("getItems", json)
            items = json  // save the json we got back into the variable `items`
        })
    .catch(err => console.error(err))
}

function createItem(data) {
    fetch(`${urlAPI}/item`, {
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify(data),
    })
        .then(response => response.json())
        .then(json => console.log('createItems()', json))
    .catch(err => console.error(err));
}

function deleteItem(item_id) {
    fetch(`${urlAPI}/item/${item_id}`, {
        method: 'DELETE',
    })
        .then(json => console.log('deleteItem()', json))
    .catch(err => console.error(err));
}
```
(
my first demo of this on 01/11/2021 with the class failed because of a bug - 
https://github.com/calaldees/frameworks_and_languages_module/commit/44cd9d126ed8cc7f7445de5fc1c3ac500de411bf
This is why the prototype is NOT fit for production use
)


Helpers for Assignment 2: Client (notes)
--------------------------------

### Helper HTML
```html
<h2>Create</h2>
<form>
    <input name="user_id" placeholder="user_id">
    <input name="lat" placeholder="lat">
    <input name="lon" placeholder="lon">
    <input name="image" placeholder="image">
    <input name="keywords" placeholder="keywords">
    <textarea name="description" placeholder="description"></textarea>
    <button data-action="create_item">Create Item</button>
</form>
<!-- Hints
    1.) Prevent default onSubmit behaviour
    2.) Bind all inputs to data model
    3.) Bind POST action to button
-->

<h2>Items</h2>
<ul>
    <li><!-- Somehow templated for each item -->
        <img src="item.image">
        <span data-field="id">??? item.id ???</span>
        <span data-field="lat">??? item.lat ???</span>
        ...
        <button data-action="delete" someKindOfOnClickAction="deleteItem(item.id)">Delete</button>
    </li>
</ul>
```

### Helper QueryString
```javascript
    // http://HOST:PORT/ADDRESS/OF/PAGE.HTML?query_param1=a&query_param2=b&api=http://localhost:8000
    // Get api url (default to `CURRENT_HOST/api/v1`) (and remove trailing slash if present)
    const urlParams = new URLSearchParams(window.location.search);
    const urlAPI = (urlParams.get('api') || '/api/v1').replace(/\/$/, '');
```


HTML Boilerplate (5min)
----------------

Anatomy of basic html page (for upcoming tutorials)

```html
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link id="favicon" rel="shortcut icon" type="image/png" href="data:image/png;base64,....==" />
    <title>Boilerplate</title>
    <style>

    /* styles here */

    </style>
    <script src=""></script>
</head>
<body>
    <h1>HTML Boilerplate</h1>

    <!-- html here -->

<script type="module">

    // javascript here

</script>
</body>
</html>
```

HyperApp Tutorial (45min)
-----------------

* [Hyperapp](https://github.com/jorgebucaran/hyperapp)
    * Tiny 1k framework
* Try _Todo example_ in CodePen
* [Tutorial](https://github.com/jorgebucaran/hyperapp/blob/main/docs/tutorial.md)
    * "Hello World" as [single HTML file](https://github.com/calaldees/frameworks_and_languages_module/tree/main/examples/client/hyperapp)
        * Can be a local html file or can be served from GitPod (see `Makefile`)

### Concepts
* html elements are generated with the `h()` function
    * Templates/view built with functions
* State, View and Actions are separate
* Altering the state requires an Action function


Vue.js (45min)
------

* [v3.vuejs.org](https://v3.vuejs.org/)
    * See _Why Vue.JS_ video (3min)
    * 20k
* v2 [vuejs.org](https://vuejs.org/)
    * Video on main page - code summary example (5min)
    * Note: this is Vue2
* [Vue 3: Tutorial](https://v3.vuejs.org/guide/introduction.html)
    * "Hello World" as [single HTML file](https://github.com/calaldees/frameworks_and_languages_module/tree/main/examples/client/vue_test)
        * Can be a local html file or can be served from GitPod (see `Makefile`)

### Concepts
* State, View and Actions are separate
* Template/View (can be) made in html and mounted/attached to code (`v-if`, `v-for`)
    * Vue components (advanced concept) can be separate/modular

### Further Reading
* [VueMastery - Intro to Vue 3](https://www.vuemastery.com/courses/intro-to-vue-3/intro-to-vue3/) 
    * 20min video (1 hour to do?) video course for complete shopping basket with repo example


React (1 hour)
-----

Facebook
200kb

* [Tutorial: Intro to React](https://reactjs.org/tutorial/tutorial.html)
    * Build O's and X's
* Start GitPod template - `template-typescript-react`
    * https://gitpod.io/#https://github.com/gitpod-io/template-typescript-react
* Setup
    * `.env`
        * ```
            FAST_REFRESH=false
            ```
    * `src/index.tsx` -> `src/index.backup.tsx`
    * `src/index.tsx`
        * ```
            import './index2'
            ```
    * From [React Tutorial: Setup Option 2: Local Development Environment](https://reactjs.org/tutorial/tutorial.html#setup-option-2-local-development-environment)
        * `index2.js` copy from source (edit line with `index.css` -> `index2.css`)
        * `index2.css` copy from source
* Follow tutorial and stop at _Adding Time Travel_
    * The history is very cool

### Concepts
* Compiler transforms _inline html_ into javascript code to dynamically create elements
    * `jsx` files
* State separate from components
* Lifting state up
    * Components do not communicate with each other (except though shared functions/actions)
* Immutability
* Function components (shorthand)

### Further Reading
* [5 Steps to THINK in React](https://www.codestackr.com/blog/5-steps-to-think-in-react/)


Further Reading
----------------

* [Introduction to client-side frameworks](https://developer.mozilla.org/en-US/docs/Learn/Tools_and_testing/Client-side_JavaScript_frameworks/Introduction)
* [Sizes of JS frameworks, just minified + minified and gzipped, (React, Angular 2, Vue, Ember)](https://gist.github.com/Restuta/cda69e50a853aa64912d)
* MonoCubed [List of 10 Best Front end Frameworks](https://www.monocubed.com/best-front-end-frameworks/)
    * [Ember.js](https://emberjs.com/)
    * [Angular.io](https://angular.io/) Google
    * [ractive.js](https://www.ractivejs.org)
* Other Frameworks in other langauges
    * [fritz2](https://www.fritz2.dev/) Kotlin
    * [WebApps with PureScript & RactiveJS](https://blog.brakmic.com/webapps-with-purescript-and-ractivejs/)

TODO
====

* [solid.js](https://www.solidjs.com/)
    * > Solid follows the same philosophy as React with unidirectional data flow, read/write segregation, and immutable interfaces. It however has a completely different implementation that forgoes using a Virtual DOM.
    * Fragments, Portals, Context, Suspense, Error Boundaries, Lazy Components, Async & Concurrent Rendering, Implicit Delegation, SSR & Hydration, Directives