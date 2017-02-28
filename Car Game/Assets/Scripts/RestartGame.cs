using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

	public string restartScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void restGame()
	{

		SceneManager.LoadScene(restartScene);

	}
}
