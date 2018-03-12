# Games Engines 2 Lab Test 2018

## Instructions
This is a video of what your project should look like at the end of today's lab test:


- Download this starter Unity project that has a skybox asset and a model of the Eagle transporter ship.
- Create a new, empty Unity github repository. Make sure the name is Space1999 and push your project to it. You can use whatever git client you are familiar with. If you are unsure how to do this, cd to the folder you unzipped the project to and type:

    ```bash
    git init
    git remote add origin PASTE_THE_REPO_URL_FROM_YOUR_BROWSER_HERE
    git add .
    git commit -m "Initial version"
    git push --set-upstream origin master
    ```
- Create a new empty scene in your Unity project
- Set up the skybox and position the camera at (42, 8, -45), with a rotation of 83<sup>o</sup> around the Y axis
- Drag the Eagle model into the scene and parent it so that it points down the Z azis. 
- Add a new component called Boid with public fields for mass and maximumSpeed. Give these the values of 1 and 10. 
- Make a prefab out of the Eagle ship and remove it from the scene.
- Make an empty GameObject called eagleSpawner and give it a position of (93, 3, -5) and a Y rotation of -116<sup>o</sup>
- Add a new EagleSpawner component to the eagleSpawner gameObject. Give it the following fields:

    ```C#
    public float gap = 20;
    public float followers = 2;
    public GameObject prefab;
    ```
- Write code in the Awake method of the EagleSpawner to spawn a fleet of Eagles in a "V pattern" around the position of the gameObject. The variable ```gap``` is used to set the gap between each of the Eagles on the X and Z axis. ```followers``` is used to set the number of eagles to spawn each side of the leader. For example a value of 2 means 2 followers each side of the leader, meaning 5 Eagles in total. Use the Eagle prefab you made earlier to the prefab gameObject. The diagram below shows how the eagles should be spawned. This script needs to work correctly even if the eagleSpawner is rotated, which it is.

![Eagles](images/eagles.jpg)

- Dynamically assign a Seek behaviour to the leader of the fleet so that it seeks a target 1000 units in front of itself.
- Dynamically assign an Offset Pursue behaviour to the followers of the leader so that they try and stay in formation with the leader
- Make the camera look at the leader of the formation
    
## Marking scheme

| Feature | Marks |
|---------|-------|
| Setting up the scene with the skybox, prefab & spawner | 10 marks |
| Writing the eagleSpawner | 30 marks |
| Programming the leader | 20 marks |
| Programming the follower | 30 marks |
| Camera following | 10 marks |
