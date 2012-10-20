using UnityEngine;
using System.Collections;

public class DropObjectScript : MonoBehaviour {
	
	//public GameObject prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 vec = Input.mousePosition;
			/*
			//vec.z = 10f;
			//Debug.Log(vec);
			//Instantiate(prefab, camera.ScreenToWorldPoint(vec), Quaternion.identity);
			Food.Create(camera.ScreenToWorldPoint(vec));
			*/
			
			//vec.z = 100f;
			//Vector3 toPos = camera.ScreenToWorldPoint(vec);
			Ray ray = camera.ScreenPointToRay(vec);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit,100)) {
				Food.Create(hit.point);
			}
		}
		if (Input.GetMouseButtonDown(1))
		{
			Vector3 vec = Input.mousePosition;
			vec.z = 10f;
			//Debug.Log(vec);
 
			//Instantiate(prefab, camera.ScreenToWorldPoint(vec), Quaternion.identity);
			Food.Create(camera.ScreenToWorldPoint(vec));
		}
	}
}
