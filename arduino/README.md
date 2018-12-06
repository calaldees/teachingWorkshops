Arduino
=======


Hardware
--------

[Adafruit Circuit Playground](https://www.adafruit.com/product/3000)
* 10 RGB leds
* 2 buttons
* 1 switch
* buzzer
* Light sensor
* Temperature sensor
* Sound sensor
* Motion x,y,z


IDE
---

### Install

Use a package manager

```bash
    choco install arduinoide
    brew install arduinoide
    apt-get install arduinoide
```

or download [ArduinoIDE](https://www.arduino.cc/en/Main/Software) for your platform.

#### Raspbery Pi 3

```bash
    #sudo apt-get install arduino  # Fails - v1.0.8 - does not have AdaFruit libs
    # Enable UART
    nano /boot/config.txt:
      core_freq=250
      enable_uart=1
    # Download 'Linux ARM' manually (1.8.7+) - extract to permanent location - `sudo ./install.sh`
```


### Setup Arduino IDE

* Sketch
    * Include Library
        * Adafruit Circuit Playground
* Tools
    * Board: Adafruit Circuit Playground
    * Port: COM3 (Adafruit Circuit Playground)


Command Reference
------------------

* [Arduino Language Reference](https://www.arduino.cc/reference/en/)
* [Adafruit Library Reference](https://github.com/adafruit/Adafruit_CircuitPlayground/blob/master/Adafruit_Circuit_Playground.h)


Example Program
---------------

```c++
#include <Adafruit_CircuitPlayground.h>
#include <Adafruit_Circuit_Playground.h>

bool running = false;

void setup() {
  // put your setup code here, to run once:
  CircuitPlayground.begin();
}

void loop() {
  if (CircuitPlayground.leftButton()) {
    running = !running;
    delay(1000);
  }
  if (running) {
    run();
  }
}

void run() {
  if (CircuitPlayground.leftButton()) {
    CircuitPlayground.playTone(262, 100);
  }
  if (CircuitPlayground.rightButton()) {
    CircuitPlayground.playTone(300, 100);
  }
  Serial.println( CircuitPlayground.motionY() );
  int tone = map(
    CircuitPlayground.motionY(),
    -10, // fromLow
    10, // fromHigh
    200, // toLow
    400 // toHight
   );
  CircuitPlayground.playTone(tone, 100);
  //delay(100);
}
```

Activity Ideas
--------------

* Simple
    * Turn LED on
    * Play sound
    * Read sensor to Serial Monitor
    * Read multiple sensors to Serial Plotter
* Medium
    * Play sound based on y axis
    * Turn on/off with switch
    * Cycle colours in loop
    * Clap and it beeps back
    * Christmass songs
* Advanced
    * Quickdraw game
    * Sound level meter
    * Operation (game, crocodile clips)
    * Rock paper scissors - light sensor
    * Music color player
    * Bop it


```c++
  Serial.print( CircuitPlayground.motionX() );
  Serial.print(",");
  Serial.println( CircuitPlayground.motionY() );
```