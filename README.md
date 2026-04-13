# 🔐 Cybersecurity Awareness Chatbot (C# Console Application)

## 📌 Project Overview

This project is a **C# console-based cybersecurity chatbot** that interacts with users and provides essential tips on staying safe online. It also includes a **voice greeting feature**, making the experience more interactive and engaging.

---

## 🎯 Purpose

The chatbot aims to:

* Educate users about cybersecurity threats
* Promote safe online practices
* Demonstrate basic C# programming concepts
* Introduce multimedia integration (audio)

---

## ⚙️ Features

### 💬 Interactive Chat

* Continuous user interaction loop
* Personalized responses using the user's name
* Handles empty input safely

### 🔊 Voice Greeting

* Plays a welcome audio (`greeting.wav`) at startup
* Enhances user experience with sound
* Uses `SoundPlayer` from `System.Media`

### 🛡️ Cybersecurity Topics Covered

* Password security
* Phishing attacks
* Malware
* Safe browsing
* Public Wi-Fi risks
* VPN (Virtual Private Network)
* Two-Factor Authentication (2FA)

### 🚪 Exit Commands

Users can exit the chatbot by typing:

* `exit`
* `quit`
* `bye`

---

## 🧠 How It Works

### Chat System

* The chatbot runs in a loop and waits for user input
* Input is converted to lowercase for easy keyword matching
* Uses `if-else` conditions to detect keywords
* Responds with relevant cybersecurity advice

### Voice Greeting System

* When the program starts, it loads an audio file from:

  ```
  /Assets/greeting.wav
  ```
* The audio is played using:

  ```csharp
  SoundPlayer player = new SoundPlayer(path);
  player.PlaySync();
  ```
* `PlaySync()` ensures the program waits until the audio finishes

---

## 🧩 Code Structure

### `UserInteraction` Class

Handles chatbot communication:

* Reads user input
* Matches keywords
* Displays responses

### `VoiceGreeting` Class

Handles audio playback:

* Loads `.wav` file from project directory
* Plays greeting sound
* Includes error handling with `try-catch`

---

## ▶️ How to Run

1. Open the project in Visual Studio (or any C# IDE)
2. Ensure the following structure exists:

   ```
   Project Folder
   └── Assets
       └── greeting.wav
   ```
3. Make sure you have a `User` class with a `Name` property
4. Call `VoiceGreeting.PlayGreeting();` at program start
5. Run the application
6. Start chatting in the console

---

## 💡 Example Interaction

```
(Audio plays)

You: what is malware
Bot: Malware is short for 'malicious software'. It refers to any program designed to harm or exploit a device.

You: help
Bot: You can ask me about passwords, phishing, malware, safe browsing, VPNs, and more!

You: bye
Bot: Goodbye John! Stay safe online.
```

---

## 🚀 Future Improvements

* Add more advanced AI responses (NLP)
* Support voice input/output
* Add a graphical user interface (GUI)
* Store chat history
* Add multilingual support (e.g., French)

---

## 🧑‍💻 Author

Perfetia Kazadi Ndjibu

---

## 📖 Notes

This project demonstrates:

* C# console programming
* File handling
* Audio integration
* Basic cybersecurity awareness

---

✨ *Stay safe online and keep building amazing projects!*
