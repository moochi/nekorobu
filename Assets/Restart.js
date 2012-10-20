#pragma strict

function Start(){
}

function Update () {
}

function OnGUI(){
	if( GUI.Button(Rect(10,10,100,50), "Restart" )){
		Application.LoadLevel("main");
	}
}