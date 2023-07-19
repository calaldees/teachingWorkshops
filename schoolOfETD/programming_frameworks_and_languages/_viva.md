Viva: XXX

Hi XXX,

Your submission for MCOMD3PFL Programming_Frameworks_and_Languages Assignment 2 has been selected for a viva.

* A viva is a meeting where you can demonstrate knowledge and understanding about your submission.
* Your meeting can be online or face-to-face.
* Please come prepared to live screen-share or bring a laptop to demo your project.
* You will be asked to run your solution and answer some questions about it's construction and use.
* Please have your development environment loaded/ready in advance of this meeting.
* A second academic will be present.
* The meeting should be no more than 30 minutes

This meeting request is a suggested time. If you are unable to make this time we can arrange an alternative.
(Most probably Monday 31st is the next available day?)

Let us know if you would prefer this meeting online or face to face.

See you soon.


Allan Callaghan (Module Lead)

Viva Questions
--------------

### Server

* Can you run your sever and show us that it works (not with client)
* Can you run the server tests
* How did you store your data
* How did you generate a new ItemID
* Tell me about the field 'date_from'. What is an ISO date?
* What is a 405, show me it's implementation, describe what this is doing
* Explain what a cors header is and show me how you tested this
* What was different about the response to `/`

  Show me where you have set a HTTP response code
  Show me where you have set a CORS header
  Can you make a change to your code that makes xxx test fail
  What fields did you add in the item POST
    what is an iso date
    `date_from` as an iso datetime string
  Where did you setup the route for `/items/`
    it was `test/html`
  Where did you set the content type for `/`
  When you were developing your solution, can you describe an error you found, how did you resolve this?

### Client
* Can you run the client tests
* Where would you look for failed test information?
  * Do they know where the output videos are?
* Show where you attached an action to a button. What was the action? what code was executed? Talk us through the information flow.
* How did you get the server host address from the query string `?api=`
* How do you render html with templated variables - show me the features of the framework that allowed you to do this
* How did you make your html elements discoverable to the automated tests?

### Client Layout
* Can you show my how you styled your buttons and inputs
* Can you resize your client display width
  * Can you talk about how you achieved this

Solutions
---------

* Server (python/falcon)
  * https://github.com/calaldees/TeachProgramming/blob/master/teachprogramming/static/projects/web/rest_api/falcon_api.py
* Client (vue.js)
  * https://github.com/calaldees/TeachProgramming/blob/master/teachprogramming/static/projects/web/frameworks/vue.html
* Exemplars
  * https://github.com/calaldees/RESTApiTask
    * https://github.com/calaldees/RESTApiTask/blob/main/app/server.js
    * https://github.com/calaldees/RESTApiTask/blob/main/app/client.html
