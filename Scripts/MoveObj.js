#pragma strict

function Start () {

}

function Update () {

}
function OnCollisionEnter(theCollision : Collision){
	if(theCollision.gameObject.tag == "RobotPush"){
		//Destroy(gameObject.Find("Player"));
		// The above line is old code to destroy object upon contact, may be useful later
		 transform.position = Vector3(10,10,10);
	}
}