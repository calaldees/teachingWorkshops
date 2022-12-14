Microbit
========

Physical computing is a way to manifest code in the 'real world' and can engage more learners.
Microbits are a small physical programmable device with lots of built in sensors and a very capable web simulator that allows students to run/debug code without needed a without needing a whole physical set of devices for your class.

* [microbit.org](https://microbit.org/)
    * Features
        * 2 Buttons
        * Crocodile clip access
        * 25 pixel display (can scroll text + display primitive graphics)
        * [Sensors](https://microbit.org/get-started/first-steps/sensors/) + activities
            * Acceleromiter (level sensor), Temperature, Light, Compass
        * Radio
        * [Local Persistent File System](https://microbit-micropython.readthedocs.io/en/v1.0.1/filesystem.html)
            * 30k - python
        * v2 (most are v1)
            * builtin speaker and microphone
    * [MakeCode](https://makecode.microbit.org/) Online Editor + Courses + Lessons
    * [MicroPython](https://microbit-micropython.readthedocs.io/en/latest/)
    * Lessons
        * [Digital Technologies Hub](https://www.digitaltechnologieshub.edu.au/teachers/lesson-ideas#/) Australia - Lesson Plans
            * https://www.digitaltechnologieshub.edu.au/teachers/lesson-ideas/morse-code-network
        * [BBC microbit Lessons for Micro Python](http://physicalcomputing.co.uk/2017/01/11/bbc-microbit-lessons/)
        * [BBC micro:bit MicroPython documentation](https://microbit-micropython.readthedocs.io/en/latest/index.html)
        * [nominetresearch Lessons](https://microbit.nominetresearch.uk/)
            * [Handling Errors: Retransmissions](https://microbit.nominetresearch.uk/networking-book-online/retransmissions/retransmissions/)
        * [mytechnotalent/Python-For-Kids](https://github.com/mytechnotalent/Python-For-Kids) A comprehensive Python Development tutorial FOR KIDS utilizing a micro:bit Development Board going step-by-step into the world of Python for Microcontrollers
    * [101computing.net micro:bit](https://www.101computing.net/category/bbc-microbit/)
    * Projects
        * [projects.raspberrypi.org microbit](https://projects.raspberrypi.org/en/projects?hardware[]=microbit)
            * [Against the Clock](https://projects.raspberrypi.org/en/projects/against-the-clock)
* [microbit2](https://tech.microbit.org/latest-revision/announcement/)
    * gesture recondition
    * voice recognition?


Async Tasks
-----------

### Task 1 - Microbit (30mins to 1hour)

There are a range of small computer boards that are programmable with c/python/etc that can attach to LEDs/Motors/Sensors.
These educational tools take code off the desktop screen and into the physical world.

* This task is to
    * Give you experience of a popular education board the microbit

1 hour
Investigate 
* What is a [microbit](https://microbit.org/)?
* What [sensors](https://microbit.org/get-started/first-steps/sensors/) does it have?
    * Look at a list of project ideas for those sensors
        * Door alarm? Nightlight?
* Using the [makecode](https://makecode.microbit.org/) browser simulator
    * Make a program that when you press a button it cycles through 3 custom mini graphics that you have created
        * Hint: You might need a variable 0 to 2 and use the modula operator to cycle this value
    * Switch the view to javascript or python and look at the code
    * Make a program that when you tilt the device it sends a number via radio to another virtual microbit and displays that number
* Consider possible activities/use in the classroom to be discussed with group
* Start a new project, select `python` as a language nand copy/paste `rock_paper_scissors.py`. Switch to `blocks` and run the program
    * This program demos the built in networking feature
    * Reverse engineer how the game works

Stuff
-----

* Strengths
    * Multiple Languages (+trivially switch between them)
        * Blocks (like Scratch)
        * Typescript/Javascript
        * Micro Python
    * Simulator is free and accessible in browser (including simulated mutliple devices for radio)
        * Upload via USB
    * Simulator + editor available for mobile phones (blocks)
    * Emphasis on connectivity + radio + comms
    * Physical manifestiation of code
        * Car (robot)
        * Electronic circuits
    * serial [debug stream](https://support.microbit.org/support/solutions/articles/19000095729-displaying-live-serial-data-from-the-micro-bit-in-the-makecode-console-) write/read (full serial)
        * plot on graph
* Weakness's
    * Bluetooth upload is a lie/mess
        * mobile is broken on my andorid
        * web (with experimental extension `about->experimental->web-bluetooth-upload`) chrome 70+ - pairs but offers no icon/mode to upload
        * Uploading + power via USB will desintegrate the board in classroom use (too much physical use)
    * Power is clumsy
    * Expensive!!!
        * £13 per board (v1) * 30 == £390 (that's without power, usb or any additional sensors/devices) - minimum £500 for a class set

An interesting tools for transitioning from blocks to text-code. Physical manifestation of code. Difficult to perform anything complexity algorithmic due to limited IO. A useful transitional device for KS3. Great for pairing because of radio.

Build an escape room idea



Additional Sensors
* [KEYESTUDIO Sensors Starter Kit with BBC Micro:bit Board for BBC Microbit, with 45 Electronics Modules, Tutorials Coding for Kids Teens Adults](https://www.amazon.co.uk/KEYESTUDIO-Sensors-Starter-Kit-Micro/dp/B08H7VSLZH/ref=sr_1_9?dchild=1&keywords=microbit&qid=1605460287&sr=8-9)
microbit main board x1
Micro bit Sensor Shield V2 x 1
White LED Module x 1
red LED Module x 1
3W LED Module x 1
RGB LED Module x 1
Analog Temperature Sensor x 1
Photocell Sensor x 1
Analog Sound Sensor x 1
Analog Rotation Sensor x 1
Passive Buzzer module x 1
Active Buzzer Module x 1
Digital Push Button x 1
Digital Tilt Sensor x 1
Photo Interrupter Module x 1
Capacitive Touch Sensor x 1
Traffic Light Module x 1
Hall Magnetic Sensor x 1
Line Tracking Sensor x 1
Infrared Obstacle Detector Sensor x 1
PIR Motion Sensor x 1
Flame Sensor x 1
Crash Sensor x 1
Analog Gas Sensor x 1
Analog Alcohol Sensor x 1
Reed Switch Module x 1
Water Sensor x 1
Soil Humidity Sensor x 1
LM35 Linear Temperature Sensor x 1
Vibration Sensor x 1
Thin-film Pressure Sensor x 1
GUVA-S12SD 3528 Ultraviolet Sensor x 1
1602 I2C Module x 1
TEMT6000 Ambient Light Sensor x 1
HC-SR04 Ultrasonic Module x 1
Joystick Module x 1
Micro Servo x 1
Single Relay Module x 1
Steam Sensor x 1
Knock Sensor Module x 1
Digital IR Receiver Module x 1
Magic Light Cup Sensor x 2
0.96inch OLED Module x 1
L9110 Fan Module x 1
DHT11 Temperature and Humidity Sensor x 1
18B20 Temperature Sensor x 1
IR Remote Control x 1
F-F Dupont Jumper Wire 40pin x 1
USB Cable x 1
1 Premium Battery Holder 6-cell AA x 1 

