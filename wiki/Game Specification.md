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
The goal of this game is for the user to produce a tile with the highest tile size as defined by the difficulty level (see difficulty level table above.)

### User Skills
* Ability to use WASD and arrow keys
* Ability to add numbers

### Game Mechanics
The game consists of a grid of tiles, initially empty except for one tile with the value of 2.  Using the WASD or arrow keys, the user shifts the blocks around the board.  Each time a key is pressed, all of the tiles that are not touching an edge or an incompatible tile in the direction of the key moves as far as it can in that direction.  If the tile impacts a tile that is compatible, it combines with that tile, producing a new tile with the value of the sum of the two tiles.  **Note:** Two tiles are compatible when they contain the same value. 

Additionally, each time one of the direction keys is pressed, a new tile is spawned in a random location on the board with a value of 2.

### Items and Powerups
The board consists of tiles containing a numerical value.  Each tile starts with a value of 2 when spawned, and when tiles are combined the stationary tile's value becomes the sum of its former value and the value of the tile it combined with.

In certain situations, tiles can be summed multiple times in a row.  When 

### Progression and Challenge

### Losing

## Art Style
Assets: https://www.kenney.nl/assets/platformer-pack-medieval
## Music and Sounds

## Technical Description

## Other Ideas (Optional)


<!--stackedit_data:
eyJoaXN0b3J5IjpbMjEyMzM3MjQzLDQyMDEyMjk4NiwtMTg4Nz
M2MjI4MiwtMTUzMDUwMDYwNiwyMjc1OTc1NDAsMTE3Mzc2OTEy
MSwtMTc0NDg1NDI2NF19
-->