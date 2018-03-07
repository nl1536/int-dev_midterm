using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleTrigger : MonoBehaviour
{

	public GameObject particles;
	public Transform playerPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.W))
		{
			Instantiate(particles, playerPos.position, Quaternion.identity);
		}

		if (Input.GetKeyDown(KeyCode.S))
		{
			
		}

		if (Input.GetKeyDown(KeyCode.A))
		{
			
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
		}
		
	}
}
