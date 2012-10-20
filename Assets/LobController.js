#pragma strict
var moveSpeed = 4.0;
var rotateSpeed = 300.0;
var scale = 0.1;
var angle;
var direction;

private var goalPosition : Transform; // goal

function Start () {
if ( !goalPosition ) {
		goalPosition = GameObject.FindWithTag( "Goal" ).transform;
	}
}

function Update () {
	RotateTowardsPosition( goalPosition.position, rotateSpeed );
	direction = transform.TransformDirection( Vector3.forward * moveSpeed );
	rigidbody.AddForce(direction, ForceMode.Force);
}

function RotateTowardsPosition( targetPos : Vector3, rotateSpeed : float )
{
	// Compute relative point and get the angle towards it
	var relative = transform.InverseTransformPoint( targetPos );
	var angle = Mathf.Atan2( relative.x, relative.z ) * Mathf.Rad2Deg;

	// Clamp it with the max rotation speed
	var maxRotation = rotateSpeed * Time.deltaTime;
	var clampedAngle = Mathf.Clamp( angle, -maxRotation, maxRotation );

	// Rotate
	transform.Rotate( 0, angle, 0 );
	
	// Follow
	var maincamera : GameObject = GameObject.FindWithTag("MainCamera");
}

// var Stone : GameObject; 
// function Update() { 
// 	transform.position.y= Stone.transform.position.y; // in this case I only needed to care about the height 
// }

