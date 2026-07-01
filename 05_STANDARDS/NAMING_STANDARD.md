# ROOTS_DIRECTOR/05_STANDARDS/NAMING_STANDARD.md

# ROOTS — NAMING STANDARD

Version: 1.0

---

## Purpose

Define one universal naming convention for the entire ROOTS project.

Every file, folder, asset, script, scene, document and AI output must follow these rules.

---

## General Rules

- Use English only.
- Use descriptive names.
- Keep names short and meaningful.
- No spaces.
- No special characters.
- No duplicate names.
- Do not use temporary names.

---

## Letter Case

### Folders

- PascalCase
- Example: Inventory, Gameplay, Dialogue

### Files

- PascalCase
- Examples: StoryBible.md, InventorySystem.cs, HouseScene.unity

---

## Scripts

- Format: <Entity><Purpose>
- Examples: PlayerController.cs, InventoryManager.cs, DialogueSystem.cs, SaveManager.cs

---

## Classes

- PascalCase
- Examples: GameManager, EvidenceDatabase, PhotoViewer

---

## Interfaces

- Prefix: I
- Examples: IInteractable, ISaveable, IAudioPlayer

---

## Methods

- PascalCase
- Examples: OpenDoor(), LoadGame(), CollectEvidence(), PlayAudio()

---

## Variables

- camelCase
- Examples: playerName, currentObjective, selectedItem

---

## Private Variables

- Prefix: _
- Examples: _player, _inventory, _currentScene

---

## Booleans

- Prefix: is, has, can, should
- Examples: isLocked, hasKey, canOpen, shouldSave

---

## Constants

- UPPER_CASE
- Examples: MAX_SAVE_SLOTS, DEFAULT_VOLUME, TARGET_FPS

---

## Enums

- PascalCase
- Examples: GameState, DoorState, PuzzleState

---

## Enum Values

- PascalCase
- Examples: Locked, Unlocked, Completed, Hidden

---

## Events

- Prefix: On
- Examples: OnDoorOpened, OnEvidenceCollected, OnGameSaved

---

## Scenes

- Prefix: SCN_
- Examples: SCN_MainMenu, SCN_House, SCN_Hospital, SCN_Cemetery

---

## Prefabs

- Suffix: Prefab
- Examples: DoorPrefab, ChairPrefab, PhotoPrefab

---

## Materials

- Prefix: MAT_
- Examples: MAT_Wood, MAT_Glass, MAT_Metal

---

## Textures

- Prefix: TEX_
- Examples: TEX_Wood01, TEX_Brick02, TEX_Floor03

---

## Sprites

- Prefix: SPR_
- Examples: SPR_Inventory, SPR_Key, SPR_Button

---

## Audio

- Music: MUS_
- Ambience: AMB_
- SFX: SFX_
- Voice: VO_
- Examples: MUS_Menu, AMB_HouseNight, SFX_DoorOpen, VO_Father01

---

## Animations

- Prefix: AN_
- Examples: AN_OpenDoor, AN_PlayerWalk

---

## UI

- Prefix: UI_
- Examples: UI_MainMenu, UI_Inventory, UI_Settings

---

## Documents

- Prefix: DOC_
- Examples: DOC_AdoptionPaper, DOC_HospitalReport, DOC_FamilyLetter

---

# PHOTOS

Prefix

PHOTO_

Examples

PHOTO_Family01

PHOTO_HouseFront

---

# EVIDENCE

Prefix

EV_

Examples

EV_Key01

EV_Letter02

EV_Record03

---

# SCRIPTABLE OBJECTS

Suffix

Data

Config

Database

Examples

PlayerData

AudioConfig

EvidenceDatabase

---

# TASKS

TASK-0001

TASK-0002

TASK-0003

---

# COMMITS

[TASK-ID] Short Description

Example

[TASK-0021] Implement inventory system

---

# FORBIDDEN

Spaces

Special characters

Mixed languages

Temporary names

Copy

Copy1

New

Final

Final2

Test

Object1

Scene1

---

# QUALITY CHECK

Every name must be:

Readable

Unique

Descriptive

Consistent

Searchable

Production-ready

---

# MASTER RULE

If someone cannot understand what a file or asset contains by reading its name alone, rename it before merging into the project.
