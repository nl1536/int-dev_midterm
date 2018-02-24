using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogMovement : MonoBehaviour {
	
	public float dogPull;
	public Transform playerPos;
	public float dogTorque;
	public Vector3 dogRotation;

	// Use this for initialization
	void Start ()
	{

		dogPull = 30f;

	}
	
	// Update is called once per frame
	void Update ()
	{

		dogTorque = Random.Range(-180, 180);
		dogRotation = new Vector3(0f, dogTorque, 0f);

		if (GetComponent<Transform>().position.z - playerPos.position.z < 15 ||
		    GetComponent<Transform>().position.z + playerPos.position.z < 15)
		{
			GetComponent<Rigidbody>().AddRelativeForce(0f,0f, dogPull, ForceMode.Force);
			GetComponent<Rigidbody>().AddRelativeTorque(dogRotation, ForceMode.Force);
		}
	}
}
