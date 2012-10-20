#pragma strict

var forceX : float = 1000;
var forceY : float = 500;

function Start(){

}

function Update () {
	if( Input.GetButtonDown("Fire1") ){
		this.rigidbody.AddForce(-1000, 0, 0);
	}
	if( Input.GetButtonDown("Fire2") ){
		this.rigidbody.AddForce(1000, 0, 0);
	}
}