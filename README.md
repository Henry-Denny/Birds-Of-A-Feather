# Birds Of A Feather
My A-Level coursework project. An implementation of boids - a program originally developed by Craig Reynolds which simulates the flocking behaviour of birds.

Developed in C# using OpenTK for graphics.

A demonstration of this program and its features: https://www.youtube.com/watch?v=C0KZ1Xh6B3Y&t=12s

# Running
To run the program either open the Visual Studio solution file and run the program from visual studio or:
1. Navigate to Birds_Of_A_Feather/bin/Debug/
2. Run the file named "Birds_Of_A_Feather.exe"

# Use
There are 3 different tabs which each allow customisation of the program

## Boid
This tab contains the properties of each boid. These being:
Property            | Description
--------------------| --------------------------------------------------------------------------------------------
Alignment           | The property concerning the influence of other boids on the direction facing by each boid
Cohesion            | The pull on each boid to the centre of a boid cluster
Boid avoidance      | The repelling force boids have on each other (as if to avoid a collision)
Predator avoidance  | The repelling force predators exert on each boid (as if to avoid being eaten)
Obstacle avoidance  | The repelling force obstacles exert on each boid (as if to avoid colliding into an obstacle)


Each property (apart from speed) also has 3 variables that can be changed:
Variable            | Description
--------------------| ------------------------------------------------------------------------------------------
Radius              | The maximum distance two boids can be from each other and still affect each other's motion
Strength            | The stength of the force the property applies
Peripheral Vision   | The cone of vision of the boid (A value of 6.18 means the boid can see all around)

## Environment
The environment tab contains settings related to the creation of new entities. On cliking on the screen, the current entity selected from the list will be spawned in at the mouse position. There is a choice between spawning in boids, predators and obstacles. The speed of the boids and predators can also be changed from this tab.

## Graphics
Finally, the graphics tab is for customising the appearance of the scene. The colour of the boids, predators, obstacles, background and lines between boids can all be changed by selecting a new colour from the colour palette. The maximum line length determines the maximum distance two boids can be from each other for a line to be drawn between them. This overlay can also be turned off / on by toggling the "Connection lines" button.

# Final Notes
I made this a while ago so the code is far from perfect. However, it still brings me joy watching the influence that emergence has on a system of simple things and the patterns created can be pretty mesmerising. Enjoy :)
