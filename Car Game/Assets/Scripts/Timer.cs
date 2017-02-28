using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{

	public float timeLeft;
	public Text timerDisplay;

	public bool timerON = false;

	// Update is called once per frame
	void Update () 
	{

		timerDisplay.text = "Time Left: " + timeLeft;

		if (Input.anyKey)
		{

			timerON = true;

		}

		if (timerON == true)
		{
			
			timeLeft -= Time.deltaTime;

			if (timeLeft < 0)
			{

				RestartScene();

			}


		}
	
	}

	void RestartScene()
	{

		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);

		timerON = false;

	}
}
