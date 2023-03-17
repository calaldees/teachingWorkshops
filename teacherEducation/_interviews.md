Computing Candidate Interview Questions
=======================================

Introduction
------------

Introduce background of interviewers

### Timeframe
* 45 min
    * 3 min Introduction
        * Introduce interviewers and timetable (2 min)
        * Check ID (1 min)
        * Fundamental skills link
            * https://forms.office.com/r/f18z47dtpN 
            * https://bit.ly/FMESkillstest
    * 5 min personal overview
    * 7 min lesson plan
    * 10 min subject knowledge
        * Code comprehension (5 min)
        * Wider computing knowledge (5 min)
    * 15 min teaching questions
        * half teaching computing focused - half general teaching focused
    * 5 min Questions

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
* How did you get here?
* Why do you want to become a teacher?


Lesson Plan (7 min)
-----------

* Tell me about your lesson
    * Resource A or B (not both!)
    * _Not_ subject focused
* Why did you structure it this way?


Computing Knowledge (5 min)
-------------------

> You type `google.com` into a ‘url bar’ and 1 second later you see the Google logo and search box.

Using your knowledge of ‘The entire discipline of Computing’; can you describe in as much detail as possible what/how has happened? You have as long as you like to answer the question.

(Assess depth/breadth of computing knowledge. A good candidate will still be describing network routing infrastructure after 3 hours, let alone; font rasterization, language tokenization, compression. As an interviewer, you will know after 2 minutes)

> What is the difference between a ‘gif’ and ‘jpg’
(Lossy, 256 color palette, animation)


Code Comprehension (5 min)
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

(Looking if candidate can use technical language to describe programming constructs. Functions, Variables, Assignment operators, mathematical operations, scope. iteration. Advanced candidates can describe the programmes purpose)


Computing in Education (5 min)
----------------------

* Tell me about the Computing syllabus in UK schools (or overseas) what are the differences compared with the UK computing curriculum?
    * Describe how you have recently developed your computing subject knowledge in relation to the UK computing curriculum
    * What books/articles/blogs/videos have you encountered about teaching Computing?
* How would you encourage more girls to engage with Computing in schools?
* What are the threats to young peoples online safety. How would you teach this?
* Can you envisage a problematic scenario in a computing classroom?
    * How might you deal with this?
* What do you think young people will find the most challenging aspect of learning computing?
* Extra
    * (Overseas) How might teaching in the context of the UK be different to your past experiences?
    * How do you think computer science could/should be taught in the classroom?
    * How would teaching Computing differ from other subjects?
    * How do you see your skills and role changing/developing over the years? Where do you see yourself in 5 years?
    * What problems are there with young people using technology?



General Teaching (10 min)
----------------

* Picture yourself 6 months into the course; I come into your classroom to check on your progress. What will I see?
* What would you do if you were concerned about a colleague's behaviour towards children?
    * e.g. overhearing language used when dismissing a class
* You have prepared an amazing lesson with guidance from theory and the university. You present the lesson plan to your mentor who is no convinced and does not want you to run the lesson. How do you respond?
* In a GCSE class, you have 2 very slow students with special needs. They are never interested or engaged with computing. You have 28 other students that need your attention. How do you split your time?
* Extra
    * Your mentor (who is younger than you) - she gives you feedback to action that you don't agree with. What do you do?
        * (TODO: reword: how will you respond to feedback from a mentor that is younger than you?)
    * Why did you choose the PGCE over School Direct or Assessment-Only?
    * How would you deal with students not doing as you say?
    * Provide examples of times when workload and numerous tasks have been managed concurrently?
    * Can you give an example of where you changed your opinion?
    * What will make you a good teacher?
    * What are the hallmarks of a good lesson?



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

  
### Rubric 2022 - 2023 

* Subject Knowledge Enthusiasm/Development 
    * Excellent breadth and (some) depth of many topics on Subject Knowledge Audit. 
    * Participates in wider subject/field of education: work in schools, members of subject associations, etc. 
    * Good general breadth or depth of key subject topics. Shares some current knowledge of new ideas/trends/authors in either the subject discipline and/or or education pedagogy more widely.  
    * Completed Subject Knowledge Audit, shows some areas of knowledge in the subject discipline (usually what has been studied previously). 
    * Aware of some strategies for to how they will develop own knowledge further  
    * No subject audit completed 
    * Little enthusiasm or strategies for developing own subject knowledge further 
* Child Centred Approach 
    * Demonstrates clear knowledge of how to keep both children and self safe in a school context 
    * Is excited about the idea of working with children and young people  
    * NB – Has had formal training 
    * Is aware of the concept of child protection and can share some contextualised views/ideas /initial research on the subject 
    * Is interested in how to bring the curriculum alive to engage pupils 
    * Expresses the importance of the need to support young people and shares their own ideas on how this could be done
    * Some reference to pupils and desire to be in the classroom, more than just imparting knowledge 
    * Has difficulty in expressing concern for young people and/or identifying potential issues young people may face 
    * Motivation to teach centres entirely on own desire to impart knowledge to pupils 
* Resilience, Dedication and Sense of Purpose 
    * Proven ability to manage and recover from stressful/adverse challenges or situations. 
    * Aware course is challenging but has determined and realistic approach to training to teach and a sense of purpose. 
    * Explains knowledge of how to work under pressure. 
    * Shows an understanding of the demands of the year ahead and explains some strategies about how they will take responsibility and manage their time/wellbeing etc. Has a sense of purpose. 
    * Demonstrates some ability to adapt to potentially stressful situations and/or intense workload. Understands that own actions will have consequences. Developing a sense of purpose. 
    * Has difficulty in explaining how they have: managed stressful situations, heavy workloads, come up with solutions to difficult problems and kept going. Has no or highly incoherent sense of purpose.   
* Creative and Critical Thinking 
    * Original/critical analysis of issues/experience 
    * In Lesson Planning Task candidate may: think of an impressive original topic, come up with multiple strong ideas/strategies. In discussion, they may adapt someone else’s idea and add clear improvements, and challenge or take risks in order to improve the impact of the lesson plan. 
    * Perceptive analysis of issues/experience 
    * In Lesson Planning Task candidate may in discussion:  contribute a range of good ideas to the outcome of the task, ask or be able to answer curious questions and will easily be able to adapt to suggested changes. 
    * Some relevant analysis of issues and experience 
    * In Lesson Planning Task candidate may in discussion: contribute one or two ideas, challenge or add improvement suggestions, be able to talk about their plan with some enthusiasm. 
    * Has difficulty in finding relevant points/makes inappropriate points 
    * Has little/no suggestions for adaptation or improvement of the Lesson Planning Task. Lacks enthusiasm for what they have planned.  
* Reflective (in Response to Feedback) 
    * Demonstrates ability to identify critical learning points from a task/experience on their own. In response to feedback can precisely explain how their actions/understanding can change as a result. 
    * Demonstrates ability to identify some key points from a task/experience with some guidance. In response to feedback, can explain one or two strategies they think will improve their actions/understanding. 
    * Demonstrates ability to identify one or two key learning points after focused questioning/guidance. In response to feedback, will positively agree to improve generally.   
    * Demonstrates difficulty in identifying learning points despite focused questioning/guidance. Alternatively may excessively question or disagree with feedback received and challenge the need to improve their actions/understanding 

 

---

https://schoolexperience.education.gov.uk/
