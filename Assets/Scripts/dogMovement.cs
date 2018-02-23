using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogMovement : MonoBehaviour {
	
public float dogPull;

	// Use this for initialization
	void Start ()
	{

		dogPull = 2f;

	}
	
	// Update is called once per frame
	void Update () {
	
	GetComponent<Rigidbody>().AddRelativeForce(0f,0f, dogPull, ForceMode.VelocityChange);
		
	}
}
