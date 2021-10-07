Computing Candidate Interview Questions
=======================================

Introduction
------------

Introduce background of interviewers

### Timeframe
* 45 min
    * 3 min Introduction
    * 5 min personal overview
    * 7 min lesson plan
    * 25 min interview questions
        * half teaching computing focused - half general teaching focused
    * 5 min QA / chat

We have a lot to fit in 45mins. 
Apologies in advance; I may move our discussions onwards to keep to time.

### Objectives
* Ascertain
    * Subject Knowledge
    * Awareness of pedagogy
    * Reasons for teaching
    * Resilience
    * Safeguarding (Professionalism)


Personal Overview (5 min)
-----------------

Tell me your story:
  How did you get here?
  Why do you want to become a teacher?


Lesson Plan (7 min)
-----------

* Resource A or B (not both!)
* Not subject focused


Computing Knowledge (4 min)
-------------------

> You type `google.com` into a ‘url bar’ and 1 second later you see the Google logo and search box.

Using your knowledge of ‘The entire discipline of Computing’; can you describe in as much detail as possible what/how has happened? You have as long as you like to answer the question.

(Assess depth/breadth of computing knowledge. A good candidate will still be describing network routing infrastructure after 3 hours, let alone; font rasterization, language tokenization, compression. As an interviewer, you will know after 2 minutes)

> What is the difference between a ‘gif’ and ‘jpg’
(Lossy, 256 color palette, animation)


Code Comprehension (4 min)
--------------------------

Look at this code and comment on anything that you can identify using technical terminology.

### Code 1

```python
    IMAGE_FILENAME = 'elev_bump_8k.jpg'
    CROP_UNITED_KINGDOM = (3850, 700, 4150, 950)

    image_src = Image.open(IMAGE_FILENAME)
    image_src = image_src.crop(CROP_UNITED_KINGDOM)
    image_des = Image.new('RGB', (image_src.width, image_src.height), 0x000000)

    sea_level = 0

    for y in range(image_src.height):
        for x in range(image_src.width):
            land_height = image_src.getpixel((x, y))
            if (land_height - sea_level) > 0:
                c = (0, 255, 0)
            else:
                c = (0, 0, 255)
        image_des.putpixel((x, y), c)
    image_des.show()
```

(Looking if candidate can use technical language to describe programming constructs. Functions, Variables, Assignment operators, mathematical operations, scope. iteration)


Computing in Education (5 min)
----------------------

* Tell me about the current Computing syllabus in schools
    * What books/articles/blogs/videos have you encountered about teaching Computing?
* How do you think computer science could/should be taught in the classroom?
* What do you think young people will find the most challenging aspect of learning computing?
* How would teaching Computing differ from other subjects?
* Can you envisage a problematic scenario in a computing classroom?
    * How might you deal with this?
* How do you see your skills and role changing/developing over the years? Where do you see yourself in 5 years?
* What problems are there with young people using technology?


General Teaching (12 min)
----------------

* What will make you a good teacher?
* What are the hallmarks of a good lesson?
* Why did you choose the PGCE over School Direct?
* Describe a time when you had to learn a new skill. Why did you learn it? How did you approach it?
* What would you do if you were concerned about a colleague's behaviour towards children?
    * e.g. overhearing language used when dismissing a class
* Provide examples of times when workload and numerous tasks have been managed concurrently?
* You have prepared an amazing lesson with guidance from theory and the university. You present the lesson plan to your mentor who is no convinced and does not want you to run the lesson. How do you respond?
* Can you give an example of where you changed your opinion?
* In a GCSE class, you have 2 very slow students with special needs. They are never interested or engaged with computing. You have 28 other students that need your attention. Are those two important?


Questions (5 min)
---------




Interview Criteria
==================

Rough grading
1. Strong
2. Good
3. Some Potential
4. Of Concern

* Subject Knowledge
    * Able to talk enthusiastically about an aspect of subject knowledge (from degree or other relevant subject qualification)
    * Demonstrates a depth and breadth of subject knowledge suitable to embark on a PGCE
    * Knows how to research new areas of subject knowledge and understands that this will be an important feature of their training programme
* Awareness of curriculum and pedagogical issues
    * Is able to articulate the importance of their subject for learners within the curriculum
    * Demonstrates a reflective capacity when considering pedagogical issues in their subject
* Reasons for teaching and choosing PGCE secondary or 7-14
    * Understands the commitment the PGCE demands in terms of the balance of academic study and practical placement
    * Is committed to developing as a teacher for the benefit of learners
* Resilience
    * Demonstrates an ability to manage and adapt to stressful situations (e.g. change)
    * Can provide examples of times when workload and numerous tasks have been managed concurrently
    * Listens to advice and takes responsibility for own actions
* Safeguarding
    * Is able to demonstrate a commitment to keeping children safe and the capacity to develop the skills and knowledge to do this
    * Can demonstrate how to keep themselves safe

Tracking Spreadsheet has different criteria:
* Subject Knowledge, Enthusiasm, Development
* Child Centred Approach
* Resilience, dedication, sense of purpose
* Creative and critical thinking
* Reflective in response to feedback


Other Institutions Interview Reference
--------------------------------------

* [University of Southampton: Computing interview process](https://www.efolio.soton.ac.uk/blog/itcs/what-is-the-interview-process/)