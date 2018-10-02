using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//put on capsule with rigidbody
//this script does mouse look and WASD for player 

public class rigidBodyfirstPerson : MonoBehaviour
{

	public float moveSpeed = 5f;

	private Vector3 inputVector;
	
	// Update is called once per frame
	void Update () {
		//mouse look
		//getting mouse input
		//these are mosuse deltas
		//these will be zero when nothing is moving, this isnt mouse position

		float mouseX = Input.GetAxis("Mouse X"); //horizontal mouse movement
		float mouseY = Input.GetAxis("Mouse Y"); //vertical mouse movement
		
		
		//apply to camera to rotate camera based on mouse input
		
		transform.Rotate(0f, mouseX, 0f);
		Camera.main.transform.Rotate(-mouseY, 0f, 0f);

		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		//transform.position += transform.forward * vertical * moveSpeed;
		//transform.position += transform.right * horizontal * moveSpeed;
		
		//doing movement via transform, there is no valid collision detection;

		inputVector = transform.forward * vertical;
		inputVector += transform.right * horizontal;

	}
	
	//runs every physics frame (different framerate than input or rendering)
	//all your physics code should go in FixedUpdate
	
	void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = inputVector * moveSpeed + Physics.gravity * 0.25f;
		
	}	
}
