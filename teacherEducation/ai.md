AI in the classroom (30min)
===================

* Description
    * Introduction and ideas for AI in the classroom
    * I'm not an expert in AI or Pedagody
    * Not a _polished_ super session
* Activities
    * Where is the AI in the National Curriculum? (5min)
    * Unplugged Demo (10min)
    * Train an AI to recodnise emotions (10min)
    * Resource ideas (5min)


Where is the AI in the National Curriculum? (5min)
---------------

* TASK: Think Pair Share
    * Investigate [National curriculum in England: computing programmes of study](https://www.gov.uk/government/publications/national-curriculum-in-england-computing-programmes-of-study/national-curriculum-in-england-computing-programmes-of-study)
    * Where is the AI?

* Commentary
    * [NCCE Digital Skills Forum - AI and the Future of Education](https://www.youtube.com/watch?v=tvtJdi8u7vU&t=218s) YouTube NCCE Simon Peyton Jones 2021 (One of the team that wrote the NC)
        * Keep National Curriculum
        * Challenge _magic_
        * Shift of emphasis -> from _computation_ more to information and data
        * AI is another way to get the computer to do what you want - you give it data
        * Overfitting (exactly and only that cat) to precisely to one dataset. Eg.g a self driving car that can only drive to sainsburys


Unplugged AI (10min)
---------

* Key Terms
    * Image Classification
    * Confidence Score

<style>img {width: 40vw;}</style>

### Unplugged Training (rules)

Misconception/Analogy WARNING!!!!!
This is not really how AI rules work on a computer. 
Understand the concept of a _confidence score_.

* In pairs
* Create (minimum of) 4 rules/descriptions/ways-of-describing
* a butterfly
* from the pictures below

* Example Rules
    * It has 2 wings
    * It's on a green plant background
    * ???
    * ???

![](https://static.wixstatic.com/media/95bafa_a9a82fca9b404f9b9631de453ca681fa~mv2.jpg/v1/fill/w_516,h_316,al_c,q_80,usm_0.66_1.00_0.01,enc_auto/Blue_Morpho.jpg) ![](https://ichef.bbci.co.uk/news/976/cpsprodpb/61B3/production/_113911052_environmentbutterfly14471731.jpg) ![](https://images.fineartamerica.com/images-medium-large/adonis-blue-butterfly-adrian-bicker.jpg) ![](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKzhavugh3sa-J06C_bXPtRKaicPs5lBzeqYB7lnRLEerQSGklS1tJugfggb1O4F2A588&usqp=CAU)

### Categorise

* Using your rules/descriptions/ways-of-describing
* Each rule could be ranked from
    * 1.0 (It's definatly there)
    * 0.5 (it's sort of there)
    * 0.0 (it is not there - I don't see it)
* Calculate a _Confidence_ score
    * Add them together and divide by the number of rules

#### Example Rules

* It has 2 wings
* It's on a green plant
* It has white bits on wings
* Top of it's wings are bigger than the bottom of the wings

#### Challenge 1

![](https://cdn.hswstatic.com/gif/storymaker-animals-biodiversity-madidi-park-12091131.jpg)

#### Challenge 2

![](https://prod-images-static.radiopaedia.org/images/57275534/0._gallery.jpeg)

#### Challenge 3

![](https://www.gardeningknowhow.com/wp-content/uploads/2020/02/butterfly.jpg)

### More

* (More links to unplugged resrouces later)
    * [aiunplugged.org](https://www.aiunplugged.org/)
        * Unlpugged KS3 appropriate school activities
* Why would we ever want to identify butterflys?
    * Important for monitoring bio-diversity?
    * [Butterfly Detection and Classification Based on Integrated YOLO Algorithm](https://arxiv.org/abs/2001.00361) 2020
    * [Butterfly AI - Image Recognition And Classification For Insect Detection](https://www.businesswaretech.com/blog/butterfly-ai-image-recognition-and-classification-for-insect-detection) 2021


Hands on 'Teachable Machine' (10min)
----------------------------

* [teachablemachine.withgoogle.com](https://teachablemachine.withgoogle.com/)

TASK: 
1. Train your AI with your video camera to identify 3 emotions
2. Can it recodnise the emotions of another person?
3. Is this a good idea?
    * What are the applications of this tech to do _good_ things?
    * How can this technology be abused (on purpose or by accident)

* [Microsoft Plans to Eliminate Face Analysis Tools in Push for ‘Responsible A.I.’](https://www.nytimes.com/2022/06/21/technology/microsoft-facial-recognition.html)
    * > For years, activists and academics have been raising concerns that facial analysis software that claims to be able to identify a person’s age, gender and emotional state can be biased, unreliable or invasive — and shouldn’t be sold.

Bonus - Privacy awareness
---------------

* [hownormalami.eu](https://www.hownormalami.eu/) Local facial recognition algorithm and commentary video


Additional Resources (5min)
---------------------

* [teachablemachine.withgoogle.com](https://teachablemachine.withgoogle.com/)
    * [experiments.withgoogle.com/collection/ai](https://experiments.withgoogle.com/collection/ai)
* [machinelearningforkids.co.uk](https://machinelearningforkids.co.uk/)
    * Teach a computer to play a game
    * Scratch, Python, Appinventor
    * [worksheets](https://machinelearningforkids.co.uk/#!/worksheets)
        * Use webcam to look at hands (rock, paper, scissors) and use Scratch for logic
    * Create models and pre-trained models
    * [Dale Lane](https://dalelane.co.uk/blog/?tag=mlforkids-tech) creator, sponsored by IBM
    * [book](https://www.amazon.co.uk/Machine-Learning-Kids-Project-Based-Introduction/dp/1718500564/) - project based introduction to artificial intelligence
* Raspberry Pi Foundation - [Try our new free machine learning projects for Scratch](https://www.raspberrypi.org/blog/free-machine-learning-projects-for-scratch/)
* [Dancing with AI - Designing Interactive AI Systems](https://dancingwithai.media.mit.edu/) - Scratch blocks with curriculum
* [Scratch Lab - Face Sensing](https://lab.scratch.mit.edu/face/)
* [Coded Bias - Documentary](https://www.codedbias.com/)
    * [IMDB](https://www.imdb.com/title/tt11394170/)
* [IBM AI Education](https://www.mindspark.org/ibm-ai) - AI Webinars
    * Diversity
    * Robotics
    * Ethics
    * Careers
    * machine learning
* [ai4k12.org](https://ai4k12.org/) - The Artificial Intelligence (AI) for K-12 initiative
* MIT Media Lab - [AI + Ethics Curriculum for Middle School](https://www.media.mit.edu/projects/ai-ethics-for-middle-school/overview/)
* [Best K-12 Resources to Teach AI Ethics](https://medium.com/fair-bytes/best-resources-to-teach-ai-ethics-in-the-k-12-classroom-a801e00839d5) - Curricula, projects, and even fiction books to empower students to learn about AI ethics
* [Middle School AI](https://raise.mit.edu/daily/index.html)
    * Impressively deep set of modules - suitable for concepts even up to ks5!
* [aiunplugged.org](https://www.aiunplugged.org/)
    * Unlpugged KS3 appropriate school activities
* [steamlabs.ca/ai-programs](https://steamlabs.ca/ai-programs/)
    * Unplugged - [Predict a Pie with a Neural Network](https://steamlabs.ca/ai-programs/predict-a-pie/)
* [Teaching Machine Learning in K–12 Classroom: Pedagogical and Technological Trajectories for Artificial Intelligence Education](https://doi.org/10.1109/ACCESS.2021.3097962) 2021 Matti Tedre
    * List of tools and how they are used in the classroom
* [NPA Curricular Resources](https://trello.com/b/TGMf9U4S/npa-curricular-resources)
    * Massive list of datasets and data capture, statistics, data formats, What is data, ethics
* [edgeimpulse.com](https://www.edgeimpulse.com/)
    * > Edge Impulse is the leading development platform for machine learning on edge devices, free for developers and trusted by enterprises.
    * Build a model in 5 minutes.
* futurelearn
    * [Raspberry Pi Foundation](https://www.futurelearn.com/partners/raspberry-pi) - LOADS of very good courses
        * see #pedagogy
        * [Introduction to Machine Learning and AI](https://www.futurelearn.com/courses/introduction-to-machine-learning)
* [appsforgood.org/courses/machine-learning](https://www.appsforgood.org/courses/machine-learning)



OpenAI Playground
=================

[openai.com/playground](https://beta.openai.com/playground)
```text
write python code to:
- ask the user for their name
- the program responds with "hello NAME"
- the program does this 3 times and then exits
```
GCSE questions 80% (that's a level 9)

```
write a story about two bears playing hide and seek

how many bits in a bite?

write a python program that can ask the user for a whole number and convert it to binary

write a python function that
  - takes a list of possible valid input values
  - the user is asked for one of the possible valid values
  - if the value acquired from the user is not one of the valid values, it asks for the user input again
  - if the value is one of the valid values, return that value
```



---


Unsorted
========

Project based

Co-Teaching (with another teacher - cross pedagogy)

Finland - computing integrated in all subjects (history! RE!)
    Asking the the other teachers: do you want to do programming (rule driven)? .. or do you want to do data-driven?


* [Using AI to Animate Children’s Drawings ](https://about.fb.com/news/2021/12/using-ai-to-animate-childrens-drawings/)
* [Coding Challenge #158: Shape Classifier Neural Network with ml5.js](https://www.youtube.com/watch?v=3MqJzMvHE3E)
* [The AI4K12 project: Big ideas for AI education](https://www.raspberrypi.org/blog/ai-education-ai4k12-big-ideas-ai-thinking/)
    * AI for K12 (US) Computing
* [Human-Centered Explainable AI (XAI): From Algorithms to User Experiences](https://arxiv.org/abs/2110.10790)



* [Repel.it ChatGPT to make a Bitcoin price tracker](https://twitter.com/Replit/status/1602351385281978369)
    * twitter guide