using UnityEngine;
using System.Collections;

[System.Serializable]
public class Food : MonoBehaviour {

	[SerializeField]
	protected float m_EffectRange = 100.0f;
	[SerializeField]
	protected float m_EffectPower = 1.0f;
	
	protected Rigidbody m_Target = null;

	// Use this for initialization
	void Start () {
		m_Target = GameObject.Find( "Lob" ).GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		// check distance
		var dist = Vector3.Distance( m_Target.position, rigidbody.position );
		if( m_EffectRange < dist ) return; //  out of range
		
		// calc direction
		var dir = GetEffect();

		// apply effect
		m_Target.AddForce( dir, ForceMode.Force );
	}
	
	// Touch
	void OnCollisionEnter( Collision collision )
	{
		Destroy( this );
	}
	
	// Calc Effect Power
	protected virtual Vector3 GetEffect()
	{
		var dir = rigidbody.position - m_Target.position;
		dir = dir.normalized * m_EffectPower;
		return dir;
	}
	
	// frand() -1 ~ 1
	public static float rand11(){ return Random.Range( -1.0f, 1.0f ); }
	
	// pos : ground position
	public static GameObject Create( Vector3 pos )
	{
		Quaternion rot = Quaternion.AngleAxis( Random.Range( 0.0f, 360.0f ), new Vector3( Food.rand11(), Food.rand11(), Food.rand11() ).normalized );
		pos.y += 1;
		return ResourceCache.CreateFood( pos, rot ) as GameObject;
	}
}
