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

        //if any key is pressed our timer will start
		if (Input.anyKey)
		{

			timerON = true;

		}

        //if timeron is true then we start our count down
		if (timerON == true)
		{
			
			timeLeft -= Time.deltaTime;

			if (timeLeft < 0)
			{

				RestartScene();

			}


		}
	
	}

    //restart the scene if we dont finish the game in the time given
	void RestartScene()
	{

		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);

		timerON = false;

	}
}
