using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	public float tug;
	private float rotateSpeed;
	public Transform leashPos1;
	public Transform leashPos2;
	public Transform leashPos3;
	public Transform dogPos;
	

// Use this for initialization
	void Start ()
	{

		tug = 250f;
		rotateSpeed = 2f;

	}
	
	// Update is called once per frame
	void Update () {
		
		// TUG INPUT

		if (Input.GetKeyDown(KeyCode.W))
		{
			GetComponent<Rigidbody>().AddRelativeForce(0f,0f,tug, ForceMode.Force);
		}

		if (Input.GetKeyDown(KeyCode.S))
		{
			GetComponent<Rigidbody>().AddRelativeForce(0f,0f,-tug, ForceMode.Force);
		}

		if (Input.GetKeyDown(KeyCode.A))
		{
			GetComponent<Rigidbody>().AddRelativeForce(-tug,0f,0f, ForceMode.Force);
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			GetComponent<Rigidbody>().AddRelativeForce(tug,0f,0f, ForceMode.Force);
		}
		
		// LOOK INPUT

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			GetComponent<Transform>().eulerAngles += new Vector3(0f, -rotateSpeed, 0f);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			GetComponent<Transform>().eulerAngles += new Vector3(0f, rotateSpeed, 0f);
		}
		
		// LEASH RENDERER

		GetComponent<LineRenderer>().SetPosition(0, new Vector3(transform.position.x, transform.position.y, transform.position.z));
		GetComponent<LineRenderer>().SetPosition(1, new Vector3(leashPos1.position.x, leashPos1.position.y, leashPos1.position.z));
		GetComponent<LineRenderer>().SetPosition(2, new Vector3(leashPos2.position.x, leashPos2.position.y, leashPos2.position.z));
		GetComponent<LineRenderer>().SetPosition(3, new Vector3(leashPos3.position.x, leashPos3.position.y, leashPos3.position.z));
		GetComponent<LineRenderer>().SetPosition(4, new Vector3(dogPos.position.x, dogPos.position.y, dogPos.position.z));
	}
}
