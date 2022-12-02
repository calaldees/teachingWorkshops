
* [NCCE - Quick Read: Physical computing](https://blog.teachcomputing.org/quick-read-physical-computing/)
* ![quick-read-physical-computing diagram](https://blog.teachcomputing.org/content/images/2021/09/QR_16_Diagram_A.png) Hodges Sentence, Finney and Ball 2020

* [The Basics Of Persistence Of Vision Projects](https://hackaday.com/2019/10/29/the-basics-of-persistence-of-vision-projects/)


* [Program Comprehension with Physical Computing: A Structure, Function, and Behavior Analysis of Think-Alouds with High School Students](https://dl.acm.org/doi/10.1145/3430665.3456371) Jayathirtha & Kafia 2021
    * we qualitatively analyzed think-aloud interview videos of 22 high school students individually comprehending a given text-based Arduino program while interacting with its corresponding functional physical artifact 
        * 1. How do novices comprehend the given text-based Arduino program? 
        * 2. What role does the physical artifact play in program comprehension?
    * We found that novices mostly approached the program bottom-up, initially comprehending structural and later functional aspects, along different granularities. 
    * The artifact provided two distinct modes of engagement, active and interactive, that supported the program's structural and functional comprehension. However, behavioral comprehension i.e. understanding program execution leading to the observed outcome was inaccessible to many. 
    * Our findings extend program comprehension literature in two ways: 
        * (a) it provides one of the very few accounts of high school students' code comprehension in a physical computing context, and, 
        * (b) it highlights the mediating role of physical artifacts in program comprehension. 
    * Further, they point directions for future pedagogical and tool designs within physical computing to better support students' distributed program comprehension.
    * > . For the most part, the abstract run-time program behavior i.e. comprehending data and control flow was inaccessible to the novices
    * the invisible abstract program behavior was hard to comprehend. This points to a need to explicitly support novices in computing classes to understand run-time program behavior. Guiding students to understand program dynamics at appropriate levels of abstractions, also called #notional-machines
    * Their limited success with reasoning program behavior calls for explicit integration of #notional-machines within programming education


Physical 
---------

A different slant on computing. Away from the screen, keyboard and mouse
Manifest your code in the real world!

* [NCCE - Quick Read: Physical computing](https://blog.teachcomputing.org/quick-read-physical-computing/)

### Lego Mindstorms - Robotics

* [Lego Mindstorms](https://www.lego.com/en-gb/themes/mindstorms)
    * £300 a kit
    * Robot can store multiple programs and selected with interface -> recombination attachments -> physical creative thinking
* [FIRST Lego League](https://www.firstlegoleague.org/)
    * [Institute of Engineering and technology - Find a tournament near you! - FIRST® LEGO® League programmes FIRST® LEGO® League Challenge (9-16)](https://education.theiet.org/first-lego-league-programmes/challenge/find-a-tournament-near-you/)
        * Hosted at the University of Kent
    * [2020 Challenges description video](https://www.youtube.com/watch?v=QeN0hkyF5XQ) (6min)
        * [405pt](https://www.youtube.com/watch?v=OVtsmME6S9Q) (2min)
        * [305pt](https://www.youtube.com/watch?v=iIAiIwWNcas) (2min 30sec) actual competition
    * Lots of time/money/logistics investment (only a handful of students benefit)
    * Extra curricular only
    * Looks AMAZING at open evening
    * [Are computing competitions worth the effort?](https://helloworld.raspberrypi.org/articles/are-computing-competitions-worth-the-effort)
* See also
    * Battlesnake, yare.io, [[_software]]

### Cool hardware

* Barcode scanners
    * Checkout project demo?
    * [The Barcode Pony, or: How To Actually Scan A Zebra](https://www.youtube.com/watch?v=3VcgW_AdDPw) YouTube 3h
* Thermal receipt printers
* Thermal camera
* USB microscope
* RFID reader (coupled with thermal printer!!)
* Magnetic card reader/writer


### Micro-boards

#### Microbit

more [microbot](../physicalProgramming/microbit/README.md)

* Possible use for whole class teaching because of good web simulators
    * You don't need physical devices for every student (they can share - in non covid times)
* Block + Python + Javascript
    * Differentiation + Progression

TASK 10min?
* From your async task exploration - possible project ideas?


#### Arduino - Adafruit Circuit playground

more [arduino](../physicalProgramming/arduino/README.md)

* Physical device needed - whole class set required
* Good introduction to `C`

#### TinkerCAD

* [TinkerCAD](https://www.tinkercad.com/)
    * Breadboards and circuit design. Combine code and electronics
    * `C` in the browser. Blocks for beginners
    * Suitable for whole class teaching
    * Surprisingly high skill ceiling! Used at universities for teaching electronic design

TASK 10min?
* From your async task exploration - possible project ideas?

### Other

* [xod.io](https://xod.io/) - A visual programming language for microcontrollers - browser IDE
* [webduino.io](https://webduino.io/en/) - chinese microbit - much more versatile
    * online ide + simulator + tasks/lessons


### Raspberry Pi

Extra curricular - not really suitable to full class teaching

* Need access to keyboard, mouse, monitor, power
    * Some schools have 'all in one' machines so screens can't be reused
    * USB ports (for keyboard/mouse) may not be accessible for school machines
    * Frequent use of USB ports can damage with ports (kids are fairly heavy handed)

* Network use in a school
    * MAC address's of devices may be blocked or applied to quarantined network
    * School WiFi may not be possible (passwords?)
        * Separate wifi?
        * Your own reconfigured router? (no internet?)
    * Your own physical network (They LOVE this)
        * Consider your own DHCP server (use an old home wireless router?)
            * problems with genuine external access
                * To install packages + reach documentation
        * Manual entry of IP address's and subnets

* £70? Machine only
    * £50 Raspberry Pi 4 (4gb)
    * £10 Heatsync
    * £5 power
    * £3 to £15 per pupil XD-card/USB3-storage
