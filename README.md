# 🎮 Scene Switching Using Firebase (Unity + Android APK)

This project demonstrates a **real-time scene control system** where a **mobile Android application (APK)** remotely controls **scene transitions in a Unity application** using **Firebase Realtime Database**.

The system enables seamless communication between a mobile controller and Unity, making it suitable for **VR/AR projects, simulations, training systems, and remote-controlled Unity applications**.

---

## 🚀 Project Overview

The main goal of this project is to control Unity scenes externally using a mobile device.

- The **Android APK** updates scene data in Firebase  
- **Unity listens** to Firebase changes in real time  
- When data changes, **Unity switches scenes automatically**

This approach removes the need for physical input devices and allows **wireless, real-time scene management**.

---

## 🧠 Key Features

- 📱 Android APK as a remote scene controller  
- 🔥 Firebase Realtime Database integration  
- 🎮 Real-time Unity scene switching  
- ⚡ Instant synchronization  
- 🌐 Internet-based communication  
- 🧩 Modular and scalable design  

---

## 🛠️ Technology Stack

| Component | Technology |
|---------|------------|
| Game Engine | Unity (C#) |
| Backend | Firebase Realtime Database |
| Mobile App | Android APK |
| Communication | Firebase SDK |
| Platform | Windows / Android |

---

## 🔄 System Architecture

[ Android Mobile APK ]
|
| (Update Scene Value)
▼
[ Firebase Realtime Database ]
|
| (Realtime Listener)
▼
[ Unity Application ]


---

## 📱 Mobile APK Controller

The mobile application acts as a **remote controller** for Unity scenes.

- Each button in the APK updates a value in Firebase
- Unity reads this value in real time
- The corresponding scene is loaded automatically

### 📸 APK Screenshots

<p align="center">
  <img src="Screen _Shots/apk1.jpeg" width="300"/>
  <img src="Screen _Shots/apk2.jpeg" width="300"/>
</p>

---

## 🔥 Firebase Integration

Firebase works as the **bridge** between the Android app and Unity.

### Responsibilities:
- Stores scene control values  
- Provides real-time updates  
- Ensures instant synchronization  
- Eliminates polling delays  

### 📸 Firebase Screenshots

<p align="center">
  <img src="Screen _Shots/sc1.png" width="400"/>
  <img src="Screen _Shots/sc2.png" width="400"/>
</p>

---

## 🎮 Unity Scene Control Logic

Unity continuously listens for changes in Firebase.

### Flow:
1. Unity subscribes to Firebase database events  
2. Mobile APK updates scene value  
3. Firebase triggers an update  
4. Unity loads the corresponding scene  

This enables:
- Remote scene switching  
- Smooth scene transitions  
- External device-based control  

---

## 📂 Repository Structure

Scene_Switching-using-Firebase/
│
├── Assets/
├── ProjectSettings/
├── Screen_Shots/
│ ├── apk1.jpeg
│ ├── apk2.jpeg
│ ├── sc1.png
│ ├── sc2.png
│
├── Scene_Switch.apk
├── README.md


---

## 📦 APK Download

The Android controller APK is available in this repository:

➡️ **Scene_Switch.apk**

Install this APK on any Android device to remotely control Unity scenes.

---

## 🎯 Use Cases

- 🥽 VR Training & Simulations  
- 🧪 Virtual Laboratory Experiments  
- 🎓 Educational Applications  
- 🏥 Medical & Research Training  
- 🎮 Remote-controlled Unity Systems  

---

## 🔮 Future Enhancements

- 🔐 Authentication and access control  
- 📊 Usage analytics  
- 📱 iOS controller application  
- 🕹️ Multi-user scene control  
- ⏲️ Automated and scheduled scene switching  

---

## 👨‍💻 Author

**Sabari R L**  
Student | Unity Developer | Firebase Enthusiast  

---

## ⭐ Support

If you find this project useful:
- ⭐ Star the repository  
- 🍴 Fork it  
- 📢 Share it  

---

> This project demonstrates real-time remote scene switching in Unity using Firebase and an Android mobile application.

