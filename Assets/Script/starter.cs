using UnityEngine;
using System.Collections;

[System.Serializable]
public class starter : MonoBehaviour {
	[SerializeField]
	private int m_CreateItemCount = 10;
	
	private const float randMax = 20.0f;
	static public Vector3 randPos(){ return new Vector3( Random.Range(-randMax,randMax),0,Random.Range(-randMax,randMax)); }

	// Use this for initialization
	void Start () {
		for( int i=0; i<m_CreateItemCount; ++i )
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
