# Angry Monkey

**Angry Monkey** is a 2D puzzle-arcade tower defense game developed in Unity, featuring strategic defense mechanics, unique enemy types, and a dynamic progression system. Inspired by classic tower defense gameplay, the project brings in-depth systems design and modern Unity architecture into a fun and challenging experience.

---

## 🔹 Game Highlights

- **Strategic Monkey Placement**  
  Players must tactically place different types of monkeys to stop balloons from escaping predefined paths.

- **Unique Monkey Types**  
  Includes Sniper Monkey, Ninja Monkey, and Sharp Monkey — each with distinct abilities and behaviors.

- **Diverse Enemy Balloons**  
  Red, Blue, Metal, Camo, and Boss Balloons offer varying health values, damage potentials, and mechanics.

- **Balloon Splitting Mechanic**  
  Certain balloons spawn smaller ones upon being popped, increasing the challenge over time.

- **Path-Following System**  
  Balloons follow specific predefined routes, requiring thoughtful positioning of monkeys.

- **Health and Coin Systems**  
  Players lose health when balloons escape and earn coins by popping them, which are used to deploy more units.

- **Audio and Feedback Systems**  
  Integrated sound effects for popping, damage, and events to enhance player immersion.

- **Level Unlocking System**  
  Completing a level unlocks the next, with progress saved using PlayerPrefs.

---

## 💡 Key Learnings & Architecture

- **Scriptable Objects**  
  Utilized extensively for defining balloon types, monkey data, and level maps, improving scalability and modularity.

- **Service Locator Pattern**  
  Transitioned from Singleton and Generic MonoSingleton patterns to Service Locator for better dependency management and testability.

- **Dependency Injection & Initialization**  
  Developed a clean initialization method (`INIT()`) across service classes to handle dynamic dependency resolution without tightly coupling logic.

- **PlayerPrefs Integration**  
  Saved level unlocking and game progress efficiently using Unity's built-in PlayerPrefs system.

- **Performance Optimization**  
  Identified and began addressing performance bottlenecks due to object overload and rendering. Work in progress to introduce pooling and optimization techniques.

---

## 🧠 Development Focus Areas

- Advanced use of Unity architecture and game systems
- Clean and maintainable C# scripting
- Balancing strategy, challenge, and replayability
- Modular game components and reusable logic
- Improving runtime performance with profiling and optimization

---

## 📬 Let’s Connect

Into Unity game development, C++ programming, or gameplay architecture?  
I’d love to hear your feedback, thoughts, or stories about your first game or algorithm implementation. Let’s chat!

---

## Play Link

[![Watch the video](https://img.youtube.com/vi/Nc567BDU10g/maxresdefault.jpg)](https://youtu.be/Nc567BDU10g)
### [Gameplay Video](https://youtu.be/Nc567BDU10g)

![Image](https://github.com/user-attachments/assets/21b8e9ae-836e-4302-a439-bf775694dc41)

![Image](https://github.com/user-attachments/assets/34e2be2b-2d32-46a5-8e24-2bf1fd5b22e6)

![Image](https://github.com/user-attachments/assets/9eceb128-5f9b-47a7-a14c-7b3da54108f4)

![Image](https://github.com/user-attachments/assets/40a0c14e-2aac-493c-9d5c-80751cd5ec64)

![Image](https://github.com/user-attachments/assets/ccd65c90-b100-4b06-b8d7-179fc88f116e)

![Image](https://github.com/user-attachments/assets/2924f201-7576-46cf-ad9a-676b01b16b6b)
