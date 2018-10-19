using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour {
	
	// player movement variables
	//public static int moveSpeed = 1;
	//Vector3 userDirection = Vector3.right;	

	private float timeToChangeDirection;

	private Vector3 newDirection;
	
	//used for initialization
	void Start() {
		newDirection = ChangeDirection();
	}

	// Update is called once per frame
	void Update () {
		//transform.Translate(userDirection * moveSpeed * Time.deltaTime);

		timeToChangeDirection -= Time.deltaTime;
		
		

		if (timeToChangeDirection <= 0)
		{
			newDirection = ChangeDirection();
		}

		transform.forward = Vector3.Lerp(transform.forward, newDirection, 2f);
		
		GetComponent<Rigidbody>().velocity = transform.forward * 2;
	}

	private Vector3 ChangeDirection()
	{
		float angle = Random.Range(0f, 360f);
		Quaternion quat = Quaternion.AngleAxis(angle, Vector3.up);
		timeToChangeDirection = 1.5f;
		return quat * transform.forward;

	}
}
