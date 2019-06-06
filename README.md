codebase for (PROJECT NAME) Shut Up And Drive.

**[DO NOT SHARE]**

# GAME DESIGN & PITCH DOCUMENT

**Version 1.0.3**

4th of June, 2019

By F. Rick Reich
& Jimmy Verwimp

***

## REVISION LIST

| VERSION | AUTHOR        | DATE         | Description                |
| ------- | ------------- | -------------| -------------------------- |
| 1.0.0   | F. Rick Reich | Feb 18, 2019 | Initial version            |
| 1.0.1   | F. Rick Reich | Feb 23, 2019 | Layout Changes             |
| 1.0.2   | F. Rick Reich | Apr 22, 2019 | Minor Changes              |
| 1.0.3   | F. Rick Reich | Jun 04, 2019 | Github translation         |

***

## TABLE OF CONTENTS

- [GAME DESIGN & PITCH DOCUMENT](#game-design--pitch-document)
	- [REVISION LIST](#revision-list)
	- [TABLE OF CONTENTS](#table-of-contents)
	- [INTRODUCTION](#introduction)
		- [OVERVIEW](#overview)
		- [SIMILAR PRODUCTS](#similar-products)
	- [STORY](#story)
	- [STORY OUTLINE](#story-outline)
	- [SETTING](#setting)
	- [GAMEPLAY](#gameplay)
	- [CONTROLS](#controls)
		- [DEBUG PC CONTROLS](#debug-pc-controls)
		- [XBOX ONE CONTROLS](#xbox-one-controls)
	- [CHARACTER MOVEMENT](#character-movement)
	- [VEHICLE MOVEMENT](#vehicle-movement)
	- [QUEST(MISSION) SYSTEM](#questmission-system)
		- [MAIN MISSIONS](#main-missions)
			- [WORKFLOW: STARTING A MAIN QUEST](#workflow-starting-a-main-quest)
			- [WORKFLOW: FINISHING A MAIN QUEST](#workflow-finishing-a-main-quest)
		- [SIDE MISSIONS](#side-missions)
			- [WORKFLOW: STARTING A SIDE QUEST](#workflow-starting-a-side-quest)
			- [WORKFLOW: FINISHING A SIDE QUEST](#workflow-finishing-a-side-quest)
	- [USER INTERFACE](#user-interface)
		- [TITLE SCREEN](#title-screen)
		- [OPTIONS MENU](#options-menu)
		- [LOADING SCREEN](#loading-screen)
		- [IN GAME GUI](#in-game-gui)
		- [PAUSE / OPTIONS SCREEN](#pause--options-screen)
		- [MISSION LOG/INVENTORY](#mission-loginventory)
	- [ART](#art)
	- [ASSETS](#assets)
		- [CHARACTERS](#characters)
		- [VEHICLES](#vehicles)
		- [WEAPONS](#weapons)
		- [ITEMS](#items)
	- [DEVELOPMENT](#development)
		- [OVERVIEW](#overview-1)
		- [LAYOUT](#layout)
		- [MODULES](#modules)
			- [BASE-MODULE](#base-module)
			- [CAMERA-MODULE](#camera-module)
			- [CHARACTER-MODULE](#character-module)
			- [DIALOG-MODULE](#dialog-module)
			- [EXTENSION-MODULE](#extension-module)
			- [HEALTH-AND-ARMOR-MODULE](#health-and-armor-module)
			- [HELPER-MODULE](#helper-module)
			- [INVENTORY-MODULE](#inventory-module)
			- [ITEM-MODULE](#item-module)
			- [LOCALISATION-MODULE](#localisation-module)
			- [MANAGER-MODULE](#manager-module)
			- [PLAYER-MODULE](#player-module)
			- [PLAYMODE-MODULE](#playmode-module)
			- [FINITE-STATE-MACHINE-MODULE](#finite-state-machine-module)
			- [UI-MODULE](#ui-module)
			- [VEHICLE-MODULE](#vehicle-module)
			- [WEAPON-MODULE](#weapon-module)
			- [ZONE-MODULE](#zone-module)
	- [TIME TABLE](#time-table)
	- [APPENDIX](#appendix)
	- [NOTES](#notes)

***

## INTRODUCTION

Shut Up ‘N’ Drive is a top-down action game that plays in the american 1970’s. The player takes over the role of a Priest, who lost his memories, on a mission to find his true identity.

### OVERVIEW

|||
| --------------- | -------------------------------------------------------------- |
| TITLE           | Shut Up ‘N’ Drive (Project Name)                               |
| GENRE           | Open-World                                                     |
|                 | Top-Down                                                       |
|                 | Action-Adventure                                               |
| PLATFORM        | XBOX ONE                                                       |
| GRAPHICAL STYLE | Current generation graphics on a low-to-mid poly-detail level. |
| COLORSET        | Standard                                                       |
| PERSPECTIVE     | Top-Down camera                                                |
| CAMERA CONTROL  | follows player/vehicle, move view-box by rotation              |
| RELEASE DATE    | TBA                                                            |

### SIMILAR PRODUCTS
- GRAND THEFT AUTO
- GRAND THEFT AUTO 2
- MAFIA
- AMERICAN FUGITIVE

***

## STORY

## STORY OUTLINE
Player takes over the role of a priest gone assassin, but things don’t seem to be what they look like.

## SETTING
The game plays in the year 1975 in a fictional american city, the cities look, setting and politics are influenced by chicago. Since the game plays in the american 1970’s, there will be a lot of pastel colors, 60’s and 70’s american muscle cars, also the clothes and other visuals will reflect the 1970’s.

Progressing on the game-map can happen through driving any vehicle, walking by foot, taking a train or using other types of transportation.

***

## GAMEPLAY

## CONTROLS

### DEBUG PC CONTROLS

### XBOX ONE CONTROLS
| BUTTON | CHARACTER MODE             | VEHICLE MODE               | MENU MODE        |
| ------ | -------------------------- | -------------------------- | ---------------- |
| A      |                            |                            | Accept           |
| B      | Crounch                    | Handbrake                  | Cancel           |
| Y      | Reload                     | Trigger Horn               |                  |
| X      | Interact / Enter Vehicle   | Exit Vehicle               |                  |
| LT     |                            | Accelerate                 |                  |
| RT     | Shoot                      | Brake                      |                  |
| LB     | Run                        | Boost	                   | Previous Tab     |
| RB     | Grenade                    | Trigger Lights             | Next Tab         |
| L      | Move / Strafe 			  | Steer	                   |                  |
| R      | Rotate / Aim               | Aim / Push to direction    |                  |
| WINDOW | Show Ingame Menu (Map)     | Show Ingame Menu (Map)     |                  |
| MENU   | Show Ingame Menu (Options) | Show Ingame Menu (Options) | Hide Ingame Menu |
| UP     |                            |                            | Up               |
| DOWN   |                            |                            | Down             |
| LEFT   | Previous Weapon	          |                            | Left             |
| RIGHT  | Next Weapon		          |                            | Right            |


## CHARACTER MOVEMENT
The Character moves into the direction it is pointing to, while the player can freely move the camera box around the players position by rotating the indicator.
If the ray, going from the player to the indicator hits an NPC, it changes to a crosshair, and the player will look at it. If the player is not allowed to attack the target, it will display a deactivsated crosshair.

## VEHICLE MOVEMENT
The vehicle moves into the direction determined by the player, while he can freely move the camera box around the vehicle.

## QUEST(MISSION) SYSTEM
The game contains a main quest-line (hereby called missions) and a subset of side-quests, wich can be taken at any time, or will be needed to be triggered.

### MAIN MISSIONS
The game consists of a set number of main quests, following the main storyline, these have to be successfully played to continue with the story.

it is possible that there are more than one main quests selectable at once, and also that one is chosable over the other (i.e.: prefering an npc’s objective over another).

#### WORKFLOW: STARTING A MAIN QUEST

**PREMISE:**
1. Player triggers quest giver
2. Game Pauses
3. Video play
4. Quest log is shown with loading screen
5. Game asks for return action
6. Video plays
7. game returns to playable state

**EXAMPLE:**
1. Player finishes prior quest, the map shows a new indicator for a quest
2. Player moves to indicator, by car or by foot
3. Player presses interaction button on quest giver
4. Dialog or video plays
5. Loading screen appears, listing the objectives
6. Player presses (ACCEPT)
7. Dialog or video plays
8. Game continues.

#### WORKFLOW: FINISHING A MAIN QUEST
**PREMISE:**
1. Player accepted main quest
2. Player moves to objective’s position
3. Video plays
4. Player sucessfully reaches quest target.
5. Video plays
6. Player has to return to quest-giver to get rewarded. (this can also happen immediatly)

### SIDE MISSIONS
The game contains a set amount of side quests not essentially by quest-givers, since these can also include collecting tasks (i.E.: collect all special vehicles in the game). These quests do not have to be played to finish the game-story progress, but to reach a 100% gameplay-rating.

#### WORKFLOW: STARTING A SIDE QUEST

**PREMISE:**
1. player triggers quest giver
2. Game pauses
3. Quest giver informs player about mission in dialog
4. Quest log is shown
5. Game asks player for return action (Accept or decline quest)
6. Game returns to playable state

**EXAMPLE:**
1. The map shows an indicator for a side-quest
2. Player moves to indicator, by car or by foot
3. Player presses interaction button on quest giver
4.  Dialog plays
5. A list of objectives shows up
6. Player presses (ACCEPT)
7. Game continues.

#### WORKFLOW: FINISHING A SIDE QUEST

**PREMISE:**
1. Player accepted quest
2. Player moves to objective’s position
3. Player sucessfully reaches quest target.
4. Game pauses
5. Quest-log for success is shown
6. Game returns to playable state

***

## USER INTERFACE
The following section defines the game’s user interface, based on the idea of scaling down the initial HUD of the game to keep it easy to use.

### TITLE SCREEN

### OPTIONS MENU

### LOADING SCREEN

### IN GAME GUI

### PAUSE / OPTIONS SCREEN

### MISSION LOG/INVENTORY


***

## ART
each tile is 4x4 meters (units) in size, quadratic. 2048x2048px resolution (originally 64x64x64px)
The world-map will be around 256x256 tiles in size, extending upwards for buildings and structures, and also might extend sideways if map needs more space.

***

## ASSETS

### CHARACTERS

- The Priest (Player)
- The Priest (Real)
- Garrett
- James

### VEHICLES
The game contains a broad list of vehicles. All brands use (Country) local alcoholic beverage names for their name.

Possible status:
- NONE = Not started
- WIP = Work in progress
- READY = Finished

Vehicles have a rarity, like in RPG's to define the amount of times it can be encountered on the street.
Rarities are:
- Common - Vehicle encountered very often
- Uncommon - Vehicle encountered often
- Rare - Vehicle encountered rarely
- Unique - Vehicle only exists Once, can be a special collectible car, or a car only driven by a certain character.

| STATUS | REAL-LIFE                              | BRAND     | NAME             | TYPE       | CATEGORY  | VERSION | TOP SPEED | WEIGHT  | DRIVE TYPE | RARITY   |
| ------ | -------------------------------------- | --------- | ---------------- | ---------- | --------- | ------- | --------- | ------- | ---------- | -------- |
| WIP    | (1975) Lamborghini Countach            | Amaretto  | Bull             | Car        | Sport     | Traffic |           |         | RWD        | Rare     |
| WIP    | (1974) FERRARI 308 GTO                 | Amaretto  | Mariano          | Car        | Sport     | Traffic |           |         | RWD        | Rare     |
| WIP    | (1974) Chevrolet Nova SS               | Bourbon   | Chuckles         | Car        | Coupe     | Traffic |           |         | RWD        | Uncommon |
| WIP    | (1971) Cadillac Deville                | Bourbon   | Millenium        | Car        | Limousine | Traffic |           |         | RWD        | Uncommon |
| WIP    | (1973) GMC Van                         | Bourbon   | Mover            | Car        | Van       | Traffic |           |         | AWD        | Common   |
| WIP    | (1974) Dodge Monaco                    | Bourbon   | Panther          | Car        | Limousine | Traffic |           |         | RWD        | Common   |
| WIP    | (1974) Dodge Monaco                    | Bourbon   | Panther (Police) | Car        | Limousine | Police  |           |         | RWD        | Common   |
| WIP    | (1932) Dodge Eight	                  | Cabernet  | Syndicate        | Car        | Limousine | Traffic |           |         | RWD        | Unique   |
| WIP    | (1974) Mercedes W115                   | Hopfen    | Teuerwagen       | Car        | Limousine | Traffic |           |         | AWD        | Rare     |
| NONE   | (1974) Dodge P30 Food Truck            | Moonshine | Assistant        | Truck      |           | Traffic |           |         | FWD        | Uncommon |
| WIP    | (1974) Dodge P30 Delivery Truck        | Delivery  | Assistant        | Truck      |           | Traffic |           |         | FWD        | Uncommon |
| WIP    | Cadillac?!                             | Moonshine | Mahagoni         | Car        | Limousine | Traffic |           |         | RWD        | Uncommon |
| WIP    | (1967) Chevrolet Impala                | Moonshine | Monsieur         | Car        | Coupe     | Traffic |           |         | RWD        | Common   |
| WIP    | (1970) Mitsubishi Galant               | Sake      | Coupe            | Car        | Coupe     | Traffic |           |         | FWD        | Common   |
| WIP    | (1963) Alfa Romeo TZ2                  | Sambuca   | Elegance         | Car        | Sport     | Traffic |           |         | RWD        | Unique   |
| WIP    | (1975) Oldsmobile 98                   | Whiskey   | Statesman        | Car        | Limousine | Traffic |           |         | RWD        | Uncommon |
| NONE   | (1975) Oldsmobile 98 Stretch Limousine | Whiskey   | Stretchman       | Car        | Limousine | Traffic |           |         | AWD        | Rare     |
| WIP    | (1973) Buick Riviera                   | Whiskey   | Boattail         | Car        | Coupe     | Traffic |           |         | RWD        | Uncommon |
| WIP    | Chevrolet C10                          | Whiskey   | Donkey           | Car        | Pickup    | Traffic |           |         | AWD        | Common   |
| WIP    | (1970) Dodge Superbee                  | Whiskey   | Freeman          | Car        | Coupe     | Traffic |           |         | RWD        | Uncommon |
| WIP    | (1971) Plymouth GTX                    | Whiskey   | Sportsman        | Car        | Coupe     | Traffic |           |         | RWD        | Uncommon |
| NONE   | UH-60                                  |           |                  | Helicopter |           |         |           |         |            | Unique   |

### WEAPONS
Weapons currently are only one per type, could be more if decided uppon.

- Fists
- Pistol
- Machine Gun
- Rifle
- Shotgun
- Rocket Launcher
- Grenades
  
### ITEMS

***

## DEVELOPMENT

Version: 1.5 (Fifth iteration of codebase)

### OVERVIEW
The development of this game is modular, meaning that each functionality can be switched out, modified or changed in any other way, without destroying the game. This opens up the possibility to not only change game mechanics for further development, but also to reuse modules in other projects.

### LAYOUT
a typical module has the following folder layout:

- [Module Name]
  - Prefabs - Contains Prefabs needed to run the module.
  - Scripts - Scripts, managers and controllers needed to run the module.
    - Interfaces - Interfaces for module scripts.
    - Editor - Custom editor inspectors for module.
  - Demo - Demo scenes to showcase module functionality.
  - States - States used for extended module functionality.
  - Enums - Enumerators used in module.

### MODULES

#### BASE-MODULE
**Namespace:** Game.V1.Base

Collection of singleton classes for persistant modules.

#### CAMERA-MODULE
**Namespace:** Game.V1.Camera

Handles Camera movement, zooming, attachment and effects.

#### CHARACTER-MODULE
**Namespace:** Game.V1.Character

Determines if the character is player or not, manages a characters life, armor and status and sets up character visually.

#### DIALOG-MODULE
**Namespace:** Game.V1.Dialog

A basic dialog system, managing current speaker, dialog management and animation.

#### EXTENSION-MODULE
**Namespace:** Game.V1.Extensions

Extensions from external ressources.

#### HEALTH-AND-ARMOR-MODULE
**Namespace:** Game.V1.HealthArmor

Manages Health and Armor of the player and NPC's

#### HELPER-MODULE
**Namespace:** Game.V1.Helper

A collection of Helper classes.

#### INVENTORY-MODULE
**Namespace:** Game.V1.Inventory

Manages the passive inventory utilized by the player.

#### ITEM-MODULE
**Namespace:** Game.V1.Item

Collectible/Pickup-able items management.

#### LOCALISATION-MODULE
**Namespace:** Game.V1.Localisation

Localisation/Translation system.

#### MANAGER-MODULE
**Namespace:** Game.V1.Manager

General Game Management, like saving and checkpoint loading. Also Game progress management.

#### PLAYER-MODULE
**Namespace:** Game.V1.Player

Player movement and other player-related functions.

#### PLAYMODE-MODULE
**Namespace:** Game.V1.Playmode

Sets current playmode, and needed animations.

#### FINITE-STATE-MACHINE-MODULE
**Namespace:** Game.V1.FSM

A Finite state machine, managing game states, currently supporting Execution and LateExecution of commands.

#### UI-MODULE
**Namespace:** Game.V1.UI

Manages the UI and all its derivates.

#### VEHICLE-MODULE
**Namespace:** Game.V1.Vehicle

Manages vehicle setup.

#### WEAPON-MODULE
**Namespace:** Game.V1.Weapon

Weapon management, shooting, ammunition and settings.

#### ZONE-MODULE
**Namespace:** Game.V1.Zone

Manages game zones, like checkpoints, damage zones, destination zones, teleportation zones and location zones.

***

## TIME TABLE
| MILESTONE       | FROM           | TO            |
| --------------- | -------------- | ------------- |
| First iteration | Feb 18th, 2019 | May 1st, 2019 |
| Alpha code base | May 1st, 20119 | Aug 1st, 2019 |
| Art Stage       | Aug 1st, 20119 | Oct 1st, 2019 |
| Beta            | ?              | ?             |

## APPENDIX
## NOTES
- A tile is 4x4 meters big
- a street block in chicago is about 100x150 meters big, in game size thats 36x24 units.
- A street block can also be longer, for example, about 250 meters.
- Light test settings:
  - fullDark = new Color(32.0f / 255.0f, 28.0f / 255.0f, 46.0f / 255.0f);
  - fullLight = new Color(253.0f / 255.0f, 248.0f / 255.0f, 223.0f / 255.0f);
  - dawnDuskFog = new Color(133.0f / 255.0f, 124.0f / 255.0f, 102.0f / 255.0f);
  - dayFog = new Color(180.0f / 255.0f, 208.0f / 255.0f, 209.0f / 255.0f);
  - nightFog = new Color(12.0f / 255.0f, 15.0f / 255.0f, 91.0f / 255.0f);

***

© 2018 - 2019 F. Rick Reich