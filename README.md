# Aegrin Beta
An RPG Action 2D Pixel Game

Made with Unity 6 LTS

---

## Table of Contents
- [Overview](#overview)
  - [Scene Files](#scene-files)
- [How To's](#how-tos)
- [File Structure](#file-structure)
- [Credits](#credits)

---

## Overview
A 2D pixel-style action RPG built using Unity. This is the beta version for experimentation, testing game mechanics, and implementing core features.

[GDocs for Game Discussion](https://docs.google.com/document/d/1VWbv2UQdG_LHKaJzLI6_3wMVXn8CyV3dhI2PJU7eyrk/edit?tab=t.0#heading=h.7kg9iatqkiz8)

---

## File Structure
```plaintext
Aegrin/
├── .vscode/               # VS Code project-specific settings
│
├── Assets/                # All Unity assets
│   ├── Placeholders/      # Placeholder assets during development
│   │   └── Placeholder Sprites/
│   ├── Scenes/            # Unity scene files
│   ├── Settings/          # Project or gameplay settings
│   └── Sprites/           # Final or working pixel art assets
│
├── Library/               # Unity-generated files (should be gitignored)
├── Logs/                  # Editor logs (optional)
├── Packages/              # Unity package manager files
├── ProjectSettings/       # Unity project settings
├── UserSettings/          # Local Unity user preferences
├── .gitignore             # Git ignore rules
├── README.md              # Project info and documentation
└── Aegrin.sln             # Solution file for IDEs like Rider or Visual Studio
````

---

## Scene Files

### 🧩 What Are Scene Files in Unity?

A scene file in Unity is like a level or screen in your game.
It contains everything that's placed in that part of the game—like characters, objects, lights, cameras, and backgrounds.

---

### 🎮 Think of it like this:

Imagine you're making a stage play. Each scene in your game is like a different act:

* One scene might be the **main menu**
* Another could be a **village**
* Another might be a **battlefield**
* Or a **cutscene**

In Unity, each of these would be saved as a separate `.unity` file (scene file).

---

### 🔧 What's Inside a Scene?

A scene file contains:

* GameObjects (like players, enemies, platforms)
* Lighting and camera setups
* UI elements (like health bars or buttons)
* Sound triggers
* Scripting references

But not the actual code, art, or audio files — it just tells Unity how to arrange and use them in that scene.

---

### 📂 Where Are They?

Scene files are saved in your project under:

```
Assets/Scenes/
```

and they end with `.unity`
Example: `MainMenu.unity`, `Level1.unity`, `BossFight.unity`

---

### 🧠 TL;DR

A scene file is a saved part of your game world — like a level or menu screen.
It tells Unity what appears there and how it all works together.