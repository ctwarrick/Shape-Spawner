# A Simple Shape Spawner for HoloLens 2
This project is a basic intro to show my familiarity with Unity, Hololens 2, and the Mixed Reality Toolkit.  It 
consists of a menu and the four basic Unity shapes of a capsule, cube, cylinder, and sphere.  You use the menu to
select which shape you want to spawn, and adjust a slider to determine how far away you want the object to spawn.
The menu will billboard to face the user, and the user can also drag and move it.

Objects can spawn between 0.85 and 2 meters from the user.  The user spawns objects by either hitting the "Spawn"
button on the bottom of the menu, or saying the voice command "Spawn."  Objects initially float in midair, and the
user can grab and move them.  By gazing at an object and saying the command "Drop," the user will enable gravity.
The object will fall to the floor, and each object will make a unique sound.  By gazing at the object and saying
the command "Pick Up," the user will disable gravity for the object and be able to pick it up and put it back in
the air somewhere.  Objects disappear when the user says the command "Delete."

That's it.

## Required Software
* Unity 2020.3.17f1 or later
* MRTK 2.7.2 or later

## MRTK Dependencies
* Mixed Reality Toolkit Extensions 2.7.2
* Mixed Reality Toolkit Foundation 2.7.2
* Mixed Reality Toolkit Standard Assets 2.7.2
* Mixed Reality Toolkit Tools 2.7.2
* Mixed Reality OpenXR Plugin 1.0.1
* Microsoft Spatializer 1.0.196