# Virtual Classroom

This is a course project (Project 3) - School's Out, for CS 428 - Virtual, Augmented & Mixed Reality at UIC under Professor Andrew Johnson ([course link](https://www.evl.uic.edu/aej/428/)). 

### Requirements

* [Unity 2019.4.1f1](https://unity3d.com/get-unity/download)
* [VRTK - 3.3.0](https://github.com/ExtendRealityLtd/VRTK/tree/3.3.0)

### How to run

1. Clone the project and open it in Unity. The project is around 200 MB without the ```Library``` folder, because of the extra assets.
2. For the VRTK requirement, you don't need to do any extra installation as the required files are present in the repository itself.
3. The project can be run without a VR headset and uses the VRTK Simulator to achieve this. The other SDKs like SteamVR, Oculus, etc., are also available and you can switch between them in Play Mode. 
4. Simply clicking on Play will run the scene for you.

__Note__: If you get suspicious errors from OpenVR when you click on Play, go to the ```[VRTL_SDKManager]``` object in the heirarchy and find it's ```VRTK_SDK Manager``` component. Under setups where the list of all available SDKs is present, remove ```SteamVR``` and ```UnityXR``` and try running again. This caused me an error initially, forcing me to remove them. But I added them back on in the end, and it seemed to work.

### Description

This is a virtual reality project that displays a virtual classrooms. It gives us a glimpse as to how we can reimagine the classroom environment if it was completely virtual. Some parts of the environment was already available to us -

1. the room
2. the walls
3. the instructor
4. the displays and the monitors
5. the chairs and tables
6. the lights and switches

The other parts were added by me and consist of assets made by me as well as imported from places like [Unity's Asset Store](https://assetstore.unity.com/) and [3D Warehouse](https://3dwarehouse.sketchup.com/). The humanoids and their animations were taken from [MakeHuman](http://www.makehumancommunity.org/) and [Mixamo](mixamo.com). A comprehensive list of features can be found below.

### Key-binds for the simulator

The following are the key-binds for using the VRTK Simulator - 

1. ```WASD``` for movement in four directions
2. Mouse movement for looking
3. Left-click for grabbing an object, left-click again for releasing the object
4. ```Q``` to bring up the teleport marker and teleport to a location
5. ```Shift``` for sprinting
6. Press ```Alt``` to use the controller. You can then move the controller in the X-Z axis using the mouse and press ```Ctrl``` for moving the controller in the X-Y axis.
7. Press ```Tab``` to switch the controller hand.

### Features

1. __My desk__ - The desk in front of the humanoid in the white tee-shirt is a representation of what my desk typically looks like. The humanoid in the white tee-shirt is also a representation of me. Each of the 10 small objects around me can be interacted with using the VR controller. They can be grabbed, bumped against other objects, and dropped. 
2. __The students__ - There are 4 students in the class. All of them have default animations that they are doing when the scene starts. When you get reasonably close to the students, they change their animation to something else, and say something appropriate. The students also have appropriate colliders, so you balls bounce against their bodies.
3. __Large objects__ - There are around 9 large objects scattered across the scene. Since the goal was to reimagine a virtual classroom, I chose objects based on what I thought would be cool to have in order to get students engaged and interested in the class. Some of these objects include a vending machine, a board game for entertainment, a rotating model of the earth to teach geoography, etc. 
4. __Interactable large objects__ - There is a red vending machine in the corner which has a large button in it's mid-section. When the user "clicks" the button, the vending machine dispenses a soda can that can be grabbed, moved around, and dropped. There is also a rotating model of the earth in the first bench. When the user touches the model, the model stops rotating so that the user can inspect a particular part of the earth.
5. __New lighting scheme__ - Adding to the 2 sets of switches and 4 white lights provided in the starter scene, there are an additional set of 2 switches located in the rear wall. These turn on 4 new lights that are red in colour and give the effect of an __Evacuate__ warning. 
6. __Scaling down__ - Button 2 on the controller is bound to the ```E``` key, which can be pressed on the keyboard to scale down the user. This makes the user around 6 inches tall and slows down the speed of movement, making the environment appear gigantic. You can go back to normal scale by pressing ```E``` again.  

### Asset and sound credits 

1. Laptop - https://assetstore.unity.com/packages/3d/props/electronics/hq-laptop-computer-42030
2. Smartphone - https://assetstore.unity.com/packages/3d/props/electronics/free-smartphone-90324#content
3. Mugs and bowls - https://assetstore.unity.com/packages/3d/props/interior/plates-bowls-mugs-pack-146682
3. Pens - https://assetstore.unity.com/packages/3d/props/tools/detailed-ballpoint-pens-164157
4. School supplies - https://assetstore.unity.com/packages/3d/school-supplies-96667#content
5. Water bottle - https://3dwarehouse.sketchup.com/model/957f897018c8c387b79156a61ad4c01/bouteille-d-eau-en-plastique
6. Briefcase and plant - https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438
7. Vending machine - https://3dwarehouse.sketchup.com/model/798a52ea-209c-41ab-84bc-40415509580b/Vending-Machine
8. Bean bag - https://3dwarehouse.sketchup.com/model/b4b58c0a-987f-4c76-a6cf-7296e76f638a/Bean-bag-rond-Enfant
9. Typing on Keyboard - http://soundbible.com/464-Typing-On-Keyboard.html
10. Printer - https://assetstore.unity.com/packages/3d/props/electronics/printer-lowpoly-4996
11. Arcade machines - https://assetstore.unity.com/packages/3d/props/arcade-machines-pack-02-lowpoly-pack-79442#content
12. Lowpoly earth - https://assetstore.unity.com/packages/3d/environments/landscapes/stylized-earth-94673
13. Christmas tree - https://assetstore.unity.com/packages/3d/environments/landscapes/lowpoly-style-free-rocks-and-plants-145133
14. Water dispenser - https://3dwarehouse.sketchup.com/model/u3ea94ff9-b17e-4918-ae07-d11e43380f39/Thermador-18-inch-Freezer-Column-with-External-Ice-and-Water-Dispenser-T18ID800LP
15. Books - https://assetstore.unity.com/packages/3d/props/interior/books-3356
16. Chess set - https://assetstore.unity.com/packages/3d/props/low-poly-chess-pack-50405
17. Calculator - https://assetstore.unity.com/packages/3d/props/office-supplies-low-poly-105519

### Gallery

![alt-text](readme-resources/screenshot-1.png)

![alt-text](readme-resources/screenshot-2.png)

![alt-text](readme-resources/screenshot-3.png)