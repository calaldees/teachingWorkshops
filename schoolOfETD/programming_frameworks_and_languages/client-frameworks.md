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


Demo Client Example
-------------------

Simplified requirements

And cypress tests



Types of Web Applications
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


Document Object Model (DOM)
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


Client/Browser communication with ServerAPI
-------------------------------------------

Interacting with our API from client browser javascript

```javascript
// Open a blank browser tab and bring up devtools (F12)
// Copy and paste the code below
//   These are javascript equivalent of `curl` statesmen's from previous session
// Start server_example api
// TASK: using the devtools console
//   - add 3 items
//   - get the item list (explore in devtools)
//   - delete the middle item

const urlAPI = 'http://localhost:8000'
const testItem = {
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

### Helpers for Assignment 2: Client

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

HyperApp Tutorial
-----------------

* [Hyperapp](https://github.com/jorgebucaran/hyperapp)
    * Tiny 1k framework
* Try _Todo example_ in CodePen
* [Tutorial](https://github.com/jorgebucaran/hyperapp/blob/main/docs/tutorial.md)
    * "Hello World" as [single HTML file](https://github.com/calaldees/frameworks_and_languages_module/tree/main/examples/client/hyperapp)
        * Can be a local html file or can be served from GitPod (see `Makefile`)

### Concepts
* html elements are generated with the `h()` function
* State, View and Actions are separate
* Altering the state requires an Action function


Vue.js
------

* [v3.vuejs.org/](https://v3.vuejs.org/)
    * See _Why Vue.JS_ video (3min)
    * 20k
* v2 [vuejs.org](https://vuejs.org/)
    * Video on main page - code summary example (5min)
    * Note: this is Vue2
* [Vue 3: Tutorial](https://v3.vuejs.org/guide/introduction.html)
    * "Hello World" as [single HTML file](https://github.com/calaldees/frameworks_and_languages_module/tree/main/examples/client/vue_test)
        * Can be a local html file or can be served from GitPod (see `Makefile`)

### Further Reading
* [VueMastery - Intro to Vue 3](https://www.vuemastery.com/courses/intro-to-vue-3/intro-to-vue3/) 
    * 20min video (1 hour to do?) video course for complete shopping basket with repo example


React
-----

1mb

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
* State separate from components
* Lifting state up
* Immutability
* Function components (shorthand)

### Further Reading
* [5 Steps to THINK in React](https://www.codestackr.com/blog/5-steps-to-think-in-react/)
