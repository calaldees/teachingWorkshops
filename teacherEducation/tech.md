Technologies for Teaching Computing
===================================

TODO:
* [Using Digital Technology to Improve Learning](https://educationendowmentfoundation.org.uk/education-evidence/guidance-reports/digital)

ITT CCF
* > 2.2 Secure subject knowledge helps teachers to motivate pupils and teach effectively


Async Tasks
-----------

### Task 1 - Microbit
[microbit](../physicalProgramming/microbit/README.md)


### Task 2 - TinkerCAD (30mins to 1hour)

* [TinkerCAD](https://www.tinkercad.com/)
    * Signup
    * Look at Starter, Lessons, [Projects](https://www.tinkercad.com/learn/circuits/projects)
        * Try `Blink an LED With Digital Output` Project
    * (Without tutorial notes)
        * From the TinkerCAD dashboard - select [Circuits](https://www.tinkercad.com/dashboard?type=circuits&collection=designs) -> Create new circuits
        * Click on `components` -> `Arduino` -> (get a simple template like `blink` or `button`) -> Click `code` -> Switch mode from `blocks` to `text` -> Click `start simulation`
    * Explore?
* Consider possible activities/use in the classroom to be discussed with group

### Task 3 - Virtualisation (30min to 1hour)

School computers are often managed machines. Students are unable to install new tools. 
This makes computing teaching problematic as you constantly need to experiment with a range of tools.
Students also need network access to run their own servers/ports.
If you as a teacher were in control and managed the base VM image, you could install new tools as-and-when needed.

* This task is to
    * Give you experience of virtualisation (if you have not done this before)
    * Show you have a VM can give your teaching flexibility with installing _libraries_ and other support tools
    * (If you are not familiar with VM's I suggest this is a skill that you develop and investigate. Get as far as you can)
    * (extension) check the extension below if you're hardcore enough

* Download [Ubuntu Desktop iso](https://ubuntu.com/download/desktop/) (3GB)
    * I suggested ubuntu as it has out of the box vm guest integration. You can use another variant should you wish.
* Setup a linux VM from your image
    * Suggest [VirtualBox](https://www.virtualbox.org/) or [HyperV](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v)
        * Or other virtualisation software of your choice.
    * Gotchas
        * `vt-x` may need to be [enable in your bios](https://2nwiki.2n.cz/pages/viewpage.action?pageId=75202968)
        * HyperV may need to be [installed/activated](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v) 
            * Note that HyperV is not available on Windows 10 "Home" (only in pro/enterprise/education).
* Attempt to run the following `python` program
    * You should be able to launch a terminal
        * If you don't know your way around a bash prompt I strongly advise you to learn the basics
    * ?You may need to install `python3-pip` for your distribution. (`sudo apt-get update && sudo apt-get install python3-pip`)
    * ```bash
        curl -O "https://raw.githubusercontent.com/calaldees/TeachProgramming/master/teachprogramming/static/projects/data/elavation.py"
        curl -O "http://shadedrelief.com/natural3/ne3_data/8192/elev_bump_8k.jpg"
        pip3 install pillow
        python3 elavation.py
      ```
    * you can read the code at [elavation.py](https://github.com/calaldees/TeachProgramming/blob/master/teachprogramming/static/projects/data/elavation.py)

* (extension) for the hardcore - These are discussions to have with your school technicians
    * Consider a VM solution that would allow a student to take a VM on a USB3 stick between home and school. What tools would need to be installed. How quickly/simply could this VHD be mounted/used? any tech ideas?
    * Consider VM's starting up with 2 network adaptors
        1. A NAT network adaptor for general internet access and package downloads
        2. A bridged network device on a separate subnet. 
        * Could this be done? Could a class set of VM's have unfiltered access to this subnet. That way students could run their own web-servers/port-scanners without affecting the real school network. What would this configuration look like?
    * If you were to create a base VM image, how would this be distributed around the network/school machines? Would the binary image be deployed to all machines overnight? Would each machine just mount a network image and use some filesystem layer to store data deltas on the local machine?

---

Lecture (sync) 1hour?
==============


Browser Based - Development environments
----------------------------------------

* Benefits
    * Students use at school/home without any installation/setup
    * home/school always has data synced
    * Pair programming
    * Range of languages
    * Mostly free services (many require login but can be used with existing school google, github, microsoft logins)
* Drawbacks
    * Must have a (reliable) web connection

* Technologies
    * Browser
        * [repl.it](https://repl.it/)
            * an education revolution
            * requires login (kind of grumpy about this)
            * (Has a paid-for school class system for projects/sumbissions/annotations/feedback $1000 per year per school)
        * [Coding Ground](https://www.tutorialspoint.com/codingground.htm)
            * login required to share
        * [CodeHS](https://codehs.com/) - Code Highschool
            * Computer science classroom in a box - lessons, courses, videos, management system, online browser ide, submission
            * no login required
            * code can be viewed (not live) without login
        * [trinket.io](https://trinket.io/)
        * [sharepad.io](https://www.sharepad.io/) - python, java, c, c++ - live share + link share
        * [SmallBASIC](https://SmallBASIC.com/) [live](https://superbasic-v2.azurewebsites.net/) - Microsoft
        * [create.withcode.uk](https://create.withcode.uk/) - python
        * [w3schools.com](https://www.w3schools.com/) - live tryit
            * html
                * [w3schools tryit svg example](https://www.w3schools.com/graphics/tryit.asp?filename=trysvg_circle)
        * Other
            * [gist.cafe](https://gist.cafe/) - runnable snippets on the web
        * [play.golang.org](https://play.golang.org/)
    * Online IDE
        * [GitPod](https://www.gitpod.io/)
            * Browser based fully remote dev environment
            * OVERKILL for ks3/ks4 - but interesting for professional developers and ks5
        * [CodeTasty](https://codetasty.com/)
        * [The 13 Best Browser IDEs Every Programmer Should Know About](https://www.makeuseof.com/tag/programmer-browser-ides/)


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


Machine Virtualisation
----------------------

* Technologies
    * VirtualBox
    * HyperV (Built in to Windows 10 Pro)

* `vt-x` hardware virtualisation extensions (REALLY important)
    * May need to be enabled in BIOS

* Virtual linux
    * You can manage the virtual hard disk image
    * Update central image and distributed to machines?
    * As a computing teacher - This means you don't need to badger technicians for every package installation
* Whole class teaching - with technician support
    * Could put VM's on a different subnet for full port access between VM guests
* Encourage students to make a VM - they can move the VM between machines
    * even bring it into school on USB (virtualbox) - (need more investigation)


Digital poverty
---------------

* The poorest low ability children will be hit hardest by the digital divide.
* How do we consider _inclusion_ for:
    * engaging out of school hours
    * remote teaching?
* To progress with computing they need their own dev machine at home. Hardware is expensive.

Task: (10min) What is the cheapest possible _general purpose_ computer you could recommend to a student?
Share links in shared doc

Even if they have a machine - what about internet connectivity?

### New
* Raspberry Pi 4 (4GB) £50 + Power/Heatsink/Keyboard/Mouse/Storage £25 - [Screen](https://www.amazon.co.uk/AOC-e2270Swdn-Widescreen-Monitor-1920x1080/dp/B016UPDUBO/) [2](https://www.amazon.co.uk/Lenovo-ThinkVision-T2054p-19-5-Monitor/dp/B08JCRC87W/) £60 = Total £135?
    * PS3 EyeToy Camera (£5)
    * Modular (Upgradable / Replaceable)
    * Almost Indestructible
    * Not (as) portable as a laptop
    * Linux only
* 13inc laptop - £170? (with webcam)
    * Builtin speakers, webcam, screen
    * Portable - Can move to a quiet room to code - can take their dev environment with them
    * When it gets damaged - whole thing is disposed-of/unusable
    * Windows or Linux
        * Low spec machines will benefit from linux in performance
* [eBay removing listed for Raspberry Pi](https://twitter.com/lbhq/status/1323482627681198080) because they COULD be used as a computer

### Old
* The school will throw away old tech
    * But they can't give it students
        * Support of machines? Software licence (windows?) Disposal of Data?
        * Grey area
* Motivated kids are good at scavenging - some kids need support with this


Unsorted
========

* [Investigating Novice Programmers' Interaction with Programming Environments](https://dl.acm.org/doi/10.1145/3304221.3325596) 2019

[//begin]: # "Autogenerated link references for markdown compatibility"
[_software]: _software.md "Education Software"
[//end]: # "Autogenerated link references"