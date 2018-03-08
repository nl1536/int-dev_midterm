using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogMovement : MonoBehaviour {
	
	public float dogPull;
	private float dogFinalPull;
	public float dogTorque;
	public Vector3 dogRotation;

	// Use this for initialization
	void Start ()
	{

		dogPull = 15f;
		dogFinalPull = 15f;

	}
	
	// Update is called once per frame
	void Update ()
	{

		dogTorque = Random.Range(-180, 180);
		dogRotation = new Vector3(0f, dogTorque, 0f);
	}

	void OnTriggerEnter(Collider turn)
	{
		if (turn.gameObject.name == "player")
		{
			GetComponent<Rigidbody>().AddRelativeTorque(dogRotation, ForceMode.Force);
			GetComponent<Rigidbody>().AddRelativeForce(0f,0f, dogFinalPull, ForceMode.Force);
		}
	}
	
	void OnTriggerExit(Collider turn)
	{
		if (turn.gameObject.name == "player")
		{
			GetComponent<Rigidbody>().AddRelativeTorque(dogRotation, ForceMode.Force);
			GetComponent<Rigidbody>().AddRelativeForce(0f,0f, dogFinalPull, ForceMode.Force);
		}
	}
	
	private void OnTriggerStay(Collider pull)
	{
		if (pull.gameObject.name == "player")
		{
			Debug.Log("pull!");
			GetComponent<Rigidbody>().AddRelativeForce(0f,0f, dogPull, ForceMode.Force);
		}
	}

	void OnCollisionEnter(Collision bounceTurn)
	{
		if (bounceTurn.gameObject.name == "Player" ||
		    bounceTurn.gameObject.name == "dogHouseMesh" ||
		    bounceTurn.gameObject.tag == "Tree")
		{
			GetComponent<Rigidbody>().AddRelativeTorque(dogRotation, ForceMode.Force);
		}
	}
}
