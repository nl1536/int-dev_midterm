using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class cameraBehavior : MonoBehaviour
{
	
	private float lerp;

	// Use this for initialization
	void Start ()
	{

		lerp = 20f;

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.LeftArrow) 
		    )
		{
			GetComponent<Transform>().localPosition = new Vector3(GetComponent<Transform>().localPosition.x + 
			                                                      (-2f - GetComponent<Transform>().localPosition.x)/lerp,
															 GetComponent<Transform>().localPosition.y,
															 GetComponent<Transform>().localPosition.z);
		}
		
		if (Input.GetKey(KeyCode.RightArrow) 
		    )
		{
			GetComponent<Transform>().localPosition = new Vector3(GetComponent<Transform>().localPosition.x + 
			                                                      (3f - GetComponent<Transform>().localPosition.x)/lerp,
				GetComponent<Transform>().localPosition.y,
				GetComponent<Transform>().localPosition.z);
		}
		
	}
}
