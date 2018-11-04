# Game Specification UNFINISHED
Author: Matthew Miller
Date: 11-2-2018
Version: 1.0 rev2

## Project Description
This design document describes 2^N^, a simple 2D, skill-based tile game based off the game [2048](https://play2048.co/).  This implementation includes several innovations including multiple levels of difficulty (hence the name), networked multi-player speed competitions, and support for multiple platforms.

## Board
The game itself is played on a tiled grid, the size of which is determined by the level of difficulty selected.

| Highest Tile Size | Grid Size |
|-------------------|-----------|
| 1024              | 4x4       |
| 2048              | 4x4       |
| 4096              | 6x6       |
| 8192              | 6x6       |

## Theme
**TODO**
## Gameplay

### Goals
The goal of this game is for the user to produce a tile with the highest tile size as defined by the difficulty level before the board becomes choked with trapped tiles (see difficulty level table above.)

### User Skills
* Ability to use WASD and arrow keys
* Ability to add numbers

### Game Mechanics
The game consists of a grid of tiles, initially empty except for one tile with the value of 2.  Using the WASD or arrow keys, the user shifts the blocks around the board.  Each time a key is pressed, all of the tiles that are not touching an edge or an incompatible tile in the direction of the key moves as far as it can in that direction.  If the tile impacts a tile that is compatible, it combines with that tile, producing a new tile with the value of the sum of the two tiles.  **Note:** Two tiles are compatible when they contain the same value, or when one of the tiles is a power tile.

Additionally, each time one of the direction keys is pressed, a new tile is spawned in a random location on the board with a value of 2.

As tiles are added together, the sum of the operation is added to the score of the game.  Thus, in a multiplayer enviroment, the player who has the highest score when one of the players finishes is declared the winner.

### Items and Powerups
The board consists of tiles containing a numerical value.  Each tile starts with a value of 2 when spawned, and when tiles are combined the stationary tile's value becomes the sum of its former value and the value of the tile it combined with.

In certain situations, tiles can be summed multiple times in a row.  When a tile is combined 3 times in a row, it becomes a power tile.  When a tile attains power status, it doubles it's value and immediately reverts to a normal state.

### Progression and Challenge
As the game is played, tiles are summed together.  Since tiles can onnly be summed with identical tiles, the possible moves of the player decreases as the game progresses.  Eventually the board becomes crowded with tiles that cannot be summed together and the game ends.

### Losing
As the game progresses, eventually the board will fill up with tiles that cannot be summed.  If the board fills up before the player creates a tile with the maximum value for the level, the game ends.  In single-player mode, this means the player has lost.  In multiplayer-mode, the session ends when one of the players either creates a maximum-value tile or fills up their board with tiles that can't be summed.  At that point, the player with the highest score wins and all other players lose the round.

It is possible to attain a tile with a higher value than the maximum tile value.  If a tile with a number close enough to the maximum value becomes a power tile, the resulting value will be greater than the maximum value.  The behavior of the game is the same as if the maximum value had been attained, and the higher score is recorded.

## Art Style
Assets: https://www.kenney.nl/assets/platformer-pack-medieval

## Music and Sounds
This game is designed as a pretty lightweight, minimalist game, and therefore we are not adding any music.

### Sound effects
* Moving pieces https://www.soundsnap.com/fantasy_game_action_collect_stone_c_wav

## Technical Description
The game will be available on the following platforms:
* Windows
* Hololens

While the codebases for these apps will be separate, they will share a common model.  

Xamarin Forms will be used for the Windows application, and UrhoSharp for the Hololens application.


<!--stackedit_data:
eyJoaXN0b3J5IjpbMjA3MTY2MzUyOSwyMTk1NTIwNDcsMTgzNz
E0NDk1NSwtMTg4MzI0NzE0NCwtMTAwMzkwMTQ2NiwyNjAwNjEz
NDcsLTg2MDYwNTcxOSwyNjQyMzAwNTYsLTc1MzgzMTQ2MSwtMT
YxODI0MzAwMywtNjk0NzY1NTkwLC0xMzMxNjEzMjc2LC0xMTMz
MDY4MTMsMjAzNzY1NDA3NywtMTEwNDQ5MjgzMyw0MjAxMjI5OD
YsLTE4ODczNjIyODIsLTE1MzA1MDA2MDYsMjI3NTk3NTQwLDEx
NzM3NjkxMjFdfQ==
-->