# Cityscape Runner

<p align="center">
  <img src="https://github.com/user-attachments/assets/d05f4cb6-6ad1-4cb8-9715-e9660b7f92c7" style="width: 600px;">
</p>

## 🔴 About This Project
<p align="justify">This project was developed as a way for me to know more about the first-person parkour genre. Throughout the process, I gained some valuable insights, including how to implement smooth first-person movement, utilize the character controller component, and create parkour mechanics that enhance the overall player experience.</p>

<br>

## 📋 Project Info

<b> Developed with Unity 2022 </b>

| **Role** | **Name** | **Development Time** |
| - | - | - |
| Game Programmer | Michael Ardisa | 3 days |

<details>
  <summary> <b>My Contribution (Game programmer)</b> </summary>
  
  - Core Mechanics
  - Level Design
  - Bug Fixing
  
</details>

<br>

## ♦️About Game
<p align="justify">Cityscape Runner is an adrenaline-fueled parkour experience set in a futuristic urban landscape. Players are immersed in a world where mastering fast-paced movement is key to success, using a range of parkour techniques to navigate complex city environments.</p>

<br>

## 🎮 Gameplay
<p align="justify">Cityscape Runner focuses on fluid movement mechanics like bunny hopping and dashing in 8 directions, allowing players to dynamically traverse the environment. The objective is to complete each level as quickly as possible, chaining together jumps, dashes, and leaps to shave off valuable seconds and achieve the fastest time.</p>

<br>

## ⚙️ Game Mechanic I Created
### Dash Mechanic

<p align="justify">
  <img src="https://github.com/user-attachments/assets/b4abb473-9fe0-4009-8e0e-44d7626fe139" style="width: 50%;">
  <img src="https://github.com/user-attachments/assets/7991090d-f9b9-4758-9226-afb802276f1f" style="width: 50%;">
</p>

- Logic is located within the `pMove.cs` script
- The dash mechanic works by gradually increasing the player's motion.
- It operates based on the normalized x and z axes.
- The mechanic enables dashing in 8 directions: front, back, right, left, front-right, front-left, back-right, and back-left.
- This allows for fluid and dynamic traversal, giving players the ability to dash in various directions during parkour sequences.

<!--
### Scriptable Objects Utilization for Weapon Data
<p align="justify">Scriptable objects here are used to store key weapon data within the 'Resources' folder, providing a flexible way to manage and modify weapon attributes. This approach makes adding new weapons efficient and straightforward — simply create a new weapon asset file and adjust its data as needed.</p> -->

<br>

## 📜 Scripts

|  Script       | Description                                                  |
| ------------------- | ------------------------------------------------------------ |
| `pMove.cs`  | Manages first person player movements. |
| `MouseLook.cs`  | Manages the logic behind the enemies' combat. |
| `etc`  |

<br>

## 🕹️ Controls

| **Key Binding** | **Function** |
|:-|:-|
| W,A,S,D | Basic movement |
| W,A,S,D + L-Shift | Dash |

<br>

## 💻 Setup

This game is still a work in progress, a playable version will be available soon!
