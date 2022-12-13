Pair Programming (1 Hour)
-------------------------

* ITT CCF 4.9 #4-Classroom-Learn-that-9-group_pair_guidance
    * Paired and group activities can increase pupil success, but to work together effectively pupils need guidance, support and practice
* ITT CCF 4.10 #4-Classroom-Learn-that-10-group_pair_monitor
    * How pupils are grouped is also important; care should be taken to monitor the impact of groupings on pupil attainment, behaviour and motivation.
* 4 Lear how .. #4-Classroom-Learn-how-12-group_pair_guidance #4-Classroom-Learn-how-13-increase_focus
* Stimulate pupil thinking and check for understanding, by:
    * Discussing and analysing with expert colleagues how to consider the factors that will support effective collaborative or paired work (e.g. familiarity with routines, whether pupils have the necessary prior knowledge and how pupils are grouped).
    * Receiving clear, consistent and effective mentoring in how to provide scaffolds for pupil talk to increase the focus and rigour of dialogue.
* ITT CCF 5.5
    * Flexibly grouping pupils within a class to provide more tailored support can be effective, but care should be taken to monitor its impact on engagement and motivation, particularly for low attaining pupils
* iCCF Learn How
    * Discussing and analysing with expert colleagues how to consider the factors that will support effective collaborative or paired work (e.g. familiarity with routines, whether pupils have the necessary prior knowledge and how pupils are grouped).


* [YouTube code.org - Pair Programming - example](https://www.youtube.com/watch?v=vgkahOzFH2Q) 3min
    * Do's and Don't list

* Overview
    * [Quick Read: Using pair programming to support learners](https://blog.teachcomputing.org/quick-read-pair-programming-supports-learners/) 2019 NCCE - 2 page A4
        * (I'm not fond of driver+navigator - see my comments below)
    * [khanacademy.org - Pair programming in the classroom](https://www.khanacademy.org/khan-for-educators/resources/teacher-essentials/teaching-computing/a/pair-programming-in-the-classroom?modal=1)
        * [Pair Programming-in-a-Box: The Power of Collaborative Learning](https://www.ncwit.org/resources/pair-programming-box-power-collaborative-learning) - National Center for Women in IT
* Tech
    * Remote code tools
        * [repl.it](https://repl.it/) - ks3/ks4
        * [GitPod.io](https://gitpod.io) - full VSCode dev env in the cloud (ks5?)
        * [Visual Studio Live Share](https://visualstudio.microsoft.com/services/live-share/)
            * [Collaboration made easy with Visual Studio Live Share](https://www.youtube.com/watch?v=9QXwSg9-2qQ) YouTube Video
    * One dev-environment - multiple inputs
        * Single machine with two keyboards plugged in

### Benefits
* Social communication
    * Historically/traditionally not a skill that a _reclusive self taught programmers_ had
        * Communication is important - challenge the stereotype
            * (Simplified) Girls are socially trained to be _perfect_ and not make mistakes.
                * Solo coding his hard and a personal threat.
    * Is expected skill/behaviour in industry
    * Coding IS a social profession
        * Building ANYTHING of significant value requires more than one person
* Spend less time _blocked_
    * (Struggling/grappling with a concept is not the same as blocked)
* Share failure and Share success leads to More frequent success
* Re-enforce concepts by having to articulate them
* Natural practice for technical language

### Drawbacks
* It DOES take longer (although the quality of the solution is better)
* It requires training and practice (it wont work first time)
    * Delicate and intricate social management (know your class before you do this)
        * Assign pairs beforehand

### My experience of pair programming as a professional developer

* I cant express the joy and safety of coding shoulder to shoulder with my colleges
* We were both constantly learning
* We channelled each others ideas
* Senior members of the team shared insights and reasons for decisions
    * The presence of one senior made all other developers better (zone of proximal development)
* Weaker members asked questions and grew
    * If a juniors didn't understand the code then it had to be made simple enough and commented enough for them to understand
* Code was overall of a higher quality
* I felt like part of a team
    * I grew
    * I learnt
    * I shared
* I feel alive (human), connected and safe when pair programming

### Rules/Notes/Guide for Pair programming 

* [Summary of A Comparison of Two Pair Programming Configurations for Upper Elementary Students](https://blog.teachcomputing.org/summary-of-a-comparison-of-two-pair-programming-configurations-for-upper-elementary-students/)
    * Pair programming with primary students
    * 2 Computers + live edit tooling
    * Research categorised 3 types of conversations
        * Exploratory conversation - learners challenge each other, offering explanation and alternative ideas.
        * Cumulative conversation - learners seek to avoid conflict and therefore converse uncritically.
        * Disputational conversation - learners tend to have unresolved disagreements.

* Do 50% of the typing (really try to keep to this)
* Do 50%ish of the talking
    * If you talk more than 75% of the time - ask your partner questions
* One person can be coding while another looks something up (make sure you both fully understand the code when you return)
* We should never ridicule each other for mistakes, even in a joking way (from list below)
* [Formative Teaching Methods - Geoff Petty Jan 2004](http://geoffpetty.com/wp-content/uploads/2012/12/FormativeTeachingMethods2.doc) - from [Active Learning](http://geoffpetty.com/for-teachers/active-learning/)
    * We will learn best if we all agree that:
        * It’s okay if you don’t fully understand a concept first time, learning takes time
        * If work is graded, aim to beat your own record, not someone else’s
            * However, grading should be avoided where possible
        * What counts is whether you understand the problem and solution, or question and answer eventually:
            * not whether you got it right first time
            * not whether you got it wrong just because of a silly slip
        * It is not humiliating to make a mistake
            * We all make mistakes when we learn
            * Indeed is part of how we learn
            * If we don’t make mistakes the work is too easy for us to learn at our maximum rate
        * Mistakes are useful because they tell us where we can improve
        * Its good for learning to admit to not understanding and to admit to mistakes and then ask for clarification
        * we should never ridicule each other for mistakes, even in a joking way
        * You will learn from mistakes if you find out how to do it without mistakes next time, and really understand this

* [Tuple's Pair Programming Guide](https://tuple.app/pair-programming-guide/) - the case for professional pair programming and guide
    * [Pair Programming Antipatterns](https://tuple.app/pair-programming-guide/antipatterns)
        * For navigators:
            * Leaping on errors too quickly
                * Give your driver a chance to notice their own syntax errors and typos.
                * Constantly pointing out small errors hurts flow. Yours and theirs. It may also make your pair self-conscious.
                * Remember: your job is to consider the bigger picture, not to point out misspelled words as soon as you spot them.
            * Giving low-level instructions
                * If you have a suggestion for the driver, communicate it at the highest level of abstraction they’ll understand.
                * If you find yourself dictating code (or worse, individual keystrokes), stop and see if you can communicate your idea at a higher level.
                * If that fails, ask to drive for a bit to get your idea sketched out.
            * Not bringing a keyboard
                * Bring your own keyboard to every pairing session. Plug it in before you start.
                * This makes swapping roles easier and allows you to show rather than tell when words fail.
                * Having your own mouse is nice too, but not as essential. (It’s easy to ask someone to click on something, harder to get them to type many characters.)
        * For drivers:
            * Driving too fast
                * If you’re highly proficient with your editor, it’s easy to move fast enough to lose even experienced navigators.
                * Unless you’re sure your pair is keeping up, don’t manipulate code quite as fast as you’re able.
                * It helps if you dictate what you’re doing.
            * Allowing a checked-out navigator
                * It’s easy to lose your navigator’s attention by moving too fast, or doing things they don’t quite understand.
                * If you get the sense that your pair’s attention is drifting, stop and sync up.
                * A bad question: “You understand this, right?”
                * A good question: “Which part of this is hardest to follow?”
                * !! Pairing should involve constant two-way communication. If you or your navigator has gone quiet, stop and check in. !!
            * Unequal screen access
                * Sit so that the monitor is between the two of you. Make sure both of you can see it equally well (consider bumping up font sizes).
                * If one person is tucked off to the side, it will create a subconscious unequal hierarchy.
                * A pair is a unit. Neither of you is more important.
            * Not taking breaks
                * Pairing is draining. Even more so than normal programming.
                * A nice way to ensure you take adequate breaks is to employ the Pomodoro Technique. Consider agreeing on preferred work and break lengths with your pair before you start.
            * Listening without hearing
                * It’s hard to listen and type at the same time.
                * If your navigator is making a suggestion, consider taking your hands off the keyboard. Even better: turn and make eye contact.
        * For both:
            * Allowing unproductive distractions
                * Before you start pairing, disable all notifications (on your computer and phone).
                * A pairing session should be interrupted by exactly zero Slack notifications or text messages. If one slips through, apologize and disable future ones.
                * Don’t leave your email open on another monitor.
                * (You should do the above even when you’re not pairing. The quickest way to improve programming productivity is to reduce interruptions.)
            * Not swapping roles
                * Driving and navigating are draining for different reasons.
                * Swapping roles lets you rest the tired parts of your brain and activate the idle ones.
                * Swapping drivers is a great way to energize a pairing session that’s losing steam. Consider setting a timer to indicate every time it’s time to switch.
            * Forgetting it’s a skill
                * Pair programming is a skill which must be learned.
                * You will not be good at it at first, but consistent practice will yield improvements.
                * Don’t give up after a difficult first experience. Don’t assume experienced developers are automatically good pairing partners. Don’t expect to be good without practice.
                * Consider reflecting with your pair or asking for feedback after each session. What could have been better?

* [Collaborative Behaviors Patterns of Students in Programming Instruction](https://journals.sagepub.com/doi/full/10.1177/07356331211062260) 2022, Hopcan, Polat
    *  During the program development process, students hesitated to create an algorithm and to improve an existing one while proposing the next step.
    *  In addition, they constantly waited for approval. 
    *  Collaborative behaviors such as giving and receiving feedback and helping other partners were less observed in females.
    *  Significant sequential driver and navigator behaviors were presented
    *  (This reinforces that pair programming is a skill, it needs to be developed, it probably wont be effective first time)



Extra: some of my thoughts
--------------------------

* 'Driver + Navigator' may be too ridged - maybe should be more fluid - equal party's - two inputs
* Code is a team sport in industry - education should match
* Pair programming takes longer - Quality of solutions is better
* Students have to be explicitly taught how to communicate - words parses
    * Explicitly highlight the 3 types of communication - cumulative, disruptive, exploratory - get pairs to self identify these
    * "What are we trying to do here?"- Clarify/communicate inputs and outputs (goal)
    * What data are we storing/using/remembering?
    * Don't use "No" - (stretch vocabulary) use - unlikely, probably not, unsure, possibly
        * Psychology of "Yes and" in improvisation
        * (Can't say "Yes" too much either - maybe add justification as to why 'yes')
    * You may not _like_ your partner. I don't _like_ all the other teachers, but I work with them. Develop professional working practices - you will have to work professionally with people you don't like in future.
    * Add your thoughts as comments
    * Advanced must explain - weaker must ask clarifications
    * Identify and praise/highlight/reaffirm good use of language
* strategies
    * rotate partners - induct/explain to your new partner (peril - ownership of login)
    * At the end of a pair session
        * explicitly get students to highlight one good and one bad from the list from "Tuple's Pair Programming" list
        * Have this captured somewhere!
        * Refer to this before the next pair programming session

Task
----

* Option 1 : One Machine + two keyboards (no login required)
    * [tutorialspoint.com/codingground](https://www.tutorialspoint.com/codingground.htm)
    * [OneCompiler](https://onecompiler.com/) pre-readline
    * [mycompiler.io](https://www.mycompiler.io/) pre-readline
    * [w3schools.com/tryit](https://www.w3schools.com/tryit/trycompiler.asp?filename=demo_python) no-readline
* Option 2 : Live Share
    * [repl.it](https://repl.it/) (login with github)
        * Create a new repl
        * Get share link and share with your partner
            * you need to create an account for this feature
            * only one of your pair needs to do this
        * Have voice comms
* Try to pick a language you have not used before
    * I have solutions/stubs for `java`, `csharp`, `python`, `javascript`
* Requires understanding of:
    * Define variables (`bool`, `string`)
    * Get index from an array
    * `for` loop and `while` loop
    * Concatenate strings
    * Compare strings
* Cheat Sheets
    * https://computingteachers.uk/static/langauge_reference.html
    * [Code-cademy - All Cheatsheets](https://www.codecademy.com/resources/cheatsheets/all)
* ADVANCED: If you are HARDCORE you could create a stub and solution for another language (`c`, `ruby`, `golang`, `rust`, `php`) - I would love to see some of these! please make a GitHubPR!


### Complete working example (for a language not supported in repl)

```vb
Module VisualBasic

    Sub Main()
        Dim data() as String = {"b", "d", "c", "a"}
        data = bubbleSort(data)
        Console.WriteLine(Join(data, ","))
    End Sub

    Function bubbleSort(data as String()) As String()
        Console.WriteLine("bubbleSort")
        Dim has_changed as Boolean = True
        Do While has_changed
            Console.WriteLine(Join(data, ","))
            has_changed = False
            For i As Integer = 0 To data.Length - 2
                Dim a as String = data(i)
                Dim b as String = data(i+1)
                Console.WriteLine("comparing "+i.toString()+":"+a+" with "+(i+1).toString()+":"+b)
                If a > b Then
                    Console.WriteLine("swap")
                    data(i) = b
                    data(i+1) = a
                    has_changed = True
                End If
            Next
        Loop
        bubbleSort = data
    End Function

End Module
```
### Output (to help you)
```txt
bubbleSort
b,d,c,a
comparing 0:b with 1:d
comparing 1:d with 2:c
swap
comparing 2:d with 3:a
swap
b,c,a,d
comparing 0:b with 1:c
comparing 1:c with 2:a
swap
comparing 2:c with 3:d
b,a,c,d
comparing 0:b with 1:a
swap
comparing 1:b with 2:c
comparing 2:c with 3:d
a,b,c,d
comparing 0:a with 1:b
comparing 1:b with 2:c
comparing 2:c with 3:d
a,b,c,d
```

### Stub Programs

Copy and paste this starting code into your repl for the correct language

#### python
```python
def bubbleSort(data):
    print('bubbleSort')
    # CODE GOES HERE!
    return data

if __name__ == '__main__':
    data = ['b', 'd', 'c', 'a']
    data = bubbleSort(data)
    print(data)
```

#### csharp
```csharp
using System;

class MainClass {

  public static void Main (string[] args) {new MainClass();}
  public MainClass() {
    string[] data = new string[]{"b", "d", "c", "a"};
    data = bubbleSort(data);
    Console.WriteLine(String.Join(",", data));
  }

  String[] bubbleSort(String[] data) {
    Console.WriteLine("bubbleSort");
    // CODE GOES HERE!
    return data;
  }

}
```

#### java
```java
class Main {

  public static void main(String[] args) {new Main();}
  Main() {
    String[] data = new String[]{"b", "d", "c", "a"};
    data = bubbleSort(data);
    System.out.println(String.join(",", data));
  }

  String[] bubbleSort(String[] data) {
    System.out.println("bubbleSort");
    // CODE GOES HERE!
    return data;
  }

}
```

#### javascript
```javascript
function bubbleSort(data) {
    console.log('bubbleSort');
    // CODE GOES HERE!
    return data
}

data = ['b', 'd', 'c', 'a'];
data = bubbleSort(data);
console.log(data);
```


Further discussion
------------------

* Summative assessment of pair work?
    * Is fraught with peril. Can it even be done?
* Formative assessment of pair work?
    * ?


Unsorted
========


Pair Programming
----------------

* Pair programming IS slower - but the quality of the result is higher
* Aim to
    * Talk 50% of the time
    * Type 50% of the time
* Methods
    1. Plug two keyboards into one machine
    2. Take turns with keyboard (driver and navigator)
    3. Live share
* Don't use the word "No" - (stretch your vocabulary) use - unlikely, probably not, unsure, possibly
    * Psychology of "Yes and" in improvisation
* You may not _like_ your partner - you have to communicate professionally
* Choice of partner
    * This week: You choose your partner
    * Next week: I will allocate you a partner
* Focus talk on "the problem"
