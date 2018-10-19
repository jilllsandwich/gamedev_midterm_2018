using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCForward : MonoBehaviour {

	// player movement variables
	public static int moveSpeed = 1;
	Vector3 userDirection = Vector3.right;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(userDirection * moveSpeed * Time.deltaTime);
	}
}
