using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndgameTrigger : MonoBehaviour
{

	void OnTriggerEnter(Collider ChangeScene) 
	{
		if (ChangeScene.gameObject.CompareTag("Player"))
		{
			SceneManager.LoadScene(sceneName:"EndgameScreen");
		}
	}
}
