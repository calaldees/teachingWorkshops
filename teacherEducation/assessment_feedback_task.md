Feedback Task (1 hour)
-------------

* We've heard about
    * Formative assessment helping the student move on and grow
    * FeedForward (rather than feedback)

* With the extracts of students work provided 
    * (I know this is a slighting different domain to your classrooms, however; students still need to justify their choices and articulate their ideas - e.g. Computers and society, ethics, eSafty, security, impact of AI)
* THIS IS RIDICULOUSLY HARD! Prepare to be overwhelmed by the complexity of the task I'm about to set.
1. (20min) In teams of two or three - Attempt to construct "Marking criteria" for the piece - this will be used by you (teacher) and students to peer assess work
    * Creating clear criteria is hard
2. (10min) Give your "Marking Criteria" to another group - they will mark/grade a piece based on your criteria
    * Using another persons criteria is hard
3. (20min) In pairs - What written feedback would you give to one of these candidates? (you can do more than one, but one is going to be hard enough)
    * Remember 'FeedForward'
    * Creating meaningful, actionable feedback is hard

---


## Candidate 1

Critique of prototype

I have been employed as a Lead Developer for FreeCycle-Inc, I have been tasked with technically advising and implementing FreeCycle’s digital products on web and mobile platforms. FreeCycle-Inc have created a prototype for their platform, this prototype includes tests. However, the existing prototype implementation is not fit for business use due to the following:


Proof of concept.
Poor Readability.
Low Performance.
No Maintainability.
No Scalability.
Adherence to standards.
Lack of Security.
No Caching support.

The prototype server is not built to the industry standard and has used bad development practices; it is evident from the lack of comments within the code that there is no readability, if FreeCycle-Inc wanted to maintain or update this platform a new developer would have to understand the prototype, this is challenging due to the lack of documentation and community resources. The prototype has incomplete HTTP response codes for the server and client, this will make it challenging for a developer to understand exactly where issues are coming from.

If the prototype is implemented, you will find that it will be unable to cope with the number of requests it receives as users access the service, this will directly affect business as the customer experience will be poor. Caching is an optimisation method that stores all or part of a web response, so it doesn’t need to be recalculated on following requests, resulting in faster load times and a smoother experience. The example server is venerable to malicious attacks as there are no security features built in; alternative frameworks such as Express.js provide built in security and many other features; such as caching, that FreeCycle-Inc would benefit from. Express.js also provides scalability, something that the existing prototype has no ability to do.

## Candidate 2

The existing solution provided is not fit to be used in a practical business environment. There are several shortcomings within the existing solution, the primary being it doesn’t use any existing framework. The current code 1000-line code, which doesn’t have any structure and is extremely difficult to read. Further, the current code starts the web development process from scratch which doesn’t make any sense as frameworks provide such functionality in small lines of code adding to easiness.

Further, the existing solution is not suitable for developers because the current prototype doesn’t even fully support HTTP spec. It doesn’t follow any pattern. It is a bunch of code in a bunch of files. It is a webserver created from complete scratch.

Metrics/ Statistics: The current server is not scalable. It is a home implemented piece of trash. It is not suitable for production deployment. This is a hack. It can’t serve an API. It is untested. It is not viable to use the current piece of code in a business setting. Therefore, there is a need to identify an alternative, which is based on a particular framework, is scalable, and can fulfill the overall requirements of the business.

Non-usage of an existing framework leads to:

Writing the code and logic from scratch leads to wasting time as the existing framework provide resources that already have pre-existing options and features which can further be used for customization

Using framework provides simple and straightforward solutions for web-development which are intuitive and responsible allowing faster and easier web development

Using frameworks makes it easier to add features that are part of all normal websites such as rendering websites, connecting databases, user authentication, etc. (Bhardwaj, 2021)

Web-frameworks provide code structuring, code formatting, allowing other developers to read code. This makes the coding part more efficient

Further, web frameworks also allow many added features, which allow focusing on development rather than on configuration (Intelegain, 2020)



## Candidate 3

The given prototype framework is simple and easy to run using the Makefile provided. While simplicity can give multiple advantages, in this case it instead comes with a range of limitations.

There is little room in the prototype server to expand beyond the functions provided, which include basic forms of POST, GET, and DELETE, and the client UI was created for one specific situation with no option to influence the appearance.

Reading the file labelled ‘http_server.py,’ which looks to be the basis for the whole framework, it can be noted that there are many important pieces missing. The response code list only provides twelve of the more common codes, leaving out the rest completely and not giving much context for why the server has responded with an error. Many comments among the code use language that implies the framework was incomplete upon deployment, such as a large section being introduced by the comments, “This probably won’t work” and “This needs more testing.”

Looking at the ‘index.html’ file for the client, most sections have a link above them leading to Stack Overflow, CodePen, and other websites that give examples of code. This suggests that the UI was pieced together using samples of code and was not linked together very efficiently. Knowing this, the client side of the prototype is unstable and would not be able to handle much more than the examples that are given.

There is no form of security or backup stability provided with this prototype, nor is there any documentation given to help with potential issues. This will become a major problem if the business plans to expand in the future – this prototype cannot handle large loads, which is even written explicitly in the comments of the server code.

The server and client both come with a few tests that can be run. While it is difficult to understand what these tests are searching for, these were clearly intended to simply verify that the server and client are running at minimum standard. These do not include any extra testing for expandability.

Overall, due to its insecurity, instability, incomplete implementation, lack of expandability, and limited testing, this prototype is unsuitable for use by the business, especially if there are plans to grow in the future.



## Candidate 4

The quality of created code representing a web framework that should be implemented for our
working system shows that it is dreadful. The documentation of the code is weak and unfinished,
which could cause problems maintaining the code and further development for anyone that will be
working on it in the future.

None of the prior testing has been done, which would ensure the quality of the framework and save
the company lots of time and money by finding bugs at any given time.
The code has been written quickly and without any consideration of readability. This framework will
not solve an existing problem as it follows, the so-called "anti-pattern", which will put the company in
more problems coming back to the existing code and fixing it in the future. (Anti-patterns You Should
Avoid in Your Code, 2021)

Also, the framework is not scalable. Load time and web update would be problematic and adding a
new product or a service takes too much time and becomes expensive. (Prokopenko, 2021)
Of course, the speed with which our online application loads is crucial. We only have a few seconds to
suit the customer's demands, no matter how practical the application is.

Security of the framework is missing many things such as secure user authentication, session
implementation, which is crucial if the business does not want to lose enormous amounts of money
because of service attacks, user data leaks, unauthorised access, and other possible threats without
suitable solutions security. (Mavituna, 2021)
