 #pragma strict
 
 
 
 //Inspector Variables
 var playerSpeed : float = 2; //speed player moves
 var turnSpeed : float = 100; // speed player turns

 //var animObj : GameObject = GameObject.Find("/Player/sword"); //set the game object you want to be animated
 var sword : GameObject;
// This returns the GameObject named Hand in the Scene.
	sword = GameObject.Find("sword");
 
 function Update () 
 {
 
     MoveForward(); // Player Movement
     TurnRightAndLeft();//Player Turning
	 Run();
	 Attack();

 }

 function Attack()
 {
	if (Input.GetKeyDown(KeyCode.E)) //set the key you want to be pressed
     {
	 //Debug.Log(sword);
     }
 }

 function Run()
 {
	if(Input.GetKeyDown(KeyCode.LeftShift)){
		playerSpeed = 4;
	}

	if(Input.GetKeyUp(KeyCode.LeftShift)){
		playerSpeed = 2;
	}
 }
 
 function MoveForward()
 {
 
     if(Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
     {
         transform.Translate(0,playerSpeed * Time.deltaTime,0);
     }

	 if(Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
     {
         transform.Translate(0,-playerSpeed * Time.deltaTime,0);
     }
 
 }
 
 function TurnRightAndLeft()
 {
 
     if(Input.GetKey("right")) //Right arrow key to turn right
     {
         transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
     }
 
     if(Input.GetKey("left"))//Left arrow key to turn left
     {
          transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
     }
 
 }