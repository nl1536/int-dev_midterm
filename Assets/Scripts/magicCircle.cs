using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicCircle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionStay(Collision ground)
	{
		if (ground.gameObject.name == "Cliff")
		{
			GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | 
			                                        RigidbodyConstraints.FreezeRotationX |
			                                        RigidbodyConstraints.FreezeRotationZ;
		}
	}

	void OnCollisionExit(Collision fall)
	{
		if (fall.gameObject.name == "Cliff")
		{
			GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezePositionY;
		}
	}
}
