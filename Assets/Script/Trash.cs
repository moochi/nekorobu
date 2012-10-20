using UnityEngine;
using System.Collections;

public class Trash : Food {
	protected override Vector3 GetEffect()
	{
		var dir = m_Target.position - rigidbody.position;
		dir = dir.normalized * m_EffectPower;
		return dir;
	}
	
	// pos : ground position
	public static new GameObject Create( Vector3 pos )
	{
		Quaternion rot = Quaternion.AngleAxis( Random.Range( 0.0f, 360.0f ), new Vector3( Food.rand11(), Food.rand11(), Food.rand11() ).normalized );
		pos.y += 1;
		return ResourceCache.CreateTrash( pos, rot ) as GameObject;
	}
}
