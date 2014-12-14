var isStartGame=false;
var isInstructions=false;

function OnMouseEnter(){
	
}

function OnMouseExit(){

}

function OnMouseUp(){

	if (isStartGame==true) {
		Application.LoadLevel(1);
	}
	else if (isInstructions==true) {
	
		Application.Quit();
	}
}

function Update(){
//quit game if escape key is pressed
	if (Input.GetKey(KeyCode.Escape)) { 
		Application.Quit();
	}
}