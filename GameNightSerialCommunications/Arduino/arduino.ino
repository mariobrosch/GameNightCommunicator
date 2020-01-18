#include <TM1638plus.h>

// GPIO I/O pins on the Arduino connected to strobe, clock, data,
#define  STROBE_TM 10
#define  CLOCK_TM 9
#define  DIO_TM 8

int buzzerPin = 12;
String prevCommand = "";

//Constructor object
TM1638plus tm(STROBE_TM, CLOCK_TM , DIO_TM);

void setup() {
  Serial.begin(9600);
  Serial.setTimeout(50);
  pinMode (buzzerPin, OUTPUT);
  digitalWrite (buzzerPin, HIGH);
}

void loop() {
  uint8_t buttons = tm.readButtons();
  processButtonPress(buttons);
  if (Serial.available()) {
    String command = Serial.readStringUntil('\n');
      prevCommand = command;
      processSerial(command);
  }
}

void processSerial(String commandText) {
  if (commandText.length() > 1) {
    char command = commandText.charAt(0);
    char delimiter = commandText.charAt(1);
    if (commandText.charAt(1) == ':') {
      String commandPart = String( command) + String(delimiter);
      commandText.replace(commandPart, "");
      if (command == 'L') {
        // L is for LED, turns on a specific led is a number and below 8
        int ledNumber = commandText.toInt();
        processLedCommand(ledNumber);
      }
      if (command == 'D') {
        // D is for display, write to display
        toDisplay(commandText);
      }
      if (command == 'S') {
        // S is for sound, number is ms sound is on (during sound, program is stalled for other input)
        int buzzTime = commandText.toInt();
        digitalWrite (buzzerPin, LOW);
        delay (buzzTime);
        digitalWrite (buzzerPin, HIGH);
      }
    }
    else {
      toDisplay(commandText);
    }
  } else {
    toDisplay(commandText);
  }
}

void keyPadPressed(String keyCode) {
  String action = "PAD";
  consoleLog(action, keyCode);
  toDisplay(keyCode);
}

void toDisplay(String command) {
  String resizedString = fillString(command, 8, " ");
  char charField[8];
  resizedString.toCharArray(charField, 9);
  tm.displayText(charField);
}

void processButtonPress(uint8_t value) {
  for (uint8_t position = 0; position < 8; position++) {
    if (value & 1 != 0)
    {
      String pos = String(position + 1);
      toDisplay(pos);
      consoleLog("BUTTON", pos);
    }
    value = value >> 1;
  }
}

String fillString(String input, int length, String fillCharacter)
{
  String result = input;
  int end = (input.length());
  if (end >= length) {
    return input.substring(0, length);
  }

  for (int i = end; i <= length; i++) {
    result = result + fillCharacter;
  }
  return result;
}

void processLedCommand(int led) {
  // 1 = led 1
  // 2 = led 2
  // 4 = led 3
  // 8 = led 4
  // 16 = led 5
  // 32 = led 6
  // 64 = led 7
  // 128 = led 8
  // so 129 = led 1 + 8

  // Not a beautifull function, but it works :)

  if (led > 256) {
    return;
  }
  bool one;
  bool two;
  bool three;
  bool four;
  bool five;
  bool six;
  bool seven;
  bool eight;

  if (led == 0) {
    eight = false;
    seven = false;
    six = false;
    five = false;
    four = false;
    three = false;
    two = false;
    one = false;
  } else {
    if ( led >= 128) {
      eight = true;
      led = led - 128;
    } else eight = false;
    if ( led >= 64) {
      seven = true;
      led = led - 64;
    } else seven = false;
    if ( led >= 32) {
      six = true;
      led = led - 32;
    } else six = false;
    if ( led >= 16) {
      five = true;
      led = led - 16;
    } else five = false;
    if ( led >= 8) {
      four = true;
      led = led - 8;
    } else four = false;
    if ( led >= 4) {
      three = true;
      led = led - 4;
    } else three = false;
    if ( led >= 2) {
      two = true;
      led = led - 2;
    } else two = false;
    if ( led >= 1) {
      one = true;
      led = led - 1;
    } else one = false;
  }

  tm.setLED(1 - 1, one);
  tm.setLED(2 - 1, two);
  tm.setLED(3 - 1, three);
  tm.setLED(4 - 1, four);
  tm.setLED(5 - 1, five);
  tm.setLED(6 - 1, six);
  tm.setLED(7 - 1, seven);
  tm.setLED(8 - 1, eight);
}

void echo(String text, String surroundedText) {
  if (surroundedText != "") {
    consoleLog(surroundedText);
  }
  consoleLog(text);
  if (surroundedText != "") {
    consoleLog(surroundedText);
  }
}

void consoleLog(String consoleMessage) {
  consoleLog(consoleMessage, "");
}

void consoleLog(String commandType, String actionText) {
  if (actionText == "") {
    Serial.println(commandType);
  } else {
    String delimiter = ":";
    String toSerial = commandType;
    toSerial = commandType + delimiter + actionText;
    Serial.println(toSerial);
  }
}