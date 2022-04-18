Module Review
=============

Course: September 2021 to January 2022 (4 months)
Review: January 2022

## Reflection of student engagement 

in respect to module learning opportunity



## Reflection of the Student Voice Feedback

## Reflection of the Peer Review Feedback


## Action Plan 

* The tasks (Assignment 1 write-up 40% + Assignment 2 Digital artifact 60%) were of an appropriate difficulty for level 6.
    * Assessment marking ratios will remain the same next year
* Viva assessment process was a strong deterrent for plagiarism and important for assessing understanding


Identified Issues
-----------------

* Students did not have enough contextual knowledge to write a meaningful technical report (Assignment 1)
    * The order of assignments and submission dates will be swapped
        * Digital Artifact -> December
        * Technical Report -> January
* Students lacked the writing skills to articulate their ideas in writing
    * Reason: The marking criteria of assignment 1 were inaccessible to students. They did not have a mental model of what was expected.
    * Actions: 
        * Create a set of small structured writing templates/prompts
            * > What is the feature -> What problem is this trying to solve -> How does it solve the problem
                * prepare a few exemplar paragraphs that follow this structure
        * Template for technical report - style guide - language examples
            * Criteria to comment on file structure, throughput, plugins, developer experience (tools), language features
        * Prepare students to a point where they can perform effective peer reviews on each others writing
            * See clarify markscheme below
        * Writeup to be created in Markdown (and part of Digital Artifact repository)
            * Facilitate development of engineering documentation tools
            * As the writeup is in a code repo - we can utilise CI to monitor progress
            * This will allow peer comments and get students using GitHub more
* There was little evidence that students were engaging with self study
    * Theory: Students were used to being guided by teacher lead directed tasks
    * Actions:
        * A weekley timetable of tasks + expected outcomes will be published at the start of the module.
        * Assignments will be clearly set into segments - expect incremental weekley submission of tasks. 
        * Weekley tasks are peer reviewed. 
            * Teacher will moderate written peer reviews and commenting where peer assessment differs from teacher assessment.
            * Automated assessment of repo/project progress will be setup
            * Code review (with comments on GitHub) - Mark by peer pull request
        * Teacher will keep log of progress on with responsive-time-on-track logging (see note below)
        * Students strongly advised "Attend afternoon session (optional)"
            * If no attendance at afternoon session and non submission in following weeks peer review, advise student of failing module - with a module this big there is no "catchup later". Reported to PAT (maybe via automation?)
            * If they don't take advantage of support this is recorded
* Students lacked graduate-attributes/professional-skills to collaborate/comment on code
    * Theory: Majority of education has focused on solo tasks and being individually assessed
    * Expected behaviours: 
        * students talk about code regularly, 
        * justify/describe the code they have written that week
        * read/discuss others code weekley
    * Action:
        * Students encouraged to peer review each other's open source repo continuously throughout the module
        * Session time to be dedicated to this
* Mark schemes lacked clarity
    * Marking criteria for both Assignments to be revised
    * Digital Artifact
        * Automated tests will be mandatory for marks - no tests no marks - The tests will revised and more granular
            * Multiple students had skills but ignored the tests and spec. This made marking very difficult as technical skill and tests that pass were difficult to disentangle
        * Split competencies test/language/framework/container? dimensions in rubric
    * Technical Report
        * To require evidence of use of framework (code snippets? running demo template?)



Actions
-------



Communication to students
* You are still developing your ability to manage your time - you need support in doing this
* Explain the meaning of 150hours self study .. really ..







TODO
----

* update openapi spec
    * [OpenAPI Spec](https://redocly.github.io/redoc/?url=https://raw.githubusercontent.com/calaldees/frameworks_and_languages_module/after_assignment_updates/openapi.yml)
        * CORS Headers?
* Break down client tests into smaller sub components? Is this possible?


* Last session leaning objective - what is a framework

* Live script to clone and give feedback on repos that dont pass particular tests (at particular datetime) - live readout on web?



### Assignment 2 - Marking criteria is not fit for purpose
Dilema - Jure/Michael comparison - Code does not tell the whole story
Time consuming - viva presentation very successful - more assessment in this manner?
How should the criteria be reworked to mark this?

Feed Forward session


* [If They Build It, Will They Understand It? Exploring the Relationship between Student Code and Performance](https://dl.acm.org/doi/10.1145/3341525.3387379)
    * > student performance on specific questions on the written assessments is only very weakly correlated to specific attributes of final projects typically used in artifact analysis as well as attributes we use to define candidate code (r < 0.2, p < 0.05). In particular, the correlation is not nearly strong enough to serve as a proxy for understanding
    * Digital artifact only weakly correlated with understanding
