using UnityEngine;
using System.Collections;

public class ResourceCache : MonoBehaviour {
	private Object m_Food;
	private Object m_Trap;
	private Object m_Trash;
	
	static public ResourceCache Instance { get; set; }
	void Awake()
	{
		Instance = this;
		m_Food = Resources.Load( "Prefabs/Food" );
		m_Trap = Resources.Load( "Prefabs/Trap" );
		m_Trash = Resources.Load( "Prefabs/Trash" );
	}
	
	public static Object CreateFood( Vector3 position, Quaternion rotation )
	{
		return Instantiate( Instance.m_Food, position, rotation );
	}
	public static Object CreateTrap( Vector3 position, Quaternion rotation )
	{
		return Instantiate( Instance.m_Trap, position, rotation );
	}
	public static Object CreateTrash( Vector3 position, Quaternion rotation )
	{
		return Instantiate( Instance.m_Trash, position, rotation );
	}
}
