## Battleship  version: 1.0.0.0

Created: 20.07.2022 

Console App

## How it works
The game is divided into 3 stages 
1. Grid generation stage
    
    Here randomly generated positions for five ships on two-player grids


2. Game itself,

    This is where the gameplay comes in. The game draws, the starting player, and then chooses a shooting position. The result of the shot is then checked. If the player hits then he gets another move, if he misses then it is the other player's turn. The player who sinks all the ships first wins. 

3. Results printout. 

    Here follows the listing of the winner and the results of the hits along with the grids 

The whole thing is done automatically from start to finish



## Rules
1. Each game generates 5 consecutive ships on each player's grid (5, 4, 3, 3, 2),
2. Ships cannot be placed diagonally,
3. Ships can be adjacent to each other, 
4. A randomly selected player starts, 
5. After a missed shot, the turn is given to the other player,
6. After a hit shot, the player gets another chance,
7. When a player hits a previously hit field, (let's assume he made a mistake), the approach is not counted and another shot is generated until it hits the water or the ship,
8. The player who sinks all the ships first (hits 17 times) wins.


## Explanation of signs
1. "~" - represents water,
2. "x" - represents a hit on a ship,
3. "#" - represents a hit in the water
4. "5" - (any number 2-5) represents a ship with its type



