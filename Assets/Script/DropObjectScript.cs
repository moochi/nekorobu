using UnityEngine;
using System.Collections;

public class DropObjectScript : MonoBehaviour {
	
	public GameObject prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 vec = Input.mousePosition;
			vec.z = 10f;
			//Debug.Log(vec);
 
			//Instantiate(prefab, camera.ScreenToWorldPoint(vec), Quaternion.identity);
			Food.Create(camera.ScreenToWorldPoint(vec));
		}
	}
}
