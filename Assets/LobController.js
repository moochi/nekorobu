#pragma strict
var moveSpeed = 4.0;
var rotateSpeed = 300.0;

private var goalPosition : Transform; // goal

function Start () {
	if ( !goalPosition ) {
		
		goalPosition = GameObject.FindWithTag( "Goal" ).transform;
		Debug.Log(goalPosition.position);
	}
}

function Update () {
	RotateTowardsPosition( goalPosition.position, rotateSpeed );
	var direction = transform.TransformDirection( Vector3.forward * moveSpeed );
	rigidbody.AddForce(direction, ForceMode.Force);
}

function RotateTowardsPosition( targetPos : Vector3, rotateSpeed : float )
{
	// Compute relative point and get the angle towards it
	var relative = transform.InverseTransformPoint( targetPos );
	var angle = Mathf.Atan2( relative.x, relative.z ) * Mathf.Rad2Deg;

	// Rotate
	transform.Rotate( 0, angle, 0 );
}

// var Stone : GameObject; 
// function Update() { 
// 	transform.position.y= Stone.transform.position.y; // in this case I only needed to care about the height 
// }

