using UnityEngine;
using System.Collections;

public class starter : MonoBehaviour {
	private const float randMax = 20.0f;
	static public Vector3 randPos(){ return new Vector3( Random.Range(-randMax,randMax),0,Random.Range(-randMax,randMax)); }

	// Use this for initialization
	void Start () {
		for( int i=0; i<10; ++i )
		{
			var t = Random.Range( 0, 3 );
			switch( t )
			{
			case 0:
				Food.Create( Vector3.forward * 5 +  Vector3.right * 3 );
				break;
			case 1:
				Trap.Create( Vector3.forward * 5 +  Vector3.right * 3 );
				break;
			case 2:
				Trash.Create( Vector3.forward * 5 +  Vector3.right * 3 );
				break;
			}
		}
	}
}
