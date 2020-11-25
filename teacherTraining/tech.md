Technologies for Teaching Computing
===================================

Async Tasks
-----------

### Task 1 - Microbit (1 hour)

There are a range of small computer boards that are programmable with c/python/etc that can attach to LEDs/Motors/Sensors.
These educational tools take code off the desktop screen and into the physical world.

* This task is to
    * Give you experience of a popular education board the microbit

1 hour
Investigate 
* What is a microbit?
* What sensors does it have
    * look at a list of project ideas for those sensors
        * Door alarm? Nightlight?
* Using the `makecode` browser simulator
    * Make a program that when you press a button it cycles through 3 custom mini graphics that you have created
        * Hint: You will need a variable 0 to 2 and use the modula operator to cycle this value
    * Switch the view to javascript or python and look at the code
    * Make a program that when you tilt the device it sends a number via radio to another virtual microbit and displays that number
* Consider possible activities and use in the classroom to be discussed with group

### Task 2 - Virtualisation (1 hour)
* This task is to
    * Give you experience of virtualisation (if you have not done this before)
    * Show you have a VM can give your teaching flexibility with installing libraries

* Download [Ubuntu Desktop iso](https://ubuntu.com/download/desktop/) (3GB)
    * I suggested ubuntu as it has out of the box vm guest integration. You can use another variant should you wish.
* Use [VirtualBox](https://www.virtualbox.org/) or [HyperV](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v) to boot a VM
    * vt-x may need to be [enable in your bios](https://2nwiki.2n.cz/pages/viewpage.action?pageId=75202968)
    * HyperV may need to be installed/activated (Note that HyperV only available in Windows10 Pro/Enterprise)
    * If you have experience of one of these virtualisation technologies I encourage you to trial the other
* Attempt to run the following python program
    * [elavation.py](https://github.com/calaldees/TeachProgramming/blob/master/teachprogramming/static/projects/data/elavation.py)
    * You should be able to launch a terminal
        * If you don't know your way around a bash prompt I strongly advise you to learn the basics
    * ```bash
        curl -O "https://raw.githubusercontent.com/calaldees/TeachProgramming/master/teachprogramming/static/projects/data/elavation.py"
        curl -O "https://karczmarczuk.users.greyc.fr/TEACH/Imagerie.old/Images/elev_bump_8k.jpg"
        pip3 install pillow
        python3 elavation.py
      ```


Browser Based 
-------------

### Code environments

* [repl.it](https://repl.it/)
    * Discussed in previous sessions - an education revolution
    * (Has a paid-for school class system for projects/sumbissions/annotations/feedback $1000 per year per school)
* Students use at home without any installation/setup
* Pair programming
* Range of languages


Physical 
---------

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

### Micro-boards

#### Microbit

* Possible use for whole class teaching because of good web simulators.
* You don't need physical devices for every student (they can share - in non covid times)
* Block + Python + JS
    * Differentiation + Progression


#### Arduino - Adafruit Circitplayground

* Physical device needed - whole class set required
* Good introduction to `C`


### Raspberry Pi

Extra curricular - not really suitable to full class teaching

* Need access to keyboard, mouse, monitor, power
    * Some schools have 'all in one' machines so screens can't be reused used
        * USB ports (for keyboard/mouse) may not be accessible for school machines

* Network
    * MAC address's of devices may be blocked or applied to quananteened network
    * WiFi may not be possible (passwords)
    * Your own physical network (They LOVE this)
        * Consider your own DHCP server (use an old home wireless router?)
            * problems with genuine external access
                * To install packages + reach documentation
        * Manual entry of IP address's and subnets

* £50 Raspberry Pi 4 (4gb)
* £10 Heatsync
* £5 power
* £3 to £15 per pupil XD-card/USB3-storage

Physical network
Separate WiFi (speak to technicians?)


Machine Virtualisation
----------------------

* Technologies
    * VirtualBox
    * HyperV (Built in to Windows 10 Pro)

* `vt-x` hardware virtulisation extensions (REALLY important)
    * May need to be enabled in bios

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

The poorest low ability children will be hardest hit by Covid.
How do we consider _inclusion_ for remote teaching?

To progress with computing they need their own dev machine at home. Hardware is expensive.

Task: (10min) What is the cheapest possible _general purpose_ computer you could recommend to a student?
Ideas + Links on the Google Doc

Even if they have a machine - what about internet connectivity?

### New
* Raspberry Pi 4 (4GB) £50 + Power/Heatsink/Keyboard/Mouse/Storage £25 - [Screen](https://www.amazon.co.uk/AOC-e2270Swdn-Widescreen-Monitor-1920x1080/dp/B016UPDUBO/) [2](https://www.amazon.co.uk/Lenovo-ThinkVision-T2054p-19-5-Monitor/dp/B08JCRC87W/) £60 = Total £140?
    * PS3 EyeToy Camera (£5)
    * Modular (Upgradable / Replaceable)
    * Almost Indestructible
    * Not (as) portable
* 13inc laptop - £170? (with webcam)
    * Builtin wireless, speakers, webcam
    * When it gets damaged - whole thing is disposed-of/unusable
    * Will benefit from linux in performance
        * Help them install linux
* [eBay removing listed for Raspberry Pi](https://twitter.com/lbhq/status/1323482627681198080) because they COULD be used as a computer

### Old
* The school will throw away old tech
    * But they can't give it students
        * Support of machines? Software licence (windows?) Disposal of Data?
        * Grey area
* Motivated kids are good at scavenging - some kids need support
