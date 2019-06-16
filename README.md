codebase for (PROJECT NAME) Shut Up And Drive.

**[DO NOT SHARE]**

# GAME DESIGN & PITCH DOCUMENT

```Version 1.0.4```

7th of June, 2019

By F. Rick Reich
& Jimmy Verwimp

***


## REVISION LIST

| VERSION       | AUTHOR        | DATE         | Description                |
| ------------- | ------------- | -------------| -------------------------- |
| ```1.0.0```   | F. Rick Reich | Feb 18, 2019 | Initial version            |
| ```1.0.1```   | F. Rick Reich | Feb 23, 2019 | Layout Changes             |
| ```1.0.2```   | F. Rick Reich | Apr 22, 2019 | Minor Changes              |
| ```1.0.3```   | F. Rick Reich | Jun 04, 2019 | Github translation         |
| ```1.0.4```   | F. Rick Reich | Jun 07, 2019 | Added Module descriptions  |

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
			- [XBOX ONE CONTROLS](#xbox-one-controls)
		- [CHARACTER MOVEMENT](#character-movement)
		- [VEHICLE MOVEMENT](#vehicle-movement)
		- [SAVING SYSTEM](#saving-system)
		- [QUEST(MISSION) SYSTEM](#questmission-system)
		- [MAIN MISSIONS](#main-missions)
			- [STARTING A MAIN QUEST**](#starting-a-main-quest)
			- [FINISHING A MAIN QUEST](#finishing-a-main-quest)
		- [SIDE MISSIONS](#side-missions)
			- [STARTING A SIDE QUEST](#starting-a-side-quest)
			- [FINISHING A SIDE QUEST](#finishing-a-side-quest)
	- [USER INTERFACE](#user-interface)
		- [TITLE SCREEN](#title-screen)
		- [OPTIONS MENU](#options-menu)
		- [LOADING SCREEN](#loading-screen)
		- [IN GAME GUI](#in-game-gui)
			- [HEALTH AND ARMOR](#health-and-armor)
			- [WEAPON](#weapon)
			- [CREDITS](#credits)
			- [CROSSHAIR](#crosshair)
			- [DESTINATION INDICATORS](#destination-indicators)
			- [NOTIFICATIONS](#notifications)
		- [PAUSE / OPTIONS SCREEN](#pause--options-screen)
		- [MISSION LOG/INVENTORY](#mission-loginventory)
	- [ART](#art)
		- [Vehicles](#vehicles)
	- [ASSETS](#assets)
		- [CHARACTERS](#characters)
		- [WHEELS](#wheels)
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
			- [DAYTIME-MODULE](#daytime-module)
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

### STORY OUTLINE
The player takes over the role of an assassin called ```The Priest```, but things don’t seem to be what they look like.

### SETTING
The game plays in the year 1975 in a fictional american city, the cities look, setting and politics are influenced by chicago. Since the game plays in the american 1970’s, there will be a lot of pastel colors, 60’s and 70’s american muscle cars, also the clothes and other visuals will reflect the 1970’s.

Progressing on the game-map can happen through driving any vehicle, walking by foot, taking a train or using other types of transportation.

***


## GAMEPLAY

### CONTROLS

#### XBOX ONE CONTROLS
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

### CHARACTER MOVEMENT
The Character moves into the direction it is pointing to, while the player can freely move the camera box around the players position by rotating the indicator.
If the ray, going from the player to the indicator hits an NPC, it changes to a crosshair, and the player will look at it. If the player is not allowed to attack the target, it will display a deactivsated crosshair.

### VEHICLE MOVEMENT
The vehicle moves into the direction determined by the player, while he can freely move the camera box around the vehicle.

### SAVING SYSTEM
The game automatically saves at checkpoints. In addition to saving, entering the player characters home saves and changes from day to night or from night to daytime.

### QUEST(MISSION) SYSTEM
The game contains a main quest-line (hereby called missions) and a subset of side-quests, wich can be taken at any time, or will be needed to be triggered.

Some missions can only be played at daylight or during the night, daytime can be changed by entering one of the player characters homes.

### MAIN MISSIONS
The game consists of a set number of main quests, following the main storyline, these have to be successfully played to continue with the story.

it is possible that there are more than one main quests selectable at once, and also that one is chosable over the other (i.e.: prefering an npc’s objective over another).

#### STARTING A MAIN QUEST**

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

#### FINISHING A MAIN QUEST
**PREMISE:**
1. Player accepted main quest
2. Player moves to objective’s position
3. Video plays
4. Player sucessfully reaches quest target.
5. Video plays
6. Player has to return to quest-giver to get rewarded. (this can also happen immediatly)

### SIDE MISSIONS
The game contains a set amount of side quests not essentially by quest-givers, since these can also include collecting tasks (i.E.: collect all special vehicles in the game). These quests do not have to be played to finish the game-story progress, but to reach a 100% gameplay-rating.

#### STARTING A SIDE QUEST

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

#### FINISHING A SIDE QUEST

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

#### HEALTH AND ARMOR
Shows the current health and armor of the player character.

#### WEAPON
Shows the currently equipped weapon, along with the current amount of ammunition in the weapon and in the amount of ammunition left in the inventory.

#### CREDITS
Shows the current amount of credits the player owns.

#### CROSSHAIR
The crosshair shows in a set distance from the player character, aimed by the player, and autolocks onto enemies.
It also features a visual cue for no-weapon-equipped, out-of-ammo, no-interaction and idle states.

#### DESTINATION INDICATORS
Indicators show the direction to a set target, wether it is a custom waypoint, a mission or a target to reach.

#### NOTIFICATIONS
Shows up-to-date notifications for the player, wether it is that shows have new weapons, new parts of the map are unlocked or other informations.

### PAUSE / OPTIONS SCREEN

### MISSION LOG/INVENTORY

***


## ART
each tile is 4x4 meters (units) in size, quadratic. 2048x2048px resolution (originally 64x64x64px)
The world-map will be around 256x256 tiles in size, extending upwards for buildings and structures, and also might extend sideways if map needs more space.

### Vehicles

Vehicles have Materials with Chrome, Detail (dark grey, for plastic) and Window (reflective)

additionally  Vehicles have a set of tags on their objects determining their Material-behavior.

The following tags are availible and can be attached to each main body part of a vehicle:
- paintable - Color can be changed
- unpaintable - Color is set by prefab.

**Examples:**
- ```Roof_unpaintable``` - The Roof is unpaintable
- ```Body_paintable``` - The main body  paintable

***


## ASSETS

### CHARACTERS

- The Priest (Player)
- The Priest (Real)
- Garrett
- James

### WHEELS
The game constits of a set of Wheels, wich are pre attached to vehicles, but "could" also be changed if the game would contain a customization feature.

| ID            | Name    | Rim         | Wheel      | Color    | Description                              |
| ------------- | ------- | ----------- | ---------- | -------- | ---------------------------------------- |
| ```wheel_1``` | Wheel 1 | Closed      | Standard   | Chrome   | Standard rim with normal tire            |
| ```wheel_2``` | Wheel 2 | Closed      | Standard   | Chrome   | Larger rim with normal tire              |
| ```wheel_3``` | Wheel 3 | 5-Spoke     | Standard   | Chrome   | 5 spoke rim with normal wheel            |
| ```wheel_4``` | Wheel 4 | 5-Spoke     | White-Wall | Two-tone | muscle car rim with white-wall tire      |
| ```wheel_5``` | Wheel 5 | Multi-Spoke | Standard   | Two-tone | Classic multi-spoke rim with normal tire |
| ```wheel_6``` | Wheel 6 | Wiremesh    | Standard   | Chrome   | Wiremesh rim with normal tire            |
| ```wheel_7``` | Wheel 7 | Closed      | Standard   | Chrome   | Closed rim with normal tire              |
| ```wheel_8``` | Wheel 8 | Luxury      | White-Wall | Chrome   | Luxurious rim with white-wall tire       |
| ```wheel_9``` | Wheel 9 | Commercial  | Standard   | Two-Tone | Commercial big rim with normal tire      |


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
- Hero - Only exists once, car the player-character drives personally.


| ID                           | STATUS | REAL-LIFE                              | BRAND     | NAME             | TYPE       | CATEGORY  | VERSION | TOP SPEED | WEIGHT  | DRIVE TYPE | RARITY   |
| ---------------------------- | ------ | -------------------------------------- | --------- | ---------------- | ---------- | --------- | ------- | --------- | ------- | ---------- | -------- |
| ```whiskey_boattail_hero```  | WIP    | (1973) Buick Riviera                   | Whiskey   | Boattail         | Car        | Coupe     | Traffic |           |         | RWD        | Hero     |
| ```amaretto_bull```          | WIP    | (1975) Lamborghini Countach            | Amaretto  | Bull             | Car        | Sport     | Traffic |           |         | RWD        | Rare     |
| ```amaretto_mariano```       | WIP    | (1974) FERRARI 308 GTO                 | Amaretto  | Mariano          | Car        | Sport     | Traffic |           |         | RWD        | Rare     | 
| ```bourbon_chuckles```       | WIP    | (1974) Chevrolet Nova SS               | Bourbon   | Chuckles         | Car        | Coupe     | Traffic |           |         | RWD        | Uncommon | 
| ```bourbon_millenium```      | WIP    | (1971) Cadillac Deville                | Bourbon   | Millenium        | Car        | Limousine | Traffic |           |         | RWD        | Uncommon |
| ```bourbon_mover```          | WIP    | (1973) GMC Van                         | Bourbon   | Mover            | Car        | Van       | Traffic |           |         | AWD        | Common   |
| ```bourbon_panther```        | WIP    | (1974) Dodge Monaco                    | Bourbon   | Panther          | Car        | Limousine | Traffic |           |         | RWD        | Common   |
| ```bourbon_panther_police``` | WIP    | (1974) Dodge Monaco                    | Bourbon   | Panther (Police) | Car        | Limousine | Police  |           |         | RWD        | Common   |
| ```cabernet_syndicate```     | WIP    | (1932) Dodge Eight	                 | Cabernet  | Syndicate        | Car        | Limousine | Traffic |           |         | RWD        | Unique   |
| ```hopfen_teuerwagen```      | WIP    | (1974) Mercedes W115                   | Hopfen    | Teuerwagen       | Car        | Limousine | Traffic |           |         | AWD        | Rare     |
| ```moonshine_assistant```    | NONE   | (1974) Dodge P30 Food Truck            | Moonshine | Assistant        | Truck      |           | Traffic |           |         | FWD        | Uncommon |
| ```moonshine_delivery```     | WIP    | (1974) Dodge P30 Delivery Truck        | Moonshine | Delivery         | Truck      |           | Traffic |           |         | FWD        | Uncommon |
| ```moonshine_mahagoni```     | WIP    | (1974) Lincoln Continental Mark IV     | Moonshine | Mahagoni         | Car        | Limousine | Traffic |           |         | RWD        | Uncommon |
| ```moonshine_monsieur```     | WIP    | (1967) Chevrolet Impala                | Moonshine | Monsieur         | Car        | Coupe     | Traffic |           |         | RWD        | Common   |
| ```sake_coupe```             | WIP    | (1970) Mitsubishi Galant               | Sake      | Coupe            | Car        | Coupe     | Traffic |           |         | FWD        | Common   |
| ```sambuca_elegance```       | WIP    | (1963) Alfa Romeo TZ2                  | Sambuca   | Elegance         | Car        | Sport     | Traffic |           |         | RWD        | Unique   |
| ```whiskey_statesman```      | WIP    | (1975) Oldsmobile 98                   | Whiskey   | Statesman        | Car        | Limousine | Traffic |           |         | RWD        | Uncommon |
| ```whiskey_stretchman```     | NONE   | (1975) Oldsmobile 98 Stretch Limousine | Whiskey   | Stretchman       | Car        | Limousine | Traffic |           |         | AWD        | Rare     |
| ```whiskey_boattail```       | WIP    | (1973) Buick Riviera                   | Whiskey   | Boattail         | Car        | Coupe     | Traffic |           |         | RWD        | Uncommon |
| ```whiskey_donkey```         | WIP    | Chevrolet C10                          | Whiskey   | Donkey           | Car        | Pickup    | Traffic |           |         | AWD        | Common   |
| ```whiskey_freeman```        | WIP    | (1970) Dodge Superbee                  | Whiskey   | Freeman          | Car        | Coupe     | Traffic |           |         | RWD        | Uncommon |
| ```whiskey_sportsman```      | WIP    | (1971) Plymouth GTX                    | Whiskey   | Sportsman        | Car        | Coupe     | Traffic |           |         | RWD        | Uncommon |


### WEAPONS
Weapons currently are only one per type, could be more if decided uppon.

Weapon ammo comes in 3 categories (plus grenades):
- Small - For guns and small weapons
- Medium - For medium sized weapons
- Large - For rocket launchers and other big weapons.

**(Statistics may change after balacing.)**

|ID                     | Name            | Ammo-Type | Max Ammo | Damage | Range | Reload Time | Fire Rate | Description |
| --------------------- | --------------- | --------- | -------- | ------ | ----- | ----------- | --------- | ----------- |
| ```weapon_fists```    | Fists           |           | 1        | 10     | 1     | 1           | 1         | -           |
| ```weapon_pistol```   | Pistol          | small     | 1        | 10     | 1     | 1           | 1         | -           |
| ```weapon_smg```      | Machine Gun     | small     | 1        | 10     | 1     | 1           | 1         | -           |
| ```weapon_rifle```    | Rifle           | medium    | 1        | 10     | 1     | 1           | 1         | -           |
| ```weapon_shotgun```  | Shotgun         | medium    | 1        | 10     | 1     | 1           | 1         | -           |
| ```weapon_rpg```      | Rocket Launcher | large     | 1        | 10     | 1     | 1           | 1         | -           |
| ```weapon_grenades``` | Grenades        | grenades  | 1        | 10     | 1     | 1           | 1         | -           |

(* Reload Time and FIre Rate in Seconds)


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
    - Editor - Custom editor inspectors for module.
    - Interfaces - Interfaces for module scripts.
    - ScriptableObjects - ScriptableObjects attached to script.
  - Demo - Demo scenes to showcase module functionality.
  - States - States used for extended module functionality.
  - Enums - Enumerators used in module.

### MODULES

#### BASE-MODULE
**Namespace:** ```Game.[VERSION].Base```

Collection of singleton classes for persistant modules.

#### CAMERA-MODULE
**Namespace:** ```Game.[VERSION].Camera```

Handles Camera movement, zooming, attachment and effects.

#### CHARACTER-MODULE
**Namespace:** ```Game.[VERSION].Character```

Determines if the character is player or not, manages a characters life, armor and status and sets up character visually.

**Character object:**

#### DAYTIME-MODULE
**Namespace:** ```Game.[VERSION].Daytime```

A system to control all changes connected to day/nighttime.

#### DIALOG-MODULE
**Namespace:** ```Game.[VERSION].Dialog```

A basic dialog system, managing current speaker, dialog management and animation.

**Dialog object:**

#### EXTENSION-MODULE
**Namespace:** ```Game.[VERSION].Extensions```

Extensions from external ressources.

#### HEALTH-AND-ARMOR-MODULE
**Namespace:** ```Game.[VERSION].HealthArmor```

Manages Health and Armor of the player and NPC's

#### HELPER-MODULE
**Namespace:** ```Game.[VERSION].Helper```

A collection of Helper classes.

#### INVENTORY-MODULE
**Namespace:** ```Game.[VERSION].Inventory```

Manages the passive inventory utilized by the player.

#### ITEM-MODULE
**Namespace:** ```Game.[VERSION].Item```

Collectible/Pickup-able items management.

**Item object:**

#### LOCALISATION-MODULE
**Namespace:** ```Game.[VERSION].Localisation```

Localisation/Translation system.

**Localization object:**

#### MANAGER-MODULE
**Namespace:** ```Game.[VERSION].Manager```

General Game Management, like saving and checkpoint loading. Also Game progress management.

#### PLAYER-MODULE
**Namespace:** ```Game.[VERSION].Player```

Player movement and other player-related functions.

#### PLAYMODE-MODULE
**Namespace:** ```Game.[VERSION].Playmode```

Sets current playmode, and needed animations.

#### FINITE-STATE-MACHINE-MODULE
**Namespace:** ```Game.[VERSION].FSM```

A Finite state machine, managing game states, currently supporting Execution and LateExecution of commands.

**States:**
- InputTest
- StringTest

#### UI-MODULE
**Namespace:** ```Game.[VERSION].UI```

Manages the UI and all its derivates.

#### VEHICLE-MODULE
**Namespace:** ```Game.[VERSION].Vehicle```

Manages vehicle setup.

**Vehicle object:**
	
	vehicleName : string
	vehicleBrand : enum
	vehicleCategory : enum
	vehicleType : enum

#### WEAPON-MODULE
**Namespace:** ```Game.[VERSION].Weapon```

Weapon management, shooting, ammunition and settings.

**Weapon object:**

#### ZONE-MODULE
**Namespace:** ```Game.[VERSION].Zone```

Manages game zones, like checkpoints, damage zones, destination zones, teleportation zones and location zones.

***


## TIME TABLE
| MILESTONE       | FROM           | TO            |
| --------------- | -------------- | ------------- |
| First iteration | Feb 18th, 2019 | May 1st, 2019 |
| Alpha code base | May 1st, 20119 | Aug 1st, 2019 |
| Art Stage       | Aug 1st, 20119 | Oct 1st, 2019 |
| Beta            | ?              | ?             |

***


## APPENDIX

### NOTES
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