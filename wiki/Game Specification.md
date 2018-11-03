# Game Specification
Author: Matthew Miller
Date: 11-2-2018
Version: 1.0 rev1

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

In certain situations, tiles can be summed multiple times in a row.  When a tile is combined 3 times in a row, it becomes a power tile.  Power tiles have the ability to combine with tiles 

### Progression and Challenge
As the game is played, tiles are summed together.  Since tiles can onnly be summed with identical tiles, the possible moves of the player decreases as the game progresses.  Eventually the board becomes crowded with tiles that cannot be summed together and the game ends.

### Losing
As the game progresses, eventually the board will fill up with tiles that cannot be summed.  If the board fills up before the player creates a tile with the maximum value for the level, the game ends.  In a s

## Art Style
Assets: https://www.kenney.nl/assets/platformer-pack-medieval
## Music and Sounds

## Technical Description

## Other Ideas (Optional)


<!--stackedit_data:
eyJoaXN0b3J5IjpbLTIyODY4NTY2MiwtNjk0NzY1NTkwLC0xMz
MxNjEzMjc2LC0xMTMzMDY4MTMsMjAzNzY1NDA3NywtMTEwNDQ5
MjgzMyw0MjAxMjI5ODYsLTE4ODczNjIyODIsLTE1MzA1MDA2MD
YsMjI3NTk3NTQwLDExNzM3NjkxMjEsLTE3NDQ4NTQyNjRdfQ==

-->