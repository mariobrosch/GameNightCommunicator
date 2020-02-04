# Game Night Communicator
An app to communicate via COM port (bluetooth for example) to send and receive data from a device. In this project an Arduino board. See Arduino folder for the setup and functionality of the board.

With this application you can handle a maximum number of two teams.

## Minimal requirements this application
* Windows computer
* At least one devices connected through a COM port.

## Functionality
The application has some functionality to communicate through the COM port. The following table is a list of buttons in the applications and the functionality what it does.

|Field name|Dutch button caption|Description|
|:---:|:---:|:--:|
|btnSend<All/1/2>|Naar <alle teams/team 1/team 2>|Sends the message as plain text to all open serial ports|
|btnFault<1/2/All>|Fout signaal|Sends a wrong answer command (message "FOUT", LED commands (L:<number>) and sound commands (S:<number>))|
 |btnGood<1/2/All>|Goed signaal|Sends a good answer command (message "GOED", LED commands (L:<number>) and sound commands (S:<number>))|
  |cboTeam<1/2>| |Combobox with the available COM ports|
  |btnSerial<1/2>Open|Open \| Close|Opens or closes the selected COM port|
  |txtLastAnswerTeam<1/2>| |Displays the last pressed answer. A team can't change it's answer during a question|
  |txtTimeSinceSet<1/2>| |During a question the time is displayed since the reset button is pressed and the answer is picked|
  |button1|button1|Unused, for alignment purposes only during development, should be removed before version 1|
  |btnStartTimer|Start timer + antwoorden legen|Set the timer to zero, empties answer fields and sends messages to the COM ports to clear display and turns off all LEDs|
  |btnSendScores|Verstuur scores|Sends the currents scores to each COM port. So team 1 will see his points total and team 2 will see his own scores on their display|
  |btnAdd<1/2><1-5>|+<1-5>|Adds score to the total for the team|
  |numscore<1/2>| |Displays the current team score and you are able to change it here|
  |chkFastest<1/2>| |If checked this team was the fastest responder|
  
## TODO
* Total answer time calculation
* Total of fastest answers
* Texts into resource file to support multiple languages and set language per team
* Write data into a sql database for the simple website
* Beautify the simple php website for showing scoring of teams
* Clicking multiple times on ADD button will accumulate score for the question, reset button must be added
* Add template for config objects in php and c#