﻿using System.Collections;
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
		if (ground.gameObject.name == "cliff")
		{
			GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | 
			                                        RigidbodyConstraints.FreezeRotationX |
			                                        RigidbodyConstraints.FreezeRotationZ;
		}
	}

	void OnCollisionExit(Collision fall)
	{
		if (fall.gameObject.name == "cliff")
		{
			GetComponent<Rigidbody>().constraints &= ~RigidbodyConstraints.FreezePositionY;
			GetComponent<Rigidbody>().mass = 5f;
			GetComponent<Rigidbody>().AddRelativeForce(0f,2500f,2500f, ForceMode.Force);
			
		}
	}
}