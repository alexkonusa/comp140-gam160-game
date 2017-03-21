using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetActivePort : MonoBehaviour
{
    //This will list all of our current ports 
    public List<string> AvaliblePorts = new List<string>();
    public int portSpeed = 9600;
    public string message;
    public string PortName;
    public string restartSceneName;
    public string gameStartSceneName;
    public Text messageText;

    SerialPort serialPort;
    RestartGame restartGame;
    // Use this for initialization
    void Start ()
    {
        AvaliblePorts.AddRange(SerialPort.GetPortNames());
    }

    void Update()
    {

        AttemptToFindThePort();

    }

    void CheckPort()
    {

        for (int i = 0; i < AvaliblePorts.Count; i++)
        {

            serialPort = new SerialPort(AvaliblePorts[i], portSpeed);

            messageText.text = "Trying Port: " + AvaliblePorts[i];

            serialPort.Open();
            serialPort.ReadTimeout = 1;

            if (serialPort != null && serialPort.IsOpen)
            {
                try
                {

                    message = serialPort.ReadLine();

                    if (message != string.Empty)
                    {
                        messageText.text = "Arduino Has Been Found on Port: " + AvaliblePorts[i];

                        PortName = AvaliblePorts[i];
                        serialPort.Close();
                        break;

                    }
                }

                catch (System.TimeoutException err)
                {

                    print(err);

                }

                messageText.text = "Looking for Arduino! " + "If waiting for more than 20seconds please Press R to RETRY";

                //if message above is displayed for a long time 
                //player can restart and re-try by pressing R
                if (Input.GetKeyDown(KeyCode.R))
                {

                    SceneManager.LoadScene(restartSceneName);

                }

                serialPort.Close();
            }

        }

    }

    void AttemptToFindThePort()
    {

        if (message == string.Empty && PortName == string.Empty)
        {

            CheckPort();

        }

        if (PortName != string.Empty)
        {

            messageText.text = "Arduino has been found! Press S to start the GAME";

            //Now that we found our port we can start our game
            if (Input.GetKeyDown(KeyCode.S))
            {

                SceneManager.LoadScene(gameStartSceneName);

            }
        }
    }
}
