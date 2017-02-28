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

**Controller Description**

I have had couple of ideas for controllers that would suit the game, but after doing some research I had to change and adapt to what I can achieve. My controller Idea is to have 2 pedals with Range Sensors that will be used to steer the car, player will need to use his feet to steer left or right. To steer the car, player will need to place 1 foot at a time on the pedal in which derection they want to steer. To accelerate and brake I will have two buttons which will preform the actions, in order to accelerate player will need to use their hands and press the according button. 

**Controller Sketches and Design**


**Research**

Before thinking of a game and a cotroller, it was interesting to see what kind of custom controllers people already came up with and below I list a couple that have caught my eye. 

Blind Car Simulator: I really liked this idea because it was something that I have never seen before, even though the controlls werent that creative but overall it turned out great and unique. Player drives the car blindly and ("Blind Car Simulator | Shake That Button (W.I.P)") "Use the navigation by the sound of your environment and GPS to reach the destination". This idea looks very simple and unique, I feel like this is where it had caught my interest. I never worked on anything car based and i'm all up for trying new things, this is where I desided to create a car based game. 

Drunk Man: This is a coop game where("Drunk-Man (Or Arak Man) | Shake That Button (W.I.P)") "Each player is assigned to a direction (up/down/left/right), and should drink Arak (an anised based alcohol) from a straw to move Pac-Man.". I really liked this Idea because i'm a fan of coop games and it also turned a classic into something unique. 

Even though this game does not use sensors, for some reasson reading about this game and the controller motion sensors kept comming to my mind. Mainly because i though of alternative ways of making the controllers for this game. This is where I though what if I use sensors to move my car, maybe I could use body movement to move my car. This is where I really liked the Idea of leaning left and right to steer the car while having two pedals/buttons for acceleration and brake. 

When looking at parts for the Arduino, i came to an issue that to create the controller I want it's either going to cost me a bomb or I would have to use alternativs such as Kinect to track the player movement and I didn't really feel comftable with this. This is where I can across a Ultrasonic Range Finder [Link to the Range Finder](https://www.bitsbox.co.uk/index.php?main_page=product_info&cPath=302_310&products_id=2109&zenid=fthsadm5kk2sbjsocrvvoobko5) which made me think what if I create the steering controlls using this component. Reasson I want to use the range finder is because I can configure how far I want the object to be, before it does something. 

Firstly I was going to use PIR Module, but after doing some reseatch I found out that it can't track movement but only detect if a human has moved. [Link to the PIR Module](https://www.bitsbox.co.uk/index.php?main_page=product_info&cPath=302_303&products_id=2782&zenid=fthsadm5kk2sbjsocrvvoobko5)




# Level Ideas 

**First Level Idea [Planks]**

This level has a very simple layout and I will only be needed 2 game objects that is the floating block of land and a plank which I can duplicate and resize to create a level. 

**Level Testing[2/26/2017]**

So far I have a working simple car mechanics (will improve later) which I have used to test the level, I have created 3 lots of land blocks and some plants(See picture below). I do not have any destruction mechanics yet but i found out that if I set the mass to 0.7 on the plank if i drive too fast or move wheels around the planks bounce off the ground, but this worked and I really liked the idea and how it played so far. Using keyboard controlls it was easy to play but I feel that when I create my custom controller it will be much harder to controll the car there for the level will be much harder. 

![Planks](http://i.imgur.com/2PPZaEG.png)

# Bibliography

"Blind Car Simulator | Shake That Button (W.I.P)". Shakethatbutton.com. N.p., 2017. Web. 23 Nov. 2015.

"Drunk-Man (Or Arak Man) | Shake That Button (W.I.P)". Shakethatbutton.com. N.p., 2017. Web. 7 July 2015.
