Technologies for Teaching Computing
===================================

Async Tasks
-----------

### Task 1 - Microbit (1 hour)
1 hour
Investigate 
* what is a microbit?
* What sensors does it have
    * look at a list of project ideas for those sensors
        * Door alarm? Nightlight?
* Using the makecode browser simulator
    * Make a program that when you press a button it cycles through 3 custom mini graphics that you have created
        * Hint: You will need a variable 0 to 2 and use the modula operator to cycle this value
    * Switch the view to javascript or python and look at the code
    * Make a program that when you tilt the device it sends a number via radio to another virtual microbit and displays that number
* Consider possible activities and use in the classroom to discuss with group

### Task 2 - Virtualisation (1 hour)
* This task is to
    * Give you experience of virtualisation (if you have not done this before)
    * Show you have a VM can give your teaching flexibility with installing libraries

* Download Ubuntu Desktop iso (3GB)
    * I suggested ubuntu as it has out of the box vm guest integration. You can use another variant should you wish.
* Use [VirtualBox](https://www.virtualbox.org/) or [HyperV](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v) to boot a VM
    * vt-x may need to be [enable in your bios](https://2nwiki.2n.cz/pages/viewpage.action?pageId=75202968)
    * HyperV may need to be installed/activated (Note that HyperV only available in Windows10 Pro/Enterprise)
    * If you have experience of one of these virtualisation technologies I encourage you to trial another
* Attempt to run the following python program
    * [elavation.py](https://github.com/calaldees/TeachProgramming/blob/master/teachprogramming/static/projects/data/elavation.py)
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

### Microboards

#### Microbit

Posisble use for whole class teaching because of good web simulators.
You don't need physical devices for every student (they can share - in non covid times)

Block + Python + JS


#### Arduino - Adafruit Circitplayground

Physical device needed - whole class set required

### Raspberry Pi


Extra curricular - not really suitable to full class teaching

* Need access to keyboard, mouse, monitor, power
* Some schools have 'all in one' machines so screens can't be reused used
* USB ports (for keyboard/mouse) may not be available

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
* £3 to £10 per pupil XD card



Physical network
Separate WiFi (technitials?)

Machine Virtualisation
----------------------

VirtualBox
HyperV

vt-x hardware virtulisation extensions (REALLY important)
May need to be enabled in bios

linux
You can manage the virtual hard disk image
Update central image and distributed to machines?
This means you don't need to badger technitians for every package installation

Whole class teaching - with technitian support

Could put VM's on a differnt subnet for full port access between VM guests

Encourage students to make a VM - they can move the VM between machines - even bring it into school on USB (virtualbox)


Access to computing tools (the class divide and resourcing)
-----------------------------------------------------------

To progress with computing they need their own dev machine at home.

Hardware is expensive

### New

RaspberryPI4 + Keyboard + mouse + screen = £150

Entry level laptop £150 to £200
Will benefit from linux in performance
Help installing linux


### Old
The school will throw away old tech
But they can't give it students
Grey area
