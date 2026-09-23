# LIFEGAME

Unity scripts for a mobile life game. The player has an age, money, and several stats, moves horizontally, and enters buildings.

This repository is **not a full Unity project**: there is no `ProjectSettings` folder and no scenes. These are loose `.cs` files to copy into a project that already has the rest of the scene.

## What the scripts do

| Script | Role |
| --- | --- |
| `PlayerStats` | Age (starts at 18), money, and stats: health, hunger, cold, mental health, and body health |
| `CharacterStat` / `StatModifier` | A stat with a base value and modifiers (uses `Kryz.CharacterStats`) |
| `PlayerController` | Horizontal movement. On Android it enables the touch path (`USING_MOBILE`) |
| `EnterBuldings` | Entering buildings |
| `DisplayText` / `TextButton` / `ResumeButton` | UI text and resume |

## Stack

- Unity
- C#
- Aimed at mobile (`UNITY_ANDROID`)
- Depends on the **Kryz.CharacterStats** asset (the `using` in `PlayerStats`)

## How to use it

1. Create or open a 2D/3D Unity project.
2. Copy these `.cs` files into `Assets`.
3. Import the Character Stats package that `PlayerStats` expects.
4. Put `PlayerController` and `PlayerStats` on the player and wire the UI in the Inspector.

`EnterBuldings` keeps that spelling in the file: when you reference the component in the Inspector, Unity uses the class name as it is.
