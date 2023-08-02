Pre Interview Communication
=============

Congratulations on having been offered an interview for a place on the PCGE course for September 2023. As you will have read from the pre-interview information online, the interview process provides an insight into the course and an opportunity for you to ask questions. The interview will comprise of several different activities that enable you to demonstrate a variety of attributes and skills that successful teachers draw upon to enable learning to happen in the classroom and therefore is fair and rigorous.
 
This document provides an overview of the subject element of the interview and should be read in conjunction with the main webpage. There are two key processes that make up the subject element of the selection process
The Subject Interview
In the specialist subject interview, you will explore a range of topics; these are likely to include:
* Your view of how computing could/should be taught in the classroom
* Your proficiency in at least one programming language
* Your previous experience of working with young people in educational settings
Initial Subject Knowledge Audit in Computer Science
Below you will find a copy of the Initial Subject Knowledge Audit in computer science. I would be grateful if you would return your completed version of this document to me via email at least two days prior to the interview day. Should this not be possible, I would ask you to contact me in advance. My email address is allan.callaghan@canterbury.ac.uk 

We look forward to meeting you. 
  
Best wishes, 

Initial Subject Knowledge Audit
This audit aims to help you:
* Understand what “subject knowledge” means for your subject
* Perform a gap analysis of your own skills 
* Guide you with building subject knowledge before you start the course
No teacher knows everything about their subject. 
There are no defined list of topics or other information that must be known by subject practitioners. 
But it is important that you have the fundamental concepts.
What the PGCE “is” and “isn’t”
* The one-year PGCE course will be focused on developing your “Subject Pedagogy” e.g. How do you effectively teach computing concepts like a 'bubble sort'.
* The course will not be focused on developing “Subject Knowledge” e.g. Your skills or knowledge about algorithms, or software packages.
You will be taking responsibility for learning new material and raising your level of subject knowledge. This is an aspect of the course in which you need to develop independent strategies for learning.

What do your levels of competence look like in different topic areas?

For each area listed below indicate where you assess your level of competence to be currently. Please use the descriptions provided and be frank and honest in your self-assessment.

Important note:
The level descriptions should be used as a guide rather than a check list, to aid you. We are not expecting you to be able to demonstrate many areas at level 3 or 4 at this stage, therefore do not worry about ticking any of the boxes as this audit is used as a tool to help support and develop your subject knowledge rather than a judgement tool.
 
1. None
    * No idea or unsure, insecure knowledge. 
2. Some: 
    * Need to look it up or refresh knowledge Know the rules but need to refresh knowledge/skills
3. I know and can do: 
    * Quickly recall, answer exam style questions without a prompt. 
    * Know the key information, meanings and have the knowledge
4. I understand and can explain: 
    * Focus on teaching: Can explain how and why to someone else. 
    * Can use analogies, models or similar. 
    * Can link prior knowledge and next development stages. 
    * Understands the progression in a topic
5. I can help others to learn: 
    * Focus on individual learning and understanding: Can interconnect and link to other topics. 
    * Use relevance and everyday applications to motivate. 
    * Anticipate problems and difficulties through use of common misconceptions and other strategies. 
    * Understand conceptual structure. 
    * Deconstruct learning into manageable chunks. 
    * Enable meta-cognition 

Additional Subject Skills
Describe any additional experience/understanding you have related to the discipline of computing:


Computing Candidate Interview Questions
=======================================

Introduction
------------

### Introduction (5 min)
* Introduce background of interviewers
* "How was the group interview?"
    * RED FLAG:
        * Inaccurate perception of how they came across in the group interview
        * overly critical of other candidates or the tasks they were expected to complete
        * a lack of awareness of the lesson planning task
* Check ID (1 min)
* Fundamental skills link
    * https://forms.office.com/r/f18z47dtpN 
    * https://bit.ly/FMESkillstest
* Objective of interview + criteria
    * Subject Knowledge Enthusiasm/Development 
    * Child Centred Approach
    * Resilience, Dedication and Sense of Purpose
    * Creative and Critical Thinking
    * Reflective (in Response to Feedback)
* TimeFrame
    * We have a lot to fit in 45mins. 
    * Apologies in advance; I may move our discussions onwards to keep to time.
* Do you have any questions about the interview?

#### TimeFrame
* 45 min
    * 3 min Introduction
    * 5 min personal overview
    * 7 min lesson plan
    * 10 min subject knowledge
        * Subject Knowledge audit (TODO)
        * Code comprehension (5 min)
        * Wider computing knowledge (5 min)
    * 15 min teaching questions
        * half teaching computing focused - half general teaching focused
    * 5 min Questions

### Objectives
* Ascertain
    * Subject Knowledge
    * Awareness of pedagogy
    * Reasons for teaching
    * Resilience
    * Safeguarding (Professionalism)


Personal Overview (4 min)
-----------------

* Tell me your story (2min):
    * How did you get here?
    * Why do you want to become a teacher?
* Questions from personal statement
    * Tell me more about xxx

Lesson Plan (7 min)
-----------

* Tell me about your lesson
    * Resource A or B (not both!)
    * _Not_ subject focused
* Why did you structure it this way?
* What improvements could be made? (Creative and Critical Thinking) (Reflective in Response to Feedback)

Subject Knowledge Audit (In progress)
----------------------

* What do you feel are your strongest areas of subject knowledge, 
    * how did you develop this knowledge/skill/deep understanding?
    * RED FLAGS:
        * If they have rated themselves at the top level but they can’t give examples of having taught them. 
        * If they have rated themselves highly for an attribute but reveal misconceptions in conversation e.g. saying they are great at identifying algorithm complexity, but can't write a bubble sort.
* What are your weakest areas of subject knowledge at this time?
    * reassure candidate that all trainees are required to develop subject knowledge during the programme and what we are looking for at interview is an accurate self assessment of competence, rather than a full depth and breadth of computing knowledge, skills and understanding.
* If you had time to develop this knowledge/skill/understanding before joining the course, how would you go about organising this independently?


Computing Knowledge (5 min)
-------------------

Show-off your knowledge of how a computer works.

> You type `google.com` into a ‘url bar’ and 1 second later you see the Google logo and search box.

Using your knowledge of ‘The entire discipline of Computing’; can you describe in as much detail as possible what/how has happened? You have as long as you like to answer the question.

(Assess depth/breadth of computing knowledge. Are they enthusiastic and glowing with knowledge about how a computer works. A good candidate will still be describing network routing infrastructure and protocols after 3 hours, let alone; font rasterization, language tokenization, compression. As an interviewer, you will know after 2 minutes)

Extension?:
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

(Looking if candidate can use technical language to describe programming constructs. Functions, Variables (primitive types), Assignment operators, mathematical operations, scope. iteration. Advanced candidates can describe the programmes purpose)


Computing in Education (5 min)
----------------------

* Tell me about the Computing syllabus in UK schools (or overseas) what are the differences compared with the UK computing curriculum?
    * e.g. the National Curriculum for Computing, GCSE/BTEC/A Level/online syllabi, Ofsted Computing Research Review etc. would be helpful to demonstrate wider understanding of the context of computing in schools.
    * Understand of distinction between: Computer Science, ICT and Digital Literacy and how these are conveyed in schools
    * RED FLAGS: Not understanding the breath of requirements a computing teacher may need to involved in. Thinking it's "only programming" or "only ict"
* What are the threats to young peoples online safety. How would you teach this?
* What do you think are are some of the challenges with 'teaching' Computing
    * How would you encourage more girls to engage with Computing in schools?
* What do you think young people will find the most challenging aspect of 'learning' computing?
* Can you envisage a problematic scenario in a computing classroom? How might you deal with this?
* Should everyone learn how to code? Why/WhyNot?
    * RED FLAGS: Lack of awareness of the range of possible learners and motivations. Computing is hard and abstract and can be difficult for some students to contextually engage with. Thinking that code is the only aspect of teaching computing.
* Extra
    * (Overseas) How might teaching in the context of the UK be different to your past experiences?
    * How do you think computer science could/should be taught in the classroom?
    * How would teaching Computing differ from other subjects?
    * What problems are there with young people using technology?
    * Would you use computer games in your classroom?
        * RED FLAGS: not identifying that games can engage some learners and significantly disengage others



General Teaching (10 min)
----------------

* Resilience, Dedication and Sense of Purpose
    * Picture yourself 6 months into the course; I come into your classroom to check on your progress. What will I see?
    * What do you think will be the most difficult part of your Initial Teacher Training year? How do you think you will overcome this?
    - Can you give an example of when you have been overwhelmed by work
        - How did you resolve this situation?
    - What do you suspect your upcoming school experience will look like?
        - What possible issues can you foresee with teaching in your new context
        - how could you resolve this situation?
* Child Centred Approach
    * What would you do if you were concerned about a colleague's behaviour towards children?
        * e.g. overhearing language used when dismissing a class
* Safeguarding:
    * RED FLAGS: Any responses which indicate a lack of concern for young people’s welfare or their own safety.
    * Scenario question: you’re taking the register one morning. A pupil runs in late and tells you that they need to talk to you urgently. They look shaken. What do you do?
        * (training year alternate: "and your mentor is also in the classroom")
    * Scenario question: You’re walking home from school and see a large group in the park smoking cannabis, vaping and drinking cans. The group includes some pupils from your Key Stage 3 classes. You’re going to have to walk past them to get home. What do you do?

* (Teaching)
    * You have prepared an amazing lesson with guidance from theory and the university. You present the lesson plan to your mentor who is no convinced and does not want you to run the lesson. How do you respond?
    * In a GCSE class, you have 2 very slow students with special needs. They are never interested or engaged with computing. You have 28 other students that need your attention. How do you split your time?
        * RED FLAGS: Lack of positivity and high aspirations for the musical learning of pupils with SEN(D) or younger pupils.
* Extra
    * Your mentor (who is younger than you) - she gives you feedback to action that you don't agree with. What do you do?
        * (TODO: reword: how will you respond to feedback from a mentor that is younger than you?)
    * Why did you choose the PGCE over other potential routes into teaching e.g. School Direct or Assessment-Only?
        * RED FLAGS: Are they aware of different routes. Do they know what the PGCE is.
    * How would you deal with students not doing as you say?
    * Provide examples of times when workload and numerous tasks have been managed concurrently?
    * Can you give an example of where you changed your opinion?
    * What will make you a good teacher?
    * What are the hallmarks of a good lesson?

TODO:
* What is it that you will bring to your department
        Please tell me about a time when you have worked effectively as part of a team.
        Can you discuss a situation when you have worked under pressure? (what strategies did you use to cope?)


Questions (5 min)
---------




Interview Criteria
==================

### Rubric 2022 - 2023 

* [browser docx](https://cccu.sharepoint.com/:w:/r/sites/FacultyofArtsHumanitiesandEducation/_layouts/15/Doc.aspx?sourcedoc=%7BE32AC9BB-1182-4A8E-87BA-7DC2FEEFBCB2%7D&file=PGCE%20recruitment%20rubric%202022-2023.docx&action=default&mobileredirect=true&cid=744df836-76b8-4047-9211-9404eeebf4a4)

* Subject Knowledge Enthusiasm/Development 
    * 1
        * Excellent breadth and (some) depth of many topics on Subject Knowledge Audit. 
        * Participates in wider subject/field of education: work in schools, members of subject associations, etc. 
    * 2
        * Good general breadth or depth of key subject topics. Shares some current knowledge of new ideas/trends/authors in either the subject discipline and/or or education pedagogy more widely.  
    * 3
        * Completed Subject Knowledge Audit, shows some areas of knowledge in the subject discipline (usually what has been studied previously). 
        * Aware of some strategies for to how they will develop own knowledge further  
    * 4
        * No subject audit completed 
        * Little enthusiasm or strategies for developing own subject knowledge further 
* Child Centred Approach
    * 1
        * Demonstrates clear knowledge of how to keep both children and self safe in a school context 
        * Is excited about the idea of working with children and young people  
        * NB – Has had formal training 
    * 2
        * Is aware of the concept of child protection and can share some contextualised views/ideas /initial research on the subject 
        * Is interested in how to bring the curriculum alive to engage pupils 
    * 3
        * Expresses the importance of the need to support young people and shares their own ideas on how this could be done
        * Some reference to pupils and desire to be in the classroom, more than just imparting knowledge 
    * 4
        * Has difficulty in expressing concern for young people and/or identifying potential issues young people may face 
        * Motivation to teach centres entirely on own desire to impart knowledge to pupils 
* Resilience, Dedication and Sense of Purpose
    * 1
        * Proven ability to manage and recover from stressful/adverse challenges or situations. 
        * Aware course is challenging but has determined and realistic approach to training to teach and a sense of purpose. 
    * 2
        * Explains knowledge of how to work under pressure. 
        * Shows an understanding of the demands of the year ahead and explains some strategies about how they will take responsibility and manage their time/wellbeing etc. 
        * Has a sense of purpose. 
    * 3
        * Demonstrates some ability to adapt to potentially stressful situations and/or intense workload. Understands that own actions will have consequences. Developing a sense of purpose. 
    * 4
        * Has difficulty in explaining how they have: managed stressful situations, heavy workloads, come up with solutions to difficult problems and kept going. Has no or highly incoherent sense of purpose.   
* Creative and Critical Thinking
    * 1
        * Original/critical analysis of issues/experience 
        * In Lesson Planning Task candidate may: think of an impressive original topic, come up with multiple strong ideas/strategies. In discussion, they may adapt someone else’s idea and add clear improvements, and challenge or take risks in order to improve the impact of the lesson plan. 
    * 2
        * Perceptive analysis of issues/experience 
        * In Lesson Planning Task candidate may in discussion:  contribute a range of good ideas to the outcome of the task, ask or be able to answer curious questions and will easily be able to adapt to suggested changes. 
    * 3
        * Some relevant analysis of issues and experience 
        * In Lesson Planning Task candidate may in discussion: contribute one or two ideas, challenge or add improvement suggestions, be able to talk about their plan with some enthusiasm. 
    * 4
        * Has difficulty in finding relevant points/makes inappropriate points 
        * Has little/no suggestions for adaptation or improvement of the Lesson Planning Task. Lacks enthusiasm for what they have planned.  
* Reflective (in Response to Feedback)
    * 1
        * Demonstrates ability to identify critical learning points from a task/experience on their own.
        * In response to feedback can precisely explain how their actions/understanding can change as a result. 
    * 2
        * Demonstrates ability to identify some key points from a task/experience with some guidance. 
        * In response to feedback, can explain one or two strategies they think will improve their actions/understanding. 
    * 3
        * Demonstrates ability to identify one or two key learning points after focused questioning/guidance. 
        * In response to feedback, will positively agree to improve generally.   
    * 4
        * Demonstrates difficulty in identifying learning points despite focused questioning/guidance. 
        * Alternatively may excessively question or disagree with feedback received and challenge the need to improve their actions/understanding 




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

  

 

---

https://schoolexperience.education.gov.uk/
