#pragma strict

var speed : float;

function Start () {
	animation["roll"].speed = speed;
}

function Fly()
{
	animation.Play( "fly" );
}

function Die1()
{
	animation.Play( "die1" );
	yield WaitForSeconds( 3.0 );
	Destroy( gameObject );
}

function Update () { 

}