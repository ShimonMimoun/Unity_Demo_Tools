
# Unity Example Code



## Collision

The modifications to the official version are located in the Scene 

***Path :***

    ..//Collision/Assets/Scenes/homwork-shield.unity

I added two functions to the official version of [@erelsgl](https://github.com/erelsgl-at-ariel/gamedev-5780-code)

 1.  The player cannot fire lasers without a break, but must wait a certain time (say, half a second). The next shot which can be rotated thanks to the delay variable

 2. The possibility of playing with two players on the same games:
	 - The first player uses the arrows to move and Space to shoot
	-  The second player uses the A_W_D_S and Q keys to shoot



## Limit 
#### first limit
for the first section, I added a new script: BoundsTriger. I added 4 walls, for them I used cubes with collider and trigger which destroy each selected element who collides them.
[BoundsTriger script](https://)
#### second limit
for the second section, I changed the: Mover script. I added YBound value for screen bounds, and an if statement that destroys the gameobject if it moved across the bounds..
[Mover  script](https://)
#### third limit
for the third section , I changed the: KeyboardMover script. I added 2 values for the screen bounds, and four if statements that check if the player moved across the bounds his position changes to the other side.
[KeyboardMover  script](https://)
***Path :***

    ..//Limit/1 or ..//Limit/2and3

Remember, one of the official components of every game is boundaries. By default, World Unity Games is
Infinite and flat. Show how to use colliders to create boundaries in the spacecraft, so the world will
1. A flat world with visible boundaries, such as walls that cannot be crossed;

2. A flat world with invisible borders; For example, when the enemies go through the bottom of the screen, they are
Destroyed; As the laser goes through the top of the screen - it is destroyed.

3. Round World - When the player reaches one side of the world, he appears on the other side.

## Jump Master
[Play game](https://bargenish.itch.io/unity-jump-master)
We created a game based on one of the games taught on Unity courses.  
The game is 3D when the player is supposed to use a space bar to jump over obstacles that been creating each time period and been destroyed when they come out of frame.  
We added music and player effects.  
We added colliders with a trigger to the player and object of the barrier when the player collides with the obstacle the game is over and there is a blast sound with a special effect.  
We have added a boolean variable that prevents the player from making a double jump.  
We added a rolling stone behind the player, but it can't really hurt us.  
The player actually not moving when only the background gets forward and comes back and we get a real sense of running so we can continue to play as much as we can without the background ends.
***Path :***

    ..//Jump



## Some examples of using Unity functions.

### Here are the functions to test:

***Path :***

    ..//MovementAndMiniMap  or ..//MultiplayerGame

- Rotator
- Mover
- BiggerSmaller
- CircularMotion
- Oscillator
- MultiplayerGame
- Minimap camera



## Use 

- Unity 2019.3.10f1 (64-bit)
- Visual Studio Community 
- [Erelsgl](https://github.com/erelsgl-at-ariel/gamedev-5780)


### Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

### Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
