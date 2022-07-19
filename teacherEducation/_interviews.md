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
* Picture yourself 6 months into the course; I come into your classroom to check on your progress. What will I see?


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


Safeguarding
------------

(copy and paste from reference document)

### Possible Safeguarding Questions 
 
1. What attracted you to teaching / this post / this school? 
2. How do you think your own childhood may have influenced your practice  
with students/pupils? 
3. Tell us about a teacher that made an impact on you and why do you think that was? 
4. What motivates you to work with young people? 
5. Tell us about your interests outside work? 
6. What do you think are the professional challenges facing teachers today? 
7. Give an e.g. of where you had to deal with bullying behaviour between pupils. What did you do? What made it successful/ What could you have done better? 
8. Young people develop crushes / like physical contact how would/do you deal with this? 
9. What would you do if you were concerned about a colleague’s behaviour towards children? 
10. Give an example of how you have managed poor pupil behaviour? 
11. Give an example of when you have had to respond to challenging pupil behaviour? How did it affect you? How did you cope with the aftermath? 
12. When do you think it is appropriate to physically intervene in a situation involving young people? 
13. What makes a school “safe and caring”? 
14. What policies are important to support a safe school environment? 
15. What are staff’s responsibilities in protecting children? 
16. How do you define an appropriate teacher/school secretary/site agent or caretaker/learning support assistant/parent helper/lunchtime supervisor? 
17. Give an example of what you would consider to be appropriate/inappropriate behaviour? 
 
### Recruitment panels should be concerned where any candidate demonstrates: 
 
1. Attitudes which attribute adult experience & knowledge to children, specially sexual knowledge or behaviour a disproportionate amount of time to extra-curricular activities with children 
2. Personal/life balance, including the paucity of adult relationships/leisure pursuits  
3. Attitudes which appear to underestimate the incidence and impact of sexual abuse 
4. An inability to recognise or respect boundaries with regards to physical contact 
5. Inability to describe appropriate boundaries of a professional relationship with children or to distinguish between appropriate or inappropriate behaviour 
6. Children and adults are equal in every sense – ignoring disparities of power and authority 
7. An inability to recognise the inherent vulnerability of children from a troubled or disadvantaged background 
8. A tendency to view children & young people in idealised or romanticised terms dogmatic, autocratic, arrogant or over-confident attitude 

some of these may have entirely satisfactory explanations; others may raise serious concerns as not everyone whose responses cause concern will be a potential abuser. They may just be poorly articulated, hesitant or a sign of “interview nerves” 

### Possible Safeguarding questions 2

1. How would you go about creating an inclusive learning environment?
2. What is a teacher's responsibility in keeping children safe?
3. What are some of the current educational issues?
4. How would you help all pupils achieve their potential?
5. How would you contribute to making a school a safe environment for the children? Can you give some examples of this from your experience?

---

### Child Centred Approach/Safeguarding 
 
7. Give an e.g. of where you had to deal with bullying behaviour between pupils. What did you do? What made it successful/ What could you have done better? 
8. Young people develop crushes / like physical contact how would/do you deal with this? 
9. What would you do if you were concerned about a colleague’s behaviour towards children? 
10. Give an example of how you have managed poor pupil behaviour? 
11. Give an example of when you have had to respond to challenging pupil behaviour? How did it affect you? How did you cope with the aftermath? 
12. When do you think it is appropriate to physically intervene in a situation involving young people? 
14. What policies are important to support a safe school environment? 
15. What are staff’s responsibilities in protecting children? 
16. How do you define an appropriate teacher/school secretary/site agent or caretaker/learning support assistant/parent helper/lunchtime supervisor? 
17. Give an example of what you would consider to be appropriate/inappropriate behaviour? 

### Sense of Purpose/Resilience and Dedication 
	

* What makes a school “safe and caring”? 
* What motivates you to work with young people? 
* Tell us about your interests outside work? 
* What do you think are the professional challenges facing teachers today? 
* How do you deal with setbacks? 
* How do you cope with pressure? 
* What has been your biggest failure to date and how did you deal with it? 
* Tell me about a time when you had to deal with a major crisis. 
* Describe a time when something didn’t work out as well as you’d hoped. What did you do and what did you learn from it? 
* Tell me about a time when you worked with someone you didn’t agree with. 
* How would you respond if you received negative feedback from someone in a leadership position? 

### Conflict Resolution 
* Tell me about a time when you disagreed with an idea a friend, colleague or family member wanted to pursue. How did you approach the disagreement? 
* Think about a situation in which you disagreed with the direction or idea that your boss suggested. What did you do to professionally disagree? If not, what were your thoughts about the situation? 
* When you work with a team or a group, disagreements can be common. Tell us about a time when you handled a disagreement. How did you approach the situation and what was the resolution? 
* When you think about your experience with disagreement and conflict resolution, how would you rate your skills in handling differences of opinion? Please give an example that illustrates that skill. 
* How comfortable are you, in general, with dealing with differences of opinion and disagreement? Can you provide a work-related example that illustrates your comfort level? 

  