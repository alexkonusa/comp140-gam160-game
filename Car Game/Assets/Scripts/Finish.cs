using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour 
{

    //Name of the scene
	public string finishScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{


	
	}

    //On trigger enter finish the game
    //and go to the winning state menu
	void OnTriggerEnter()
	{

        //looks for playing using the Player tag
		if (GameObject.FindWithTag("Player"))
		{

			Debug.Log("test");
			SceneManager.LoadScene(finishScene);


		}

	}

}
