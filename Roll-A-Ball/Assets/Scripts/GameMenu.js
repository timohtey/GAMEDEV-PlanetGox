var isStartGame=false;
var isInstructions=false;
var isBack=false;

function OnMouseEnter(){
	
}

function OnMouseExit(){

}

function OnMouseUp(){

	if (isStartGame==true) {
		Application.LoadLevel(1);
	}
	else if (isInstructions==true) {
		GameObject.Find("Instructions").animation.PlayQueued("InstructionsSlideUp");
		GameObject.Find("Instructions").animation.PlayQueued("InstructionsHover");
		
	}
	else if (isBack==true) {
		GameObject.Find("Instructions").animation.Play("InstructionsSlideDown");
	
	}
}

function Update(){
//quit game if escape key is pressed
	if (Input.GetKey(KeyCode.Escape)) { 
		Application.Quit();
	}
}