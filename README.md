SECUREBOT

THE OVERVIEW
This project is a C# console-based cybersecurity chatbot that interacts with users and provides essential tips on staying safe online. It also includes a voice greeting feature, making the experience more interactive and engaging.



 Purpose

The chatbot aims to:

* Educate users about cybersecurity threats
* Promote safe online practices
* Demonstrate basic C# programming concepts
* Introduce multimedia integration (audio)



 Features

 Interactive Chat

* Continuous user interaction loop
* Personalized responses using the user's name
* Handles empty input safely

 Voice Greeting

* Plays a welcome audio (`greeting.wav`) at startup
* Enhances user experience with sound
* Uses `SoundPlayer` from `System.Media`

 Cybersecurity Topics Covered

* Password security
* Phishing attacks
* Malware
* Safe browsing
* Public Wi-Fi risks
* VPN (Virtual Private Network)
* Two-Factor Authentication (2FA)

 Exit Commands

Users can exit the chatbot by typing:

* `exit`
* `quit`
* `bye`

---

 How It Works

Chat System

* The chatbot runs in a loop and waits for user input
* Input is converted to lowercase for easy keyword matching
* Uses `if-else` conditions to detect keywords
* Responds with relevant cybersecurity advice



 Code Structure

`UserInteraction` Class

Handles chatbot communication:

* Reads user input
* Matches keywords
* Displays responses
* 
 Example Interaction
 The Audio plays

You: what is malware
Bot: Malware is short for 'malicious software'. It refers to any program designed to harm or exploit a device.

You: help
Bot: You can ask me about passwords, phishing, malware, safe browsing, VPNs, and more!

You: bye
Bot: Goodbye John! Stay safe online.

<img width="1277" height="932" alt="image" src="https://github.com/user-attachments/assets/67d33537-806c-402d-a554-edf1b1782a77" />

Branch 2 – WPF Version with Enhanced Features

A separate branch (Branch 2) contains the second part of the POE where SecureBot has been converted to a WPF application. This version introduces:

Responsive UI: Modern and visually appealing interface
Interactive chatbot: Gives tips in real-time
Sentiment detection: Adjusts responses based on the user's tone
Improved user experience: Supports chat bubbles, dynamic scrolling, and voice integration

Branch 2 provides a more professional and engaging version of SecureBot suitable for demonstration and deployment.


