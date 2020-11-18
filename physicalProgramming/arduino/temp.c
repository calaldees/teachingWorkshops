#include <Adafruit_CircuitPlayground.h>
#include <Adafruit_Circuit_Playground.h>

short numberOfRounds = 5;
bool running;
short p1_score[5];
short p2_score[5];
unsigned long timestampRoundStart;
unsigned long timestampRoundActivate;
unsigned int roundNumber;

void setup() {
  CircuitPlayground.begin();
  randomSeed(CircuitPlayground.motionX() + CircuitPlayground.motionY() + CircuitPlayground.motionZ());
}

void reset() {
  resetArray(p1_score, 0);
  resetArray(p2_score, 0);
  roundNumber = -1;
  setAllPixels(0,0,0);
}

void loop() {
  if (CircuitPlayground.slideSwitch()) {
    run();
  } else {
    reset();
  }
 }

void run() {
  if (timestampRoundStart) {
    unsigned long timestampNow = millis();
    bool p1_pressed = CircuitPlayground.leftButton();
    bool p2_pressed = CircuitPlayground.rightButton();
    bool is_early = timestampNow < timestampRoundActivate;

    // Play sound if buzzer time passed
    if (!is_early) {
      CircuitPlayground.playTone(262, 10);
    }

    // Score
    if (p1_pressed || p2_pressed) {
      if (is_early) {
        if (p1_pressed) {
          p1_score[roundNumber] = -1;
          foulRound(1);
        }
        if (p2_pressed) {
          p2_score[roundNumber] = -1;
          foulRound(2);
        }
        showScore();
      } else {
        if (p1_pressed) {p1_score[roundNumber] = +1;}
        if (p2_pressed) {p2_score[roundNumber] = +1;}
        showScore();
      }
      startRound();
    }
  }
  else {
    startRound();
  }
}

void startRound() {
  roundNumber = roundNumber + 1;
  startRoundSound();
  showScore();
  timestampRoundStart = millis();
  timestampRoundActivate = timestampRoundStart + random(1000,8000);
}

void startRoundSound() {
  CircuitPlayground.playTone(262, 500);
  delay(500);
  CircuitPlayground.playTone(262, 500);
  delay(500);
  CircuitPlayground.playTone(362, 500);
  delay(500);
}

void showScore() {
  _showScore(p1_score, 0);
  _showScore(p2_score, 5);
  //setAllPixels(0, 255, 0);
  //CircuitPlayground.playTone(262, 500);
  //delay(500);
  
}
void _showScore(short score[], uint8_t pixel_offset) {
  for (uint8_t i=0 ; i < numberOfRounds ; i++) {
    uint8_t p = i + pixel_offset;
    if (score[i] >= 1) {
      CircuitPlayground.setPixelColor(p, 0, 255, 0);
    }
    if (score[i] <= -1) {
      CircuitPlayground.setPixelColor(p, 255, 0, 0);
    }
    if (score[i] == 0) {
      CircuitPlayground.setPixelColor(p, 0, 0, 0);
    }
  }
}

void foulRound(uint8_t player) {
  setAllPixelsForPlayer(player, 255, 0, 0);
  CircuitPlayground.playTone(200, 500);
  setAllPixels(0, 0, 0);
  delay(500);

  setAllPixelsForPlayer(player, 255, 0, 0);
  CircuitPlayground.playTone(200, 500);
  setAllPixels(0, 0, 0);
  delay(500);
}

void setAllPixels(uint8_t r, uint8_t g, uint8_t b) {setAllPixelsForPlayer(0, r, g, b);}
void setAllPixelsForPlayer(uint8_t player, uint8_t r, uint8_t g, uint8_t b) {
  uint8_t index_start = 0;
  uint8_t index_end = 10;
  if (player == 1) {
    index_start = 0;
    index_end = 4;
  }
  if (player == 2) {
    index_start = 5;
    index_end = 9;
  }
  for (int p=index_start ; p < index_end ; p++) {
    CircuitPlayground.setPixelColor(p, r, g, b);
  }
}


void resetArray(short a[], short v) {
  for (short i ; i < numberOfRounds ; i++) {
    a[i] = v;
  }
}