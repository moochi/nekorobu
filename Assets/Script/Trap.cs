using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {

	void OnCollisionEnter( Collision collision )
	{
		if ( collision.gameObject.tag == "Lob" )
			collision.gameObject.SendMessage("Die1");
		//Debug.Log( "Hit:" + collision.gameObject.name );
	}
	
	// pos : ground position
	public static GameObject Create( Vector3 pos )
	{
		Quaternion rot = Quaternion.AngleAxis( Random.Range( 0.0f, 360.0f ), new Vector3( Food.rand11(), Food.rand11(), Food.rand11() ).normalized );
		pos.y += 1;
		return ResourceCache.CreateTrap( pos, rot ) as GameObject;
	}
}
