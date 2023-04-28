Managing Data
=============

* Managing Data
    * Considering computing tools for transparency
    * Record-keeping for professional accountability

Objective:
* Understand what data is publicly available for schools and how to interpret it
* Consider how whole schools and departments use data
* Understand a range of practical tools for tracking class progress

* Data is part of your job - Should not encompass your whole job

ITT Core Framework
> 6.
> Make marking manageable and effective, by:
>   * Receiving clear, consistent and effective mentoring in how to record data only when it is useful for improving pupil outcomes

Teachers' Standards
> 6.3 use relevant data to monitor progress, set targets, and plan subsequent lessons

DfE
> 3 data collection points per student each year. (once every 12 weeks)


Use of School Data
------------------

[The 6 golden rules of pupil progress data](https://www.tes.com/news/6-golden-rules-pupil-progress-data)
> Used badly, pupil progress data can do more harm than good 

<sub>warns the director of middle leaders’ union NAHT Edge</sub>

1. Focus on assessment first
    * Confidence in the assessment?
2. Minimise the time spent collecting and analysing data
    * remember that every minute spent collecting and analysing data is a minute that could be spent doing something about the very issues it reveals
3. Don’t lose sight of the wood for the trees
    * Schools are incredibly data rich, perhaps too much so
4. Be very careful of over-analysing small data sets
5. Lower the stakes
    * The Tyranny of Metrics
6. Use data to raise questions rather than draw conclusions
    * “Why might there be an issue with maths progress in Year 5?”

[DfE Blog - Making time to use data effectively](https://teaching.blog.gov.uk/2016/04/01/making-time-to-use-data-effectively/)

> The mechanics of data collection had obscured and overtaken the reason for collecting the data in the first place

> 3 data collection points per student each year. Staff are given one week to input a grade/level and an attitude to learning score per student and the system has been set up to allow data to be inputted from anywhere (home or school to allow flexible working).

[Using Data to Support Teaching and Learning](http://www.lancsngfl.ac.uk/curriculum/english/files/UsingDatatoSupportTeachingandLearning.pdf) Robin Lane - Associate Literacy Consultant - Lancashire County Council

> REMEMBER, the purpose of assessment is to improve standards (of teaching and learning) not merely to measure them.

[Guardian - Top tips on getting the most out of school data](https://www.theguardian.com/teacher-network/teacher-blog/2014/apr/15/top-tips-school-data-pupil-performance)

> Make sure all staff are able to analyse the school's data


Ofsted Reports & Performance Data
---------------------------------

Lessons observations have been proven to be an opinionated unreliable way to inspect schools.
Ofsted now focuses of looking at the schools data and evidence of _real learning_
* [Written feedback on lessons is mostly pointless. Better to meet, review and plan – together](https://teacherhead.com/2021/05/06/written-feedback-on-lessons-is-mostly-pointless-better-to-meet-review-and-plan-together/) @teacherhead Tom Sherrington 2021

RAISEonline replaced by _Analyse School Performance_ in September 2017

* [What is RAISEonline data – and why should it be publicly available?](http://helpmeinvestigate.com/education/2011/12/what-is-raiseonline-data-and-why-should-it-be-publicly-available/)
    * There’s a vast store of information about our schools, but access is limited. 

* [Analysing school performance: NGA (National Governance Association)](https://www.governor.support/wp-content/uploads/2018/08/ASP-guidance_final-2018.pdf) 2018
    * A guide for governing boards on the DfE data service for schools

### Attainment8 and Progress8

* Explanation of calculation
    * [Secondary accountability measures (including Progress 8 and Attainment 8)](https://www.gov.uk/government/publications/progress-8-school-performance-measure)
    * [Progress8](https://www.youtube.com/watch?v=2qeQxQ06TXw) 5min Explanation

#### Attainment 8 - Grade point score

* Maths (2 multiplier)
* English (Highest of Language or Literature) (*2 multiplier)
* EBACC: Best 3 subjects from (Science, Computer Science, Geography, History, MFL)
* Other: Best 3 subjects from (vocational, lower-english, Art, DT, Drama, PE)

2*Maths + 2*English + 3 EBACC + 3 Other = 10 buckets = 8 subjects

#### Progress8

ExpectedAttainment8 KS2Score-> Lookup
(Attainment8 - ExpectedAttatinment8) / 10 (the num of buckets) = Progress 8


### Activity: Calculate Attainment8/Progress8 (10min)

Further _Teach Computing_ Concept: Below is an experiment with using code to generate individual questions with individual answers.
(Next steps could be a web interface?) #CAT

You will be generated a random set of subject grades and expected_attainment8 and asked to calculate progress8

```python
# You can copy and paste this into a python3 terminal or repl.it to try it
import random
from itertools import chain

SUBJECTS = {
    'core': {'maths', 'english_lit', 'english_lang'},
    'ebacc': {'science', 'computer science', 'geography', 'history', 'mfl'},
    'other': {'art', 'dt', 'drama', 'pe', 'social-care', 'travel-tourism', 'business'},
}

def gen_random_grades():
    return {
        subject: random.randint(1,9)
        for subject in chain(
            SUBJECTS['core'],
            random.sample(SUBJECTS['ebacc'], random.randint(3,4)),
            random.sample(SUBJECTS['other'], random.randint(2,5)),
        )
    }

def calc_attainment8(subject_grades):
    _sorted_grades = sorted(((grade, subject) for subject, grade in subject_grades.items()), reverse=True)
    english_hi = 'english_lang' if subject_grades['english_lang'] > subject_grades['english_lit'] else 'english_lit'
    english_low = 'english_lang' if english_hi == 'english_lit' else 'english_lit'
    return sum(chain(
        (
            subject_grades['maths'] * 2,
            subject_grades[english_hi] * 2,
        ),
        tuple(
            grade
            for grade, subject in _sorted_grades 
            if subject in SUBJECTS['ebacc']
        )[:3],
        tuple(
            grade
            for grade, subject in _sorted_grades 
            if subject in SUBJECTS['other'] | {english_low, }
        )[:3],
    ))

def calc_progress8(attainment8, expected_attainment8):
    return (attainment8 - expected_attainment8) / 10

def calc_activity(subject_grades=None, expected_attainment8=None):
    subject_grades = subject_grades or gen_random_grades()
    expected_attainment8 = expected_attainment8 or random.randint(10, 100)
    attainment8 = calc_attainment8(subject_grades)
    progress8 = calc_progress8(attainment8, expected_attainment8)
    return locals()

CLASS_LIST = ('bob', 'jane', 'freddy')
from copy import deepcopy
questions_and_answers = {name: calc_activity() for name in CLASS_LIST}
# remove answers
questions = deepcopy(questions_and_answers)
for i in questions.values():
    del i['attainment8']
    del i['progress8']

from pprint import pprint
pprint(questions_and_answers)
pprint(questions)

```

### Activity: Compare Schools (20min)

* [Ofsted - Inspections and performance of education providers](https://www.gov.uk/education/inspections-and-performance-of-education-providers)
    * Description of report content - [Using Ofsted’s inspection data summary report](https://www.gov.uk/government/collections/using-ofsteds-inspection-dashboard)
    * Example - Add three schools to MySchools to see a comparison
        * [Canterbury Academy](https://www.compare-school-performance.service.gov.uk/school/136302/the-canterbury-academy/secondary&year=final)
        * Barton Court

1. Find the Ofsted report for your school
2. Compare your school with other local school (using MySchools)
3. Read the ofsted report for your school - do the comments made justify/align with the progress8

Notes:
* Kent _believes_ in choice. 50% of school are grammar schools.
    * What do you think that does to performance statistics? LEA Average?
    * Should not affect *Progress8*?
* Schools can have a negative Progress8 and still be classed as _good_


Organisations with Products
---------------------------

* [Centre for Education and Monitoring](https://www.cem.org/)
    * > CEM is one of the largest and longest established providers of formative assessments for children of all ages, from early years to post 16. CEM’s methods are research-based, evidence driven and market-tested, built on a foundation of non-commercial academic practice.
    * [video](https://www.cem.org/about-us)
    * [YELLIS](https://www.cem.org/yellis)
        * > Yellis gives us a benchmark as to see how our students compare with others of the same age nationally.
* [Fisher Family Trust](https://fft.org.uk/fft/target-setting/)
    * > FFT is a non-profit organisation established in 2001 as part of the Fischer Family Trust. We are focussed on providing accurate and insightful information to schools which enables pupils to achieve their full potential and schools to improve.
    * [Example KS4 FFT Target SettingDashboard](https://mk0fftm7irhiawh7i.kinstacdn.com/wp-content/uploads/FFT-Aspire-Example-KS4-Target-Setting-reports.pdf)


Special Purpose Software
------------------------

Some schools employ 3rd party software to help with data management.

* [Alps](https://alps.education/how-alps-works/)
* [SMID](http://www.smidreport.com/) - Progress8 Software Example
    * Scroll down to SMID Tools and see the videos

Personal Experience: Most of these systems are flawed at the data capture level. Teacher time and data capture methods are always of secondary importance compared to the graphs that senior leaders can get.


Activity: Reflection on 'The industry of teaching' (15min)
----------------------------------------------------------

* Question to the group:
    * What does this data mean for your career and you?

(performance review - the reality? - interview question "how will my progress/performance be analysed?")


Is data effective?
------------------

> Data can be tortured sufficiently will to confess to anything

Story: Gender gap - school focus (David Daidu)

[Teacher Effects on Student Achievement and Height: A Cautionary Tale](https://www.nber.org/papers/w26480)

> many states and school districts have adopted value-added measures as indicators of teacher job performance. In this paper, we conduct a new test of the validity of value-added models.

Leadership of a school can twist results. In some cases asking teachers to report different levels to parents.
Story: Dale - Raise their grade


Activity: Data in Your schools (15min)
------------

The data system used in your school
question each other and compare different methods (encourage critical engagement).


Flightpath
----------

Async - Read this article - (15min)
* [Creating flight paths to replace levels Year 7-11 - the impact of the new GCSE grade descriptors](http://www.andallthat.co.uk/blog/creating-flight-paths-to-replace-levels-year-7-11-the-impact-of-the-new-gcse-grade-descriptors)

You don't get input into a students predicted grade. That is set in stone at KS2.

* [AndAllThat.co.uk](https://AndAllThat.co.uk/) - [Alex Ford](@apf102) - History Teacher
    * [Creating flight paths to replace levels Year 7-11 - the impact of the new GCSE grade descriptors](http://www.andallthat.co.uk/blog/creating-flight-paths-to-replace-levels-year-7-11-the-impact-of-the-new-gcse-grade-descriptors)
    * [Setting us free - ppt](https://onedrive.live.com/embed?cid=DAA916CB8AB52178&resid=DAA916CB8AB52178%2149526&authkey=AKMNJnkRHgYi9C0&em=2)

* A ‘flightpath’ is basically an indication of whether a particular pupil is on schedule to achieve a particular grade.
* In order to monitor progress the student would typically take regular tests (or complete agreed tasks) which are assessed against agreed criteria.
* Towards the end of a GCSE course these would be GCSE past papers, marked against board mark schemes.
* The outcome of these tests would be a mark.
* This could then be plotted on a graph
    * typically mark on the Y axis and term on the X axis.
    * A trend line can then be followed to the end of the programme and a predicted grade established.
* Ideally the pupil’s marks should follow the trend line through the following terms and the pupil achieves their potential, but we all know that progress is never smooth.
* Some schools have a flight path graph in the front of pupil folders with the pupil plotting their own marks on it.
    * Looks impressive, but I’m not convinced it actually means anything at all!


Is the data helping?
--------------------

* There is a feeling in some schools that all of this monitoring is more about holding teachers to account (and informing performance management decisions) than it is about promoting pupil progress.
* Students may want to use some of this data in their pupil progress bundles, even if they decide not to it is important that they understand their school system and make the most of what it offers.

They could also compare their school systems with the WRG recommendations at:

DfE [Commission on Assessment Without Levels: final report](https://www.gov.uk/government/publications/commission-on-assessment-without-levels-final-report) September 2015
>  It should be clear what the aims of assessment are and how they can be achieved without adding unnecessarily to teacher workload.

> A good assessment policy will be clear about how assessment outcomes will be used, with a view to collecting data only where necessary and ensuring assessment outcomes are communicated effectively to pupils, parents and other teachers. 

> Ofsted is very clear that unnecessary or extensive collections of marked pupils’ work are not required for inspection purposes.

> there is no intrinsic value in recording formative assessment; what matters is that it is acted on

> 7. Is it necessary to record the information gained from this assessment? And if so, how can this be done most efficiently?
>   * For example: do not assume that everything needs to be recorded. Identify which assessment outcomes are essential to record for the teacher pupil, parent or carer and keep it simple.
>   * For example: do not assume that formative assessment must be recorded using the same scale or terminology as summative assessment


Workload Reform
---------------

* [Eliminating unnecessary workload associated with data management - Report of the Independent Teacher Workload Review Group](https://assets.publishing.service.gov.uk/government/uploads/system/uploads/attachment_data/file/511258/Eliminating-unnecessary-workload-associated-with-data-management.pdf) March 2016


General Purpose Software - Publishing Class Tracking/Progress (2 hours)
========================

* Introduction and Demo (30min)
* Hands-on (1hour 15min)
* Discussion of application of these techniques (15min)

Perception
* Data in your head cannot be quantified or shared
* Data formally on a computer carries more weight than hand written notes
    * (Story: A-Level student complaint parent/teacher meeting 5min)
* Transparency is vital (It's only useful/real if people can see it)
* Students see where they are in the class
    * This create a hierarchy
    * Is this a problem

### Tasks - Hands-on (1hour 30min)

Attempt to explore the techniques used in my [Teacher Workbook Example](https://docs.google.com/spreadsheets/d/1LRn7KCvpGXhnYlRnEZeU19xQ4Zo39xjn5KBjWH-_x0E/edit?usp=sharing)

### Technique 1: Google Docs Public/Private View

1. Create new [Google Sheet](https://docs.google.com/spreadsheets/)
2. Add/Rename Sheets
    * `public`
    * `private`
3. Enter Formula on `public` to reference `private`
    * `={private!A:G}`
4. Hide required columns
5. `public` -> Data -> Protect Sheets and Ranges -> 'Show warning when editing this range'
6. File -> Publish to the web -> Publish content & settings -> `public` + Automatically republish
7. [bit.ly](http://bit.ly) - Shorten the url
    * Signup (free) will allow you to manually name your short links
8. Distribute link to students and parents

### Technique 2: Automatic progress indicator

* Automatic progress `%` and on-target feedback
    * `start_date`, `due_date`, `=NOW()`, `days_total`, `days_elapsed`, `% elapsed`
    * `expected progress %` = (`target` * `% elasped`)
    * `on_track` = `current_progress %` - `expected progress %`

### Technique 3: Google Docs - Linking separate sheets

* [IMPORTRANGE](https://support.google.com/docs/answer/3093340?hl=en) interlink separate sheets
    * `=IMPORTRANGE("https://docs.google.com/spreadsheets/d/1LRn7KCvpGXhnYlRnEZeU19xQ4Zo39xjn5KBjWH-_x0E/edit#gid=1822394775", "Unit1!A1:S32")`
    * Great for linking a whole departments sheets?
    * Can't currently be done with [Excel Online](https://answers.microsoft.com/en-us/msoffice/forum/msoffice_excel-mso_other-mso_o365b/office-365-excel-workbook-share-only-one-worksheet/16fdf6b5-4876-4e0f-9b07-629a3c2ef00e?auth=1)

### Supporting skills

* Assuming student teachers are familiar 
    * with absolute cell references
    * conditional formatting
    * comments
* `Tools` -> `Protect sheet` -> `range`
    * This is really important!
* Copy + Paste (special) - formatting only (only within same workbook)
* Random ID's ()
    * ```python
        import random, string
        def random_string(num_letters=4):
            return ''.join(random.choices(string.ascii_uppercase + string.digits, k=num_letters))

        random_strings = [random_string() for i in range(16)]
        print("\t".join(random_strings))
      ```

### Other ideas?

* [SPARKLINE](https://gsuitetips.com/tips/sheets/bring-some-sparkline-sparkle-to-your-google-sheet/) Creates a miniature chart contained within a single cell.
    * [Docs](https://support.google.com/docs/answer/3093289)
* [FLOOKUP](https://news.ycombinator.com/item?id=22083533) - possible useful addon
    *  Flookup is a fuzzy matching add-on that helps you manage text that is less than a 100% match
* All data in a GoogleSheet can be accessed via a JSON api
    * example of use in frontend web - [googleSheets.js](https://github.com/calaldees/barcampCanterbury/blob/b91b9f0748342d6e21ba95db83b21a58ce5aa933/barcampcanterbury.com/data/googleSheets.js#L1)
        * Top row is heading name
        * Each row becomes a dictionary/object

Todo
----

* [How to use data to spot pupil behaviour issues ahead of time](https://www.tes.com/magazine/leadership/data/how-use-data-spot-pupil-behaviour-issues-ahead-time)
    * Rolling behaviour data of whole cohort with excel

https://analytics.ofqual.gov.uk/

Data teacher meme

Hard data is what - Quantitative
Soft data is why - Qualitative
SIMS
Pupil Premium - stigma - wider
Behaviour logs - incomplete?
Flightpaths damaging - pregedise? moral?
Exit cards - from lesson - still kids (do they know shit?)
Data
* something you have to do
* something you use for action
Google forms

Seating plan - by ability - data?
hard information to high achievers - simpler information to weaker students
SIMS behaviour alerts


Online Engagement
-----------------

Features of modern remote learning systems

Monitoring _views_ of resources.

* [Adopting a framework to support the process of critical reflection and understanding of online engagement](https://link.springer.com/article/10.1007%2Fs12528-021-09281-3)


TODO
====

* [pupilprogress.com](https://www.pupilprogress.com/)
    * online exam board specifc tracking tool
    * looks like 'data entry the profession'

* Grade Inflation
    * [analytics.ofqual.gov.uk](https://analytics.ofqual.gov.uk/apps/Alevel/Outcomes/)
        * in 2020 A's and A* went from 3% to 20%?
    * [BBC: First-class degrees more than double in a decade](https://www.bbc.co.uk/news/education-61422305)
        * [Analysis of degree classifications over time: Changes in graduate attainment from 2010-11 to 2020-21](https://www.officeforstudents.org.uk/publications/analysis-of-degree-classifications-over-time-changes-in-graduate-attainment-from-2010-11-to-2020-21/)
    * [The great university con: how the British degree lost its value](https://www.newstatesman.com/politics/2019/08/the-great-university-con-how-the-british-degree-lost-its-value) - Never before has Britain had so many qualified graduates. And never before have their qualifications amounted to so little. 

* [TES: How do GCSE and A-level grade boundaries work?](https://www.tes.com/magazine/analysis/secondary/how-do-gcse-and-level-grade-boundaries-work)

* gov.uk [Collection - Statistics: initial teacher training](https://www.gov.uk/government/collections/statistics-teacher-training)

* [Putting Evidence to Work – A School’s Guide to Implementation](https://educationendowmentfoundation.org.uk/education-evidence/guidance-reports/implementation)

* [FTT Education Data Lab](https://ffteducationdatalab.org.uk/) - Stats about UK education
