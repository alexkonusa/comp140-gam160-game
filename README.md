# comp140-gam160-game
Repository for Assignment 1 of COMP140-GAM160

# [Proposal] Tiny Car

Player will control a small/tiny physics based vehicle which will need to be driven from one position to another, the vehicle will be unbalanced and hard to control there for it will be difficult for the player to get the vehicle from one position to another without failing the level.  

The level itself will act as the obstacle for the player and levels will be small but difficult. For example, one of the level idea that I had is where two planks are laid across a river and the player needs to get the vehicle from one side to another. If the player drives the car too quick or unexpected weight is added they can break which will lead to failure. The player can be very careful and take the time to complete the level but there also be a set timer in which the player needs to complete the level otherwise they will fail and the level will restart.  

Later when I have a working prototype and it's challenging, I can start to introduce different type of game modes and obstacles into the levels to make them a lot more entertaining and in general have a more game content. For example A cannon shoots balls at the car while the player is driving it on a bridge and the balls can damage the bridge or push the car off the bridge in this case the player will fail and will have to restart the level. 

**Core Mechanics**

**Turn left, right and accelerate controls:**
Simple 3 input vehicle controller  
 
**Physics based vehicle:**
Environment can affect the vehicle and make it harder for the player to complete the level 
 
**Level that act like obstacles:**
Objects that can break if too much weight is added or small objects that can make it harder for the player to control the vehicle 
 
**Timer:** 
Each level will have a set timer if failed to complete the level before the time runs out it will restart 

# Custom Controller

**Research**

Before thinking of a game and a cotroller, it was interesting to see what kind of custom controllers people already came up with and below I list a couple that have caught my eye. 

Blind Car Simulator ("Blind Car Simulator | Shake That Button (W.I.P)"): I really liked this idea because it was something that I have never seen before, even though the controlls werent that creative but overall it turned out great and unique. Player drives a car using a generic steering wheel with only sound as his navigation. This idea looks very simple and unique, I feel like this is where it had caught my interest. I never worked on anything car based and i'm all up for trying new things, this is where I desided to create a car based game. 




# Level Ideas 

**First Level Idea [Planks]**

This level has a very simple layout and I will only be needed 2 game objects that is the floating block of land and a plank which I can duplicate and resize to create a level. 

**Level Testing[2/26/2017]**

So far I have a working simple car mechanics (will improve later) which I have used to test the level, I have created 3 lots of land blocks and some plants(See picture below). I do not have any destruction mechanics yet but i found out that if I set the mass to 0.7 on the plank if i drive too fast or move wheels around the planks bounce off the ground, but this worked and I really liked the idea and how it played so far. Using keyboard controlls it was easy to play but I feel that when I create my custom controller it will be much harder to controll the car there for the level will be much harder. 

![Planks](http://i.imgur.com/2PPZaEG.png)

# Bibliography

"Blind Car Simulator | Shake That Button (W.I.P)". Shakethatbutton.com. N.p., 2017. Web. 23 Nov. 2015.
