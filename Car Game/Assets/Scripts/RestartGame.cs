using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

	public string restartScene;

    public bool useCollision = false;

    //Restart our Scene
    void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.tag == "Player" && useCollision == true)
        {

            restGame();

        }

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {

            restGame();

        }
        
    }

    //We can Call this to restart the game
    public void restGame()
	{

		SceneManager.LoadScene(restartScene);

	}
}
