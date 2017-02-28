using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour 
{

	public string finishScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{


	
	}

	void OnTriggerEnter()
	{

		if (GameObject.FindWithTag("Player"))
		{

			Debug.Log("test");
			SceneManager.LoadScene(finishScene);


		}

	}

}
